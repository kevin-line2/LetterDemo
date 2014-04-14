/****** Object:  StoredProcedure [dbo].[GetLetterSource]    Script Date: 08/12/2013 09:10:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetLetterSource]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetLetterSource]
GO
/****** Object:  StoredProcedure [dbo].[GetLetterSource]    Script Date: 08/12/2013 09:10:11 ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetLetterSource]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'  

CREATE PROCEDURE [dbo].[GetLetterSource] (

@Key bigint)
 
AS SET NOCOUNT ON

BEGIN
	select First firstName, Last lastName, PhoneNbr account, CCardType cardType, CCardPart lastFour, CCardExpMonth expireMonth, CCardExpYear expireYear from LetterSource where LetterID = @Key
END
' 
END
GO
