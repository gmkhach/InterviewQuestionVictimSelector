USE [master]
GO
/****** Object:  Database [VictimSelector]    Script Date: 8/14/2018 12:27:51 PM ******/
CREATE DATABASE [VictimSelector]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InterviewQuestionVictimSelector', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\InterviewQuestionVictimSelector.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InterviewQuestionVictimSelector_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\InterviewQuestionVictimSelector_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VictimSelector] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VictimSelector].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VictimSelector] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VictimSelector] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VictimSelector] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VictimSelector] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VictimSelector] SET ARITHABORT OFF 
GO
ALTER DATABASE [VictimSelector] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VictimSelector] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VictimSelector] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VictimSelector] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VictimSelector] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VictimSelector] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VictimSelector] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VictimSelector] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VictimSelector] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VictimSelector] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VictimSelector] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VictimSelector] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VictimSelector] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VictimSelector] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VictimSelector] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VictimSelector] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VictimSelector] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VictimSelector] SET RECOVERY FULL 
GO
ALTER DATABASE [VictimSelector] SET  MULTI_USER 
GO
ALTER DATABASE [VictimSelector] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VictimSelector] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VictimSelector] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VictimSelector] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VictimSelector] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'InterviewQuestionVictimSelector', N'ON'
GO
ALTER DATABASE [VictimSelector] SET QUERY_STORE = OFF
GO
USE [VictimSelector]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [VictimSelector]
GO
/****** Object:  Table [dbo].[QUESTIONS]    Script Date: 8/14/2018 12:27:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUESTIONS](
	[QUESTION_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[QUESTION] [varchar](1000) NOT NULL,
	[SELECTED] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QUESTION_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUESTIONS_OLD]    Script Date: 8/14/2018 12:27:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUESTIONS_OLD](
	[QuestionID] [int] IDENTITY(1,1) NOT NULL,
	[Question] [varchar](255) NULL,
	[SELECTED] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STUDENTS]    Script Date: 8/14/2018 12:27:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STUDENTS](
	[STUDENT_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [varchar](255) NOT NULL,
	[LAST_NAME] [varchar](255) NOT NULL,
	[SELECTED] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STUDENT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STUDENTS_OLD]    Script Date: 8/14/2018 12:27:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STUDENTS_OLD](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[SELECTED] [bit] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[QUESTIONS] ON 

INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (1, N'Tell me about yourself.', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (2, N'Why are you leaving your current position?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (3, N'Why do you want this job?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (4, N'What''s a time you disagreed with a decision that was made at work?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (5, N'Can you explain why you changed career paths?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (6, N'What do you like to do outside of work?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (7, N'Where do you see yourself in 5 years?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (8, N'What are your strengths? ', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (9, N'What are your weaknesses?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (10, N'Why should we hire you?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (11, N'What do you consider your most significant accomplishment?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (12, N'Have you ever accomplished something you did not think you could?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (13, N'How do you handle pressure?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (14, N'What value can you bring to the team?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (15, N'What''s your dream job?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (16, N'What are you looking for in a new position?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (17, N'What type of work environment do you prefer?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (18, N'When were you most satisfied in your job?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (19, N'How would your boss and co-workers describe you?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (20, N'What''s your management style?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (21, N'What''s a time you exercised leadership?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (22, N'If you were an animal, which one would you want to be?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (23, N'What questions haven’t I asked you?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (24, N'How did you hear about the position?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (25, N'What other companies are you interviewing with?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (26, N'What do you know about the company?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (27, N'What would your first 30, 60, or 90 days look like in this role?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (28, N'What are your salary requirements?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (29, N'What do you think we could do better or differently?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (30, N'What is the name of our CEO?', 0)
INSERT [dbo].[QUESTIONS] ([QUESTION_ID], [QUESTION], [SELECTED]) VALUES (31, N'What do you like the most and least about working in this industry?', 0)
SET IDENTITY_INSERT [dbo].[QUESTIONS] OFF
SET IDENTITY_INSERT [dbo].[QUESTIONS_OLD] ON 

INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (1, N'Tell me about yourself.', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (2, N'Why are you leaving your current position?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (3, N'Why do you want this job?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (4, N'What''s a time you disagreed with a decision that was made at work?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (5, N'Can you explain why you changed career paths?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (6, N'What do you like to do outside of work?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (7, N'Where do you see yourself in 5 years?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (8, N'What are your strengths? ', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (9, N'What are your weaknesses?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (10, N'Why should we hire you?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (11, N'What do you consider your most significant accomplishment?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (12, N'Have you ever accomplished something you did not think you could?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (13, N'How do you handle pressure?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (14, N'What value can you bring to the team?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (15, N'What''s your dream job?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (16, N'What are you looking for in a new position?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (17, N'What type of work environment do you prefer?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (18, N'When were you most satisfied in your job?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (19, N'How would your boss and co-workers describe you?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (20, N'What''s your management style?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (21, N'What''s a time you exercised leadership?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (22, N'If you were an animal, which one would you want to be?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (23, N'What questions haven’t I asked you?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (24, N'How did you hear about the position?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (25, N'What other companies are you interviewing with?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (26, N'What do you know about the company?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (27, N'What would your first 30, 60, or 90 days look like in this role?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (28, N'What are your salary requirements?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (29, N'What do you think we could do better or differently?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (30, N'What is the name of our CEO?', 0)
INSERT [dbo].[QUESTIONS_OLD] ([QuestionID], [Question], [SELECTED]) VALUES (31, N'What do you like the most and least about working in this industry?', 0)
SET IDENTITY_INSERT [dbo].[QUESTIONS_OLD] OFF
SET IDENTITY_INSERT [dbo].[STUDENTS] ON 

INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (1, N'Alex', N'Gough', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (2, N'Arthur', N'Robinson', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (3, N'Austin', N'Kareiva', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (4, N'Auston', N'Heffling', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (5, N'Benjamin', N'Ward', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (6, N'Bobby', N'Morehead', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (7, N'Brittany', N'Duke', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (8, N'Caleb', N'Ehrich', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (9, N'Chris', N'Britt', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (10, N'David', N'Wood', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (11, N'Demarquise', N'Boone', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (12, N'Derrick', N'Hubbard', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (13, N'Edgar', N'Barrientos', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (14, N'Gabriel', N'Khachatryan', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (15, N'Humberto', N'Banuelos', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (16, N'Jacob', N'Grimm', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (17, N'Jacob', N'Russell', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (18, N'Jason', N'Morgan', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (19, N'Jonathan', N'Hayes', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (20, N'Joseph', N'Callahan', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (21, N'Levi', N'Swain', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (22, N'Marc', N'Estima', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (23, N'Marcus', N'Lucious', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (24, N'Matthew', N'Smith', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (25, N'Michael', N'Hopkins', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (26, N'Michel', N'Ngako', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (27, N'Prabin', N'Pun', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (28, N'Zach', N'Altom', 0)
INSERT [dbo].[STUDENTS] ([STUDENT_ID], [FIRST_NAME], [LAST_NAME], [SELECTED]) VALUES (29, N'Zachary', N'Miller', 0)
SET IDENTITY_INSERT [dbo].[STUDENTS] OFF
SET IDENTITY_INSERT [dbo].[STUDENTS_OLD] ON 

INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (1, N'Alex', N'Gough', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (2, N'Arthur', N'Robinson', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (3, N'Austin', N'Kareiva', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (4, N'Auston', N'Heffling', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (5, N'Benjamin', N'Ward', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (6, N'Bobby', N'Morehead', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (7, N'Brittany', N'Duke', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (8, N'Caleb', N'Ehrich', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (9, N'Chris', N'Britt', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (10, N'David', N'Wood', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (11, N'Demarquise', N'Boone', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (12, N'Derrick', N'Hubbard', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (13, N'Edgar', N'Barrientos', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (14, N'Gabriel', N'Khachatryan', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (15, N'Humberto', N'Banuelos', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (16, N'Jacob', N'Grimm', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (17, N'Jacob', N'Russell', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (18, N'Jason', N'Morgan', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (19, N'Jonathan', N'Hayes', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (20, N'Joseph', N'Callahan', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (21, N'Levi', N'Swain', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (22, N'Marc', N'Estima', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (23, N'Marcus', N'Lucious', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (24, N'Matthew', N'Smith', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (25, N'Michael', N'Hopkins', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (26, N'Michel', N'Ngako', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (27, N'Prabin', N'Pun', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (28, N'Zach', N'Altom', 0)
INSERT [dbo].[STUDENTS_OLD] ([StudentID], [FirstName], [LastName], [SELECTED]) VALUES (29, N'Zachary', N'Miller', 0)
SET IDENTITY_INSERT [dbo].[STUDENTS_OLD] OFF
ALTER TABLE [dbo].[QUESTIONS_OLD] ADD  DEFAULT ((0)) FOR [SELECTED]
GO
ALTER TABLE [dbo].[STUDENTS_OLD] ADD  DEFAULT ((0)) FOR [SELECTED]
GO
USE [master]
GO
ALTER DATABASE [VictimSelector] SET  READ_WRITE 
GO
