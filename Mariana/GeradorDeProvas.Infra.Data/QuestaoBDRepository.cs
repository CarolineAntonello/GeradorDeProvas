using GeradorDeProvas.Domain;
using GeradorDeProvas.Domain.Enum;
using GeradorDeProvas.Domain.Interface;
using GeradorDeProvas.Infra.Data.Database;
using System;
using System.Collections.Generic;
using System.Data;

namespace GeradorDeProvas.Infra.Data
{
    public class QuestaoBDRepository : IQuestaoRepository
    {
        /// Scripts para manipulação das tabelas do banco de dados
        #region Scripts SQL

        public const string _sqlInsert = @"INSERT INTO TBQuestao
                                                       (Pergunta, Bimestre, MateriaId)
                                                   VALUES
                                                         (@Pergunta, @Bimestre, @MateriaId)";

        public const string _sqlUpdate = @"UPDATE TBQuestao
                                                   SET Pergunta = @Pergunta, Bimestre = @Bimestre, MateriaId = @MateriaId
                                                    WHERE Id = @Id";

        public static string _sqlDelete = @"DELETE FROM TBQuestao
                                                    WHERE Id = @Id";

        private static string _sqlSelectAll = @"SELECT q.Id
                                 ,q.Pergunta
                                 ,q.Bimestre
	                             ,q.MateriaId
                                 ,m.NomeMateria
                                 ,m.SerieId
                                 ,m.DisciplinaId
	                             ,d.NomeDisciplina
	                             ,s.NomeSerie
                           FROM TBQuestao AS q
                          
                           INNER JOIN TBMateria AS m ON m.Id = q.MateriaId 
                           INNER JOIN TBDisciplina AS d ON d.Id = m.DisciplinaId
                           INNER JOIN TBSerie AS s ON s.Id = m.SerieId order by q.Pergunta";

        public const string _sqlSelect = @"SELECT q.Id
                                 ,q.Pergunta
                                 ,q.Bimestre
	                             ,q.MateriaId
                                 ,m.NomeMateria
                                 ,m.SerieId
                                 ,m.DisciplinaId
	                             ,d.NomeDisciplina
	                             ,s.NomeSerie
                           FROM TBQuestao AS q
                          
                           INNER JOIN TBMateria AS m ON m.Id = q.MateriaId 
                           INNER JOIN TBDisciplina AS d ON d.Id = m.DisciplinaId
                           INNER JOIN TBSerie AS s ON s.Id = m.SerieId  WHERE q.Id = @Id";

        public const string _sqlSelectNome = @"select* from TBQuestao where Pergunta = @Pergunta and Id<> @Id";

        public const string _sqlSelectNomeLike = @"SELECT q.Id
                                                         ,q.Pergunta
                                                         ,q.Bimestre
	                                                     ,q.MateriaId
                                                         ,m.NomeMateria
                                                         ,m.SerieId
                                                         ,m.DisciplinaId
	                                                     ,d.NomeDisciplina
	                                                     ,s.NomeSerie
                                                   FROM TBQuestao AS q
                          
                                                   INNER JOIN TBMateria AS m ON m.Id = q.MateriaId 
                                                   INNER JOIN TBDisciplina AS d ON d.Id = m.DisciplinaId
                                                   INNER JOIN TBSerie AS s ON s.Id = m.SerieId WHERE Pergunta LIKE @Pergunta";

        #endregion Scripts SQL
        AlternativaBDRepository _alternativa;
        public QuestaoBDRepository()
        {
            _alternativa = new AlternativaBDRepository();
        }
        public Questao Adicionar(Questao questao)
        {
            questao.Id = Db.Insert(_sqlInsert, Take(questao));
            foreach (var item in questao.Alternativas)
            {
                item.IdQuestao = questao.Id;
                _alternativa.Adicionar(item);
            }

            return questao;
        }

        public void Editar(Questao questao)
        {
            Db.Update(_sqlUpdate, Take(questao));
         

                _alternativa.ExcluirByQuestaoID(questao.Id);
            
            
            foreach (var item in questao.Alternativas)
            {
                item.IdQuestao = questao.Id;
                _alternativa.Adicionar(item);

            }
           
        }

        public void Excluir(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object>
            {
                {"Id", Id}
            };
            _alternativa.ExcluirByQuestaoID(Id);

            Db.Delete(_sqlDelete, parms);
        }

        public List<Questao> PegarTodos()
        {
            List<Questao> questoes = Db.GetAll(_sqlSelectAll, Make);
            foreach (var item in questoes)
            {
                item.Alternativas = _alternativa.GetByQuestaoID(item.Id);
            }
            return questoes;
        }

        public Questao GetById(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "Id", Id } };

            Questao questao = Db.Get(_sqlSelect, Make, parms);

            questao.Alternativas = _alternativa.GetByQuestaoID(questao.Id);


            return questao;
        }

        public List<Questao> GetByNome(Questao questao)
        {
            return Db.GetAll(_sqlSelectNome, MakeByNome, Take(questao));
        }


        private Dictionary<string, object> Take(Questao questao)
        {
            return new Dictionary<string, object>
            {
                { "Id", questao.Id },
                { "Pergunta", questao.Pergunta },
                { "Bimestre", questao.Bimestre },
                { "MateriaId", questao.Materia.Id }
            };
        }

        public  Questao MakeID(IDataReader reader)
        {
            Questao questao = new Questao();
            questao.Id = Convert.ToInt32(reader["Id"]);
            return questao;
        }
        


            private Questao Make(IDataReader reader)
        {
            Questao questao = new Questao();
            questao.Id = Convert.ToInt32(reader["Id"]);

            questao.Pergunta = Convert.ToString(reader["Pergunta"]);
            questao.Bimestre = (Bimestre)reader["Bimestre"];

            questao.Materia = new Materia();
            questao.Materia.Nome = Convert.ToString(reader["NomeMateria"]);
            questao.Materia.Id = Convert.ToInt32(reader["MateriaId"]);

            questao.Materia.Disciplina = new Disciplina();
            questao.Materia.Disciplina.Id = Convert.ToInt32(reader["DisciplinaId"]);
            questao.Materia.Disciplina.Nome = Convert.ToString(reader["NomeDisciplina"]);
            questao.Materia.Serie = new Serie();
            questao.Materia.Serie.Id = Convert.ToInt32(reader["SerieId"]);
            questao.Materia.Serie.Nome = Convert.ToString(reader["NomeSerie"]);
            return questao;
        }

        private Questao MakeByNome(IDataReader reader)
        {
            Questao questao = new Questao();
            questao.Id = Convert.ToInt32(reader["Id"]);
            questao.Pergunta = Convert.ToString(reader["Pergunta"]);

            return questao;
        }

        public List<Questao> Pesquisar(string texto)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "Pergunta", '%' + texto + '%' } };
            return Db.GetAll(_sqlSelectNomeLike, Make, parms);
        }
    }
}
