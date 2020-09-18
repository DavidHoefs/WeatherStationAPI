CREATE TABLE [dbo].[TemperatureSensor]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Temperature] FLOAT NOT NULL, 
     [Humidity] FLOAT NOT NULL DEFAULT 0,
    [TimeCaptured] DATETIME2 NOT NULL, 
   

)
