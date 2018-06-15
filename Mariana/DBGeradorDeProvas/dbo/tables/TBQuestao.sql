CREATE TABLE [dbo].[TBQuestao]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Pergunta] NVARCHAR(MAX) NOT NULL, 
    [Bimestre] INT NOT NULL, 
    [MateriaId] INT NOT NULL, 
    
    CONSTRAINT [FK_TBQuestao_Materia] FOREIGN KEY (MateriaId) REFERENCES TBMateria(Id)
)
