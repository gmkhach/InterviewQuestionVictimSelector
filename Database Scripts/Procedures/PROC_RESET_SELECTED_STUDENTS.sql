USE [VictimSelector]
GO

/****** Object:  StoredProcedure [dbo].[RESET_SELECTED_STUDENTS]    Script Date: 8/28/2018 3:38:29 PM ******/
DROP PROCEDURE [dbo].[RESET_SELECTED_STUDENTS]
GO

/****** Object:  StoredProcedure [dbo].[RESET_SELECTED_STUDENTS]    Script Date: 8/28/2018 3:38:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[RESET_SELECTED_STUDENTS]
--      $Revision: 1.1 $
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE dbo.STUDENTS
	SET  SELECTED = '0'
END

GO


