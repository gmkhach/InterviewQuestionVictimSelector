USE [VictimSelector]
GO

/****** Object:  StoredProcedure [dbo].[DELETE_STUDENT]    Script Date: 8/28/2018 3:34:39 PM ******/
DROP PROCEDURE [dbo].[DELETE_STUDENT]
GO

/****** Object:  StoredProcedure [dbo].[DELETE_STUDENT]    Script Date: 8/28/2018 3:34:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROC [dbo].[DELETE_STUDENT]
--      $Revision: 1.8 $
	-- Add the parameters for the stored procedure here
	@STUDENT_ID       BIGINT  	
AS
BEGIN	
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE FROM [DBO].STUDENTS
    WHERE STUDENT_ID = @STUDENT_ID 
END

GO


