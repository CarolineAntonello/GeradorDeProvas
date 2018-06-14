using GeradorDeProvas.Domain;
using GeradorDeProvas.Domain.Interface;
using GeradorDeProvas.Infra.Data.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Infra.Data
{
    public class ProvaBDRepository : IProvaRepository
    {
        /// Scripts para manipulação das tabelas do banco de dados
        #region Scripts SQL

        public const string _sqlInsert = @"INSERT INTO TBProva
                                                       (MateriaId,DisciplinaId,SerieId,QuantidadeQuestoes)
                                                   VALUES
                                                         (@MateriaId,@DisciplinaId,@SerieId,@QuantidadeQuestoes)";

        public const string _sqlInsertQuestaoProva = @"INSERT INTO TBQuestaoProva
                                                       (QuestaoId, ProvaId)
                                                   VALUES
                                                         (@QuestaoId, @ProvaId)";

        public const string _sqlUpdate = @"UPDATE TBProva
                                                   SET DisciplinaId = @DisciplinaId, SerieId = @SerieId, NomeProva = @NomeProva
                                                    WHERE Id = @Id";

        public static string _sqlDelete = @"DELETE FROM TBProva
                                                    WHERE Id = @Id";

        private static string _sqlSelectAll = @"SELECT p.Id
                                 ,p.MateriaId
                                 ,p.DisciplinaId
                                 ,p.SerieId
	                             ,p.QuantidadeQuestoes
	                             ,m.NomeMateria
	                             ,d.NomeDisciplina
	                             ,s.NomeSerie
                           FROM TBProva AS p
                           INNER JOIN TBMateria AS m ON m.Id = p.MateriaId
                           INNER JOIN TBDisciplina AS d ON d.Id = p.DisciplinaId
                           INNER JOIN TBSerie AS s ON s.Id = p.SerieId order by s.NomeSerie";

        public const string _sqlSelect = @"SELECT *
                                               FROM TBProva
                                           WHERE Id = @Id";



        public const string _sqlSelectQuestaoProva = @"SELECT qp.QuestaoId,
                                                              q.id
                                               FROM TBQuestaoProva as qp
                                                 INNER JOIN TBQuestao AS q ON q.id = qp.QuestaoId
                                           WHERE ProvaId = @ProvaId";

        public const string _sqlSelectNome = @"SELECT p.Id
                                 ,p.SerieId
                                 ,p.DisciplinaId
	                             ,p.MateriaId
                                 ,p.QuantidadeQuestoes
                           FROM TBProva AS p
                           INNER JOIN TBMateria AS m ON m.Id = p.MateriaId
                           INNER JOIN TBDisciplina AS d ON d.Id = p.DisciplinaId
                           INNER JOIN TBSerie AS s ON s.Id = p.SerieId
                           WHERE p.Id = @Id AND s.Id = @SerieId AND d.Id = @DisciplinaId AND m.Id = @MateriaId AND p.QuantidadeQuestoes = @QuantidadeQuestoes";


        #endregion Scripts SQL

        QuestaoBDRepository _questao;

        public ProvaBDRepository()
        {
            _questao = new QuestaoBDRepository();
        }
        public Prova Adicionar(Prova prova)
        {
            prova.Id = Db.Insert(_sqlInsert, Take2(prova));


            for (int i = 0; i < prova.Questoes.Count; i++)
            {
                Dictionary<string, object> parms = new Dictionary<string, object>
                { {"QuestaoId", prova.Questoes[i].Id }, { "ProvaId", prova.Id }};
                Db.Insert(_sqlInsertQuestaoProva, parms);
            }


            return prova;
        }

        public void Editar(Prova prova)
        {
            Db.Update(_sqlUpdate, Take2(prova));

        }

        public void Excluir(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object>
            {
                {"Id", Id}
            };

            Db.Delete(_sqlDelete, parms);
        }

        public List<Prova> PegarTodos()
        {

            List<Prova> provas = Db.GetAll(_sqlSelectAll, Make);
            foreach (var item in provas)
            {
                List<Questao> aux = new List<Questao>();
                Dictionary<string, object> parms = new Dictionary<string, object>
                { { "ProvaId", item.Id } };

                aux = Db.GetAll(_sqlSelectQuestaoProva, _questao.MakeID, parms);
                foreach (var item2 in aux)
                {
                    item.Questoes.Add(_questao.GetById(item2.Id));
                }


            }
            return provas;
        }

        public Prova GetById(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "Id", Id } };

            return Db.Get(_sqlSelect, Make, parms);
        }

        public List<Prova> GetByNome(Prova prova)
        {
            return Db.GetAll(_sqlSelectNome, MakeByNome, Take2(prova));
        }


        private Dictionary<string, object> Take2(Prova prova)
        {
            return new Dictionary<string, object>
            {
                { "Id", prova.Id },
                { "SerieId", prova.Serie.Id },
                { "DisciplinaId", prova.Disciplina.Id },
                { "MateriaId", prova.Materia.Id},
                { "QuantidadeQuestoes", prova.QuantidadeQuestoes }
            };
        }

        private Prova Make(IDataReader reader)
        {
            Prova prova = new Prova();

            prova.Id = Convert.ToInt32(reader["Id"]);
            prova.QuantidadeQuestoes = Convert.ToInt32(reader["QuantidadeQuestoes"]);

            prova.Materia = new Materia();
            prova.Materia.Id = Convert.ToInt32(reader["MateriaId"]);
            prova.Materia.Nome = Convert.ToString(reader["NomeMateria"]);

            prova.Disciplina = new Disciplina();
            prova.Disciplina.Id = Convert.ToInt32(reader["DisciplinaId"]);
            prova.Disciplina.Nome = Convert.ToString(reader["NomeDisciplina"]);

            prova.Serie = new Serie();
            prova.Serie.Id = Convert.ToInt32(reader["SerieId"]);
            prova.Serie.Nome = Convert.ToString(reader["NomeSerie"]);

            return prova;
        }

        private Prova MakeByNome(IDataReader reader)
        {
            Prova prova = new Prova();
            prova.Id = Convert.ToInt32(reader["Id"]);
            prova.QuantidadeQuestoes = Convert.ToInt32(reader["QuantidadeQuestoes"]);
            prova.Materia = new Materia();
            prova.Materia.Id = Convert.ToInt32(reader["MateriaId"]);
            prova.Disciplina = new Disciplina();
            prova.Disciplina.Id = Convert.ToInt32(reader["DisciplinaId"]);
            prova.Serie = new Serie();
            prova.Serie.Id = Convert.ToInt32(reader["SerieId"]);
            return prova;
        }

    }
}
