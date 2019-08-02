Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.DMISG
  <DataObject()>
  Partial Public Class dmisg121
    Private Shared _RecordCount As Integer
    Private _t_docn As String = ""
    Private _t_revn As String = ""
    Private _t_cprj As String = ""
    Private _t_dsca As String = ""
    Private _t_aldo As String = ""
    Private _t_alre As String = ""
    Private _t_cspa As String = ""
    Private _t_type As String = ""
    Private _t_resp As String = ""
    Private _t_eunt As String = ""
    Private _t_size As Int32 = 0
    Private _t_orgn As String = ""
    Private _t_subm As Int32 = 0
    Private _t_intr As Int32 = 0
    Private _t_prod As Int32 = 0
    Private _t_erec As Int32 = 0
    Private _t_info As Int32 = 0
    Private _t_remk As String = ""
    Private _t_pldt As String = ""
    Private _t_rele As Int32 = 0
    Private _t_acdt As String = ""
    Private _t_vend As Int32 = 0
    Private _t_bpid As String = ""
    Private _t_revd As Int32 = 0
    Private _t_redt As String = ""
    Private _t_logn As String = ""
    Private _t_verk As String = ""
    Private _t_extn As Int32 = 0
    Private _t_ofbp As String = ""
    Private _t_nama As String = ""
    Private _t_eogn As String = ""
    Private _t_exdt As String = ""
    Private _t_exrk As String = ""
    Private _t_cler As Int32 = 0
    Private _t_bloc As Int32 = 0
    Private _t_appr As Int32 = 0
    Private _t_link As Int32 = 0
    Private _t_tran As String = ""
    Private _t_soft As String = ""
    Private _t_test As Int32 = 0
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Private _t_imby As String = ""
    Private _t_imdt As String = ""
    Private _t_emno As String = ""
    Private _t_nhrs As Single = 0
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
    Public Property t_cprj() As String
      Get
        Return _t_cprj
      End Get
      Set(ByVal value As String)
        _t_cprj = value
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
    Public Property t_aldo() As String
      Get
        Return _t_aldo
      End Get
      Set(ByVal value As String)
        _t_aldo = value
      End Set
    End Property
    Public Property t_alre() As String
      Get
        Return _t_alre
      End Get
      Set(ByVal value As String)
        _t_alre = value
      End Set
    End Property
    Public Property t_cspa() As String
      Get
        Return _t_cspa
      End Get
      Set(ByVal value As String)
        _t_cspa = value
      End Set
    End Property
    Public Property t_type() As String
      Get
        Return _t_type
      End Get
      Set(ByVal value As String)
        _t_type = value
      End Set
    End Property
    Public Property t_resp() As String
      Get
        Return _t_resp
      End Get
      Set(ByVal value As String)
        _t_resp = value
      End Set
    End Property
    Public Property t_eunt() As String
      Get
        Return _t_eunt
      End Get
      Set(ByVal value As String)
        _t_eunt = value
      End Set
    End Property
    Public Property t_size() As Int32
      Get
        Return _t_size
      End Get
      Set(ByVal value As Int32)
        _t_size = value
      End Set
    End Property
    Public Property t_orgn() As String
      Get
        Return _t_orgn
      End Get
      Set(ByVal value As String)
        _t_orgn = value
      End Set
    End Property
    Public Property t_subm() As Int32
      Get
        Return _t_subm
      End Get
      Set(ByVal value As Int32)
        _t_subm = value
      End Set
    End Property
    Public Property t_intr() As Int32
      Get
        Return _t_intr
      End Get
      Set(ByVal value As Int32)
        _t_intr = value
      End Set
    End Property
    Public Property t_prod() As Int32
      Get
        Return _t_prod
      End Get
      Set(ByVal value As Int32)
        _t_prod = value
      End Set
    End Property
    Public Property t_erec() As Int32
      Get
        Return _t_erec
      End Get
      Set(ByVal value As Int32)
        _t_erec = value
      End Set
    End Property
    Public Property t_info() As Int32
      Get
        Return _t_info
      End Get
      Set(ByVal value As Int32)
        _t_info = value
      End Set
    End Property
    Public Property t_remk() As String
      Get
        Return _t_remk
      End Get
      Set(ByVal value As String)
        _t_remk = value
      End Set
    End Property
    Public Property t_pldt() As String
      Get
        If Not _t_pldt = String.Empty Then
          Return Convert.ToDateTime(_t_pldt).ToString("dd/MM/yyyy")
        End If
        Return _t_pldt
      End Get
      Set(ByVal value As String)
        _t_pldt = value
      End Set
    End Property
    Public Property t_rele() As Int32
      Get
        Return _t_rele
      End Get
      Set(ByVal value As Int32)
        _t_rele = value
      End Set
    End Property
    Public Property t_acdt() As String
      Get
        If Not _t_acdt = String.Empty Then
          Return Convert.ToDateTime(_t_acdt).ToString("dd/MM/yyyy")
        End If
        Return _t_acdt
      End Get
      Set(ByVal value As String)
        _t_acdt = value
      End Set
    End Property
    Public Property t_vend() As Int32
      Get
        Return _t_vend
      End Get
      Set(ByVal value As Int32)
        _t_vend = value
      End Set
    End Property
    Public Property t_bpid() As String
      Get
        Return _t_bpid
      End Get
      Set(ByVal value As String)
        _t_bpid = value
      End Set
    End Property
    Public Property t_revd() As Int32
      Get
        Return _t_revd
      End Get
      Set(ByVal value As Int32)
        _t_revd = value
      End Set
    End Property
    Public Property t_redt() As String
      Get
        If Not _t_redt = String.Empty Then
          Return Convert.ToDateTime(_t_redt).ToString("dd/MM/yyyy")
        End If
        Return _t_redt
      End Get
      Set(ByVal value As String)
        _t_redt = value
      End Set
    End Property
    Public Property t_logn() As String
      Get
        Return _t_logn
      End Get
      Set(ByVal value As String)
        _t_logn = value
      End Set
    End Property
    Public Property t_verk() As String
      Get
        Return _t_verk
      End Get
      Set(ByVal value As String)
        _t_verk = value
      End Set
    End Property
    Public Property t_extn() As Int32
      Get
        Return _t_extn
      End Get
      Set(ByVal value As Int32)
        _t_extn = value
      End Set
    End Property
    Public Property t_ofbp() As String
      Get
        Return _t_ofbp
      End Get
      Set(ByVal value As String)
        _t_ofbp = value
      End Set
    End Property
    Public Property t_nama() As String
      Get
        Return _t_nama
      End Get
      Set(ByVal value As String)
        _t_nama = value
      End Set
    End Property
    Public Property t_eogn() As String
      Get
        Return _t_eogn
      End Get
      Set(ByVal value As String)
        _t_eogn = value
      End Set
    End Property
    Public Property t_exdt() As String
      Get
        If Not _t_exdt = String.Empty Then
          Return Convert.ToDateTime(_t_exdt).ToString("dd/MM/yyyy")
        End If
        Return _t_exdt
      End Get
      Set(ByVal value As String)
        _t_exdt = value
      End Set
    End Property
    Public Property t_exrk() As String
      Get
        Return _t_exrk
      End Get
      Set(ByVal value As String)
        _t_exrk = value
      End Set
    End Property
    Public Property t_cler() As Int32
      Get
        Return _t_cler
      End Get
      Set(ByVal value As Int32)
        _t_cler = value
      End Set
    End Property
    Public Property t_bloc() As Int32
      Get
        Return _t_bloc
      End Get
      Set(ByVal value As Int32)
        _t_bloc = value
      End Set
    End Property
    Public Property t_appr() As Int32
      Get
        Return _t_appr
      End Get
      Set(ByVal value As Int32)
        _t_appr = value
      End Set
    End Property
    Public Property t_link() As Int32
      Get
        Return _t_link
      End Get
      Set(ByVal value As Int32)
        _t_link = value
      End Set
    End Property
    Public Property t_tran() As String
      Get
        Return _t_tran
      End Get
      Set(ByVal value As String)
        _t_tran = value
      End Set
    End Property
    Public Property t_soft() As String
      Get
        Return _t_soft
      End Get
      Set(ByVal value As String)
        _t_soft = value
      End Set
    End Property
    Public Property t_test() As Int32
      Get
        Return _t_test
      End Get
      Set(ByVal value As Int32)
        _t_test = value
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
    Public Property t_imby() As String
      Get
        Return _t_imby
      End Get
      Set(ByVal value As String)
        _t_imby = value
      End Set
    End Property
    Public Property t_imdt() As String
      Get
        If Not _t_imdt = String.Empty Then
          Return Convert.ToDateTime(_t_imdt).ToString("dd/MM/yyyy")
        End If
        Return _t_imdt
      End Get
      Set(ByVal value As String)
        _t_imdt = value
      End Set
    End Property
    Public Property t_emno() As String
      Get
        Return _t_emno
      End Get
      Set(ByVal value As String)
        _t_emno = value
      End Set
    End Property
    Public Property t_nhrs() As Single
      Get
        Return _t_nhrs
      End Get
      Set(ByVal value As Single)
        _t_nhrs = value
      End Set
    End Property
    Public ReadOnly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public ReadOnly Property PrimaryKey() As String
      Get
        Return _t_docn & "|" & _t_revn
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
    Public Class PKdmisg121
      Private _t_docn As String = ""
      Private _t_revn As String = ""
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
    End Class
    '1. Used
    Public Shared Function dmisg121GetByID(ByVal t_docn As String, ByVal t_revn As String, ByVal Comp As String) As SIS.DMISG.dmisg121
      Dim Results As SIS.DMISG.dmisg121 = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "SELECT *  FROM [tdmisg121" & Comp & "] WHERE [t_docn] = '" & t_docn & "' AND [t_revn] = '" & t_revn & "'"
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.DMISG.dmisg121(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    '2. Used
    Public Shared Function Getdmisg121(ByVal t As vaultXML) As SIS.DMISG.dmisg121
      Dim tmp As New dmisg121
      With tmp
        .t_docn = t.number
        .t_revn = t.rev
        .t_cprj = t.contract
        .t_dsca = t.title
        .t_aldo = "" 'Alternate Doc ID
        .t_alre = "" 'Alternate Doc Rev
        .t_cspa = t.el_id
        .t_type = IIf(IO.Path.GetExtension(t.filename).ToUpper = ".DWG", "DWG", "DOC")  'Document Type DWG/DOC 
        .t_resp = GetRespDeptt(t.resp_dept, t.ERPCompany)
        If .t_resp Is Nothing Then
          .t_resp = ""
          Select Case t.resp_dept.ToLower
            Case "c&i"
              .t_resp = "C&I"
            Case "civil"
              .t_resp = "CVL"
            Case "electrical"
              .t_resp = "ELE"
            Case "mechanical", "smd-design"
              .t_resp = "MEC"
            Case "other"
              .t_resp = "OTR"
            Case "piping"
              .t_resp = "PIP"
            Case "process"
              .t_resp = "PRC"
            Case "smd-mhe"
              .t_resp = "MHE"
            Case "structure"
              .t_resp = "STR"
          End Select
        End If
        Dim div As String = ""
        Select Case t.VaultDBName
          Case "BOILER"
            div = "EU200"
          Case "SMD"
            div = "EU230"
          Case "EPC"
            div = "EU210"
          Case "PC"
            Select Case t.contract.Substring(0, 2).ToUpper
              Case "FS", "FG"
                div = "EU250"
              Case Else
                div = "EU220"
            End Select
          Case "APC"
            div = "EU240"
        End Select
        If t.ERPCompany = "700" Then
          div = "EU700"
        End If
        .t_eunt = div
        Select Case t.sheetsize
          Case "A0"
            .t_size = 1
          Case "A1"
            .t_size = 2
          Case "A2"
            .t_size = 3
          Case "A3"
            .t_size = 4
          Case "A4"
            .t_size = 5
          Case Else
            .t_size = 1
        End Select
        .t_orgn = IIf(t.drgid.IndexOf("-VEN-") > 0, "VEN", "ISG")

        .t_erec = IIf(t.ere.Trim.ToUpper = "YES", yesno.YES, yesno.NO)
        .t_prod = IIf(t.pro.Trim.ToUpper = "YES", yesno.YES, yesno.NO)
        .t_info = IIf(t.inf.Trim.ToUpper = "YES", yesno.YES, yesno.NO)
        .t_subm = IIf(t.apr.Trim.ToUpper = "YES", yesno.YES, yesno.NO)
        .t_intr = yesno.YES 'For Internal use
        .t_remk = ""
        .t_pldt = "31/12/1974"   ' "01/01/1753"
        .t_rele = yesno.NO
        .t_acdt = "31/12/1974"   ' "01/01/1753"
        .t_vend = IIf(t.drgid.IndexOf("-VEN-") > 0, yesno.YES, yesno.NO)
        .t_bpid = ""
        .t_revd = yesno.NO
        .t_redt = "31/12/1974"   ' "01/01/1753"
        .t_logn = ""
        .t_verk = ""
        .t_extn = yesno.NO
        .t_ofbp = ""
        .t_nama = ""
        .t_eogn = ""
        .t_exdt = "31/12/1974"   ' "01/01/1753"
        .t_exrk = ""
        .t_cler = yesno.NO
        .t_bloc = yesno.NO
        .t_appr = yesno.NO 'Can Be Included In Trans
        .t_link = yesno.NO
        .t_tran = ""
        .t_soft = t.name_software
        .t_test = 0
        .t_Refcntd = 0
        .t_Refcntu = 0
        .t_imby = ""
        .t_imdt = "01/01/1753"
        .t_emno = ""
        .t_nhrs = 0.00
      End With
      Return tmp
    End Function

    Public Shared Function GetRespDeptt(ByVal t_dsca As String, ByVal comp As String) As String
      Dim mRet As String = ""
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "Select t_grup from tdmisg090" & comp & " where UPPER(LTRIM(t_dsca)) = '" & t_dsca.Trim.ToUpper & "'"
          mRet = Cmd.ExecuteScalar()
        End Using
      End Using
      Return mRet
    End Function
    '3. Used
    Public Shared Function InsertData(ByVal Record As SIS.DMISG.dmisg121, ByVal Comp As String) As SIS.DMISG.dmisg121
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg121" & Comp & "Insert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn", SqlDbType.VarChar, 33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revn", SqlDbType.VarChar, 33, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj", SqlDbType.VarChar, 10, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dsca", SqlDbType.VarChar, 101, Record.t_dsca)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aldo", SqlDbType.VarChar, 33, Record.t_aldo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_alre", SqlDbType.VarChar, 21, Record.t_alre)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cspa", SqlDbType.VarChar, 9, Record.t_cspa)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_type", SqlDbType.VarChar, 8, Record.t_type)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_resp", SqlDbType.VarChar, 4, Record.t_resp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_eunt", SqlDbType.VarChar, 7, Record.t_eunt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_size", SqlDbType.Int, 11, Record.t_size)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_orgn", SqlDbType.VarChar, 4, Record.t_orgn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_subm", SqlDbType.Int, 11, Record.t_subm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_intr", SqlDbType.Int, 11, Record.t_intr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prod", SqlDbType.Int, 11, Record.t_prod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_erec", SqlDbType.Int, 11, Record.t_erec)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_info", SqlDbType.Int, 11, Record.t_info)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_remk", SqlDbType.VarChar, 101, Record.t_remk)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pldt", SqlDbType.DateTime, 21, Record.t_pldt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rele", SqlDbType.Int, 11, Record.t_rele)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acdt", SqlDbType.DateTime, 21, Record.t_acdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_vend", SqlDbType.Int, 11, Record.t_vend)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bpid", SqlDbType.VarChar, 10, Record.t_bpid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revd", SqlDbType.Int, 11, Record.t_revd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_redt", SqlDbType.DateTime, 21, Record.t_redt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_logn", SqlDbType.VarChar, 17, Record.t_logn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_verk", SqlDbType.VarChar, 101, Record.t_verk)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_extn", SqlDbType.Int, 11, Record.t_extn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ofbp", SqlDbType.VarChar, 10, Record.t_ofbp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_nama", SqlDbType.VarChar, 36, Record.t_nama)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_eogn", SqlDbType.VarChar, 17, Record.t_eogn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_exdt", SqlDbType.DateTime, 21, Record.t_exdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_exrk", SqlDbType.VarChar, 101, Record.t_exrk)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cler", SqlDbType.Int, 11, Record.t_cler)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bloc", SqlDbType.Int, 11, Record.t_bloc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_appr", SqlDbType.Int, 11, Record.t_appr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_link", SqlDbType.Int, 11, Record.t_link)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_tran", SqlDbType.VarChar, 10, Record.t_tran)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_soft", SqlDbType.VarChar, 51, Record.t_soft)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_test", SqlDbType.Int, 11, Record.t_test)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_imby", SqlDbType.VarChar, 17, Record.t_imby)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_imdt", SqlDbType.DateTime, 21, Record.t_imdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_emno", SqlDbType.VarChar, 10, Record.t_emno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_nhrs", SqlDbType.Real, 8, Record.t_nhrs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Company", SqlDbType.NVarChar, 9, Comp)
          Cmd.Parameters.Add("@Return_t_docn", SqlDbType.VarChar, 33)
          Cmd.Parameters("@Return_t_docn").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_revn", SqlDbType.VarChar, 33)
          Cmd.Parameters("@Return_t_revn").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.t_docn = Cmd.Parameters("@Return_t_docn").Value
          Record.t_revn = Cmd.Parameters("@Return_t_revn").Value
        End Using
      End Using
      Return Record
    End Function
    '4. Used
    Public Shared Function UpdateData(ByVal Record As SIS.DMISG.dmisg121, ByVal Comp As String) As SIS.DMISG.dmisg121
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg121" & Comp & "Update"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_docn", SqlDbType.VarChar, 33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_revn", SqlDbType.VarChar, 33, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn", SqlDbType.VarChar, 33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revn", SqlDbType.VarChar, 33, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj", SqlDbType.VarChar, 10, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dsca", SqlDbType.VarChar, 101, Record.t_dsca)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aldo", SqlDbType.VarChar, 33, Record.t_aldo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_alre", SqlDbType.VarChar, 21, Record.t_alre)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cspa", SqlDbType.VarChar, 9, Record.t_cspa)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_type", SqlDbType.VarChar, 8, Record.t_type)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_resp", SqlDbType.VarChar, 4, Record.t_resp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_eunt", SqlDbType.VarChar, 7, Record.t_eunt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_size", SqlDbType.Int, 11, Record.t_size)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_orgn", SqlDbType.VarChar, 4, Record.t_orgn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_subm", SqlDbType.Int, 11, Record.t_subm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_intr", SqlDbType.Int, 11, Record.t_intr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prod", SqlDbType.Int, 11, Record.t_prod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_erec", SqlDbType.Int, 11, Record.t_erec)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_info", SqlDbType.Int, 11, Record.t_info)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_remk", SqlDbType.VarChar, 101, Record.t_remk)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pldt", SqlDbType.DateTime, 21, Record.t_pldt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rele", SqlDbType.Int, 11, Record.t_rele)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acdt", SqlDbType.DateTime, 21, Record.t_acdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_vend", SqlDbType.Int, 11, Record.t_vend)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bpid", SqlDbType.VarChar, 10, Record.t_bpid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revd", SqlDbType.Int, 11, Record.t_revd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_redt", SqlDbType.DateTime, 21, Record.t_redt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_logn", SqlDbType.VarChar, 17, Record.t_logn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_verk", SqlDbType.VarChar, 101, Record.t_verk)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_extn", SqlDbType.Int, 11, Record.t_extn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ofbp", SqlDbType.VarChar, 10, Record.t_ofbp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_nama", SqlDbType.VarChar, 36, Record.t_nama)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_eogn", SqlDbType.VarChar, 17, Record.t_eogn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_exdt", SqlDbType.DateTime, 21, Record.t_exdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_exrk", SqlDbType.VarChar, 101, Record.t_exrk)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cler", SqlDbType.Int, 11, Record.t_cler)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bloc", SqlDbType.Int, 11, Record.t_bloc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_appr", SqlDbType.Int, 11, Record.t_appr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_link", SqlDbType.Int, 11, Record.t_link)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_tran", SqlDbType.VarChar, 10, Record.t_tran)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_soft", SqlDbType.VarChar, 51, Record.t_soft)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_test", SqlDbType.Int, 11, Record.t_test)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_imby", SqlDbType.VarChar, 17, Record.t_imby)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_imdt", SqlDbType.DateTime, 21, Record.t_imdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_emno", SqlDbType.VarChar, 10, Record.t_emno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_nhrs", SqlDbType.Real, 8, Record.t_nhrs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Company", SqlDbType.NVarChar, 9, Comp)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
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
