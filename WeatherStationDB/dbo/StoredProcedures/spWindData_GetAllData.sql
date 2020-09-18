CREATE PROCEDURE [dbo].[spWindData_GetAllData]

AS
SET NOCOUNT ON;
BEGIN
	SELECT WindSpeed_Knots,WindSpeed_MPH,WindDirection,DateCaptured
	FROM dbo.WindData;

END