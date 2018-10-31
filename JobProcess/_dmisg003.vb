Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.DMISG
  <DataObject()>
  Partial Public Class dmisg003
    Private Shared _RecordCount As Integer
    Private _t_docn As String = ""
    Private _t_revn As String = ""
    Private _t_drgt As String = ""
    Private _t_dcfn As String = ""
    Private _t_drev As String = ""
    Private _t_drgn As String = ""
    Private _t_pdff As String = ""
    Private _t_stat As String = ""
    Private _t_type As Int32 = 0
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Public Property t_docn() As String
      Get
        Return _t_docn
      End Get
      Set(ByVal value As String)
        _t_docn = value
      End Set
    End Property
    Public Property t_revn() As String
      Get
        Return _t_revn
      End Get
      Set(ByVal value As String)
        _t_revn = value
      End Set
    End Property
    Public Property t_drgt() As String
      Get
        Return _t_drgt
      End Get
      Set(ByVal value As String)
        _t_drgt = value
      End Set
    End Property
    Public Property t_dcfn() As String
      Get
        Return _t_dcfn
      End Get
      Set(ByVal value As String)
        _t_dcfn = value
      End Set
    End Property
    Public Property t_drev() As String
      Get
        Return _t_drev
      End Get
      Set(ByVal value As String)
        _t_drev = value
      End Set
    End Property
    Public Property t_drgn() As String
      Get
        Return _t_drgn
      End Get
      Set(ByVal value As String)
        _t_drgn = value
      End Set
    End Property
    Public Property t_pdff() As String
      Get
        Return _t_pdff
      End Get
      Set(ByVal value As String)
        _t_pdff = value
      End Set
    End Property
    Public Property t_stat() As String
      Get
        Return _t_stat
      End Get
      Set(ByVal value As String)
        _t_stat = value
      End Set
    End Property
    Public Property t_type() As Int32
      Get
        Return _t_type
      End Get
      Set(ByVal value As Int32)
        _t_type = value
      End Set
    End Property
    Public Property t_Refcntd() As Int32
      Get
        Return _t_Refcntd
      End Get
      Set(ByVal value As Int32)
        _t_Refcntd = value
      End Set
    End Property
    Public Property t_Refcntu() As Int32
      Get
        Return _t_Refcntu
      End Get
      Set(ByVal value As Int32)
        _t_Refcntu = value
      End Set
    End Property
    Public ReadOnly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public ReadOnly Property PrimaryKey() As String
      Get
        Return _t_docn & "|" & _t_revn & "|" & _t_drgt
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
    Public Class PKdmisg003
      Private _t_docn As String = ""
      Private _t_revn As String = ""
      Private _t_drgt As String = ""
      Public Property t_docn() As String
        Get
          Return _t_docn
        End Get
        Set(ByVal value As String)
          _t_docn = value
        End Set
      End Property
      Public Property t_revn() As String
        Get
          Return _t_revn
        End Get
        Set(ByVal value As String)
          _t_revn = value
        End Set
      End Property
      Public Property t_drgt() As String
        Get
          Return _t_drgt
        End Get
        Set(ByVal value As String)
          _t_drgt = value
        End Set
      End Property
    End Class
    '1. Used
    Public Shared Function InsertData(ByVal Record As SIS.DMISG.dmisg003, ByVal Comp As String) As SIS.DMISG.dmisg003
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg003" & Comp & "Insert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn", SqlDbType.VarChar, 33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revn", SqlDbType.VarChar, 21, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drgt", SqlDbType.VarChar, 101, Record.t_drgt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dcfn", SqlDbType.VarChar, 101, Record.t_dcfn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drev", SqlDbType.VarChar, 21, Record.t_drev)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drgn", SqlDbType.VarChar, 51, Record.t_drgn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pdff", SqlDbType.VarChar, 101, Record.t_pdff)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_stat", SqlDbType.VarChar, 51, Record.t_stat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_type", SqlDbType.Int, 11, Record.t_type)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Company", SqlDbType.NVarChar, 9, Comp)
          Cmd.Parameters.Add("@Return_t_docn", SqlDbType.VarChar, 33)
          Cmd.Parameters("@Return_t_docn").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_revn", SqlDbType.VarChar, 21)
          Cmd.Parameters("@Return_t_revn").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_drgt", SqlDbType.VarChar, 101)
          Cmd.Parameters("@Return_t_drgt").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.t_docn = Cmd.Parameters("@Return_t_docn").Value
          Record.t_revn = Cmd.Parameters("@Return_t_revn").Value
          Record.t_drgt = Cmd.Parameters("@Return_t_drgt").Value
        End Using
      End Using
      Return Record
    End Function
    '2. Used
    Public Shared Function Getdmisg003(ByVal t As vaultXML.RefDoc, ByVal x As vaultXML) As SIS.DMISG.dmisg003
      Dim tmp As New dmisg003
      With tmp
        .t_docn = x.drgid
        .t_revn = x.rev
        .t_drgt = t.drgno
        .t_dcfn = t.drg_descn
        .t_drev = t.rev
        .t_drgn = t.filename
        .t_pdff = t.PDF_filename
        .t_stat = ""
        .t_type = 1 'Document Type is Reference Drawing, 2=>Additional Document
        .t_Refcntd = 0
        .t_Refcntu = 0
      End With
      Return tmp
    End Function

    Public Sub New(ByVal Reader As SqlDataReader)
      Try
        For Each pi As System.Reflection.PropertyInfo In Me.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              Dim Found As Boolean = False
              For I As Integer = 0 To Reader.FieldCount - 1
                If Reader.GetName(I).ToLower = pi.Name.ToLower Then
                  Found = True
                  Exit For
                End If
              Next
              If Found Then
                If Convert.IsDBNull(Reader(pi.Name)) Then
                  Select Case Reader.GetDataTypeName(Reader.GetOrdinal(pi.Name))
                    Case "decimal"
                      CallByName(Me, pi.Name, CallType.Let, "0.00")
                    Case "bit"
                      CallByName(Me, pi.Name, CallType.Let, Boolean.FalseString)
                    Case Else
                      CallByName(Me, pi.Name, CallType.Let, String.Empty)
                  End Select
                Else
                  CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
                End If
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      Catch ex As Exception
      End Try
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
