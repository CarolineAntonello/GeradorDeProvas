using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp.Features.DisciplinaModule
{
    public partial class FormDisciplina : Form
    {
        private Disciplina _disciplina;
        private DisciplinaService _service;
        public FormDisciplina(DisciplinaService service)
        {
            _service = service;
            InitializeComponent();
            btnSalvar.Enabled = false;
        }

        public Disciplina NovaDisciplina
        {
            get
            {
                _disciplina = new Disciplina();
                _disciplina.Nome = txtNome.Text;
                return _disciplina;
            }
        }

        public Disciplina EditarDisciplina
        { 
            get
            {
                _disciplina.Nome = txtNome.Text;
                return _disciplina;
            }
            set
            {
                txtNome.Text = string.Empty;
                _disciplina = value;
                txtNome.Text = _disciplina.Nome;
            }
        }
        private void AtribuirValores()
        {
            _disciplina.Nome = txtNome.Text;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                if(_disciplina == null)
                {
                    _disciplina = new Disciplina();
                }
                _disciplina.Nome = txtNome.Text;
                _disciplina.Validar();
                _service.ValidaDuplicado(_disciplina);
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
