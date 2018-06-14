insert into TBDisciplina (NomeDisciplina) values 
('Matemática'), 
('Português'),
('Ciências'),
('Geografia'),
('História'),
('Educação Física'),
('Artes');

insert into TBSerie(NomeSerie) values 
('1'), 
('2'),
('3'),
('4'),
('5'),
('6'),
('7'),
('8'),
('9');

insert into TBMateria(NomeMateria, SerieId, DisciplinaId) values 
('Operações Numéricas',1,1),
('Categorização Gráfica das Letras',2,2),
('Corpo Humano',4,3),
('O Sistema Solar',6,4),
('Vestígios do Passado',1,5),
('Futebol',1,6),
('A Arte nos Ritos Primitivos',1,7);


Insert Into TBQuestao (Pergunta, Bimestre, MateriaId) values
('Quanto é 2 + 8 - 3 - 5 + 15 = ?', 1, 1),
('Quanto é 2 + 8 = ?', 1, 1),
('Quanto é 5 + 15 = ?', 1, 1),
('Quanto é 2 + 8 - 15 = ?', 1, 1),
('Quanto é 2 + 15 = ?', 1, 1),
('Quanto é 2 + 8 - 3 = ?', 1, 1),
('Quanto é 3 - 15 = ?', 1, 1),
('Quanto é 3 - 10 = ?', 1, 1),
('Quanto é 7 - 5 = ?', 1, 1),
('Quanto é 150 - 45 = ?', 1, 1),
('Paulo tinha 7 carrinhos. Ele achou mais 3. Quantos carrinhos ele tem agora? ', 1, 1),
('Paulo tinha 7 selos. Ele encontrou um amigo e lhe deu 4. Quantos selos ele tem agora? ', 1, 1),
('Carlos tinha 9 piões. Ele perdeu 6. Quantos piões ele tem agora ?', 1, 1),
('Antônio tinha 8 cadernos. Ele comprou mais 6. Quantos cadernos ele tem agora?', 1, 1),
('Classifique os três números abaixo em ordem crescente (do menor para o maior): 12 , 17 , 9.', 1, 1),
('Maurício tinha 7 livros. Ele comprou mais 5. Quantos livros ele tem agora?', 1, 1),
('Quanto é 6 - 1 - 2 = ?', 1, 1),
('Quanto é 2 - 1 + 6 - 1 - 2 = ?', 1, 1),
('Classifique os três números abaixo em ordem crescente (do menor para o maior) : 9 , 13 , 4.',1,1),
('Classifique os três números abaixo em ordem decrescente (do maior para o menor) : 18 , 2 , 12.',1,1),
('Classifique os três números abaixo em ordem decrescente (do maior para o menor) : 4 , 10 , 3. ',1,1),
('Passe do extenso para o numeral : dezesseis:',1,1),
('Passe do extenso para o numeral : quatorze:',1,1),
('Passe do extenso para o numeral : cento e vinte e três:',1,1),
('Passe do extenso para o numeral : cento e quarenta e cinco:',1,1),
('Passe do extenso para o numeral : quatrocentos e cinquenta:',1,1),
('Carlos tinha 9 livros. Ele achou mais 2. Quantos livros ele tem agora ?',1,1),
('Carlos tinha 8 selos. Um amigo lhe deu mais 5.Quantos selos ele tem agora ?',1,1),
('Carlos tinha 10 piões. Ele encontrou um amigo que lhe deu 6. Quantos piões ele tem agora?',1,1),
('Carlos tinha 11 carrinhos. Ele encontrou um amigo e lhe deu 8.Quantos carrinhos ele tem agora?',1,1),
('Marcos tinha 5 selos. Um amigo lhe deu mais 2.Quantos selos ele tem agora ?',1,1);

Insert Into TBAlternativa (Descricao, IsVerdadeira, QuestaoId) values

('9', 0, 31),
('3', 0, 31),
('15', 0, 31),
('7', 1, 31),

('9', 0, 30),
('3', 1, 30),
('15', 0, 30),
('10', 0, 30),

('14', 0, 29),
('13', 0, 29),
('16', 1, 29),
('20', 0, 29),

('13', 1, 28),
('14', 0, 28),
('16', 0, 28),
('20', 0, 28),

('12', 0, 27),
('11', 1, 27),
('13', 0, 27),
('10', 0, 27),

('143', 0, 26),
('400', 0, 26),
('410', 0, 26),
('450', 1, 26),

('143', 0, 25),
('145', 1, 25),
('131', 0, 25),
('100', 0, 25),

('110', 0, 24),
('122', 0, 24),
('123', 1, 24),
('120', 0, 24),

('14', 1, 23),
('16', 0, 23),
('10', 0, 23),
('5', 0, 23),

('22', 0, 22),
('16', 1, 22),
('10', 0, 22),
('5', 0, 22),

('10, 4, 3', 1, 21),
('4 , 10 , 3', 0, 21),
('3 , 4 , 10', 0, 21),
('4, 3, 10', 0, 21),

('18, 2, 12', 0, 20),
('18 , 12 , 2', 1, 20),
('2 , 18 , 12', 0, 20),
('12, 18, 2', 0, 20),

('9, 13, 4', 0, 19),
('13 , 9 ,4', 0, 19),
('4 , 13 , 9', 0, 19),
('4, 9, 13', 1, 19),

('10', 0, 18),
('5', 0, 18),
('4', 1, 18),
('12', 0, 18),

('7', 0, 17),
('3', 1, 17),

('10', 0, 16),
('14', 1, 16),
('7', 0, 16),
('12', 0, 16),

('12, 9, 17', 0, 15),
('9, 12, 17', 1, 15),
('17, 9, 12', 0, 15),

('10', 0, 14),
('14', 1, 14),
('7', 0, 14),
('12', 0, 14),
('3', 0, 14),

('10', 0, 13),
('11', 0, 13),
('7', 0, 13),
('12', 0, 13),
('3', 1, 13),

('10', 0, 12),
('11', 1, 12),
('7', 0, 12),
('12', 0, 12),
('33', 0, 12),

('10', 1, 11),
('11', 0, 11),
('7', 0, 11),
('12', 0, 11),
('33', 0, 11),

('3', 0, 1),
('16', 0, 1),
('26', 0, 1),
('17', 1, 1),
('30', 0, 1),

('13', 0, 2),
('16', 0, 2),
('10', 1, 2),
('17', 0, 2),
('3', 0, 2),

('13', 0, 3),
('16', 0, 3),
('20', 1, 3),
('17', 0, 3),
('3', 0, 3),

('7', 0, 4),
('-4', 0, 4),
('-5', 1, 4),
('10', 0, 4),
('21', 0, 4),

('3', 0, 5),
('17', 1, 5),
('26', 0, 5),
('16', 0, 5),
('30', 0, 5),

('3', 0, 6),
('16', 0, 6),
('26', 0, 6),
('17', 0, 6),
('7', 1, 6),

('-3', 0, 7),
('-16', 0, 7),
('-12', 1, 7),
('-7', 0, 7),
('-17', 0, 7),

('-3', 0, 8),
('-16', 0, 8),
('-12', 0, 8),
('-7', 1, 8),
('-17', 0, 8),

('3', 0, 9),
('2', 1, 9),
('1', 0, 9),
('0', 0, 9),
('-1', 0, 9),

('105', 1, 10),
('90', 0, 10),
('120', 0, 10),
('88', 0, 10),
('145', 0, 10);
