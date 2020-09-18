CREATE PROCEDURE [dbo].[spWindData_InsertData]
	@WindSpeed_Knots float,
	@WindSpeed_MPH float,
	@WindDirection nvarchar(6),
	@DateCaptured datetime2(7)
AS
SET NOCOUNT ON;
BEGIN

	INSERT INTO dbo.WindData (WindSpeed_Knots,WindSpeed_MPH,WindDirection,DateCaptured)
	VALUES (@WindSpeed_Knots,@WindSpeed_MPH,@WindDirection,@DateCaptured);


END

