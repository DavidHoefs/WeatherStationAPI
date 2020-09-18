﻿/*
Deployment script for WeatherStationDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "WeatherStationDB"
:setvar DefaultFilePrefix "WeatherStationDB"
:setvar DefaultDataPath "C:\Users\hoefs\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\hoefs\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Rename refactoring operation with key b1806899-c061-4ab9-827a-45973968aacd is skipped, element [dbo].[WindData].[WindSpeed] (SqlSimpleColumn) will not be renamed to WindSpeed_Knots';


GO
PRINT N'Creating [dbo].[WindData]...';


GO
CREATE TABLE [dbo].[WindData] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [WindSpeed_Knots] FLOAT (53)    NOT NULL,
    [WindSpeed_MPH]   FLOAT (53)    NOT NULL,
    [WindDirection]   NVARCHAR (6)  NOT NULL,
    [DateCaptured]    DATETIME2 (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[spWindData_GetAllData]...';


GO
CREATE PROCEDURE [dbo].[spWindData_GetAllData]

AS
SET NOCOUNT ON;
BEGIN
	SELECT WindSpeed_Knots,WindSpeed_MPH,WindDirection,DateCaptured
	FROM dbo.WindData;

END
GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'ea57d6d9-d498-474f-8bd2-2be1fa0135a0')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('ea57d6d9-d498-474f-8bd2-2be1fa0135a0')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '21339438-8534-4317-8f0b-5b3f1430cdf3')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('21339438-8534-4317-8f0b-5b3f1430cdf3')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'b1806899-c061-4ab9-827a-45973968aacd')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('b1806899-c061-4ab9-827a-45973968aacd')

GO

GO
PRINT N'Update complete.';


GO