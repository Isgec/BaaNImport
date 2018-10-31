Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.DMISG
  <DataObject()>
  Partial Public Class dmisg004
    Private Shared _RecordCount As Integer
    Private _t_docn As String = ""
    Private _t_revn As String = ""
    Private _t_srno As Int32 = 0
    Private _t_item As String = ""
    Private _t_pisn As String = ""
    Private _t_prtn As String = ""
    Private _t_prtd As String = ""
    Private _t_wght As Double = 0
    Private _t_qnty As Double = 0
    Private _t_spec As String = ""
    Private _t_size As String = ""
    Private _t_rmrk As String = ""
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Private _t_mcod As String = ""
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
    Public Property t_srno() As Int32
      Get
        Return _t_srno
      End Get
      Set(ByVal value As Int32)
        _t_srno = value
      End Set
    End Property
    Public Property t_item() As String
      Get
        Return _t_item
      End Get
      Set(ByVal value As String)
        _t_item = value
      End Set
    End Property
    Public Property t_pisn() As String
      Get
        Return _t_pisn
      End Get
      Set(ByVal value As String)
        _t_pisn = value
      End Set
    End Property
    Public Property t_prtn() As String
      Get
        Return _t_prtn
      End Get
      Set(ByVal value As String)
        _t_prtn = value
      End Set
    End Property
    Public Property t_prtd() As String
      Get
        Return _t_prtd
      End Get
      Set(ByVal value As String)
        _t_prtd = value
      End Set
    End Property
    Public Property t_wght() As Double
      Get
        Return _t_wght
      End Get
      Set(ByVal value As Double)
        _t_wght = value
      End Set
    End Property
    Public Property t_qnty() As Double
      Get
        Return _t_qnty
      End Get
      Set(ByVal value As Double)
        _t_qnty = value
      End Set
    End Property
    Public Property t_spec() As String
      Get
        Return _t_spec
      End Get
      Set(ByVal value As String)
        _t_spec = value
      End Set
    End Property
    Public Property t_size() As String
      Get
        Return _t_size
      End Get
      Set(ByVal value As String)
        _t_size = value
      End Set
    End Property
    Public Property t_rmrk() As String
      Get
        Return _t_rmrk
      End Get
      Set(ByVal value As String)
        _t_rmrk = value
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
    Public Property t_mcod() As String
      Get
        Return _t_mcod
      End Get
      Set(ByVal value As String)
        _t_mcod = value
      End Set
    End Property
    Public ReadOnly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public ReadOnly Property PrimaryKey() As String
      Get
        Return _t_docn & "|" & _t_revn & "|" & _t_srno & "|" & _t_item & "|" & _t_pisn
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
    Public Class PKdmisg004
      Private _t_docn As String = ""
      Private _t_revn As String = ""
      Private _t_srno As Int32 = 0
      Private _t_item As String = ""
      Private _t_pisn As String = ""
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
      Public Property t_srno() As Int32
        Get
          Return _t_srno
        End Get
        Set(ByVal value As Int32)
          _t_srno = value
        End Set
      End Property
      Public Property t_item() As String
        Get
          Return _t_item
        End Get
        Set(ByVal value As String)
          _t_item = value
        End Set
      End Property
      Public Property t_pisn() As String
        Get
          Return _t_pisn
        End Get
        Set(ByVal value As String)
          _t_pisn = value
        End Set
      End Property
    End Class

    '1 Used
    Public Shared Function InsertData(ByVal Record As SIS.DMISG.dmisg004, ByVal Comp As String) As SIS.DMISG.dmisg004
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg004" & Comp & "Insert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn", SqlDbType.VarChar, 33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revn", SqlDbType.VarChar, 21, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srno", SqlDbType.Int, 11, Record.t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_item", SqlDbType.VarChar, 48, Record.t_item)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pisn", SqlDbType.VarChar, 5, Record.t_pisn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prtn", SqlDbType.VarChar, 51, Record.t_prtn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prtd", SqlDbType.VarChar, 101, Record.t_prtd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_wght", SqlDbType.Float, 16, Record.t_wght)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_qnty", SqlDbType.Float, 16, Record.t_qnty)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_spec", SqlDbType.VarChar, 101, Record.t_spec)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_size", SqlDbType.VarChar, 51, Record.t_size)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rmrk", SqlDbType.VarChar, 101, Record.t_rmrk)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_mcod", SqlDbType.VarChar, 10, Record.t_mcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Company", SqlDbType.NVarChar, 9, Comp)
          Cmd.Parameters.Add("@Return_t_docn", SqlDbType.VarChar, 33)
          Cmd.Parameters("@Return_t_docn").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_revn", SqlDbType.VarChar, 21)
          Cmd.Parameters("@Return_t_revn").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_srno", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_t_srno").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_item", SqlDbType.VarChar, 48)
          Cmd.Parameters("@Return_t_item").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_pisn", SqlDbType.VarChar, 3)
          Cmd.Parameters("@Return_t_pisn").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.t_docn = Cmd.Parameters("@Return_t_docn").Value
          Record.t_revn = Cmd.Parameters("@Return_t_revn").Value
          Record.t_srno = Cmd.Parameters("@Return_t_srno").Value
          Record.t_item = Cmd.Parameters("@Return_t_item").Value
          Record.t_pisn = Cmd.Parameters("@Return_t_pisn").Value
        End Using
      End Using
      Return Record
    End Function
    '2. Used
    Public Shared Function Getdmisg004(ByVal t As vaultXML.Part, ByVal x As vaultXML, ByVal SrNo As Integer, ByVal pNo As Integer, ByVal pItem As String) As SIS.DMISG.dmisg004
      Dim tmp As New dmisg004
      With tmp
        .t_docn = x.drgid
        .t_revn = x.rev
        .t_srno = SrNo
        .t_item = pItem.PadLeft(pItem.Length + 9, " ")
        .t_pisn = pNo.ToString.PadLeft(4, "0")
        .t_prtn = t.p_no
        .t_prtd = t.p_desc
        Try
          .t_qnty = t.p_qty
        Catch ex As Exception
          .t_qnty = 0
        End Try
        Try
          .t_wght = t.p_wt
        Catch ex As Exception
          .t_wght = 0
        End Try
        .t_spec = t.spec
        .t_size = t.size
        .t_rmrk = t.remark
        .t_Refcntd = 0
        .t_Refcntu = 0
        .t_mcod = ""

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
