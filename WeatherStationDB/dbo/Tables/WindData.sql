CREATE TABLE [dbo].[WindData]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WindSpeed_Knots] FLOAT NOT NULL, 
     [WindSpeed_MPH] FLOAT NOT NULL,
    [WindDirection] NVARCHAR(6) NOT NULL, 
    [DateCaptured] DATETIME2 NOT NULL, 
   
)
