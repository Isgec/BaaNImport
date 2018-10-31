Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.DMISG
  <DataObject()>
  Partial Public Class dmisg001
    Private Shared _RecordCount As Integer
    Private _t_docn As String = ""
    Private _t_revn As String = ""
    Private _t_dcid As String = ""
    Private _t_dsca As String = ""
    Private _t_dttl As String = ""
    Private _t_cspa As String = ""
    Private _t_erec As Int32 = 0
    Private _t_prod As Int32 = 0
    Private _t_info As Int32 = 0
    Private _t_appr As Int32 = 0
    Private _t_resp As String = ""
    Private _t_date As String = ""
    Private _t_appb As String = ""
    Private _t_chkb As String = ""
    Private _t_drwb As String = ""
    Private _t_wght As Double = 0
    Private _t_scal As String = ""
    Private _t_size As String = ""
    Private _t_pdfn As String = ""
    Private _t_cprj As String = ""
    Private _t_grup As String = ""
    Private _t_clnt As String = ""
    Private _t_cnsl As String = ""
    Private _t_year As String = ""
    Private _t_iwtn As String = ""
    Private _t_ser2 As String = ""
    Private _t_ser1 As String = ""
    Private _t_stat As Int32 = 0
    Private _t_name As String = ""
    Private _t_user As String = ""
    Private _t_mach As String = ""
    Private _t_sdat As String = ""
    Private _t_sorc As String = ""
    Private _t_crtp As Int32 = 0
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Private _t_drdt As String = ""
    Private _t_drur As String = ""
    Private _t_aact As Int32 = 0
    Private _t_aact_1 As Int32 = 0
    Private _t_aact_2 As Int32 = 0
    Private _t_aact_3 As Int32 = 0
    Private _t_adat As String = ""
    Private _t_apre As String = ""
    Private _t_atxt As Int32 = 0
    Private _t_ausr As String = ""
    Private _t_dcrr As Int32 = 0
    Private _t_docs As Int32 = 0
    Private _t_drwd As String = ""
    Private _t_link As Int32 = 0
    Private _t_pdfd As String = ""
    Private _t_ract As Int32 = 0
    Private _t_ract_1 As Int32 = 0
    Private _t_ract_2 As Int32 = 0
    Private _t_rdat As String = ""
    Private _t_rere As String = ""
    Private _t_rtxt As Int32 = 0
    Private _t_rusr As String = ""
    Private _t_sudt As String = ""
    Private _t_type As String = ""
    Private _t_wfst As Int32 = 0
    Private _t_soft As String = ""
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
    Public Property t_dcid() As String
      Get
        Return _t_dcid
      End Get
      Set(ByVal value As String)
        _t_dcid = value
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
    Public Property t_dttl() As String
      Get
        Return _t_dttl
      End Get
      Set(ByVal value As String)
        _t_dttl = value
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
    Public Property t_erec() As Int32
      Get
        Return _t_erec
      End Get
      Set(ByVal value As Int32)
        _t_erec = value
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
    Public Property t_info() As Int32
      Get
        Return _t_info
      End Get
      Set(ByVal value As Int32)
        _t_info = value
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
    Public Property t_resp() As String
      Get
        Return _t_resp
      End Get
      Set(ByVal value As String)
        _t_resp = value
      End Set
    End Property
    Public Property t_date() As String
      Get
        Return _t_date
      End Get
      Set(ByVal value As String)
        _t_date = value
      End Set
    End Property
    Public Property t_appb() As String
      Get
        Return _t_appb
      End Get
      Set(ByVal value As String)
        _t_appb = value
      End Set
    End Property
    Public Property t_chkb() As String
      Get
        Return _t_chkb
      End Get
      Set(ByVal value As String)
        _t_chkb = value
      End Set
    End Property
    Public Property t_drwb() As String
      Get
        Return _t_drwb
      End Get
      Set(ByVal value As String)
        _t_drwb = value
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
    Public Property t_scal() As String
      Get
        Return _t_scal
      End Get
      Set(ByVal value As String)
        _t_scal = value
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
    Public Property t_pdfn() As String
      Get
        Return _t_pdfn
      End Get
      Set(ByVal value As String)
        _t_pdfn = value
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
    Public Property t_grup() As String
      Get
        Return _t_grup
      End Get
      Set(ByVal value As String)
        _t_grup = value
      End Set
    End Property
    Public Property t_clnt() As String
      Get
        Return _t_clnt
      End Get
      Set(ByVal value As String)
        _t_clnt = value
      End Set
    End Property
    Public Property t_cnsl() As String
      Get
        Return _t_cnsl
      End Get
      Set(ByVal value As String)
        _t_cnsl = value
      End Set
    End Property
    Public Property t_year() As String
      Get
        Return _t_year
      End Get
      Set(ByVal value As String)
        _t_year = value
      End Set
    End Property
    Public Property t_iwtn() As String
      Get
        Return _t_iwtn
      End Get
      Set(ByVal value As String)
        _t_iwtn = value
      End Set
    End Property
    Public Property t_ser2() As String
      Get
        Return _t_ser2
      End Get
      Set(ByVal value As String)
        _t_ser2 = value
      End Set
    End Property
    Public Property t_ser1() As String
      Get
        Return _t_ser1
      End Get
      Set(ByVal value As String)
        _t_ser1 = value
      End Set
    End Property
    Public Property t_stat() As Int32
      Get
        Return _t_stat
      End Get
      Set(ByVal value As Int32)
        _t_stat = value
      End Set
    End Property
    Public Property t_name() As String
      Get
        Return _t_name
      End Get
      Set(ByVal value As String)
        _t_name = value
      End Set
    End Property
    Public Property t_user() As String
      Get
        Return _t_user
      End Get
      Set(ByVal value As String)
        _t_user = value
      End Set
    End Property
    Public Property t_mach() As String
      Get
        Return _t_mach
      End Get
      Set(ByVal value As String)
        _t_mach = value
      End Set
    End Property
    Public Property t_sdat() As String
      Get
        If Not _t_sdat = String.Empty Then
          Return Convert.ToDateTime(_t_sdat).ToString("dd/MM/yyyy HH:mm")
        End If
        Return _t_sdat
      End Get
      Set(ByVal value As String)
        _t_sdat = value
      End Set
    End Property
    Public Property t_sorc() As String
      Get
        Return _t_sorc
      End Get
      Set(ByVal value As String)
        _t_sorc = value
      End Set
    End Property
    Public Property t_crtp() As Int32
      Get
        Return _t_crtp
      End Get
      Set(ByVal value As Int32)
        _t_crtp = value
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
    Public Property t_drdt() As String
      Get
        If Not _t_drdt = String.Empty Then
          Return Convert.ToDateTime(_t_drdt).ToString("dd/MM/yyyy")
        End If
        Return _t_drdt
      End Get
      Set(ByVal value As String)
        _t_drdt = value
      End Set
    End Property
    Public Property t_drur() As String
      Get
        Return _t_drur
      End Get
      Set(ByVal value As String)
        _t_drur = value
      End Set
    End Property
    Public Property t_aact() As Int32
      Get
        Return _t_aact
      End Get
      Set(ByVal value As Int32)
        _t_aact = value
      End Set
    End Property
    Public Property t_aact_1() As Int32
      Get
        Return _t_aact_1
      End Get
      Set(ByVal value As Int32)
        _t_aact_1 = value
      End Set
    End Property
    Public Property t_aact_2() As Int32
      Get
        Return _t_aact_2
      End Get
      Set(ByVal value As Int32)
        _t_aact_2 = value
      End Set
    End Property
    Public Property t_aact_3() As Int32
      Get
        Return _t_aact_3
      End Get
      Set(ByVal value As Int32)
        _t_aact_3 = value
      End Set
    End Property
    Public Property t_adat() As String
      Get
        If Not _t_adat = String.Empty Then
          Return Convert.ToDateTime(_t_adat).ToString("dd/MM/yyyy")
        End If
        Return _t_adat
      End Get
      Set(ByVal value As String)
        _t_adat = value
      End Set
    End Property
    Public Property t_apre() As String
      Get
        Return _t_apre
      End Get
      Set(ByVal value As String)
        _t_apre = value
      End Set
    End Property
    Public Property t_atxt() As Int32
      Get
        Return _t_atxt
      End Get
      Set(ByVal value As Int32)
        _t_atxt = value
      End Set
    End Property
    Public Property t_ausr() As String
      Get
        Return _t_ausr
      End Get
      Set(ByVal value As String)
        _t_ausr = value
      End Set
    End Property
    Public Property t_dcrr() As Int32
      Get
        Return _t_dcrr
      End Get
      Set(ByVal value As Int32)
        _t_dcrr = value
      End Set
    End Property
    Public Property t_docs() As Int32
      Get
        Return _t_docs
      End Get
      Set(ByVal value As Int32)
        _t_docs = value
      End Set
    End Property
    Public Property t_drwd() As String
      Get
        Return _t_drwd
      End Get
      Set(ByVal value As String)
        _t_drwd = value
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
    Public Property t_pdfd() As String
      Get
        Return _t_pdfd
      End Get
      Set(ByVal value As String)
        _t_pdfd = value
      End Set
    End Property
    Public Property t_ract() As Int32
      Get
        Return _t_ract
      End Get
      Set(ByVal value As Int32)
        _t_ract = value
      End Set
    End Property
    Public Property t_ract_1() As Int32
      Get
        Return _t_ract_1
      End Get
      Set(ByVal value As Int32)
        _t_ract_1 = value
      End Set
    End Property
    Public Property t_ract_2() As Int32
      Get
        Return _t_ract_2
      End Get
      Set(ByVal value As Int32)
        _t_ract_2 = value
      End Set
    End Property
    Public Property t_rdat() As String
      Get
        If Not _t_rdat = String.Empty Then
          Return Convert.ToDateTime(_t_rdat).ToString("dd/MM/yyyy")
        End If
        Return _t_rdat
      End Get
      Set(ByVal value As String)
        _t_rdat = value
      End Set
    End Property
    Public Property t_rere() As String
      Get
        Return _t_rere
      End Get
      Set(ByVal value As String)
        _t_rere = value
      End Set
    End Property
    Public Property t_rtxt() As Int32
      Get
        Return _t_rtxt
      End Get
      Set(ByVal value As Int32)
        _t_rtxt = value
      End Set
    End Property
    Public Property t_rusr() As String
      Get
        Return _t_rusr
      End Get
      Set(ByVal value As String)
        _t_rusr = value
      End Set
    End Property
    Public Property t_sudt() As String
      Get
        If Not _t_sudt = String.Empty Then
          Return Convert.ToDateTime(_t_sudt).ToString("dd/MM/yyyy")
        End If
        Return _t_sudt
      End Get
      Set(ByVal value As String)
        _t_sudt = value
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
    Public Property t_wfst() As Int32
      Get
        Return _t_wfst
      End Get
      Set(ByVal value As Int32)
        _t_wfst = value
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
    Public Class PKdmisg001
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
    '01.Used
    Public Shared Function dmisg001GetByID(ByVal t_docn As String, ByVal t_revn As String, ByVal comp As String) As SIS.DMISG.dmisg001
      Dim Results As SIS.DMISG.dmisg001 = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "SELECT *  FROM [tdmisg001" & comp & "] WHERE [t_docn] = '" & t_docn & "' AND [t_revn] = '" & t_revn & "'"
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.DMISG.dmisg001(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    '02. Used
    Public Shared Function Getdmisg001(ByVal t As vaultXML) As SIS.DMISG.dmisg001
      Dim tmp As New dmisg001
      With tmp
        .t_name = t.VaultDBName
        .t_user = t.VaultUserName
        .t_mach = t.VaultClientMachine
        .t_sdat = t.VaultSubmittedDate
        .t_sorc = t.ISGEC_Datasource
        .t_docn = t.number
        .t_revn = t.rev
        .t_dcid = t.drgid
        .t_dsca = t.filename
        .t_grup = t.group
        .t_dttl = t.title
        .t_cspa = t.el_id
        .t_erec = IIf(t.ere.Trim.ToUpper = "YES", yesno.YES, yesno.NO)
        .t_prod = IIf(t.pro.Trim.ToUpper = "YES", yesno.YES, yesno.NO)
        .t_info = IIf(t.inf.Trim.ToUpper = "YES", yesno.YES, yesno.NO)
        .t_appr = IIf(t.apr.Trim.ToUpper = "YES", yesno.YES, yesno.NO)
        .t_type = IIf(IO.Path.GetExtension(t.filename).ToUpper = ".DWG", "DWG", "DOC")  'Document Type DWG/DOC 
        .t_resp = t.resp_dept
        .t_date = t.dDate
        .t_appb = t.appd
        .t_chkb = t.chqd
        .t_drwb = t.drawn
        Try
          .t_wght = t.weight
        Catch ex As Exception
          .t_wght = 0.00
        End Try
        .t_scal = t.scale
        .t_size = t.sheetsize
        .t_pdfn = t.PDF_filename
        .t_cprj = t.contract
        .t_clnt = t.client
        .t_cnsl = t.consultant
        .t_year = t.year
        .t_iwtn = t.iwt
        .t_ser2 = t.service2
        .t_ser1 = t.service1
        .t_stat = stat.Submitted
        .t_crtp = yesno.NO 'Mannually Created
        .t_Refcntd = 0
        .t_Refcntu = 0
        .t_drdt = "01/01/1970"  ' "01/01/1753" 'Release Date
        .t_drur = "" 'Releasing User
        .t_aact = 20 'Approver Action
        .t_aact_1 = yesno.NO 'Approver Reject
        .t_aact_2 = yesno.NO 'Approver Approve
        .t_aact_3 = yesno.NO 'Approver Withdrawn
        .t_adat = "01/01/1970"  ' "01/01/1753" 'Approved On
        .t_apre = "" 'Approver Remarks
        .t_atxt = 0 'Approver Comment Text
        .t_ausr = "" 'Approved By
        .t_dcrr = yesno.NO
        .t_docs = yesno.NO
        .t_drwd = "" 'Original File ID of ODM
        .t_link = yesno.NO
        .t_pdfd = "" 'PDF File ID of ODM
        .t_ract = 20 'Reviewer Action
        .t_ract_1 = yesno.NO 'Reviewer Reject
        .t_ract_2 = yesno.NO 'Reviewer Accept
        .t_rdat = "01/01/1970"  ' "01/01/1753" 'Reviewed On
        .t_rere = "" 'Reviewer Remarks
        .t_rtxt = 0 'Reviewer Comments Text
        .t_rusr = "" 'Review By
        .t_sudt = "01/01/1970"  ' "01/01/1753" 'Submitted for Verification
        .t_wfst = wfst.Submitted
        .t_soft = t.name_software
      End With
      Return tmp
    End Function

    '03. Used
    Public Shared Function InsertData(ByVal Record As SIS.DMISG.dmisg001, ByVal Comp As String) As SIS.DMISG.dmisg001
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg001" & Comp & "Insert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn", SqlDbType.VarChar, 33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revn", SqlDbType.VarChar, 21, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dcid", SqlDbType.VarChar, 33, Record.t_dcid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dsca", SqlDbType.VarChar, 101, Record.t_dsca)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dttl", SqlDbType.VarChar, 101, Record.t_dttl)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cspa", SqlDbType.VarChar, 9, Record.t_cspa)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_erec", SqlDbType.Int, 11, Record.t_erec)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prod", SqlDbType.Int, 11, Record.t_prod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_info", SqlDbType.Int, 11, Record.t_info)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_appr", SqlDbType.Int, 11, Record.t_appr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_resp", SqlDbType.VarChar, 51, Record.t_resp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_date", SqlDbType.VarChar, 21, Record.t_date)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_appb", SqlDbType.VarChar, 21, Record.t_appb)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_chkb", SqlDbType.VarChar, 51, Record.t_chkb)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drwb", SqlDbType.VarChar, 51, Record.t_drwb)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_wght", SqlDbType.Float, 16, Record.t_wght)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_scal", SqlDbType.VarChar, 21, Record.t_scal)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_size", SqlDbType.VarChar, 51, Record.t_size)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pdfn", SqlDbType.VarChar, 101, Record.t_pdfn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj", SqlDbType.VarChar, 10, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_grup", SqlDbType.VarChar, 21, Record.t_grup)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_clnt", SqlDbType.VarChar, 101, Record.t_clnt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cnsl", SqlDbType.VarChar, 101, Record.t_cnsl)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_year", SqlDbType.VarChar, 5, Record.t_year)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iwtn", SqlDbType.VarChar, 11, Record.t_iwtn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ser2", SqlDbType.VarChar, 101, Record.t_ser2)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ser1", SqlDbType.VarChar, 101, Record.t_ser1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_stat", SqlDbType.Int, 11, Record.t_stat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_name", SqlDbType.VarChar, 36, Record.t_name)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_user", SqlDbType.VarChar, 36, Record.t_user)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_mach", SqlDbType.VarChar, 36, Record.t_mach)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sdat", SqlDbType.DateTime, 21, Record.t_sdat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sorc", SqlDbType.VarChar, 51, Record.t_sorc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_crtp", SqlDbType.Int, 11, Record.t_crtp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drdt", SqlDbType.DateTime, 21, Record.t_drdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drur", SqlDbType.VarChar, 17, Record.t_drur)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aact", SqlDbType.Int, 11, Record.t_aact)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aact_1", SqlDbType.Int, 11, Record.t_aact_1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aact_2", SqlDbType.Int, 11, Record.t_aact_2)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aact_3", SqlDbType.Int, 11, Record.t_aact_3)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_adat", SqlDbType.DateTime, 21, Record.t_adat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_apre", SqlDbType.VarChar, 51, Record.t_apre)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_atxt", SqlDbType.Int, 11, Record.t_atxt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ausr", SqlDbType.VarChar, 10, Record.t_ausr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dcrr", SqlDbType.Int, 11, Record.t_dcrr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docs", SqlDbType.Int, 11, Record.t_docs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drwd", SqlDbType.VarChar, 33, Record.t_drwd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_link", SqlDbType.Int, 11, Record.t_link)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pdfd", SqlDbType.VarChar, 33, Record.t_pdfd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ract", SqlDbType.Int, 11, Record.t_ract)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ract_1", SqlDbType.Int, 11, Record.t_ract_1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ract_2", SqlDbType.Int, 11, Record.t_ract_2)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rdat", SqlDbType.DateTime, 21, Record.t_rdat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rere", SqlDbType.VarChar, 51, Record.t_rere)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rtxt", SqlDbType.Int, 11, Record.t_rtxt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rusr", SqlDbType.VarChar, 10, Record.t_rusr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sudt", SqlDbType.DateTime, 21, Record.t_sudt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_type", SqlDbType.VarChar, 8, Record.t_type)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_wfst", SqlDbType.Int, 11, Record.t_wfst)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_soft", SqlDbType.VarChar, 51, Record.t_soft)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Company", SqlDbType.NVarChar, 9, Comp)
          Cmd.Parameters.Add("@Return_t_docn", SqlDbType.VarChar, 33)
          Cmd.Parameters("@Return_t_docn").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_revn", SqlDbType.VarChar, 21)
          Cmd.Parameters("@Return_t_revn").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.t_docn = Cmd.Parameters("@Return_t_docn").Value
          Record.t_revn = Cmd.Parameters("@Return_t_revn").Value
        End Using
      End Using
      Return Record
    End Function
    '04. Used
    Public Shared Sub dmisg001DeleteAll(ByVal t_docn As String, ByVal t_revn As String, ByVal comp As String)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "DELETE tdmisg121" & comp & " where t_docn='" & t_docn & "' and t_revn='" & t_revn & "'"
          Cmd.ExecuteNonQuery()
        End Using
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "DELETE tdmisg004" & comp & " where t_docn='" & t_docn & "' and t_revn='" & t_revn & "'"
          Cmd.ExecuteNonQuery()
        End Using
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "DELETE tdmisg003" & comp & " where t_docn='" & t_docn & "' and t_revn='" & t_revn & "'"
          Cmd.ExecuteNonQuery()
        End Using
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg002" & comp & "DeleteText"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn", SqlDbType.VarChar, 33, t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revn", SqlDbType.VarChar, 21, t_revn)
          Cmd.ExecuteNonQuery()
        End Using
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "DELETE tdmisg002" & comp & " where t_docn='" & t_docn & "' and t_revn='" & t_revn & "'"
          Cmd.ExecuteNonQuery()
        End Using
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "DELETE tdmisg001" & comp & " where t_docn='" & t_docn & "' and t_revn='" & t_revn & "'"
          Cmd.ExecuteNonQuery()
        End Using
      End Using
    End Sub
    '05. Used
    Public Shared Function UpdateData(ByVal Record As SIS.DMISG.dmisg001, ByVal Comp As String) As SIS.DMISG.dmisg001
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg001" & Comp & "Update"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_docn", SqlDbType.VarChar, 33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_revn", SqlDbType.VarChar, 21, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn", SqlDbType.VarChar, 33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revn", SqlDbType.VarChar, 21, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dcid", SqlDbType.VarChar, 33, Record.t_dcid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dsca", SqlDbType.VarChar, 101, Record.t_dsca)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dttl", SqlDbType.VarChar, 101, Record.t_dttl)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cspa", SqlDbType.VarChar, 9, Record.t_cspa)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_erec", SqlDbType.Int, 11, Record.t_erec)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prod", SqlDbType.Int, 11, Record.t_prod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_info", SqlDbType.Int, 11, Record.t_info)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_appr", SqlDbType.Int, 11, Record.t_appr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_resp", SqlDbType.VarChar, 51, Record.t_resp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_date", SqlDbType.VarChar, 21, Record.t_date)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_appb", SqlDbType.VarChar, 21, Record.t_appb)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_chkb", SqlDbType.VarChar, 51, Record.t_chkb)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drwb", SqlDbType.VarChar, 51, Record.t_drwb)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_wght", SqlDbType.Float, 16, Record.t_wght)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_scal", SqlDbType.VarChar, 21, Record.t_scal)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_size", SqlDbType.VarChar, 51, Record.t_size)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pdfn", SqlDbType.VarChar, 101, Record.t_pdfn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj", SqlDbType.VarChar, 10, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_grup", SqlDbType.VarChar, 21, Record.t_grup)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_clnt", SqlDbType.VarChar, 101, Record.t_clnt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cnsl", SqlDbType.VarChar, 101, Record.t_cnsl)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_year", SqlDbType.VarChar, 5, Record.t_year)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iwtn", SqlDbType.VarChar, 11, Record.t_iwtn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ser2", SqlDbType.VarChar, 101, Record.t_ser2)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ser1", SqlDbType.VarChar, 101, Record.t_ser1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_stat", SqlDbType.Int, 11, Record.t_stat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_name", SqlDbType.VarChar, 36, Record.t_name)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_user", SqlDbType.VarChar, 36, Record.t_user)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_mach", SqlDbType.VarChar, 36, Record.t_mach)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sdat", SqlDbType.DateTime, 21, Record.t_sdat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sorc", SqlDbType.VarChar, 51, Record.t_sorc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_crtp", SqlDbType.Int, 11, Record.t_crtp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drdt", SqlDbType.DateTime, 21, Record.t_drdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drur", SqlDbType.VarChar, 17, Record.t_drur)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aact", SqlDbType.Int, 11, Record.t_aact)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aact_1", SqlDbType.Int, 11, Record.t_aact_1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aact_2", SqlDbType.Int, 11, Record.t_aact_2)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aact_3", SqlDbType.Int, 11, Record.t_aact_3)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_adat", SqlDbType.DateTime, 21, Record.t_adat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_apre", SqlDbType.VarChar, 51, Record.t_apre)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_atxt", SqlDbType.Int, 11, Record.t_atxt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ausr", SqlDbType.VarChar, 10, Record.t_ausr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dcrr", SqlDbType.Int, 11, Record.t_dcrr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docs", SqlDbType.Int, 11, Record.t_docs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drwd", SqlDbType.VarChar, 33, Record.t_drwd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_link", SqlDbType.Int, 11, Record.t_link)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pdfd", SqlDbType.VarChar, 33, Record.t_pdfd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ract", SqlDbType.Int, 11, Record.t_ract)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ract_1", SqlDbType.Int, 11, Record.t_ract_1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ract_2", SqlDbType.Int, 11, Record.t_ract_2)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rdat", SqlDbType.DateTime, 21, Record.t_rdat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rere", SqlDbType.VarChar, 51, Record.t_rere)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rtxt", SqlDbType.Int, 11, Record.t_rtxt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rusr", SqlDbType.VarChar, 10, Record.t_rusr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sudt", SqlDbType.DateTime, 21, Record.t_sudt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_type", SqlDbType.VarChar, 8, Record.t_type)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_wfst", SqlDbType.Int, 11, Record.t_wfst)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_soft", SqlDbType.VarChar, 51, Record.t_soft)
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
