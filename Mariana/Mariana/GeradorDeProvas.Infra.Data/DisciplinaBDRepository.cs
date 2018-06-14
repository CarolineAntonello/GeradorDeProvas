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
    public class DisciplinaBDRepository : IDisciplinaRepository
    {
        /// Scripts para manipulação das tabelas do banco de dados
        #region Scripts SQL

        public const string _sqlInsert = @"INSERT INTO TBDisciplina
                                                       (NomeDisciplina)
                                                   VALUES
                                                         (@NomeDisciplina)";

        public const string _sqlUpdate = @"UPDATE TBDisciplina
                                                   SET NomeDisciplina = @NomeDisciplina
                                                    WHERE Id = @Id";

        public static string _sqlDelete = @"DELETE FROM TBDisciplina
                                                    WHERE Id = @Id";

        public const string _sqlSelectAll = @"SELECT *
                                               FROM TBDisciplina order by NomeDisciplina";

        public const string _sqlSelect = @"SELECT *
                                               FROM TBDisciplina
                                           WHERE Id = @Id order by NomeDisciplina";

        public const string _sqlSelectNome = @"SELECT *
                                               FROM TBDisciplina
                                           WHERE NomeDisciplina = @NomeDisciplina and id <> @id";

        public const string _sqlConfereMateria = @"SELECT *
                                               FROM TBMateria
                                           WHERE DisciplinaId = @Id";


        #endregion Scripts SQL


        public Disciplina Adicionar(Disciplina disciplina)
        {
            disciplina.Id = Db.Insert(_sqlInsert, Take2(disciplina));
            return disciplina;
        }

        public void Editar(Disciplina disciplina)
        {
            Db.Update(_sqlUpdate, Take2(disciplina));

        }

        public void Excluir(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object>
            {
                {"Id", Id}
            };

            Db.Delete(_sqlDelete, parms);
        }

        public Disciplina ConfereMateria(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object>
            {
                {"Id", Id}
            };

            return Db.Get(_sqlConfereMateria, MakeMateria, parms);
        }

        public List<Disciplina> PegarTodos()
        {
            return Db.GetAll(_sqlSelectAll, Make);
        }

        public Disciplina GetById(int Id)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "Id", Id } };

            return Db.Get(_sqlSelect, Make, parms);
        }

        public Disciplina GetByNome(Disciplina disciplina)
        {
            Dictionary<string, object> parms = new Dictionary<string, object> { { "NomeDisciplina", disciplina.Nome } ,{"id",disciplina.Id} };

            return Db.Get(_sqlSelectNome, Make, parms);
        }


        private Dictionary<string, object> Take2(Disciplina disciplina)
        {
            return new Dictionary<string, object>
            {
                { "Id", disciplina.Id },
                { "NomeDisciplina", disciplina.Nome }
            };
        }

        private Disciplina Make(IDataReader reader)
        {
           Disciplina  disciplina = new Disciplina();

            disciplina.Id = Convert.ToInt32(reader["Id"]);
            disciplina.Nome = Convert.ToString(reader["NomeDisciplina"]);

            return disciplina;
        }

        private Disciplina MakeMateria(IDataReader reader)
        {
            Materia materia = new Materia();
            materia.Disciplina = new Disciplina();
            materia.Disciplina.Id = Convert.ToInt32(reader["DisciplinaId"]);
            return materia.Disciplina;
        }


    }
}
