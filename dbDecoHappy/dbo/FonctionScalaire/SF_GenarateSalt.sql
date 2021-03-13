﻿CREATE FUNCTION [dbo].[SF_GenerateSalt]
()
RETURNS CHAR(250)
AS
BEGIN
	DECLARE @saltResult NVARCHAR(250)
	DECLARE @randomValue SMALLINT, @i SMALLINT
	SET @i = 0;
	WHILE @i < 250
	BEGIN
		SET @randomValue = (SELECT RandomValue FROM [V_GetRandom])
		SET @saltResult = CONCAT(@saltResult,@randomValue)
		SET @i = @i + 1;
	END

	RETURN @saltResult


	--IF (@i = 0)
	--BEGIN
	--	PRINT(CONCAT(@i, ' est égale à zéro'))
	--END

END
