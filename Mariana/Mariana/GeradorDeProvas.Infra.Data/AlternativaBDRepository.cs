using System;
using System.Collections.Generic;
using GeradorDeProvas.Domain;
using GeradorDeProvas.Infra.Data.Database;
using System.Data;
using GeradorDeProvas.Domain.Interface;

namespace GeradorDeProvas.Infra.Data
{
    public class AlternativaBDRepository : IAlternativaRepository
    {
        /// Scripts para manipulação das tabelas do banco de dados
        #region Scripts SQL

        public const string _sqlInsert = @"INSERT INTO TBAlternativa
                                                       (Descricao,IsVerdadeira,QuestaoId)
                                                   VALUES
                                                         (@Descricao, @IsVerdadeira, @QuestaoId)";

        public const string _sqlUpdate = @"UPDATE TBAlternativa
                                                   SET Descricao = @Descricao, IsVerdadeira = @IsVerdadeira, QuestaoId = @QuestaoId
                                                    WHERE Id = @Id";

        public static string _sqlDelete = @"DELETE FROM TBAlternativa
                                                    WHERE Id = @Id";

        public static string _sqlDeleteByQuestao = @"DELETE FROM TBAlternativa
                                                    WHERE QuestaoId = @Id";

        

        private static string _sqlSelectAll = @"SELECT *
                           FROM TBAlternativa ";

        public const string _sqlSelect = @"SELECT *
                                               FROM TBAlternativa
                                           WHERE Id = @Id";

        public const string _sqlSelectByQuestaoID = @"SELECT *
                                               FROM TBAlternativa
                                           WHERE QuestaoId = @QuestaoId";

        

        #endregion Scripts SQL


        public Alternativa Adicionar(Alternativa alternativa)
        {
            alternativa.Id = Db.Insert(_sqlInsert, Take(alternativa));
            return alternativa;
        }

        public void Editar(Alternativa alternativa)
        {
            Db.Update(_sqlUpdate, Take(alternativa));

        }

        public void ExcluirByQuestaoID(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object>
            {
                {"Id", Id}
            };

            Db.Delete(_sqlDeleteByQuestao, parms);
        }

        public void Excluir(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object>
            {
                {"Id", Id}
            };

            Db.Delete(_sqlDelete, parms);
        }

        public List<Alternativa> PegarTodos()
        {
            return Db.GetAll(_sqlSelectAll, Make);
        }

        public Alternativa GetById(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "Id", Id } };

            Alternativa alternativa = Db.Get(_sqlSelect, Make, parms);

            return alternativa;
        }

      
        public List<Alternativa> GetByQuestaoID(int id)
        {
            return Db.GetAll(_sqlSelectByQuestaoID, Make, new Dictionary<string, object> { { "QuestaoId", id } });
        }

        private Dictionary<string, object> Take(Alternativa alternativa)
        {
            return new Dictionary<string, object>
            {
                { "Id", alternativa.Id },
                { "Descricao", alternativa.Descricao },
                { "IsVerdadeira", alternativa.IsVerdadeira },
                {"QuestaoId", alternativa.IdQuestao }
            };
        }

        private Alternativa Make(IDataReader reader)
        {
            Alternativa alternativa = new Alternativa();
            alternativa.Id = Convert.ToInt32(reader["Id"]);
            alternativa.Descricao = Convert.ToString(reader["Descricao"]);
            alternativa.IsVerdadeira = Convert.ToBoolean(reader["isVerdadeira"]);
            alternativa.IdQuestao = Convert.ToInt32(reader["QuestaoId"]);
            return alternativa;
        }

      

    }
}