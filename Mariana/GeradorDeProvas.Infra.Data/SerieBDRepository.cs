using GeradorDeProvas.Domain;
using GeradorDeProvas.Domain.Interface;
using GeradorDeProvas.Infra.Data.Database;
using System;
using System.Collections.Generic;
using System.Data;

namespace GeradorDeProvas.Infra.Data
{
    public class SerieBDRepository : ISerieRepository
    {
        /// Scripts para manipulação das tabelas do banco de dados
        #region Scripts SQL

        public const string _sqlInsert = @"INSERT INTO TBSerie
                                                       (NomeSerie)
                                                   VALUES
                                                         (@NomeSerie)";

        public const string _sqlUpdate = @"UPDATE TBSerie
                                                   SET NomeSerie = @NomeSerie
                                                    WHERE Id = @Id";

        public static string _sqlDelete = @"DELETE FROM TBSerie
                                                    WHERE Id = @Id";

        public const string _sqlSelectAll = @"SELECT *
                                               FROM TBSerie order by NomeSerie";

        public const string _sqlSelect = @"SELECT *
                                               FROM TBSerie
                                           WHERE Id = @Id order by NomeSerie";

        public const string _sqlSelectNome = @"SELECT *
                                               FROM TBSerie
                                           WHERE NomeSerie = @NomeSerie and id<>@id";

        public const string _sqlConfereMateria = @"SELECT *
                                               FROM TBMateria
                                           WHERE SerieId = @Id";

        public const string _sqlSelectNomeLike = @"SELECT *
                                               FROM TBSerie
                                           WHERE NomeSerie LIKE @NomeSerie";

        #endregion Scripts SQL


        public Serie Adicionar(Serie serie)
        {
            serie.Id = Db.Insert(_sqlInsert, Take2(serie));
            return serie;
        }

        public void Editar(Serie serie)
        {
            Db.Update(_sqlUpdate, Take2(serie));

        }

        public void Excluir(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object>
            {
                {"Id", Id}
            };

            Db.Delete(_sqlDelete, parms);
        }

        public List<Serie> PegarTodos()
        {
            return Db.GetAll(_sqlSelectAll, Make);
        }

        public Serie ConfereMateria(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object>
            {
                {"Id", Id}
            };

            return Db.Get(_sqlConfereMateria, MakeMateria, parms);
        }

        public Serie GetById(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "Id", Id } };

            return Db.Get(_sqlSelect, Make, parms);
        }

        public Serie GetByNome(Serie serie)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "NomeSerie", serie.Nome },{"id", serie.Id} };

            return Db.Get(_sqlSelectNome, Make, parms);
        }


        private Dictionary<string, object> Take2(Serie serie)
        {
            return new Dictionary<string, object>
            {
                { "Id", serie.Id },
                { "NomeSerie", serie.Nome }
            };
        }

        private Serie Make(IDataReader reader)
        {
            Serie serie = new Serie();

            serie.Id = Convert.ToInt32(reader["Id"]);
            serie.Nome = Convert.ToString(reader["NomeSerie"]);

            return serie;
        }

        private Serie MakeMateria(IDataReader reader)
        {
            Materia materia = new Materia();
            materia.Serie = new Serie();
            materia.Serie.Id = Convert.ToInt32(reader["SerieId"]);
            return materia.Serie;
        }

        public List<Serie> Pesquisar(string texto)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "NomeSerie", '%' + texto + '%' } };
            return Db.GetAll(_sqlSelectNomeLike, Make, parms);
        }
    }
}
