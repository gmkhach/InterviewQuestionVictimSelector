USE [VictimSelector]
GO

/****** Object:  StoredProcedure [dbo].[INSERT_QUESTION]    Script Date: 8/28/2018 3:37:37 PM ******/
DROP PROCEDURE [dbo].[INSERT_QUESTION]
GO

/****** Object:  StoredProcedure [dbo].[INSERT_QUESTION]    Script Date: 8/28/2018 3:37:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERT_QUESTION]
--      $Revision: 1.1 $
	-- Add the parameters for the stored procedure here
	 @QUESTION VARCHAR(1000)
	,@SELECTED BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO DBO.QUESTIONS
			(QUESTION
			,SELECTED)
	VALUES
			(@QUESTION
			,@SELECTED)

END


GO


