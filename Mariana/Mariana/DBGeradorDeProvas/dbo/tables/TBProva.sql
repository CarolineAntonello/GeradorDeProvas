CREATE TABLE [dbo].[TBProva]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SerieId] INT NOT NULL, 
    [DisciplinaId] INT NOT NULL, 
    [MateriaId] INT NOT NULL, 
    [QuantidadeQuestoes] INT NOT NULL, 
    CONSTRAINT [FK_TBProva_Serie] FOREIGN KEY (SerieId) REFERENCES TBSerie(Id), 
    CONSTRAINT [FK_TBProva_Disciplina] FOREIGN KEY (DisciplinaId) REFERENCES TBDisciplina(Id), 
    CONSTRAINT [FK_TBProva_Materia] FOREIGN KEY (MateriaId) REFERENCES TBMateria(Id)
)
