USE [VeduboxProject]
GO
/****** Object:  Table [dbo].[CourseDetails]    Script Date: 30.06.2021 15:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseDetails](
	[CourseId] [int] NOT NULL,
	[CourseHeader] [nvarchar](250) NOT NULL,
	[CourseCurriculum] [nvarchar](500) NOT NULL,
	[CourseDescription] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_CourseDetails_1] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Courses]    Script Date: 30.06.2021 15:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
	[Fee] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[FinishDate] [date] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OperationClaims]    Script Date: 30.06.2021 15:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OperationClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 30.06.2021 15:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[StudentName] [nvarchar](150) NOT NULL,
	[CourseId] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 30.06.2021 15:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [nvarchar](50) NOT NULL,
	[Education] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserOperationClaims]    Script Date: 30.06.2021 15:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOperationClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[OperationClaimId] [int] NOT NULL,
 CONSTRAINT [PK_UserOperationClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 30.06.2021 15:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PasswordHash] [varbinary](500) NOT NULL,
	[PasswordSalt] [varbinary](500) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CourseDetails] ([CourseId], [CourseHeader], [CourseCurriculum], [CourseDescription]) VALUES (1, N'İleri Düzey C# Kursu', N'EntityFramework , Aop , OOP , Validation , EntityFramework , Linq, Angular, JavaScript ,,TypeScript , Bootstrap , Html , Css , Solid', N'Bu kurs''da ileri düzey C# konularını göreceğiz. Solid yazılım geliştirme kurallarına uygun şekilde ilerliyor olacağız. Kurs kapsamın da bir katmanlı bir yapıya sahip solid prensiblerine uygun bir uygulama geliştiriyor olacağız. Ders sonrasın da verilen ödevlerin yapılması büyük önem arz etmektedir')
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (1, 1, N'C# Kursu', 1500, CAST(0x91420B00 AS Date), CAST(0x2A430B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (3, 1, N'Sql Kursu', 800, CAST(0xA3420B00 AS Date), CAST(0xB0420B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (4, 8, N'Java Kursu', 1500, CAST(0xB2420B00 AS Date), CAST(0x4C430B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (9, 8, N'Html Kursu', 1500, CAST(0x69430B00 AS Date), CAST(0x86430B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (10, 3, N'Arduino', 2500, CAST(0xEF420B00 AS Date), CAST(0x2E430B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (26, 8, N'Angular', 1200, CAST(0x18430B00 AS Date), CAST(0x57430B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (27, 8, N'JavaScript', 1450, CAST(0x1D430B00 AS Date), CAST(0x67430B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (28, 2, N'Devre Tasarımı', 600, CAST(0x2E430B00 AS Date), CAST(0x4A430B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (29, 4, N'Teknik Çizim', 2300, CAST(0xB3420B00 AS Date), CAST(0xCB420B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (30, 5, N'Muhasebe', 1325, CAST(0xB8420B00 AS Date), CAST(0xD2420B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (31, 7, N'Türev', 450, CAST(0xDD420B00 AS Date), CAST(0xEE420B00 AS Date))
INSERT [dbo].[Courses] ([CourseId], [TeacherId], [CourseName], [Fee], [StartDate], [FinishDate]) VALUES (32, 9, N'Manyetik Alanlar', 560, CAST(0xF1420B00 AS Date), CAST(0x0E430B00 AS Date))
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[OperationClaims] ON 

INSERT [dbo].[OperationClaims] ([Id], [Name]) VALUES (1, N'admin')
INSERT [dbo].[OperationClaims] ([Id], [Name]) VALUES (2, N'student')
INSERT [dbo].[OperationClaims] ([Id], [Name]) VALUES (3, N'teacher')
SET IDENTITY_INSERT [dbo].[OperationClaims] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (9, N'ekremersoz06@gmail.com', N'Ekrem Ersöz', 1)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (10, N'ayseyilmaz@ayse.com', N'Ayşe Yılmaz', 9)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (11, N'kadircan@kadir.com', N'Kadir Can', 29)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (12, N'cerenkorkmaz@ceren.com', N'Ceren Korkmaz', 31)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (13, N'hasanyilmaz@yilmaz.com', N'Hasan Yilmaz', 32)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (14, N'omercelik@gmail.com', N'Ömer Çelik', 28)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (15, N'cenaydogru@hotmail.com', N'Cem Aydoğru', 10)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (16, N'ceren@hotmail.com', N'Ceren Er', 10)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (17, N'neslihanermis@hotmail.com', N'Neslihan Ermiş', 9)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (18, N'kaderdemirbilek@hotmail.com', N'Kader Demir Bilek', 4)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (19, N'osman@hotmail.com', N'Osman Yıldırım', 4)
INSERT [dbo].[Students] ([StudentId], [Email], [StudentName], [CourseId]) VALUES (20, N'fatmabuket@hotmail.com', N'Fatma Buket', 4)
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [Education]) VALUES (1, N'Volkan Hoca', N'Bilgisayar Mühendisi')
INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [Education]) VALUES (2, N'Ahmet Yılmazer', N'Elektronik Mühendisi')
INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [Education]) VALUES (3, N'Yusuf Gök', N'Gömülü Sistemler Uzmanı')
INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [Education]) VALUES (4, N'Engin Er', N'Makina')
INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [Education]) VALUES (5, N'Ayşe Suzan', N'İşletme')
INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [Education]) VALUES (7, N'Burcu Korkmaz', N'Matematik')
INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [Education]) VALUES (8, N'Ekrem Ersöz', N'Bilgisayar Mühendisi')
INSERT [dbo].[Teachers] ([TeacherId], [TeacherName], [Education]) VALUES (9, N'Esra Bir', N'Fizik')
SET IDENTITY_INSERT [dbo].[Teachers] OFF
SET IDENTITY_INSERT [dbo].[UserOperationClaims] ON 

INSERT [dbo].[UserOperationClaims] ([Id], [UserId], [OperationClaimId]) VALUES (2, 22, 1)
INSERT [dbo].[UserOperationClaims] ([Id], [UserId], [OperationClaimId]) VALUES (4, 24, 1)
INSERT [dbo].[UserOperationClaims] ([Id], [UserId], [OperationClaimId]) VALUES (5, 24, 2)
INSERT [dbo].[UserOperationClaims] ([Id], [UserId], [OperationClaimId]) VALUES (7, 24, 3)
INSERT [dbo].[UserOperationClaims] ([Id], [UserId], [OperationClaimId]) VALUES (8, 25, 2)
SET IDENTITY_INSERT [dbo].[UserOperationClaims] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [PasswordHash], [PasswordSalt], [Status]) VALUES (22, N'admin', N'admin', N'admin@admin.com', 0xF90A8A9E2E017548CC6F8EE9A15955E70FCE5F8D67409760E793104D1391E5E4D9AB0C2AF667CB91544455A6BEB92FAB9C93BA47D5E0CB41E465E2CF671EF632, 0x74D99335B82B4CC33A2BF7BF033E1F586E6E93CEC1DED9B6879307CD9A4F37A08E53DE0379365065C42D6DAB36E7DC2D99048F90A45A672E6593144B68CEBD300F5A596976176871FB1C5F1EA19A8B06E4BC235B64BF77C7FD43C34D8A9C9A778C6C6AD6F5D808AB5DECC19AAE9FE42DFDC5400A4D94DBBB680A81BA31CD7906, 1)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [PasswordHash], [PasswordSalt], [Status]) VALUES (24, N'Ekrem', N'Ersöz', N'ekrem@ekrem.com', 0x950A1258CA2652F14215DDA5A0E46A543D2DE51E108E5922A6B97AB7F7E2426E8432B1DD0ECE5843A4D9DD42945C5D8145B1CAD28B8C3DBCB4A501857474A3E8, 0xF94110381D04EABE76D0195A07CA793E5F73FE71A70E23C3DA7EB678305A19933C92AB54A0287D24CEACE2D6908A359D8B98A6BA5C38EA5B98502207530EB384047A7BD2E4CC1D85B517113FECD27A0FBE95A444DD227A2C0CAB1577A746ED4E05463ECF61CCAD9805D63F2811C506C43AA6FA9B9C8693C2371DA60E45469402, 1)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [PasswordHash], [PasswordSalt], [Status]) VALUES (25, N'Student', N'Student', N'student@student.com', 0x549C134BA7599BCC5B337B41638280EB261190F292DBEB639B03B5C3E6DE5E26F94510429CCFDCF3EDA8126BC439282119CCA3FF290A0B3DD7CF38BFC0E93A76, 0xCFBC963742644CCCDBA5BD9FE54E3A0A47AB2287678D49111F6AB24B1C4E34F25FC68B47D8E70E965804A80D73A1463063A06261F7E01E29D744D7C8BDD4B9720AAA4119ECA9AB48D6782763310DACA03068C06E7895540370C3B8A9B963C91B6BF8A9ABFAD73DE9F9478F7225A70C16FA6BA1325EE236456055758EA06885CE, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
