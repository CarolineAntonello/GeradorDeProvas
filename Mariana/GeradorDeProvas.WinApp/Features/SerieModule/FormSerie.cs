using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp.Features.SerieModule
{
    public partial class FormSerie : Form
    {
        private Serie _serie;
        SerieService _service;
        public FormSerie(SerieService service)
        {
            _service = service;
            InitializeComponent();
            btnSalvar.Enabled = false;
        }

        public Serie NovaSerie
        {
            get
            {
                _serie = new Serie();
                _serie.Nome = txtSerie.Text;
                return _serie;
            }
        }

        public Serie EditarSerie
        {
            get
            {
                _serie.Nome = txtSerie.Text;
                return _serie;
            }
            set
            {
                txtSerie.Text = string.Empty;
                _serie = value;
                txtSerie.Text = _serie.Nome;

            }
        }

        private void txtSerie_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                if (_serie == null)
                {
                    _serie = new Serie();
                }
                _serie.Nome = txtSerie.Text;
                _serie.Validar();
                _service.ValidaDuplicado(_serie);
                btnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnSalvar.Enabled = false;
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = ex.Message;
            }
        }
    }
}
