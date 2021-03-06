﻿Imports System.Reflection
Imports System.Xml
Imports System.Xml.Serialization
Imports ejiVault
Public Class JobProcessor
  Inherits TimerSupport
  Implements IDisposable

  Private jpConfig As ConfigFile = Nothing
  Private MayContinue As Boolean = True
  Private LibraryPath As String = ""
  Private LibraryID As String = ""
  Private RemoteLibraryConnected As Boolean = False

  Public Event JobStarted()
  Public Event JobStopped()
  Public Event Log(ByVal Message As String)
  Public Event Err(ByVal Message As String)

  Public Sub Msg(ByVal str As String, x As SIS.LOG.logBaaNTransfer)
    If x IsNot Nothing Then
      x.StepError = str
      SIS.LOG.logBaaNTransfer.InsertData(x)
    Else
      Dim log As New SIS.LOG.logBaaNTransfer()
      log.StepError = str
      SIS.LOG.logBaaNTransfer.InsertData(log)
    End If
    RaiseEvent Log(str)
  End Sub

  Public Sub MsgErr(ByVal str As String, x As SIS.LOG.logBaaNTransfer)
    If x IsNot Nothing Then
      x.StepError = str
      SIS.LOG.logBaaNTransfer.InsertData(x)
    Else
      Dim log As New SIS.LOG.logBaaNTransfer()
      log.StepError = str
      SIS.LOG.logBaaNTransfer.InsertData(log)
    End If
    RaiseEvent Err(str)
  End Sub
  Public Overrides Sub Process()
    Dim log As SIS.LOG.logBaaNTransfer = Nothing
    Try
      For Each tmpFld As ConfigFile.Folder In jpConfig.Folders
        Dim Xmls() As String = IO.Directory.GetFiles(tmpFld.xmlPDFslzPath, "*.xml", IO.SearchOption.TopDirectoryOnly)
        If Xmls.Length > 0 Then
          Msg("Files: " & Xmls.Length & " In Folder: " & tmpFld.xmlPDFslzPath, Nothing)
        End If
        For Each XmlFile As String In Xmls

          Dim tmpXml As vaultXML = Nothing
          Try
            tmpXml = vaultXML.GetVaultXML(XmlFile)
            log = New SIS.LOG.logBaaNTransfer()
            With log
              .CreatedOn = Now
              .JobFileName = XmlFile
              .Job_CreatedBy = tmpXml.VaultUserName
              .Job_UserID = tmpXml.VaultClientMachine
              .Job_CreationDate = tmpXml.VaultSubmittedDate
              .Job_CreationTime = tmpXml.VaultSubmittedDate
              .DocumentID = tmpXml.number
            End With
            Msg("Importing: " & IO.Path.GetFileName(XmlFile), log)
            tmpXml.PDFFilePathName = IO.Path.ChangeExtension(XmlFile, "PDF")
            tmpXml.slzFileName = IO.Path.ChangeExtension(XmlFile, "slz")
            tmpXml.ERPCompany = tmpFld.ERPCompany
            'EJI.DBCommon.ERPCompany = tmpFld.ERPCompany
            '
            'tmpXml.LibraryID = LibraryID
            'tmpXml.LibraryPath = LibraryPath
            '
            ERPLN.InsertUpdateInERPLN(tmpXml, log, AddressOf Msg)

            IO.File.Copy(XmlFile, tmpFld.ProcessedPath & "\" & IO.Path.GetFileName(XmlFile), True)
            IO.File.Delete(XmlFile)
            IO.File.Copy(tmpXml.PDFFilePathName, tmpFld.ProcessedPath & "\" & IO.Path.GetFileName(tmpXml.PDFFilePathName), True)
            IO.File.Delete(tmpXml.PDFFilePathName)
            'Create Lock XML
            Msg("Creating Lock XML.", log)
            Try
              CreateLockXML(tmpXml, jpConfig.LockXMLFolder)
              Msg("Lock XML Created.", log)
              Msg("XML Imported in BaaN: " & tmpXml.number, log)
            Catch ex As Exception
              MsgErr("Error Lock XML : " & ex.Message, log)
            End Try
          Catch ex As Exception
            Msg("Error In Import: " & IO.Path.GetFileName(XmlFile), log)
            'Send E-Mail to User
            If tmpXml.SendMailRequired Then
              Msg("Sending E-Mail to : " & tmpXml.VaultUserName, log)
              vaultXML.SendMail(tmpXml)
            End If
            MsgErr(IO.Path.GetFileName(XmlFile) & " : " & ex.Message, log)
            IO.File.Copy(XmlFile, tmpFld.ErrorPath & "\" & IO.Path.GetFileName(XmlFile), True)
            IO.File.Delete(XmlFile)
            IO.File.Copy(tmpXml.PDFFilePathName, tmpFld.ErrorPath & "\" & IO.Path.GetFileName(tmpXml.PDFFilePathName), True)
            IO.File.Delete(tmpXml.PDFFilePathName)
          End Try
          If IsStopping Then
            Exit For
          End If
        Next
        If IsStopping Then
          Msg("Cancelled", log)
          Exit For
        End If
      Next
    Catch ex As Exception
      MsgErr(ex.Message, log)
    End Try
  End Sub

  Private Sub CreateLockXML(ByVal tmpXML As vaultXML, ByVal LockXMLPath As String)
    Dim document As New XmlDocument
    Dim tmpDeclaration As XmlNode = document.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
    document.AppendChild(tmpDeclaration)

    Dim tmpPLM As XmlNode = document.CreateElement("InforLN-PLM")
    document.AppendChild(tmpPLM)

    Dim tmpA As XmlAttribute = document.CreateAttribute("Type")
      tmpA.Value = "Lock"
      tmpPLM.Attributes.Append(tmpA)

      Dim tmpDocs As XmlNode = document.CreateElement("Documents")
      tmpPLM.AppendChild(tmpDocs)

      Dim tmpDoc As XmlNode = document.CreateElement("Document")
      tmpDocs.AppendChild(tmpDoc)

      tmpA = document.CreateAttribute("VaultUserName")
      tmpA.Value = tmpXML.VaultUserName
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("VaultDBName")
      tmpA.Value = tmpXML.VaultDBName
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("FileName")
      tmpA.Value = tmpXML.filename
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("IsgecDataSource")
      tmpA.Value = tmpXML.ISGEC_Datasource
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("Main")
      tmpA.Value = "True"
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("ComponentStatus")
      tmpA.Value = ""
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("ApprovalRequiredBy")
      tmpA.Value = ""
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("Description")
      tmpA.Value = ""
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("RequestPriority")
      tmpA.Value = ""
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("DCRCategory")
      tmpA.Value = ""
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("DCRDate")
      tmpA.Value = "0"
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("DCRNo")
      tmpA.Value = ""
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("UserID")
      tmpA.Value = "0340"
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("RevisionNo")
      tmpA.Value = tmpXML.rev
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("DocumentID")
      tmpA.Value = tmpXML.drgid
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("Element")
      tmpA.Value = tmpXML.el_id
      tmpDoc.Attributes.Append(tmpA)

      tmpA = document.CreateAttribute("Project")
      tmpA.Value = tmpXML.contract
      tmpDoc.Attributes.Append(tmpA)

      For Each tmpRef As vaultXML.RefDoc In tmpXML.RefDocs
        tmpDoc = document.CreateElement("Document")
        tmpDocs.AppendChild(tmpDoc)

        tmpA = document.CreateAttribute("Type")
        tmpA.Value = "1"
        tmpDoc.Attributes.Append(tmpA)

        tmpA = document.CreateAttribute("Status")
        tmpA.Value = "1"
        tmpDoc.Attributes.Append(tmpA)

        tmpA = document.CreateAttribute("PDF_filename")
        tmpA.Value = tmpRef.PDF_filename
        tmpDoc.Attributes.Append(tmpA)

        tmpA = document.CreateAttribute("Main")
        tmpA.Value = "False"
        tmpDoc.Attributes.Append(tmpA)

        tmpA = document.CreateAttribute("DrawingNumber")
        tmpA.Value = tmpRef.drgno
        tmpDoc.Attributes.Append(tmpA)

        tmpA = document.CreateAttribute("DocumentRevision")
        tmpA.Value = tmpRef.rev
        tmpDoc.Attributes.Append(tmpA)

        tmpA = document.CreateAttribute("DrawingTitle")
        tmpA.Value = tmpRef.drg_descn
        tmpDoc.Attributes.Append(tmpA)

        tmpA = document.CreateAttribute("DocumentFileName")
        tmpA.Value = tmpRef.filename
        tmpDoc.Attributes.Append(tmpA)
      Next
      document.Save(LockXMLPath & "\" & tmpXML.drgid & ".xml")
    'Catch ex As Exception
    '  Throw New Exception("LOCK: " & ex.Message & " : " & tmpXML.drgid)
    'End Try

  End Sub

  Public Overrides Sub Started()
    Try
      RaiseEvent JobStarted()
      Msg("Reading Settings", Nothing)
      Dim ConfigPath As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) & "\Settings.xml"
      jpConfig = ConfigFile.DeSerialize(ConfigPath)
      For Each tmp As ConfigFile.Folder In jpConfig.Folders
        If Not IO.Directory.Exists(tmp.ErrorPath) Then
          IO.Directory.CreateDirectory(tmp.ErrorPath)
        End If
        If Not IO.Directory.Exists(tmp.ProcessedPath) Then
          IO.Directory.CreateDirectory(tmp.ProcessedPath)
        End If
      Next
      SIS.SYS.SQLDatabase.DBCommon.BaaNLive = jpConfig.BaaNLive

      EJI.DBCommon.BaaNLive = jpConfig.BaaNLive
      EJI.DBCommon.ERPCompany = "200"
      EJI.DBCommon.IsLocalISGECVault = jpConfig.IsLocalISGECVault
      EJI.DBCommon.ISGECVaultIP = jpConfig.ISGECVaultIP

      Dim tmpL As EJI.ediALib = EJI.ediALib.GetActiveLibrary
      LibraryPath = tmpL.LibraryPath
      LibraryID = tmpL.t_lbcd
      If Not jpConfig.IsLocalISGECVault Then
        RemoteLibraryConnected = EJI.ediALib.ConnectISGECVault(tmpL)
      End If
    Catch ex As Exception
      StopJob()
      MsgErr(ex.Message, Nothing)
    End Try
  End Sub

  Public Overrides Sub Stopped()
    If RemoteLibraryConnected Then
      EJI.ediALib.DisconnectISGECVault()
      RemoteLibraryConnected = False
    End If
    jpConfig = Nothing
    RaiseEvent JobStopped()
    Msg("Stopped", Nothing)
  End Sub

  Public Shared Function IsFileAvailable(ByVal FilePath As String) As Boolean
    If Not IO.File.Exists(FilePath) Then Return False
    Dim fInfo As IO.FileInfo = Nothing
    Dim st As IO.FileStream = Nothing
    Try
      fInfo = New IO.FileInfo(FilePath)
    Catch ex As Exception
      Return False
    End Try
    Dim ret As Boolean = False
    If fInfo.IsReadOnly Then
      If DateDiff(DateInterval.Minute, fInfo.CreationTime, Now) >= 1 Then
        fInfo.IsReadOnly = False
      End If
    End If
    Try
      st = fInfo.Open(IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.None)
      ret = True
    Catch ex As Exception
      ret = False
    Finally
      If st IsNot Nothing Then
        st.Close()
      End If
    End Try
    Return ret
  End Function

  Sub New()
    'dummy
  End Sub

#Region "IDisposable Support"
  Private disposedValue As Boolean ' To detect redundant calls

  ' IDisposable
  Protected Overridable Sub Dispose(disposing As Boolean)
    If Not disposedValue Then
      If disposing Then
        ' TODO: dispose managed state (managed objects).
      End If

      ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
      ' TODO: set large fields to null.
    End If
    disposedValue = True
  End Sub

  ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
  'Protected Overrides Sub Finalize()
  '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
  '    Dispose(False)
  '    MyBase.Finalize()
  'End Sub

  ' This code added by Visual Basic to correctly implement the disposable pattern.
  Public Sub Dispose() Implements IDisposable.Dispose
    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    Dispose(True)
    ' TODO: uncomment the following line if Finalize() is overridden above.
    ' GC.SuppressFinalize(Me)
  End Sub
#End Region
End Class
