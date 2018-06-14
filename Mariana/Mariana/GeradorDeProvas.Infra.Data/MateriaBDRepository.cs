using GeradorDeProvas.Domain;
using GeradorDeProvas.Domain.Enum;
using GeradorDeProvas.Domain.Interface;
using GeradorDeProvas.Infra.Data.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Infra.Data
{
    public class MateriaBDRepository : IMateriaRepository
    {
        /// Scripts para manipulação das tabelas do banco de dados
        #region Scripts SQL

        public const string _sqlInsert = @"INSERT INTO TBMateria
                                                       (DisciplinaId,SerieId,NomeMateria)
                                                   VALUES
                                                         (@DisciplinaId,@SerieId,@NomeMateria)";

        public const string _sqlUpdate = @"UPDATE TBMateria
                                                   SET DisciplinaId = @DisciplinaId, SerieId = @SerieId, NomeMateria = @NomeMateria
                                                    WHERE Id = @Id";

        public static string _sqlDelete = @"DELETE FROM TBMateria
                                                    WHERE Id = @Id";

        private static string _sqlSelectAll = @"SELECT m.Id
                                 ,m.NomeMateria
                                 ,m.SerieId
                                 ,m.DisciplinaId
	                             ,d.NomeDisciplina
	                             ,s.NomeSerie
                           FROM TBMateria AS m
                           INNER JOIN TBDisciplina AS d ON d.Id = m.DisciplinaId
                           INNER JOIN TBSerie AS s ON s.Id = m.SerieId order by NomeMateria";

        public const string _sqlSelect = @"SELECT *
                                               FROM TBMateria
                                           WHERE Id = @Id";

        public const string _sqlSelectNome = @"SELECT m.Id
                                 ,m.NomeMateria
                                 ,m.SerieId
                                 ,m.DisciplinaId
	                             ,d.NomeDisciplina
	                             ,s.NomeSerie
                           FROM TBMateria AS m
                           INNER JOIN TBDisciplina AS d ON d.Id = m.DisciplinaId
                           INNER JOIN TBSerie AS s ON s.Id = m.SerieId
                                           WHERE m.NomeMateria = @NomeMateria and d.Id = @DisciplinaId and s.Id = @SerieId and m.Id <> @Id ";


        #endregion Scripts SQL


        public Materia Adicionar(Materia materia)
        {
            materia.Id = Db.Insert(_sqlInsert, Take2(materia));
            return materia;
        }

        public void Editar(Materia materia)
        {
            Db.Update(_sqlUpdate, Take2(materia));

        }

        public void Excluir(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object>
            {
                {"Id", Id}
            };

            Db.Delete(_sqlDelete, parms);
        }

        public List<Materia> PegarTodos()
        {
            return Db.GetAll(_sqlSelectAll, Make);
        }

        public Materia GetById(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "Id", Id } };

            return Db.Get(_sqlSelect, Make, parms);
        }

        public List<Materia> GetByNome(Materia materia)
        {
            //Dictionary<string, object> parms = new Dictionary<string, object> { { "NomeMateria", nome } };

            return Db.GetAll(_sqlSelectNome, Make, Take2(materia));
        }


        private Dictionary<string, object> Take2(Materia materia)
        {
            return new Dictionary<string, object>
            {
                { "Id", materia.Id },
                { "NomeMateria", materia.Nome },
                { "DisciplinaId", materia.Disciplina.Id },
                { "SerieId", materia.Serie.Id }
            };
        }

        private Materia Make(IDataReader reader)
        {
            Materia materia = new Materia();

            materia.Id = Convert.ToInt32(reader["Id"]);
            materia.Nome = Convert.ToString(reader["NomeMateria"]);
            materia.Disciplina = new Disciplina();
            materia.Disciplina.Id = Convert.ToInt32(reader["DisciplinaId"]);
            materia.Disciplina.Nome = Convert.ToString(reader["NomeDisciplina"]);
            materia.Serie = new Serie();
            materia.Serie.Id = Convert.ToInt32(reader["SerieId"]);
            materia.Serie.Nome = Convert.ToString(reader["NomeSerie"]);

            return materia;
        }


    }
}
