using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp.Features.MateriaModule
{
    public partial class FormMateria : Form
    {
        private Materia _materia;
        private MateriaService _service;
        private DisciplinaService _serviceDisciplina;
        private SerieService _serviceSerie;
        public FormMateria(MateriaService service, DisciplinaService serviceDisciplina, SerieService serviceSerie)
        {
            _service = service;
            _serviceDisciplina = serviceDisciplina;
            _serviceSerie = serviceSerie;

            InitializeComponent();
            PopulateComboBoxSerie();
            PopulateComboBoxDisciplina();
        }

        public Materia NovaMateria
        {
            get
            {
                _materia = new Materia();
                _materia.Nome = txtNomeMateria.Text;
                _materia.Disciplina = cbxDisciplina.SelectedItem as Disciplina;
                _materia.Serie = cbxSerie.SelectedItem as Serie;
                return _materia;
            }
        }

        public Materia EditarMateria
        {
            get
            {
                _materia.Nome = txtNomeMateria.Text;
                _materia.Disciplina = cbxDisciplina.SelectedItem as Disciplina;
                _materia.Serie = cbxSerie.SelectedItem as Serie;
                return _materia;
            }
            set
            {
                _materia = value;
                cbxDisciplina.SelectedIndex = cbxDisciplina.FindString(_materia.Disciplina.Nome);
                cbxSerie.SelectedIndex = cbxSerie.FindString(_materia.Serie.Nome);
                txtNomeMateria.Text = _materia.Nome;
            }
        }

        private void PopulateComboBoxDisciplina()
        {
            cbxDisciplina.Items.Clear();
            var list = _serviceDisciplina.PegarTodos();
            foreach (var item in list)
            {
                cbxDisciplina.Items.Add(item);
            }
        }

        private void PopulateComboBoxSerie()
        {
            cbxSerie.Items.Clear();
            var list = _serviceSerie.PegarTodos();
            foreach (var item in list)
            {
                cbxSerie.Items.Add(item);
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                if (_materia == null)
                {
                    _materia = new Materia();
                }
                _materia.Nome = txtNomeMateria.Text;
                _materia.Disciplina = cbxDisciplina.SelectedItem as Disciplina;
                _materia.Serie = cbxSerie.SelectedItem as Serie;
                _materia.Validar();
                _service.ValidaDuplicado(_materia);
                btnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = ex.Message;
            }
        }
    }
}
