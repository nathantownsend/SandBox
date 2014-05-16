USE [SandBox]
GO

/****** Object:  Table [dbo].[User]    Script Date: 5/16/2014 12:21:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[MiddleInitial] [char](1) NULL,
	[EmailAddress] [varchar](150) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[Address1] [varchar](100) NOT NULL,
	[Address2] [varchar](100) NULL,
	[City] [varchar](50) NOT NULL,
	[State] [char](2) NOT NULL,
	[ZipCode] [varchar](10) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

