USE [PatientInfoDb]
GO
/****** Object:  Table [dbo].[Allergies]    Script Date: 5/23/2024 10:25:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Allergies](
	[AId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
 CONSTRAINT [PK_Allergies] PRIMARY KEY CLUSTERED 
(
	[AId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Allergies_Details]    Script Date: 5/23/2024 10:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Allergies_Details](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[AllergyId] [int] NOT NULL,
 CONSTRAINT [PK_Allergies_Details] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiseaseInfo]    Script Date: 5/23/2024 10:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiseaseInfo](
	[DId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_DiseaseInfo] PRIMARY KEY CLUSTERED 
(
	[DId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NCD_Details]    Script Date: 5/23/2024 10:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCD_Details](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[NCDId] [int] NOT NULL,
 CONSTRAINT [PK_NCD_Details] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NCDs]    Script Date: 5/23/2024 10:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCDs](
	[NId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
 CONSTRAINT [PK_NCDs] PRIMARY KEY CLUSTERED 
(
	[NId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 5/23/2024 10:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[PId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Epilepcy] [bit] NULL,
	[DId] [int] NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[PId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Allergies] ON 

INSERT [dbo].[Allergies] ([AId], [Name]) VALUES (1, N'Drugs - Penicilin')
INSERT [dbo].[Allergies] ([AId], [Name]) VALUES (2, N'Drugs - Others')
INSERT [dbo].[Allergies] ([AId], [Name]) VALUES (3, N'Animals')
INSERT [dbo].[Allergies] ([AId], [Name]) VALUES (4, N'Food')
INSERT [dbo].[Allergies] ([AId], [Name]) VALUES (5, N'Oinments')
INSERT [dbo].[Allergies] ([AId], [Name]) VALUES (6, N'Plant')
INSERT [dbo].[Allergies] ([AId], [Name]) VALUES (7, N'Sprays')
INSERT [dbo].[Allergies] ([AId], [Name]) VALUES (8, N'Others')
INSERT [dbo].[Allergies] ([AId], [Name]) VALUES (9, N'No Allergies')
SET IDENTITY_INSERT [dbo].[Allergies] OFF
GO
SET IDENTITY_INSERT [dbo].[Allergies_Details] ON 

INSERT [dbo].[Allergies_Details] ([Id], [PatientId], [AllergyId]) VALUES (3, 3, 2)
SET IDENTITY_INSERT [dbo].[Allergies_Details] OFF
GO
SET IDENTITY_INSERT [dbo].[DiseaseInfo] ON 

INSERT [dbo].[DiseaseInfo] ([DId], [Name]) VALUES (1, N'Diabetes')
INSERT [dbo].[DiseaseInfo] ([DId], [Name]) VALUES (2, N'Hepatitis')
SET IDENTITY_INSERT [dbo].[DiseaseInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[NCD_Details] ON 

INSERT [dbo].[NCD_Details] ([Id], [PatientId], [NCDId]) VALUES (3, 3, 4)
SET IDENTITY_INSERT [dbo].[NCD_Details] OFF
GO
SET IDENTITY_INSERT [dbo].[NCDs] ON 

INSERT [dbo].[NCDs] ([NId], [Name]) VALUES (1, N'Asthma')
INSERT [dbo].[NCDs] ([NId], [Name]) VALUES (2, N'Cancer')
INSERT [dbo].[NCDs] ([NId], [Name]) VALUES (3, N'Disorder of ear')
INSERT [dbo].[NCDs] ([NId], [Name]) VALUES (4, N'Disorder of eye')
INSERT [dbo].[NCDs] ([NId], [Name]) VALUES (5, N'Mental illness')
INSERT [dbo].[NCDs] ([NId], [Name]) VALUES (6, N'Oral health problems')
SET IDENTITY_INSERT [dbo].[NCDs] OFF
GO
SET IDENTITY_INSERT [dbo].[Patients] ON 

INSERT [dbo].[Patients] ([PId], [Name], [Epilepcy], [DId]) VALUES (3, N'Tanvir Ahmmed', 0, 2)
SET IDENTITY_INSERT [dbo].[Patients] OFF
GO
ALTER TABLE [dbo].[Allergies_Details]  WITH CHECK ADD  CONSTRAINT [FK_Allergies_Details_Patients_PatientId] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([PId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Allergies_Details] CHECK CONSTRAINT [FK_Allergies_Details_Patients_PatientId]
GO
ALTER TABLE [dbo].[NCD_Details]  WITH CHECK ADD  CONSTRAINT [FK_NCD_Details_Patients_PatientId] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([PId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NCD_Details] CHECK CONSTRAINT [FK_NCD_Details_Patients_PatientId]
GO
