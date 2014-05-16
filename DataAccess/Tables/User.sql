/****** Object:  Table [dbo].[User]    Script Date: 5/16/2014 1:13:33 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LastName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MiddleInitial] [char](1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EmailAddress] [varchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PhoneNumber] [varchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Address1] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Address2] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[City] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[State] [char](2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ZipCode] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

