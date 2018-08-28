USE [VictimSelector]
GO

/****** Object:  StoredProcedure [dbo].[DELETE_QUESTION]    Script Date: 8/28/2018 3:34:06 PM ******/
DROP PROCEDURE [dbo].[DELETE_QUESTION]
GO

/****** Object:  StoredProcedure [dbo].[DELETE_QUESTION]    Script Date: 8/28/2018 3:34:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROC [dbo].[DELETE_QUESTION]
--      $Revision: 1.8 $
	-- Add the parameters for the stored procedure here
	@QUESTION_ID       BIGINT  	
AS
BEGIN	
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE FROM [DBO].[QUESTIONS]
    WHERE QUESTION_ID = @QUESTION_ID 
END

GO


