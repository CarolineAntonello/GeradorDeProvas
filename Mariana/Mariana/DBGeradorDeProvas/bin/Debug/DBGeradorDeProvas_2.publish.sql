﻿/*
Deployment script for DBGeradorDeProvas

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DBGeradorDeProvas"
:setvar DefaultFilePrefix "DBGeradorDeProvas"
:setvar DefaultDataPath "C:\Users\ndduser\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb"
:setvar DefaultLogPath "C:\Users\ndduser\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb"

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
PRINT N'Creating [dbo].[TBProva]...';


GO
CREATE TABLE [dbo].[TBProva] (
    [Id]                 INT NOT NULL,
    [SerieId]            INT NOT NULL,
    [DisciplinaId]       INT NOT NULL,
    [MateriaId]          INT NOT NULL,
    [QuantidadeQuestoes] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[FK_TBProva_Serie]...';


GO
ALTER TABLE [dbo].[TBProva] WITH NOCHECK
    ADD CONSTRAINT [FK_TBProva_Serie] FOREIGN KEY ([SerieId]) REFERENCES [dbo].[TBSerie] ([Id]);


GO
PRINT N'Creating [dbo].[FK_TBProva_Disciplina]...';


GO
ALTER TABLE [dbo].[TBProva] WITH NOCHECK
    ADD CONSTRAINT [FK_TBProva_Disciplina] FOREIGN KEY ([DisciplinaId]) REFERENCES [dbo].[TBDisciplina] ([Id]);


GO
PRINT N'Creating [dbo].[FK_TBProva_Materia]...';


GO
ALTER TABLE [dbo].[TBProva] WITH NOCHECK
    ADD CONSTRAINT [FK_TBProva_Materia] FOREIGN KEY ([MateriaId]) REFERENCES [dbo].[TBMateria] ([Id]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[TBProva] WITH CHECK CHECK CONSTRAINT [FK_TBProva_Serie];

ALTER TABLE [dbo].[TBProva] WITH CHECK CHECK CONSTRAINT [FK_TBProva_Disciplina];

ALTER TABLE [dbo].[TBProva] WITH CHECK CHECK CONSTRAINT [FK_TBProva_Materia];


GO
PRINT N'Update complete.';


GO
