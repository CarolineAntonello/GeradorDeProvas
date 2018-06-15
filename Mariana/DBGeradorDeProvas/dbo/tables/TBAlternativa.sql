CREATE TABLE [dbo].[TBAlternativa]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Descricao] NVARCHAR(MAX) NOT NULL, 
    [IsVerdadeira] BIT NOT NULL, 
    [QuestaoId] INT NOT NULL
)
