CREATE TABLE [dbo].[TBQuestaoProva]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [QuestaoId] INT NULL, 
    [ProvaId] INT NULL, 
    CONSTRAINT [FK_TBQuestaoProva_Questao] FOREIGN KEY (QuestaoId) REFERENCES TBQuestao(Id), 
    CONSTRAINT [FK_TBQuestaoProva_Prova] FOREIGN KEY (ProvaId) REFERENCES TBProva(Id) ON DELETE CASCADE
)
