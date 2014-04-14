/****** Object:  Table [dbo].[LetterSource]    Script Date: 08/12/2013 09:10:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LetterSource]') AND type in (N'U'))
DROP TABLE [dbo].LetterSource
GO
/****** Object:  Table [dbo].[LetterSource]    Script Date: 08/12/2013 09:10:11 ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LetterSource]') AND type in (N'U'))
BEGIN
	CREATE TABLE [dbo].LetterSource(
		[LetterID] [bigint] IDENTITY(1,1) NOT NULL,
		[First] [nvarchar](25) NOT NULL,
		[Last] [nvarchar](25) NOT NULL,
		[PhoneNbr] [nvarchar](25) NOT NULL,
		[CCardType] [nvarchar](25) NOT NULL,
		[CCardPart] [nvarchar](4) NOT NULL,
		[CCardExpMonth] int NOT NULL,
		[CCardExpYear] int NOT NULL,
		[CreateDate] [datetimeoffset] NOT NULL CONSTRAINT [DF_LetterSource_CreateDate] DEFAULT (getutcdate()),
	CONSTRAINT [PK_LetterSource] PRIMARY KEY CLUSTERED (
	[LetterID] ASC
	)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
END

GO

