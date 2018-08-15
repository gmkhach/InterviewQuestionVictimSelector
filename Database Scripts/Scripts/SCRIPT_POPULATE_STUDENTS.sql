use InterviewQuestionVictimSelector

INSERT INTO dbo.STUDENTS(
		[FIRST_NAME]
		,[LAST_NAME]
		,[SELECTED]
		)
SELECT 	[FirstName]
		,[LastName]
		,[SELECTED]
FROM dbo.STUDENTS_OLD