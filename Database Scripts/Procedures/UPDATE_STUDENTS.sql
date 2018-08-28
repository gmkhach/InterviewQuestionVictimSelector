USE [VictimSelector]
GO

/****** Object:  StoredProcedure [dbo].[UPDATE_STUDENTS]    Script Date: 8/28/2018 3:38:50 PM ******/
DROP PROCEDURE [dbo].[UPDATE_STUDENTS]
GO

/****** Object:  StoredProcedure [dbo].[UPDATE_STUDENTS]    Script Date: 8/28/2018 3:38:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[UPDATE_STUDENTS]
--      $Revision: 1.1 $
	-- Add the parameters for the stored procedure here
	 @STUDENT_ID BIGINT
	,@FIRST_NAME VARCHAR(255)
	,@LAST_NAME VARCHAR(255)
	,@SELECTED BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE dbo.STUDENTS
	SET  FIRST_NAME= @FIRST_NAME
		,LAST_NAME= @LAST_NAME
		,SELECTED = @SELECTED
	WHERE STUDENT_ID = @STUDENT_ID
END

GO


