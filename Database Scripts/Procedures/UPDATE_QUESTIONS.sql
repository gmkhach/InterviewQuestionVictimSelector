USE [VictimSelector]
GO

/****** Object:  StoredProcedure [dbo].[UPDATE_QUESTION]    Script Date: 8/28/2018 3:38:46 PM ******/
DROP PROCEDURE [dbo].[UPDATE_QUESTION]
GO

/****** Object:  StoredProcedure [dbo].[UPDATE_QUESTION]    Script Date: 8/28/2018 3:38:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[UPDATE_QUESTION]
--      $Revision: 1.1 $
	-- Add the parameters for the stored procedure here
	 @QUESTION_ID BIGINT
	,@QUESTION VARCHAR(1000)
	,@SELECTED BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE dbo.QUESTIONS
	SET  QUESTION = @QUESTION
		,SELECTED = @SELECTED
	WHERE QUESTION_ID = @QUESTION_ID
END

GO


