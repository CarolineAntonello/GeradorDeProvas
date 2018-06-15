CREATE TABLE [dbo].[TBMateria]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DisciplinaId] INT NOT NULL, 
    [SerieId] INT NOT NULL, 
    [NomeMateria] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_TBMateria_TBDisciplina] FOREIGN KEY (DisciplinaId) REFERENCES TBDisciplina(Id), 
    CONSTRAINT [FK_TBMateria_TBSerie] FOREIGN KEY (SerieId) REFERENCES TBSerie(Id)
)
