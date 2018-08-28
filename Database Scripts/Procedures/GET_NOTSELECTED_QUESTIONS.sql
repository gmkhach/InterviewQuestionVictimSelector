USE [VictimSelector]
GO

/****** Object:  StoredProcedure [dbo].[GET_NOTSELECTED_QUESTIONS]    Script Date: 8/28/2018 3:34:58 PM ******/
DROP PROCEDURE [dbo].[GET_NOTSELECTED_QUESTIONS]
GO

/****** Object:  StoredProcedure [dbo].[GET_NOTSELECTED_QUESTIONS]    Script Date: 8/28/2018 3:34:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[GET_NOTSELECTED_QUESTIONS]
--      $Revision: 1.1 $
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT QUESTION_ID
		  ,QUESTION	
		  ,SELECTED
	FROM dbo.QUESTIONS
	WHERE SELECTED = '0'
	ORDER BY QUESTION_ID ASC
END

GO


