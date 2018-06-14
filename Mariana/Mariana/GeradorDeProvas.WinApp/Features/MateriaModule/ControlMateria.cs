using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;

namespace GeradorDeProvas.WinApp.Features.MateriaModule
{
    public partial class ControlMateria : UserControl
    {
        MateriaService _serviceMateria;
        public ControlMateria(MateriaService serviceMateria)
        {
            _serviceMateria = serviceMateria;
            InitializeComponent();
        }

        public void PopularListagemMaterias(List<Materia> materias)
        {
            if (materias != null)
            {
                listMateria.Items.Clear();

                foreach (Materia c in materias)
                {
                    listMateria.Items.Add(c);
                }
            }
        }

        internal Materia ObtemMateriaSelecionada()
        {

            return (Materia)listMateria.SelectedItem;
        }
    }
}
