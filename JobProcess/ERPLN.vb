﻿Imports ejiVault
Public Class ERPLN
  Public Delegate Sub showMsg(ByVal str As String, x As SIS.LOG.logBaaNTransfer)
  Public Shared Function InsertUpdateInERPLN(ByVal t As vaultXML, log As SIS.LOG.logBaaNTransfer, Optional ByVal msg As showMsg = Nothing) As Boolean
    Dim mRet As Boolean = True
    Dim dmDoc As SIS.DMISG.dmisg121 = Nothing
    If t.rev = "00" Then
      Dim tmpDoc As SIS.DMISG.dmisg001 = SIS.DMISG.dmisg001.dmisg001GetByID(t.drgid, t.rev, t.ERPCompany)
      If tmpDoc IsNot Nothing Then
        If tmpDoc.t_wfst <> wfst.UnderDesign Then
          Throw New Exception("Document is not UNDER DESIGN.")
        End If
        SIS.DMISG.dmisg001.dmisg001DeleteAll(t.drgid, t.rev, t.ERPCompany)
        '===Physical File Delete only when ERP is LIVE
        If SIS.SYS.SQLDatabase.DBCommon.BaaNLive Then
          Try
            Dim tmp As EJI.ediAFile = EJI.ediAFile.GetFileByHandleIndex("DOCUMENTMASTERPDF_" & t.ERPCompany, t.AttachmentIndex)
            If tmp IsNot Nothing Then
              If t.LibraryID <> tmp.t_lbcd Then
                Dim tmpL As EJI.ediALib = EJI.ediALib.GetLibraryByID(tmp.t_lbcd)
                t.LibraryID = tmpL.t_lbcd
                t.LibraryPath = tmpL.LibraryPath
                If Not EJI.DBCommon.IsLocalISGECVault Then
                  EJI.ediALib.ConnectISGECVault(tmpL)
                End If
              End If
              Try
                If IO.File.Exists(t.LibraryPath & "\" & tmp.t_dcid) Then
                  IO.File.SetAttributes(t.LibraryPath & "\" & tmp.t_dcid, IO.FileAttributes.Normal)
                  IO.File.Delete(t.LibraryPath & "\" & tmp.t_dcid)
                End If
              Catch ex As Exception
                If msg IsNot Nothing Then msg("Error Deleting File [PDF-00]: " & ex.Message, log)
              End Try
              EJI.ediAFile.DeleteData(tmp)
            End If
            tmp = EJI.ediAFile.GetFileByHandleIndex("DOCUMENTMASTERORG_" & t.ERPCompany, t.AttachmentIndex)
            If tmp IsNot Nothing Then
              If t.LibraryID <> tmp.t_lbcd Then
                Dim tmpL As EJI.ediALib = EJI.ediALib.GetLibraryByID(tmp.t_lbcd)
                t.LibraryID = tmpL.t_lbcd
                t.LibraryPath = tmpL.LibraryPath
                If Not EJI.DBCommon.IsLocalISGECVault Then
                  EJI.ediALib.ConnectISGECVault(tmpL)
                End If
              End If
              Try
                If IO.File.Exists(t.LibraryPath & "\" & tmp.t_dcid) Then
                  IO.File.SetAttributes(t.LibraryPath & "\" & tmp.t_dcid, IO.FileAttributes.Normal)
                  IO.File.Delete(t.LibraryPath & "\" & tmp.t_dcid)
                End If
              Catch ex As Exception
                If msg IsNot Nothing Then msg("Error Deleting File [ORG-00]: " & ex.Message, log)
              End Try
              EJI.ediAFile.DeleteData(tmp)
            End If
          Catch ex As Exception
            If msg IsNot Nothing Then msg("Error Deleting File [00]: " & ex.Message, log)
          End Try
        End If
        '===Physical File Handling
      End If
      Try
        '1. Insert in all 5 tables
        tmpDoc = SIS.DMISG.dmisg001.Getdmisg001(t)
        If msg IsNot Nothing Then msg("Inserting in 001", log)
        tmpDoc = SIS.DMISG.dmisg001.InsertData(tmpDoc, t.ERPCompany)
        If msg IsNot Nothing Then msg("Inserted in 001", log)
        '2. Item & 4 Part Item
        Dim tmpCnt As Integer = 0
        Dim refCnt As Integer = 0
        Dim pCnt As Integer = 0
        Dim pItem As String = ""
        For Each itm As vaultXML.Item In t.Items
          pCnt = 0
          Select Case itm.t.ToUpper
            Case "R"
              refCnt += 1
              Dim refItm As SIS.DMISG.dmisg021 = SIS.DMISG.dmisg021.Getdmisg021(itm, t, refCnt)
              refItm = SIS.DMISG.dmisg021.InsertData(refItm, t.ERPCompany)
              pItem = itm.item_code
              '3. Part Item
              For Each pItm As vaultXML.Part In itm.Parts
                pCnt += 1
                Dim refPitm As SIS.DMISG.dmisg022 = SIS.DMISG.dmisg022.Getdmisg022(pItm, t, refCnt, pCnt, pItem)
                refPitm = SIS.DMISG.dmisg022.InsertData(refPitm, t.ERPCompany)
              Next
            Case Else
              tmpCnt += 1
              Dim tmpItm As SIS.DMISG.dmisg002 = SIS.DMISG.dmisg002.Getdmisg002(itm, t, tmpCnt)
              If msg IsNot Nothing Then msg("Inserting in 002: " & tmpItm.t_item, log)
              tmpItm = SIS.DMISG.dmisg002.InsertData(tmpItm, t.ERPCompany)
              If msg IsNot Nothing Then msg("Inserted in 002: " & tmpItm.t_item, log)
              pItem = itm.item_code
              '3. Part Item
              For Each pItm As vaultXML.Part In itm.Parts
                pCnt += 1
                Dim tmpPitm As SIS.DMISG.dmisg004 = SIS.DMISG.dmisg004.Getdmisg004(pItm, t, tmpCnt, pCnt, pItem)
                If msg IsNot Nothing Then msg("Inserting in 004:" & tmpPitm.t_prtn, log)
                tmpPitm = SIS.DMISG.dmisg004.InsertData(tmpPitm, t.ERPCompany)
                If msg IsNot Nothing Then msg("Inserted in 004:" & tmpPitm.t_prtn, log)
              Next
          End Select
        Next
        '4. Ref Dwg
        For Each doc As vaultXML.RefDoc In t.RefDocs
          Dim refD As SIS.DMISG.dmisg003 = SIS.DMISG.dmisg003.Getdmisg003(doc, t)
          'Try
          If msg IsNot Nothing Then msg("Inserting ref dwg in 003: " & refD.t_drgn, log)
          refD = SIS.DMISG.dmisg003.InsertData(refD, t.ERPCompany)
          If msg IsNot Nothing Then msg("Inserting ref dwg in 003: " & refD.t_drgn, log)
          'Catch ex As Exception
          '  If msg IsNot Nothing Then msg(refD.t_drgt & ": " & ex.Message, log)
          'End Try
        Next
        '5. Master Document List
        dmDoc = SIS.DMISG.dmisg121.Getdmisg121(t)
        If msg IsNot Nothing Then msg("Inserting in 121", log)
        dmDoc = SIS.DMISG.dmisg121.InsertData(dmDoc, t.ERPCompany)
        If msg IsNot Nothing Then msg("Inserted in 121", log)
        '=====================
        If SIS.SYS.SQLDatabase.DBCommon.BaaNLive Then
          If msg IsNot Nothing Then msg("Attaching: " & t.drgid, log)
          '==========================
          Threading.Thread.Sleep(5000)
          '==========================
          ERPLN.UploadInISGECVault(t, log, msg)
          If msg IsNot Nothing Then msg("Attached.", log)
        End If
        '=====================
      Catch ex As Exception
        SIS.DMISG.dmisg001.dmisg001DeleteAll(t.drgid, t.rev, t.ERPCompany)
        t.SendMailRequired = True
        Throw New Exception(ex.Message)
      End Try
      '==========
    Else 'Rev x00
      '==========
      Dim tmpDoc As SIS.DMISG.dmisg001 = SIS.DMISG.dmisg001.dmisg001GetByID(t.drgid, t.rev, t.ERPCompany)
      If tmpDoc Is Nothing Then
        Dim p_rev As String = Convert.ToString(Convert.ToInt32(t.rev) - 1).PadLeft(2, "0")
        Dim pDoc As SIS.DMISG.dmisg001 = SIS.DMISG.dmisg001.dmisg001GetByID(t.drgid, p_rev, t.ERPCompany)
        If pDoc Is Nothing Then
          t.SendMailRequired = True
          t.Errors.Add("Preceding Revision of Document Not Found in ERP.: " & p_rev)
          Throw New Exception("Preceding Revision of Document Not Found in ERP.: " & p_rev)
        End If
        If pDoc.t_wfst <> wfst.Superseded Then
          If pDoc.t_wfst <> wfst.UnderRevision Then
            Throw New Exception("Document is not UNDER REVISION.")
          End If
          pDoc.t_wfst = wfst.Superseded
          pDoc = SIS.DMISG.dmisg001.UpdateData(pDoc, t.ERPCompany)
          '121
          dmDoc = SIS.DMISG.dmisg121.dmisg121GetByID(t.drgid, p_rev, t.ERPCompany)
          If dmDoc IsNot Nothing Then
            dmDoc.t_bloc = yesno.YES
            dmDoc = SIS.DMISG.dmisg121.UpdateData(dmDoc, t.ERPCompany)
          End If
        End If
      Else
        If tmpDoc.t_wfst <> wfst.UnderDesign Then
          Throw New Exception("Document is not UNDER DESIGN.")
        End If
        SIS.DMISG.dmisg001.dmisg001DeleteAll(t.drgid, t.rev, t.ERPCompany)
        '==========Physical File Delete When ERP is Live Handling============
        If SIS.SYS.SQLDatabase.DBCommon.BaaNLive Then
          Try
            Dim tmp As EJI.ediAFile = EJI.ediAFile.GetFileByHandleIndex("DOCUMENTMASTERPDF_" & t.ERPCompany, t.AttachmentIndex)
            If tmp IsNot Nothing Then
              If t.LibraryID <> tmp.t_lbcd Then
                Dim tmpL As EJI.ediALib = EJI.ediALib.GetLibraryByID(tmp.t_lbcd)
                t.LibraryID = tmpL.t_lbcd
                t.LibraryPath = tmpL.LibraryPath
                If Not EJI.DBCommon.IsLocalISGECVault Then
                  EJI.ediALib.ConnectISGECVault(tmpL)
                End If
              End If
              Try
                If IO.File.Exists(t.LibraryPath & "\" & tmp.t_dcid) Then
                  IO.File.SetAttributes(t.LibraryPath & "\" & tmp.t_dcid, IO.FileAttributes.Normal)
                  IO.File.Delete(t.LibraryPath & "\" & tmp.t_dcid)
                End If
              Catch ex As Exception
                If msg IsNot Nothing Then msg("Error Deleting File [PDF-x00]: " & ex.Message, log)
              End Try
              EJI.ediAFile.DeleteData(tmp)
            End If
            tmp = EJI.ediAFile.GetFileByHandleIndex("DOCUMENTMASTERORG_" & t.ERPCompany, t.AttachmentIndex)
            If tmp IsNot Nothing Then
              If t.LibraryID <> tmp.t_lbcd Then
                Dim tmpL As EJI.ediALib = EJI.ediALib.GetLibraryByID(tmp.t_lbcd)
                t.LibraryID = tmpL.t_lbcd
                t.LibraryPath = tmpL.LibraryPath
                If Not EJI.DBCommon.IsLocalISGECVault Then
                  EJI.ediALib.ConnectISGECVault(tmpL)
                End If
              End If
              Try
                If IO.File.Exists(t.LibraryPath & "\" & tmp.t_dcid) Then
                  IO.File.SetAttributes(t.LibraryPath & "\" & tmp.t_dcid, IO.FileAttributes.Normal)
                  IO.File.Delete(t.LibraryPath & "\" & tmp.t_dcid)
                End If
              Catch ex As Exception
                If msg IsNot Nothing Then msg("Error Deleting File [ORG-x00]: " & ex.Message, log)
              End Try
              EJI.ediAFile.DeleteData(tmp)
            End If
          Catch ex As Exception
            If msg IsNot Nothing Then msg("Error Deleting File [x00]: " & ex.Message, log)
          End Try
        End If
        '================Physical File Handling==========================
      End If
      Try
        '1. Insert in all 5 tables
        tmpDoc = SIS.DMISG.dmisg001.Getdmisg001(t)
        If msg IsNot Nothing Then msg("Inserting in 001", log)
        tmpDoc = SIS.DMISG.dmisg001.InsertData(tmpDoc, t.ERPCompany)
        If msg IsNot Nothing Then msg("Inserted in 001", log)
        '2. Item & 4 Part Item
        Dim tmpCnt As Integer = 0
        Dim refCnt As Integer = 0
        Dim pCnt As Integer = 0
        Dim pItem As String = ""
        For Each itm As vaultXML.Item In t.Items
          pCnt = 0
          Select Case itm.t.ToUpper
            Case "R"
              refCnt += 1
              Dim refItm As SIS.DMISG.dmisg021 = SIS.DMISG.dmisg021.Getdmisg021(itm, t, refCnt)
              refItm = SIS.DMISG.dmisg021.InsertData(refItm, t.ERPCompany)
              pItem = itm.item_code
              For Each pItm As vaultXML.Part In itm.Parts
                pCnt += 1
                Dim refPitm As SIS.DMISG.dmisg022 = SIS.DMISG.dmisg022.Getdmisg022(pItm, t, refCnt, pCnt, pItem)
                refPitm = SIS.DMISG.dmisg022.InsertData(refPitm, t.ERPCompany)
              Next
            Case Else
              tmpCnt += 1
              Dim tmpItm As SIS.DMISG.dmisg002 = SIS.DMISG.dmisg002.Getdmisg002(itm, t, tmpCnt)
              If msg IsNot Nothing Then msg("Inserting in 002: " & tmpItm.t_item, log)
              tmpItm = SIS.DMISG.dmisg002.InsertData(tmpItm, t.ERPCompany)
              If msg IsNot Nothing Then msg("Inserted in 002: " & tmpItm.t_item, log)
              pItem = itm.item_code
              For Each pItm As vaultXML.Part In itm.Parts
                pCnt += 1
                Dim tmpPitm As SIS.DMISG.dmisg004 = SIS.DMISG.dmisg004.Getdmisg004(pItm, t, tmpCnt, pCnt, pItem)
                If msg IsNot Nothing Then msg("Inserting in 004:" & tmpPitm.t_prtn, log)
                tmpPitm = SIS.DMISG.dmisg004.InsertData(tmpPitm, t.ERPCompany)
                If msg IsNot Nothing Then msg("Inserted in 004:" & tmpPitm.t_prtn, log)
              Next
          End Select
        Next
        '3. Ref Dwg
        For Each doc As vaultXML.RefDoc In t.RefDocs
          Dim refD As SIS.DMISG.dmisg003 = SIS.DMISG.dmisg003.Getdmisg003(doc, t)
          'Try
          If msg IsNot Nothing Then msg("Inserting ref dwg in 003: " & refD.t_drgn, log)
            refD = SIS.DMISG.dmisg003.InsertData(refD, t.ERPCompany)
            If msg IsNot Nothing Then msg("Inserting ref dwg in 003: " & refD.t_drgn, log)
          'Catch ex As Exception
          '  If msg IsNot Nothing Then msg(refD.t_drgt & ": " & ex.Message, log)
          'End Try
        Next
        '5. Master Document List
        dmDoc = SIS.DMISG.dmisg121.Getdmisg121(t)
        If msg IsNot Nothing Then msg("Inserting in 121", log)
        dmDoc = SIS.DMISG.dmisg121.InsertData(dmDoc, t.ERPCompany)
        If msg IsNot Nothing Then msg("Inserted in 121", log)
        '=====================
        If SIS.SYS.SQLDatabase.DBCommon.BaaNLive Then
          If msg IsNot Nothing Then msg("Attaching: " & t.drgid, log)
          '==========================
          Threading.Thread.Sleep(5000)
          '==========================
          ERPLN.UploadInISGECVault(t, log, msg)
          If msg IsNot Nothing Then msg("Attached.", log)
        End If
        '=====================
      Catch ex As Exception
        SIS.DMISG.dmisg001.dmisg001DeleteAll(t.drgid, t.rev, t.ERPCompany)
        t.SendMailRequired = True
        Throw New Exception(ex.Message)
      End Try
    End If
    Return mRet
  End Function
  Public Shared Function UploadInISGECVault(ByVal t As vaultXML, log As SIS.LOG.logBaaNTransfer, Optional ByVal msg As showMsg = Nothing) As Boolean
    Dim tmpL As EJI.ediALib = EJI.ediALib.GetActiveLibrary
    If t.LibraryID <> tmpL.t_lbcd Then
      t.LibraryID = tmpL.t_lbcd
      t.LibraryPath = tmpL.LibraryPath
      If Not EJI.DBCommon.IsLocalISGECVault Then
        EJI.ediALib.ConnectISGECVault(tmpL)
      End If
    End If
    If IO.File.Exists(t.PDFFilePathName) Then
      Dim LibFileName As String = ""
      Dim Found As Boolean = True
      '1. Check PDF Attachment Found
      Dim tmp As EJI.ediAFile = EJI.ediAFile.GetFileByHandleIndex("DOCUMENTMASTERPDF_" & t.ERPCompany, t.AttachmentIndex)
      If tmp Is Nothing Then
        Found = False
        tmp = New EJI.ediAFile
        tmp.t_dcid = EJI.ediASeries.GetNextFileID
        tmp.t_drid = EJI.ediASeries.GetNextRecordID
      End If
      LibFileName = tmp.t_dcid
      With tmp
        '.t_drid = EJI.ediASeries.GetNextRecordID
        '.t_dcid = LibFileName
        .t_hndl = "DOCUMENTMASTERPDF_" & t.ERPCompany
        .t_indx = t.AttachmentIndex
        .t_prcd = "EJIMAIN"
        .t_fnam = IO.Path.GetFileName(t.PDFFilePathName)
        .t_lbcd = t.LibraryID
        .t_atby = t.VaultUserName
        .t_aton = Now.ToString("dd/MM/yyyy")
        .t_Refcntd = 0
        .t_Refcntu = 0
      End With
      If Not Found Then
        tmp = EJI.ediAFile.InsertData(tmp)
      Else
        tmp = EJI.ediAFile.UpdateData(tmp)
      End If
      If msg IsNot Nothing Then
        msg.Invoke("PDF Handle: " & tmp.t_fnam, log)
      End If
      Try
        '2. Move & Overwrite File
        If IO.File.Exists(t.LibraryPath & "\" & LibFileName) Then
          IO.File.SetAttributes(t.LibraryPath & "\" & LibFileName, IO.FileAttributes.Normal)
          IO.File.Delete(t.LibraryPath & "\" & LibFileName)
        End If
        IO.File.Copy(t.PDFFilePathName, t.LibraryPath & "\" & LibFileName)
        IO.File.SetAttributes(t.LibraryPath & "\" & LibFileName, IO.FileAttributes.Normal)
        If msg IsNot Nothing Then
          msg.Invoke("PDF Copied: " & tmp.t_fnam, log)
        End If
      Catch ex As Exception
        If msg IsNot Nothing Then
          msg.Invoke("Error Copying PDF: " & tmp.t_fnam, log)
        End If
        Throw New Exception(ex.Message)
      End Try
    End If
    '=================================
    If IO.File.Exists(t.ORGFilePathName) Then
      Dim LibFileName As String = ""
      Dim Found As Boolean = True
      '1. Check ORG Attachment Found
      Dim tmp As EJI.ediAFile = EJI.ediAFile.GetFileByHandleIndex("DOCUMENTMASTERORG_" & t.ERPCompany, t.AttachmentIndex)
      If tmp Is Nothing Then
        Found = False
        tmp = New EJI.ediAFile
        tmp.t_dcid = EJI.ediASeries.GetNextFileID
        tmp.t_drid = EJI.ediASeries.GetNextRecordID
      End If
      LibFileName = tmp.t_dcid
      With tmp
        '.t_drid = EJI.ediASeries.GetNextRecordID
        '.t_dcid = LibFileName
        .t_hndl = "DOCUMENTMASTERORG_" & t.ERPCompany
        .t_indx = t.AttachmentIndex
        .t_prcd = "EJIMAIN"
        .t_fnam = IO.Path.GetFileName(t.ORGFilePathName)
        .t_lbcd = t.LibraryID
        .t_atby = t.VaultUserName
        .t_aton = Now.ToString("dd/MM/yyyy")
        .t_Refcntd = 0
        .t_Refcntu = 0
      End With
      If Not Found Then
        tmp = EJI.ediAFile.InsertData(tmp)
      Else
        tmp = EJI.ediAFile.UpdateData(tmp)
      End If
      If msg IsNot Nothing Then
        msg.Invoke("ORG Handle: " & tmp.t_fnam, log)
      End If
      Try
        '2. Move & Overwrite File
        If IO.File.Exists(t.LibraryPath & "\" & LibFileName) Then
          IO.File.SetAttributes(t.LibraryPath & "\" & LibFileName, IO.FileAttributes.Normal)
          IO.File.Delete(t.LibraryPath & "\" & LibFileName)
        End If
        IO.File.Move(t.ORGFilePathName, t.LibraryPath & "\" & LibFileName)
        IO.File.SetAttributes(t.LibraryPath & "\" & LibFileName, IO.FileAttributes.Normal)
        If msg IsNot Nothing Then
          msg.Invoke("ORG Copied: " & tmp.t_fnam, log)
        End If
      Catch ex As Exception
        If msg IsNot Nothing Then
          msg.Invoke("Error Copying ORG: " & tmp.t_fnam, log)
        End If
        Throw New Exception(ex.Message)
      End Try
    End If
    Return True
  End Function
End Class
