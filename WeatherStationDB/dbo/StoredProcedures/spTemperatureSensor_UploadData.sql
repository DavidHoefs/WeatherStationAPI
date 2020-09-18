CREATE PROCEDURE [dbo].[spTemperatureSensor_UploadData]
	@Temperature float ,
	@Humidity float,
	@TimeCaptured datetime2(7)
AS
BEGIN
SET NOCOUNT ON;

INSERT INTO dbo.TemperatureSensor (Temperature,Humidity,TimeCaptured)
VALUES (@Temperature,@Humidity,@TimeCaptured);



END
