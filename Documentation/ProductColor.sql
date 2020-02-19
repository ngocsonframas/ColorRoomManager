USE [ColorMix]
GO

/****** Object:  Table [dbo].[ProductColor]    Script Date: 2/15/2020 10:42:01 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductColor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [nvarchar](50) NULL,
	[ColorCode] [nvarchar](50) NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateTime] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_ProductColor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


