USE [VictimSelector]
GO

/****** Object:  StoredProcedure [dbo].[INSERT_STUDENT]    Script Date: 8/28/2018 3:36:42 PM ******/
DROP PROCEDURE [dbo].[INSERT_STUDENT]
GO

/****** Object:  StoredProcedure [dbo].[INSERT_STUDENT]    Script Date: 8/28/2018 3:36:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[INSERT_STUDENT]
--      $Revision: 1.1 $
	-- Add the parameters for the stored procedure here
	 @FIRST_NAME VARCHAR(255)
	,@LAST_NAME VARCHAR(255)
	,@SELECTED BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO DBO.STUDENTS
			(FIRST_NAME
			,LAST_NAME
			,SELECTED)
	VALUES
			(@FIRST_NAME
			,@LAST_NAME
			,@SELECTED)

END


GO


