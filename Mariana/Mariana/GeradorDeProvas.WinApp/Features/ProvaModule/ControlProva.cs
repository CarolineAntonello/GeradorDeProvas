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

namespace GeradorDeProvas.WinApp.Features.ProvaModule
{
    public partial class ControlProva : UserControl
    {
        ProvaService _serviceProva;
        public ControlProva (ProvaService serviceProva)
        {
            _serviceProva = serviceProva;
            InitializeComponent();
        }

        public void PopularListagemProvas(List<Prova> provas)
        {
            if (provas != null)
            {
                listProva.Items.Clear();

                foreach (Prova c in provas)
                {
                    listProva.Items.Add(c);
                }
            }
        }

        internal Prova ObtemProvaSelecionada()
        {

            return (Prova)listProva.SelectedItem;
        }

        private void listProva_DoubleClick(object sender, EventArgs e)
        {
            ObtemProvaSelecionada();
        }
    }
}
