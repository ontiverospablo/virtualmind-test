CREATE DATABASE [virtualmind]
GO

USE [virtualmind]
GO

CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[email] [varchar](30) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[User] ON 
INSERT [dbo].[User] ([id], [nombre], [apellido], [email]) VALUES (1, N'Pablo', N'Ontiveros', N'pablo.ontiveros@gmail.com')
INSERT [dbo].[User] ([id], [nombre], [apellido], [email]) VALUES (2, N'David', N'Plaza', N'davidplaza@mail.com')
INSERT [dbo].[User] ([id], [nombre], [apellido], [email]) VALUES (3, N'Maria', N'Gomez', N'gomezm@mail.com')
INSERT [dbo].[User] ([id], [nombre], [apellido], [email]) VALUES (4, N'Jose', N'Perez', N'josep@mail.com')
SET IDENTITY_INSERT [dbo].[User] OFF

