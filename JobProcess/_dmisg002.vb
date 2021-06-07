Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.DMISG
  <DataObject()>
  Partial Public Class dmisg002
    Private Shared _RecordCount As Integer
    Private _t_docn As String = ""
    Private _t_revn As String = ""
    Private _t_srno As Int32 = 0
    Private _t_item As String = ""
    Private _t_dsca As String = ""
    Private _t_citg As String = ""
    Private _t_qnty As Double = 0
    Private _t_wght As Double = 0
    Private _t_itmt As String = ""
    Private _t_txta As Int32 = 0
    Private _t_txtb As Int32 = 0
    Private _t_cuni As String = ""
    Private _t_oitm As String = ""
    Private _t_elem As String = ""
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Public Property Remarks As String = ""
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
    Public Property t_dsca() As String
      Get
        Return _t_dsca
      End Get
      Set(ByVal value As String)
        _t_dsca = value
      End Set
    End Property
    Public Property t_citg() As String
      Get
        Return _t_citg
      End Get
      Set(ByVal value As String)
        _t_citg = value
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
    Public Property t_wght() As Double
      Get
        Return _t_wght
      End Get
      Set(ByVal value As Double)
        _t_wght = value
      End Set
    End Property
    Public Property t_itmt() As String
      Get
        Return _t_itmt
      End Get
      Set(ByVal value As String)
        _t_itmt = value
      End Set
    End Property
    Public Property t_txta() As Int32
      Get
        Return _t_txta
      End Get
      Set(ByVal value As Int32)
        _t_txta = value
      End Set
    End Property
    Public Property t_txtb() As Int32
      Get
        Return _t_txtb
      End Get
      Set(ByVal value As Int32)
        _t_txtb = value
      End Set
    End Property
    Public Property t_cuni() As String
      Get
        Return _t_cuni
      End Get
      Set(ByVal value As String)
        _t_cuni = value
      End Set
    End Property
    Public Property t_oitm() As String
      Get
        Return _t_oitm
      End Get
      Set(ByVal value As String)
        _t_oitm = value
      End Set
    End Property
    Public Property t_elem() As String
      Get
        Return _t_elem
      End Get
      Set(ByVal value As String)
        _t_elem = value
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
        Return _t_docn & "|" & _t_revn & "|" & _t_srno
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
    Public Class PKdmisg002
      Private _t_docn As String = ""
      Private _t_revn As String = ""
      Private _t_srno As Int32 = 0
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
    End Class
    '1. Used
    Public Shared Function Getdmisg002(ByVal t As vaultXML.Item, ByVal x As vaultXML, ByVal SrNo As Integer) As SIS.DMISG.dmisg002
      Dim tmp As New dmisg002
      With tmp
        .t_docn = x.drgid
        .t_revn = x.rev
        .t_srno = SrNo
        .t_item = (t.item_code.Trim & x.ItemSuffix).PadLeft((t.item_code.Trim & x.ItemSuffix).Length + 9, " ")
        .t_dsca = t.item_descn
        .t_citg = t.item_g
        Try
          .t_qnty = t.it_qty
        Catch ex As Exception
          .t_qnty = 0
        End Try
        Try
          If Convert.ToDecimal(t.it_qty) < 0 Then
            Throw New Exception("Item Quantity is Negative.")
          End If
        Catch ex As Exception
        End Try
        Try
          .t_wght = t.it_wt
        Catch ex As Exception
          .t_wght = 0
        End Try
        Try
          If Convert.ToDecimal(t.it_wt) < 0 Then
            Throw New Exception("Item Weight is Negative.")
          End If
        Catch ex As Exception

        End Try
        .t_itmt = t.t
        .t_txta = 0
        .t_txtb = 0
        If t.remark <> "" Then
          If t.remark.Length >= 5 Then
            .Remarks = t.remark
          End If
        End If
        .t_cuni = GetUnitOfGroup(t.item_g, x.ERPCompany)
        If .t_cuni Is Nothing Then
          x.Errors.Add("Item Group " & t.item_g & " NOT Found in ERP for Item=>" & t.item_code)
          Throw New Exception("Item Group " & t.item_g & " NOT Found in ERP for Item=>" & t.item_code)
        End If
        .t_oitm = t.item_code.PadLeft(t.item_code.Trim.Length + 9, " ")
        .t_elem = x.el_id
        .t_Refcntd = 0
        .t_Refcntu = 0
      End With
      Return tmp
    End Function


    Public Shared Function GetUnitOfGroup(ByVal t_citg As String, ByVal comp As String) As String
      Dim Unit As String = ""
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "Select t_cuni from ttcibd002" & comp & " where t_kitm = 1 and t_citg='" & t_citg & "'"
          Unit = Cmd.ExecuteScalar()
        End Using
      End Using
      Return Unit
    End Function

    '2. Used
    Public Shared Function InsertData(ByVal Record As SIS.DMISG.dmisg002, ByVal Comp As String) As SIS.DMISG.dmisg002
      If Record.Remarks <> "" Then
        Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
          Using Cmd As SqlCommand = Con.CreateCommand()
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "spdmisg002" & Comp & "CreateText"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_user", SqlDbType.VarChar, 240, "0340")
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_kwd1", SqlDbType.VarChar, 240, "dmisg002.txtb")
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_txtb", SqlDbType.VarChar, 240, Record.Remarks)
            Cmd.Parameters.Add("@Return_t_srno", SqlDbType.Int, 11)
            Cmd.Parameters("@Return_t_srno").Direction = ParameterDirection.Output
            Con.Open()
            Cmd.ExecuteNonQuery()
            Record.t_txtb = Cmd.Parameters("@Return_t_srno").Value
          End Using
        End Using
      End If
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg002" & Comp & "Insert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn", SqlDbType.VarChar, 33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revn", SqlDbType.VarChar, 21, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srno", SqlDbType.Int, 11, Record.t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_item", SqlDbType.VarChar, 48, Record.t_item)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dsca", SqlDbType.VarChar, 101, Record.t_dsca)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_citg", SqlDbType.VarChar, 51, Record.t_citg)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_qnty", SqlDbType.Float, 16, Record.t_qnty)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_wght", SqlDbType.Float, 16, Record.t_wght)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_itmt", SqlDbType.VarChar, 51, Record.t_itmt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_txta", SqlDbType.Int, 11, Record.t_txta)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_txtb", SqlDbType.Int, 11, Record.t_txtb)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cuni", SqlDbType.VarChar, 4, Record.t_cuni)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_oitm", SqlDbType.VarChar, 48, Record.t_oitm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_elem", SqlDbType.VarChar, 9, Record.t_elem)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Company", SqlDbType.NVarChar, 9, Comp)
          Cmd.Parameters.Add("@Return_t_docn", SqlDbType.VarChar, 33)
          Cmd.Parameters("@Return_t_docn").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_revn", SqlDbType.VarChar, 21)
          Cmd.Parameters("@Return_t_revn").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_srno", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_t_srno").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.t_docn = Cmd.Parameters("@Return_t_docn").Value
          Record.t_revn = Cmd.Parameters("@Return_t_revn").Value
          Record.t_srno = Cmd.Parameters("@Return_t_srno").Value
        End Using
      End Using
      Return Record
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
