USE [VictimSelector]
GO

/****** Object:  StoredProcedure [dbo].[GET_STUDENTS]    Script Date: 8/28/2018 3:37:32 PM ******/
DROP PROCEDURE [dbo].[GET_STUDENTS]
GO

/****** Object:  StoredProcedure [dbo].[GET_STUDENTS]    Script Date: 8/28/2018 3:37:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GET_STUDENTS]
--      $Revision: 1.1 $
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT STUDENT_ID
		  ,FIRST_NAME	
		  ,LAST_NAME
		  ,SELECTED
	FROM dbo.STUDENTS
	ORDER BY FIRST_NAME ASC
END

GO


