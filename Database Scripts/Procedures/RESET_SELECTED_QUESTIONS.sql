USE [VictimSelector]
GO

/****** Object:  StoredProcedure [dbo].[RESET_SELECTED_QUESTIONS]    Script Date: 8/28/2018 3:38:10 PM ******/
DROP PROCEDURE [dbo].[RESET_SELECTED_QUESTIONS]
GO

/****** Object:  StoredProcedure [dbo].[RESET_SELECTED_QUESTIONS]    Script Date: 8/28/2018 3:38:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[RESET_SELECTED_QUESTIONS]
--      $Revision: 1.1 $
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE dbo.QUESTIONS
	SET  SELECTED = '0'
END

GO


