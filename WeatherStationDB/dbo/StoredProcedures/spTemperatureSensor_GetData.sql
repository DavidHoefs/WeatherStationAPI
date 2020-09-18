CREATE PROCEDURE [dbo].[spTemperatureSensor_GetData]
	
AS
BEGIN
SET NOCOUNT ON;
	SELECT Temperature,Humidity,TimeCaptured
	FROM dbo.TemperatureSensor;
END
RETURN 0
