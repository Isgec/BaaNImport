Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.LOG
  <DataObject()> _
  Partial Public Class logBaaNTransfer
    Private Shared _RecordCount As Integer
    Public Property SrNo As Int32 = 0
    Public Property ProcessName As String = "BaaNImport"
    Public Property JobFileName As String = ""
    Public Property Job_CreatedBy As String = ""
    Public Property Job_UserID As String = ""
    Public Property Job_CreationDate As String = ""
    Public Property Job_CreationTime As String = ""
    Public Property DocumentID As String = ""
    Public Property StepDescription As String = ""
    Public Property StepError As String = ""
    Public Property IsError As Boolean = False
    Private _CreatedOn As String = ""
    Public Property CreatedOn() As String
      Get
        If Not _CreatedOn = String.Empty Then
          Return Convert.ToDateTime(_CreatedOn).ToString("dd/MM/yyyy HH:mm:ss")
        End If
        Return _CreatedOn
      End Get
      Set(ByVal value As String)
        _CreatedOn = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _SrNo
      End Get
    End Property
    Public Shared Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    Public Class PKlogBaaNTransfer
      Private _SrNo As Int32 = 0
      Public Property SrNo() As Int32
        Get
          Return _SrNo
        End Get
        Set(ByVal value As Int32)
          _SrNo = value
        End Set
      End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function logBaaNTransferGetNewRecord() As SIS.LOG.logBaaNTransfer
      Return New SIS.LOG.logBaaNTransfer()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function logBaaNTransferGetByID(ByVal SrNo As Int32) As SIS.LOG.logBaaNTransfer
      Dim Results As SIS.LOG.logBaaNTransfer = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "splogBaaNTransferSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SrNo",SqlDbType.Int,SrNo.ToString.Length, SrNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, "")
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.LOG.logBaaNTransfer(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function logBaaNTransferSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.LOG.logBaaNTransfer)
      Dim Results As List(Of SIS.LOG.logBaaNTransfer) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "CreatedOn DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "splogBaaNTransferSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "splogBaaNTransferSelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, "")
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.LOG.logBaaNTransfer)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.LOG.logBaaNTransfer(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function logBaaNTransferSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function logBaaNTransferInsert(ByVal Record As SIS.LOG.logBaaNTransfer) As SIS.LOG.logBaaNTransfer
      Dim _Rec As SIS.LOG.logBaaNTransfer = SIS.LOG.logBaaNTransfer.logBaaNTransferGetNewRecord()
      With _Rec
        .ProcessName = Record.ProcessName
        .JobFileName = Record.JobFileName
        .Job_CreatedBy = Record.Job_CreatedBy
        .Job_UserID = Record.Job_UserID
        .Job_CreationDate = Record.Job_CreationDate
        .Job_CreationTime = Record.Job_CreationTime
        .DocumentID = Record.DocumentID
        .StepDescription = Record.StepDescription
        .StepError = Record.StepError
        .IsError = Record.IsError
        .CreatedOn = Record.CreatedOn
      End With
      Return SIS.LOG.logBaaNTransfer.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.LOG.logBaaNTransfer) As SIS.LOG.logBaaNTransfer
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "splogBaaNTransferInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProcessName",SqlDbType.NVarChar,51, Iif(Record.ProcessName= "" ,Convert.DBNull, Record.ProcessName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@JobFileName",SqlDbType.NVarChar,101, Iif(Record.JobFileName= "" ,Convert.DBNull, Record.JobFileName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Job_CreatedBy",SqlDbType.NVarChar,51, Iif(Record.Job_CreatedBy= "" ,Convert.DBNull, Record.Job_CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Job_UserID",SqlDbType.NVarChar,51, Iif(Record.Job_UserID= "" ,Convert.DBNull, Record.Job_UserID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Job_CreationDate",SqlDbType.NVarChar,51, Iif(Record.Job_CreationDate= "" ,Convert.DBNull, Record.Job_CreationDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Job_CreationTime",SqlDbType.NVarChar,51, Iif(Record.Job_CreationTime= "" ,Convert.DBNull, Record.Job_CreationTime))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DocumentID",SqlDbType.NVarChar,51, Iif(Record.DocumentID= "" ,Convert.DBNull, Record.DocumentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StepDescription",SqlDbType.NVarChar,51, Iif(Record.StepDescription= "" ,Convert.DBNull, Record.StepDescription))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StepError",SqlDbType.NVarChar,501, Iif(Record.StepError= "" ,Convert.DBNull, Record.StepError))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsError",SqlDbType.Bit,3, Record.IsError)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn", SqlDbType.DateTime, 21, Now)
          Cmd.Parameters.Add("@Return_SrNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_SrNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.SrNo = Cmd.Parameters("@Return_SrNo").Value
        End Using
      End Using
      Return Record
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      SIS.SYS.SQLDatabase.DBCommon.NewObj(Me, Reader)
    End Sub
    Public Sub New(strPath As String)
      ProcessName = "BomXPort-" & strPath
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
