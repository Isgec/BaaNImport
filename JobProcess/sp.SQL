SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg002200DeleteText]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg002200DeleteText]
GO

ALTER PROCEDURE [dbo].[spdmisg002200DeleteText]
  @t_docn VarChar(32),
  @t_revn VarChar(20)
  AS
  BEGIN
  DELETE [ttttxt010200] where [t_ctxt] IN (select t_txtb from tdmisg002200 where t_docn=@t_docn and t_revn=@t_revn)
  DELETE [ttttxt002200] where [t_ctxt] IN (select t_txtb from tdmisg002200 where t_docn=@t_docn and t_revn=@t_revn)
  DELETE [ttttxt001200] where [t_ctxt] IN (select t_txtb from tdmisg002200 where t_docn=@t_docn and t_revn=@t_revn)
  END
GO 

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg002200CreateText]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg002200CreateText]
GO

ALTER PROCEDURE [dbo].[spdmisg002200CreateText]
  @t_user VarChar(12),
  @t_kwd1 VarChar(20),
  @t_txtb VarChar(240), 
  @Return_t_srno Int = null OUTPUT 
  AS
  BEGIN
  select @Return_t_srno=max(t_ctxt)+1 from ttttxt001200

  INSERT [ttttxt001200] ([t_ctxt],[t_opwd],[t_txtg],[t_desc],[t_Refcntd],[t_Refcntu]) VALUES (@Return_t_srno,'text','text','',0,0 )
  INSERT [ttttxt002200] ([t_ctxt],[t_clan],[t_kwd1],[t_kwd2],[t_kwd3],[t_kwd4],[t_ludt],[t_user],[t_nlin],[t_Refcntd],[t_Refcntu]) 
         VALUES (@Return_t_srno,2,@t_kwd1,'','','',GetDate(),@t_user,1,0,0)
  INSERT [ttttxt010200] ([t_ctxt],[t_clan],[t_seqe],[t_text],[t_Refcntd],[t_Refcntu]) VALUES (@Return_t_srno,2,1,convert(binary,@t_txtb),0,0)
  END
GO 

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg001200Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg001200Insert]
GO
 
CREATE PROCEDURE [dbo].[spdmisg001200Insert]
  @t_docn VarChar(32),
  @t_revn VarChar(20),
  @t_dcid VarChar(32),
  @t_dsca VarChar(100),
  @t_dttl VarChar(100),
  @t_cspa VarChar(8),
  @t_erec Int,
  @t_prod Int,
  @t_info Int,
  @t_appr Int,
  @t_resp VarChar(50),
  @t_date VarChar(20),
  @t_appb VarChar(20),
  @t_chkb VarChar(50),
  @t_drwb VarChar(50),
  @t_wght Float,
  @t_scal VarChar(20),
  @t_size VarChar(50),
  @t_pdfn VarChar(100),
  @t_cprj VarChar(9),
  @t_grup VarChar(20),
  @t_clnt VarChar(100),
  @t_cnsl VarChar(100),
  @t_year VarChar(4),
  @t_iwtn VarChar(10),
  @t_ser2 VarChar(100),
  @t_ser1 VarChar(100),
  @t_stat Int,
  @t_name VarChar(35),
  @t_user VarChar(35),
  @t_mach VarChar(35),
  @t_sdat DateTime,
  @t_sorc VarChar(50),
  @t_crtp Int,
  @t_Refcntd Int,
  @t_Refcntu Int,
  @t_drdt DateTime,
  @t_drur VarChar(16),
  @t_aact Int,
  @t_aact_1 Int,
  @t_aact_2 Int,
  @t_aact_3 Int,
  @t_adat DateTime,
  @t_apre VarChar(50),
  @t_atxt Int,
  @t_ausr VarChar(9),
  @t_dcrr Int,
  @t_docs Int,
  @t_drwd VarChar(32),
  @t_link Int,
  @t_pdfd VarChar(32),
  @t_ract Int,
  @t_ract_1 Int,
  @t_ract_2 Int,
  @t_rdat DateTime,
  @t_rere VarChar(50),
  @t_rtxt Int,
  @t_rusr VarChar(9),
  @t_sudt DateTime,
  @t_type VarChar(7),
  @t_wfst Int,
  @t_soft VarChar(50),
  @Company NvarChar(9), 
  @Return_t_docn VarChar(32) = null OUTPUT, 
  @Return_t_revn VarChar(20) = null OUTPUT 
  AS
  INSERT [tdmisg001200]
  (
   [t_docn]
  ,[t_revn]
  ,[t_dcid]
  ,[t_dsca]
  ,[t_dttl]
  ,[t_cspa]
  ,[t_erec]
  ,[t_prod]
  ,[t_info]
  ,[t_appr]
  ,[t_resp]
  ,[t_date]
  ,[t_appb]
  ,[t_chkb]
  ,[t_drwb]
  ,[t_wght]
  ,[t_scal]
  ,[t_size]
  ,[t_pdfn]
  ,[t_cprj]
  ,[t_grup]
  ,[t_clnt]
  ,[t_cnsl]
  ,[t_year]
  ,[t_iwtn]
  ,[t_ser2]
  ,[t_ser1]
  ,[t_stat]
  ,[t_name]
  ,[t_user]
  ,[t_mach]
  ,[t_sdat]
  ,[t_sorc]
  ,[t_crtp]
  ,[t_Refcntd]
  ,[t_Refcntu]
  ,[t_drdt]
  ,[t_drur]
  ,[t_aact]
  ,[t_aact_1]
  ,[t_aact_2]
  ,[t_aact_3]
  ,[t_adat]
  ,[t_apre]
  ,[t_atxt]
  ,[t_ausr]
  ,[t_dcrr]
  ,[t_docs]
  ,[t_drwd]
  ,[t_link]
  ,[t_pdfd]
  ,[t_ract]
  ,[t_ract_1]
  ,[t_ract_2]
  ,[t_rdat]
  ,[t_rere]
  ,[t_rtxt]
  ,[t_rusr]
  ,[t_sudt]
  ,[t_type]
  ,[t_wfst]
  ,[t_soft]
  )
  VALUES
  (
   UPPER(@t_docn)
  ,UPPER(@t_revn)
  ,@t_dcid
  ,@t_dsca
  ,@t_dttl
  ,@t_cspa
  ,@t_erec
  ,@t_prod
  ,@t_info
  ,@t_appr
  ,@t_resp
  ,@t_date
  ,@t_appb
  ,@t_chkb
  ,@t_drwb
  ,@t_wght
  ,@t_scal
  ,@t_size
  ,@t_pdfn
  ,@t_cprj
  ,@t_grup
  ,@t_clnt
  ,@t_cnsl
  ,@t_year
  ,@t_iwtn
  ,@t_ser2
  ,@t_ser1
  ,@t_stat
  ,@t_name
  ,@t_user
  ,@t_mach
  ,@t_sdat
  ,@t_sorc
  ,@t_crtp
  ,@t_Refcntd
  ,@t_Refcntu
  ,@t_drdt
  ,@t_drur
  ,@t_aact
  ,@t_aact_1
  ,@t_aact_2
  ,@t_aact_3
  ,@t_adat
  ,@t_apre
  ,@t_atxt
  ,@t_ausr
  ,@t_dcrr
  ,@t_docs
  ,@t_drwd
  ,@t_link
  ,@t_pdfd
  ,@t_ract
  ,@t_ract_1
  ,@t_ract_2
  ,@t_rdat
  ,@t_rere
  ,@t_rtxt
  ,@t_rusr
  ,@t_sudt
  ,@t_type
  ,@t_wfst
  ,@t_soft
  )
  SET @Return_t_docn = @t_docn
  SET @Return_t_revn = @t_revn
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg001200Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg001200Update]
GO
 
CREATE PROCEDURE [dbo].[spdmisg001200Update]
  @Original_t_docn VarChar(32), 
  @Original_t_revn VarChar(20), 
  @t_docn VarChar(32),
  @t_revn VarChar(20),
  @t_dcid VarChar(32),
  @t_dsca VarChar(100),
  @t_dttl VarChar(100),
  @t_cspa VarChar(8),
  @t_erec Int,
  @t_prod Int,
  @t_info Int,
  @t_appr Int,
  @t_resp VarChar(50),
  @t_date VarChar(20),
  @t_appb VarChar(20),
  @t_chkb VarChar(50),
  @t_drwb VarChar(50),
  @t_wght Float,
  @t_scal VarChar(20),
  @t_size VarChar(50),
  @t_pdfn VarChar(100),
  @t_cprj VarChar(9),
  @t_grup VarChar(20),
  @t_clnt VarChar(100),
  @t_cnsl VarChar(100),
  @t_year VarChar(4),
  @t_iwtn VarChar(10),
  @t_ser2 VarChar(100),
  @t_ser1 VarChar(100),
  @t_stat Int,
  @t_name VarChar(35),
  @t_user VarChar(35),
  @t_mach VarChar(35),
  @t_sdat DateTime,
  @t_sorc VarChar(50),
  @t_crtp Int,
  @t_Refcntd Int,
  @t_Refcntu Int,
  @t_drdt DateTime,
  @t_drur VarChar(16),
  @t_aact Int,
  @t_aact_1 Int,
  @t_aact_2 Int,
  @t_aact_3 Int,
  @t_adat DateTime,
  @t_apre VarChar(50),
  @t_atxt Int,
  @t_ausr VarChar(9),
  @t_dcrr Int,
  @t_docs Int,
  @t_drwd VarChar(32),
  @t_link Int,
  @t_pdfd VarChar(32),
  @t_ract Int,
  @t_ract_1 Int,
  @t_ract_2 Int,
  @t_rdat DateTime,
  @t_rere VarChar(50),
  @t_rtxt Int,
  @t_rusr VarChar(9),
  @t_sudt DateTime,
  @t_type VarChar(7),
  @t_wfst Int,
  @t_soft VarChar(50),
  @Company NvarChar(9), 
  @RowCount int = null OUTPUT
  AS
  UPDATE [tdmisg001200] SET 
   [t_docn] = @t_docn
  ,[t_revn] = @t_revn
  ,[t_dcid] = @t_dcid
  ,[t_dsca] = @t_dsca
  ,[t_dttl] = @t_dttl
  ,[t_cspa] = @t_cspa
  ,[t_erec] = @t_erec
  ,[t_prod] = @t_prod
  ,[t_info] = @t_info
  ,[t_appr] = @t_appr
  ,[t_resp] = @t_resp
  ,[t_date] = @t_date
  ,[t_appb] = @t_appb
  ,[t_chkb] = @t_chkb
  ,[t_drwb] = @t_drwb
  ,[t_wght] = @t_wght
  ,[t_scal] = @t_scal
  ,[t_size] = @t_size
  ,[t_pdfn] = @t_pdfn
  ,[t_cprj] = @t_cprj
  ,[t_grup] = @t_grup
  ,[t_clnt] = @t_clnt
  ,[t_cnsl] = @t_cnsl
  ,[t_year] = @t_year
  ,[t_iwtn] = @t_iwtn
  ,[t_ser2] = @t_ser2
  ,[t_ser1] = @t_ser1
  ,[t_stat] = @t_stat
  ,[t_name] = @t_name
  ,[t_user] = @t_user
  ,[t_mach] = @t_mach
  ,[t_sdat] = @t_sdat
  ,[t_sorc] = @t_sorc
  ,[t_crtp] = @t_crtp
  ,[t_Refcntd] = @t_Refcntd
  ,[t_Refcntu] = @t_Refcntu
  ,[t_drdt] = @t_drdt
  ,[t_drur] = @t_drur
  ,[t_aact] = @t_aact
  ,[t_aact_1] = @t_aact_1
  ,[t_aact_2] = @t_aact_2
  ,[t_aact_3] = @t_aact_3
  ,[t_adat] = @t_adat
  ,[t_apre] = @t_apre
  ,[t_atxt] = @t_atxt
  ,[t_ausr] = @t_ausr
  ,[t_dcrr] = @t_dcrr
  ,[t_docs] = @t_docs
  ,[t_drwd] = @t_drwd
  ,[t_link] = @t_link
  ,[t_pdfd] = @t_pdfd
  ,[t_ract] = @t_ract
  ,[t_ract_1] = @t_ract_1
  ,[t_ract_2] = @t_ract_2
  ,[t_rdat] = @t_rdat
  ,[t_rere] = @t_rere
  ,[t_rtxt] = @t_rtxt
  ,[t_rusr] = @t_rusr
  ,[t_sudt] = @t_sudt
  ,[t_type] = @t_type
  ,[t_wfst] = @t_wfst
  ,[t_soft] = @t_soft
  WHERE
  [t_docn] = @Original_t_docn
  AND [t_revn] = @Original_t_revn
  SET @RowCount = @@RowCount
  GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg002200Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg002200Insert]
GO
 
CREATE PROCEDURE [dbo].[spdmisg002200Insert]
  @t_docn VarChar(32),
  @t_revn VarChar(20),
  @t_srno Int,
  @t_item VarChar(47),
  @t_dsca VarChar(100),
  @t_citg VarChar(50),
  @t_qnty Float,
  @t_wght Float,
  @t_itmt VarChar(50),
  @t_txta Int,
  @t_txtb Int,
  @t_cuni VarChar(3),
  @t_oitm VarChar(47),
  @t_elem VarChar(8),
  @t_Refcntd Int,
  @t_Refcntu Int,
  @Company NvarChar(9), 
  @Return_t_docn VarChar(32) = null OUTPUT, 
  @Return_t_revn VarChar(20) = null OUTPUT, 
  @Return_t_srno Int = null OUTPUT 
  AS
  INSERT [tdmisg002200]
  (
   [t_docn]
  ,[t_revn]
  ,[t_srno]
  ,[t_item]
  ,[t_dsca]
  ,[t_citg]
  ,[t_qnty]
  ,[t_wght]
  ,[t_itmt]
  ,[t_txta]
  ,[t_txtb]
  ,[t_cuni]
  ,[t_oitm]
  ,[t_elem]
  ,[t_Refcntd]
  ,[t_Refcntu]
  )
  VALUES
  (
   UPPER(@t_docn)
  ,UPPER(@t_revn)
  ,@t_srno
  ,@t_item
  ,@t_dsca
  ,@t_citg
  ,@t_qnty
  ,@t_wght
  ,@t_itmt
  ,@t_txta
  ,@t_txtb
  ,@t_cuni
  ,@t_oitm
  ,@t_elem
  ,@t_Refcntd
  ,@t_Refcntu
  )
  SET @Return_t_docn = @t_docn
  SET @Return_t_revn = @t_revn
  SET @Return_t_srno = @t_srno
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg002200Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg002200Update]
GO
 
CREATE PROCEDURE [dbo].[spdmisg002200Update]
  @Original_t_docn VarChar(32), 
  @Original_t_revn VarChar(20), 
  @Original_t_srno Int, 
  @t_docn VarChar(32),
  @t_revn VarChar(20),
  @t_srno Int,
  @t_item VarChar(47),
  @t_dsca VarChar(100),
  @t_citg VarChar(50),
  @t_qnty Float,
  @t_wght Float,
  @t_itmt VarChar(50),
  @t_txta Int,
  @t_txtb Int,
  @t_cuni VarChar(3),
  @t_oitm VarChar(47),
  @t_elem VarChar(8),
  @t_Refcntd Int,
  @t_Refcntu Int,
  @Company NvarChar(9), 
  @RowCount int = null OUTPUT
  AS
  UPDATE [tdmisg002200] SET 
   [t_docn] = @t_docn
  ,[t_revn] = @t_revn
  ,[t_srno] = @t_srno
  ,[t_item] = @t_item
  ,[t_dsca] = @t_dsca
  ,[t_citg] = @t_citg
  ,[t_qnty] = @t_qnty
  ,[t_wght] = @t_wght
  ,[t_itmt] = @t_itmt
  ,[t_txta] = @t_txta
  ,[t_txtb] = @t_txtb
  ,[t_cuni] = @t_cuni
  ,[t_oitm] = @t_oitm
  ,[t_elem] = @t_elem
  ,[t_Refcntd] = @t_Refcntd
  ,[t_Refcntu] = @t_Refcntu
  WHERE
  [t_docn] = @Original_t_docn
  AND [t_revn] = @Original_t_revn
  AND [t_srno] = @Original_t_srno
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg003200Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg003200Insert]
GO
 
CREATE PROCEDURE [dbo].[spdmisg003200Insert]
  @t_docn VarChar(32),
  @t_revn VarChar(20),
  @t_drgt VarChar(100),
  @t_dcfn VarChar(100),
  @t_drev VarChar(20),
  @t_drgn VarChar(50),
  @t_pdff VarChar(100),
  @t_stat VarChar(50),
  @t_type Int,
  @t_Refcntd Int,
  @t_Refcntu Int,
  @Company NvarChar(9), 
  @Return_t_docn VarChar(32) = null OUTPUT, 
  @Return_t_revn VarChar(20) = null OUTPUT, 
  @Return_t_drgt VarChar(100) = null OUTPUT 
  AS
  INSERT [tdmisg003200]
  (
   [t_docn]
  ,[t_revn]
  ,[t_drgt]
  ,[t_dcfn]
  ,[t_drev]
  ,[t_drgn]
  ,[t_pdff]
  ,[t_stat]
  ,[t_type]
  ,[t_Refcntd]
  ,[t_Refcntu]
  )
  VALUES
  (
   UPPER(@t_docn)
  ,UPPER(@t_revn)
  ,UPPER(@t_drgt)
  ,@t_dcfn
  ,@t_drev
  ,@t_drgn
  ,@t_pdff
  ,@t_stat
  ,@t_type
  ,@t_Refcntd
  ,@t_Refcntu
  )
  SET @Return_t_docn = @t_docn
  SET @Return_t_revn = @t_revn
  SET @Return_t_drgt = @t_drgt
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg003200Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg003200Update]
GO
 
CREATE PROCEDURE [dbo].[spdmisg003200Update]
  @Original_t_docn VarChar(32), 
  @Original_t_revn VarChar(20), 
  @Original_t_drgt VarChar(100), 
  @t_docn VarChar(32),
  @t_revn VarChar(20),
  @t_drgt VarChar(100),
  @t_dcfn VarChar(100),
  @t_drev VarChar(20),
  @t_drgn VarChar(50),
  @t_pdff VarChar(100),
  @t_stat VarChar(50),
  @t_type Int,
  @t_Refcntd Int,
  @t_Refcntu Int,
  @Company NvarChar(9), 
  @RowCount int = null OUTPUT
  AS
  UPDATE [tdmisg003200] SET 
   [t_docn] = @t_docn
  ,[t_revn] = @t_revn
  ,[t_drgt] = @t_drgt
  ,[t_dcfn] = @t_dcfn
  ,[t_drev] = @t_drev
  ,[t_drgn] = @t_drgn
  ,[t_pdff] = @t_pdff
  ,[t_stat] = @t_stat
  ,[t_type] = @t_type
  ,[t_Refcntd] = @t_Refcntd
  ,[t_Refcntu] = @t_Refcntu
  WHERE
  [t_docn] = @Original_t_docn
  AND [t_revn] = @Original_t_revn
  AND [t_drgt] = @Original_t_drgt
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg004200Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg004200Insert]
GO
 
CREATE PROCEDURE [dbo].[spdmisg004200Insert]
  @t_docn VarChar(32),
  @t_revn VarChar(20),
  @t_srno Int,
  @t_item VarChar(47),
  @t_pisn VarChar(2),
  @t_prtn VarChar(50),
  @t_prtd VarChar(100),
  @t_wght Float,
  @t_qnty Float,
  @t_spec VarChar(100),
  @t_size VarChar(50),
  @t_rmrk VarChar(100),
  @t_Refcntd Int,
  @t_Refcntu Int,
  @t_mcod VarChar(9),
  @Company NvarChar(9), 
  @Return_t_docn VarChar(32) = null OUTPUT, 
  @Return_t_revn VarChar(20) = null OUTPUT, 
  @Return_t_srno Int = null OUTPUT, 
  @Return_t_item VarChar(47) = null OUTPUT, 
  @Return_t_pisn VarChar(2) = null OUTPUT 
  AS
  INSERT [tdmisg004200]
  (
   [t_docn]
  ,[t_revn]
  ,[t_srno]
  ,[t_item]
  ,[t_pisn]
  ,[t_prtn]
  ,[t_prtd]
  ,[t_wght]
  ,[t_qnty]
  ,[t_spec]
  ,[t_size]
  ,[t_rmrk]
  ,[t_Refcntd]
  ,[t_Refcntu]
  ,[t_mcod]
  )
  VALUES
  (
   UPPER(@t_docn)
  ,UPPER(@t_revn)
  ,@t_srno
  ,UPPER(@t_item)
  ,UPPER(@t_pisn)
  ,@t_prtn
  ,@t_prtd
  ,@t_wght
  ,@t_qnty
  ,@t_spec
  ,@t_size
  ,@t_rmrk
  ,@t_Refcntd
  ,@t_Refcntu
  ,@t_mcod
  )
  SET @Return_t_docn = @t_docn
  SET @Return_t_revn = @t_revn
  SET @Return_t_srno = @t_srno
  SET @Return_t_item = @t_item
  SET @Return_t_pisn = @t_pisn
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg004200Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg004200Update]
GO
 
CREATE PROCEDURE [dbo].[spdmisg004200Update]
  @Original_t_docn VarChar(32), 
  @Original_t_revn VarChar(20), 
  @Original_t_srno Int, 
  @Original_t_item VarChar(47), 
  @Original_t_pisn VarChar(2), 
  @t_docn VarChar(32),
  @t_revn VarChar(20),
  @t_srno Int,
  @t_item VarChar(47),
  @t_pisn VarChar(2),
  @t_prtn VarChar(50),
  @t_prtd VarChar(100),
  @t_wght Float,
  @t_qnty Float,
  @t_spec VarChar(100),
  @t_size VarChar(50),
  @t_rmrk VarChar(100),
  @t_Refcntd Int,
  @t_Refcntu Int,
  @t_mcod VarChar(9),
  @Company NvarChar(9), 
  @RowCount int = null OUTPUT
  AS
  UPDATE [tdmisg004200] SET 
   [t_docn] = @t_docn
  ,[t_revn] = @t_revn
  ,[t_srno] = @t_srno
  ,[t_item] = @t_item
  ,[t_pisn] = @t_pisn
  ,[t_prtn] = @t_prtn
  ,[t_prtd] = @t_prtd
  ,[t_wght] = @t_wght
  ,[t_qnty] = @t_qnty
  ,[t_spec] = @t_spec
  ,[t_size] = @t_size
  ,[t_rmrk] = @t_rmrk
  ,[t_Refcntd] = @t_Refcntd
  ,[t_Refcntu] = @t_Refcntu
  ,[t_mcod] = @t_mcod
  WHERE
  [t_docn] = @Original_t_docn
  AND [t_revn] = @Original_t_revn
  AND [t_srno] = @Original_t_srno
  AND [t_item] = @Original_t_item
  AND [t_pisn] = @Original_t_pisn
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg121200Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg121200Insert]
GO
 
CREATE PROCEDURE [dbo].[spdmisg121200Insert]
  @t_docn VarChar(32),
  @t_revn VarChar(32),
  @t_cprj VarChar(9),
  @t_dsca VarChar(100),
  @t_aldo VarChar(32),
  @t_alre VarChar(20),
  @t_cspa VarChar(8),
  @t_type VarChar(7),
  @t_resp VarChar(3),
  @t_eunt VarChar(6),
  @t_size Int,
  @t_orgn VarChar(3),
  @t_subm Int,
  @t_intr Int,
  @t_prod Int,
  @t_erec Int,
  @t_info Int,
  @t_remk VarChar(100),
  @t_pldt DateTime,
  @t_rele Int,
  @t_acdt DateTime,
  @t_vend Int,
  @t_bpid VarChar(9),
  @t_revd Int,
  @t_redt DateTime,
  @t_logn VarChar(16),
  @t_verk VarChar(100),
  @t_extn Int,
  @t_ofbp VarChar(9),
  @t_nama VarChar(35),
  @t_eogn VarChar(16),
  @t_exdt DateTime,
  @t_exrk VarChar(100),
  @t_cler Int,
  @t_bloc Int,
  @t_appr Int,
  @t_link Int,
  @t_tran VarChar(9),
  @t_soft VarChar(50),
  @t_test Int,
  @t_Refcntd Int,
  @t_Refcntu Int,
  @t_imby VarChar(16),
  @t_imdt DateTime,
  @t_emno VarChar(9),
  @t_nhrs Real,
  @Company NvarChar(9),
  @Return_t_docn VarChar(32) = null OUTPUT, 
  @Return_t_revn VarChar(32) = null OUTPUT 
  AS
  INSERT [tdmisg121200]
  (
   [t_docn]
  ,[t_revn]
  ,[t_cprj]
  ,[t_dsca]
  ,[t_aldo]
  ,[t_alre]
  ,[t_cspa]
  ,[t_type]
  ,[t_resp]
  ,[t_eunt]
  ,[t_size]
  ,[t_orgn]
  ,[t_subm]
  ,[t_intr]
  ,[t_prod]
  ,[t_erec]
  ,[t_info]
  ,[t_remk]
  ,[t_pldt]
  ,[t_rele]
  ,[t_acdt]
  ,[t_vend]
  ,[t_bpid]
  ,[t_revd]
  ,[t_redt]
  ,[t_logn]
  ,[t_verk]
  ,[t_extn]
  ,[t_ofbp]
  ,[t_nama]
  ,[t_eogn]
  ,[t_exdt]
  ,[t_exrk]
  ,[t_cler]
  ,[t_bloc]
  ,[t_appr]
  ,[t_link]
  ,[t_tran]
  ,[t_soft]
  ,[t_test]
  ,[t_Refcntd]
  ,[t_Refcntu]
  ,[t_imby]
  ,[t_imdt]
  ,[t_emno]
  ,[t_nhrs]
  )
  VALUES
  (
   UPPER(@t_docn)
  ,UPPER(@t_revn)
  ,@t_cprj
  ,@t_dsca
  ,@t_aldo
  ,@t_alre
  ,@t_cspa
  ,@t_type
  ,@t_resp
  ,@t_eunt
  ,@t_size
  ,@t_orgn
  ,@t_subm
  ,@t_intr
  ,@t_prod
  ,@t_erec
  ,@t_info
  ,@t_remk
  ,@t_pldt
  ,@t_rele
  ,@t_acdt
  ,@t_vend
  ,@t_bpid
  ,@t_revd
  ,@t_redt
  ,@t_logn
  ,@t_verk
  ,@t_extn
  ,@t_ofbp
  ,@t_nama
  ,@t_eogn
  ,@t_exdt
  ,@t_exrk
  ,@t_cler
  ,@t_bloc
  ,@t_appr
  ,@t_link
  ,@t_tran
  ,@t_soft
  ,@t_test
  ,@t_Refcntd
  ,@t_Refcntu
  ,@t_imby
  ,@t_imdt
  ,@t_emno
  ,@t_nhrs
  )
  SET @Return_t_docn = @t_docn
  SET @Return_t_revn = @t_revn
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spdmisg121200Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spdmisg121200Update]
GO
 
CREATE PROCEDURE [dbo].[spdmisg121200Update]
  @Original_t_docn VarChar(32), 
  @Original_t_revn VarChar(32), 
  @t_docn VarChar(32),
  @t_revn VarChar(32),
  @t_cprj VarChar(9),
  @t_dsca VarChar(100),
  @t_aldo VarChar(32),
  @t_alre VarChar(20),
  @t_cspa VarChar(8),
  @t_type VarChar(7),
  @t_resp VarChar(3),
  @t_eunt VarChar(6),
  @t_size Int,
  @t_orgn VarChar(3),
  @t_subm Int,
  @t_intr Int,
  @t_prod Int,
  @t_erec Int,
  @t_info Int,
  @t_remk VarChar(100),
  @t_pldt DateTime,
  @t_rele Int,
  @t_acdt DateTime,
  @t_vend Int,
  @t_bpid VarChar(9),
  @t_revd Int,
  @t_redt DateTime,
  @t_logn VarChar(16),
  @t_verk VarChar(100),
  @t_extn Int,
  @t_ofbp VarChar(9),
  @t_nama VarChar(35),
  @t_eogn VarChar(16),
  @t_exdt DateTime,
  @t_exrk VarChar(100),
  @t_cler Int,
  @t_bloc Int,
  @t_appr Int,
  @t_link Int,
  @t_tran VarChar(9),
  @t_soft VarChar(50),
  @t_test Int,
  @t_Refcntd Int,
  @t_Refcntu Int,
  @t_imby VarChar(16),
  @t_imdt DateTime,
  @t_emno VarChar(9),
  @t_nhrs Real,
  @Company NvarChar(9),
  @RowCount int = null OUTPUT
  AS
  UPDATE [tdmisg121200] SET 
   [t_docn] = @t_docn
  ,[t_revn] = @t_revn
  ,[t_cprj] = @t_cprj
  ,[t_dsca] = @t_dsca
  ,[t_aldo] = @t_aldo
  ,[t_alre] = @t_alre
  ,[t_cspa] = @t_cspa
  ,[t_type] = @t_type
  ,[t_resp] = @t_resp
  ,[t_eunt] = @t_eunt
  ,[t_size] = @t_size
  ,[t_orgn] = @t_orgn
  ,[t_subm] = @t_subm
  ,[t_intr] = @t_intr
  ,[t_prod] = @t_prod
  ,[t_erec] = @t_erec
  ,[t_info] = @t_info
  ,[t_remk] = @t_remk
  ,[t_pldt] = @t_pldt
  ,[t_rele] = @t_rele
  ,[t_acdt] = @t_acdt
  ,[t_vend] = @t_vend
  ,[t_bpid] = @t_bpid
  ,[t_revd] = @t_revd
  ,[t_redt] = @t_redt
  ,[t_logn] = @t_logn
  ,[t_verk] = @t_verk
  ,[t_extn] = @t_extn
  ,[t_ofbp] = @t_ofbp
  ,[t_nama] = @t_nama
  ,[t_eogn] = @t_eogn
  ,[t_exdt] = @t_exdt
  ,[t_exrk] = @t_exrk
  ,[t_cler] = @t_cler
  ,[t_bloc] = @t_bloc
  ,[t_appr] = @t_appr
  ,[t_link] = @t_link
  ,[t_tran] = @t_tran
  ,[t_soft] = @t_soft
  ,[t_test] = @t_test
  ,[t_Refcntd] = @t_Refcntd
  ,[t_Refcntu] = @t_Refcntu
  ,[t_imby] = @t_imby
  ,[t_imdt] = @t_imdt
  ,[t_emno] = @t_emno
  ,[t_nhrs] = @t_nhrs
  WHERE
  [t_docn] = @Original_t_docn
  AND [t_revn] = @Original_t_revn
  SET @RowCount = @@RowCount
  GO

SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO
