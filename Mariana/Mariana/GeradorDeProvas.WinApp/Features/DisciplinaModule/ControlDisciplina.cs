using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorDeProvas.Domain;
using GeradorDeProvas.Aplication;

namespace GeradorDeProvas.WinApp.Features.DisciplinaModule
{
    public partial class ControlDisciplina : UserControl
    {

        DisciplinaService _serviceDisciplina;
        public ControlDisciplina(DisciplinaService serviceDisciplina)
        {
            _serviceDisciplina = serviceDisciplina;
            InitializeComponent();
        }

        public void PopularListagemDisciplinas(List<Disciplina> disciplinas)
        {
            if (disciplinas != null)
            {
                listDisciplina.Items.Clear();

                foreach (Disciplina c in disciplinas)
                {
                    listDisciplina.Items.Add(c);
                }
            }
        }

        internal Disciplina ObtemDisciplinaSelecionada()
        {
            
            return (Disciplina)listDisciplina.SelectedItem;
        }
    }
}
