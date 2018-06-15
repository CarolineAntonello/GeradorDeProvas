using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;
using GeradorDeProvas.Domain.Enum;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp.Features.QuestaoModule
{
    public partial class FormQuestao : Form
    {


        private Questao _questao;
        private Alternativa _alternativa;
        private QuestaoService _service;
        private MateriaService _serviceMateria;
        public FormQuestao(QuestaoService service, MateriaService serviceMateria)
        {
            _service = service;
            _serviceMateria = serviceMateria;
            InitializeComponent();
            PopulateComboBoxBimestre();
            PopulateComboBoxMateria();
        }
        public Questao NovaQuestao
        {
            get
            {
                _questao.Pergunta = txtPergunta.Text;
                _questao.Materia = cbxMateria.SelectedItem as Materia;
                _questao.Bimestre = (Bimestre)cbxBimestre.SelectedValue;
                ValidaCorreta();
                return _questao;
            }
        }

        public Questao EditarQuestao
        {
            get
            {
                _questao.Pergunta = txtPergunta.Text;
                _questao.Materia = cbxMateria.SelectedItem as Materia;
                _questao.Bimestre = (Bimestre)cbxBimestre.SelectedValue;
                ValidaCorreta();
                return _questao;
            }
            set
            {
                _questao = value;
                cbxMateria.SelectedIndex = cbxMateria.FindString(_questao.Materia.ToString());
                cbxBimestre.SelectedItem = _questao.Bimestre;
                txtPergunta.Text = _questao.Pergunta;

                foreach (var item in _questao.Alternativas)
                {
                    listBoxAlternativas.Items.Add(item);
                }

                PopulateComboBoxAlternativaCorreta();
                ValidaCorreta();
                ValidaAddAlternativa();
            }
        }

        private void PopulateComboBoxMateria()
        {
            cbxMateria.Items.Clear();
            var list = _serviceMateria.PegarTodos();
            foreach (var item in list)
            {
                cbxMateria.Items.Add(item);
            }
        }

        private void PopulateComboBoxBimestre()
        {
            cbxBimestre.Items.Clear();
            cbxBimestre.DataSource = Enum.GetValues(typeof(Bimestre));

        }

        private void ValidaCorreta()
        {
            foreach (var item in _questao.Alternativas)
            {
                item.IsVerdadeira = false;
                if (item.Equals((Alternativa)cmbAlternativaCorreta.SelectedItem))
                {
                    item.IsVerdadeira = true;
                }
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                if (_questao == null)
                {
                    _questao = new Questao();
                }
                _questao.Pergunta = txtPergunta.Text;
                _questao.Materia = cbxMateria.SelectedItem as Materia;
                _questao.Bimestre = (Bimestre)cbxBimestre.SelectedValue;

                _questao.Validar();
                _service.ValidaDuplicado(_questao);
                btnSalvar.Enabled = true;
                ValidaCorreta();

            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = ex.Message;
            }
        }

        private void btnAddAlternativa_Click(object sender, EventArgs e)
        {
            lbStatus.Text = string.Empty;
            try
            {

                if (_questao == null)
                {
                    _questao = new Questao();
                }
                _questao.ValidaExistenciaAlternativa(txtAlternativa.Text);
                _alternativa = new Alternativa();
                _alternativa.Descricao = txtAlternativa.Text;
                _alternativa.Validar();
                _questao.Alternativas.Add(_alternativa);
                populateListBox();
                PopulateComboBoxAlternativaCorreta();
                ValidaAddAlternativa();
                txtAlternativa.Text = string.Empty;

            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = ex.Message;
            }
        }

        private void ValidaAddAlternativa()
        {
            if (_questao.Alternativas.Count >= 5)
            {
                btnAddAlternativa.Enabled = false;
            }
            else
            {
                btnAddAlternativa.Enabled = true;
            }
        }

        private void populateListBox()
        {
            listBoxAlternativas.Items.Clear();
            if (_questao.Alternativas.Count > 0)
            {
                foreach (var item in _questao.Alternativas)
                {
                    listBoxAlternativas.Items.Add(item);
                }
            }
        }

        private void btnRemoverAlternativa_Click(object sender, EventArgs e)
        {
            lbStatus.Text = string.Empty;
            _questao.Alternativas.Remove(ObtemAlternativaSelecionada());
            listBoxAlternativas.Items.Clear();
            cmbAlternativaCorreta.Items.Remove(ObtemAlternativaSelecionada());
            populateListBox();
            ValidaCorreta();
            PopulateComboBoxAlternativaCorreta();
            ValidaAddAlternativa();
        }

        private Alternativa ObtemAlternativaSelecionada()
        {
            return (Alternativa)listBoxAlternativas.SelectedItem;
        }

        private void PopulateComboBoxAlternativaCorreta()
        {
            cmbAlternativaCorreta.Items.Clear();

            if (_questao.Alternativas.Count > 0)
            {
                foreach (var item in _questao.Alternativas)
                {
                    cmbAlternativaCorreta.Items.Add(item);
                }
                foreach (var item in _questao.Alternativas)
                {
                    if (item.IsVerdadeira == true)
                    {
                        cmbAlternativaCorreta.SelectedIndex = cmbAlternativaCorreta.FindString(item.ToString());
                        break;
                    }
                    else
                    {
                        cmbAlternativaCorreta.SelectedIndex = 0;
                    }
                }
            }
        }

        private void LimparErroAoDigitar(object sender, EventArgs e)
        {
            lbStatus.Text = string.Empty;
        }
    }
}
