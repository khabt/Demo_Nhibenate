USE [NHibernateDemo]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 11/23/2018 4:40:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](max) NULL,
	[FirstMidName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([ID], [LastName], [FirstMidName]) VALUES (3, N'Bommer', N'Allan')
INSERT [dbo].[Student] ([ID], [LastName], [FirstMidName]) VALUES (4, N'Lewis', N'Jerry')
INSERT [dbo].[Student] ([ID], [LastName], [FirstMidName]) VALUES (5, N'KHA', N'BT')
SET IDENTITY_INSERT [dbo].[Student] OFF

GO
CREATE TABLE [dbo].[Customer]( 
   [Id] [uniqueidentifier] NOT NULL, 
   [FirstName] [nvarchar](100) NOT NULL, 
   [LastName] [nvarchar](100) NOT NULL, 
   [Points] [int] NULL, [HasGoldStatus] [bit] NULL, 
   [MemberSince] [date] NULL, 
   [CreditRating] [nchar](20) NULL, 
   [AverageRating] [decimal](18, 4) NULL, 
   [Street] [nvarchar](100) NULL, 
   [City] [nvarchar](100) NULL, 
   [Province] [nvarchar](100) NULL, 
   [Country] [nvarchar](100) NULL,
   PRIMARY KEY CLUSTERED ([Id] ASC) 
) 

GO 
CREATE TABLE [dbo].[Order]( 
   [Id] [uniqueidentifier] NOT NULL, 
   [CustomerId] [uniqueidentifier] NULL, 
   [Ordered] [datetime] NULL, 
   [Shipped] [datetime] NULL, 
   [Street] [nvarchar](100) NULL, 
   [City] [nvarchar](100) NULL, 
   [Province] [nvarchar](100) NULL, 
   [Country] [nvarchar](100) NULL, 
   PRIMARY KEY CLUSTERED ([Id] ASC) 
) 
GO