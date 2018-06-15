using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp.Features.ProvaModule
{
    public partial class FormProva : Form
    {
        private Prova _prova;
        private ProvaService _serviceProva;
        private DisciplinaService _serviceDisciplina;
        private MateriaService _serviceMateria;
        private List<Materia> _materia;
        private SerieService _serviceSerie;
        private QuestaoService _serviceQuestao;
        private List<Questao> _questao;
        public FormProva(ProvaService serviceProva, DisciplinaService serviceDisciplina, MateriaService serviceMateria,
          SerieService serviceSerie, QuestaoService serviceQuestao)
        {
            _serviceProva = serviceProva;
            _serviceDisciplina = serviceDisciplina;
            _serviceMateria = serviceMateria;
            _serviceQuestao = serviceQuestao;
            _serviceSerie = serviceSerie;
            InitializeComponent();
            _materia = _serviceMateria.PegarTodos();
            _questao = _serviceQuestao.PegarTodos();
            PopulateComboBoxSerie();
            PopulateComboBoxDisciplina();
            // PopulateComboBoxMateria();
            if (_prova == null)
            {
                _prova = new Prova();
            }
        }

        public Prova NovaProva
        {
            get
            {
                _prova.Materia = cbxMateria.SelectedItem as Materia;
                _prova.Disciplina = cbxDisciplina.SelectedItem as Disciplina;
                _prova.Serie = cbxSerie.SelectedItem as Serie;
                _prova.QuantidadeQuestoes = (int)numericQuantidadeQuestoes.Value;
                return _prova;
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
        private void PopulateComboBoxDisciplina()
        {
            cbxDisciplina.Items.Clear();
            var list = _serviceDisciplina.PegarTodos();
            foreach (var item in list)
            {
                cbxDisciplina.Items.Add(item);
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
        private Serie ObtemSerieSelecionada()
        {
            return (Serie)cbxSerie.SelectedItem;
        }
        private Disciplina ObtemDisciplinaSelecionada()
        {
            return (Disciplina)cbxDisciplina.SelectedItem;
        }
        private Materia ObtemMateriaSelecionada()
        {
            return (Materia)cbxMateria.SelectedItem;
        }
        private void PreencheComboMateria()
        {
            cbxMateria.Items.Clear();
            foreach (var item in _materia)
            {
                if(ObtemSerieSelecionada() != null && ObtemDisciplinaSelecionada() != null)
                {
                    if (ObtemSerieSelecionada().Equals(item.Serie) && ObtemDisciplinaSelecionada().Equals(item.Disciplina))
                    {
                        cbxMateria.Items.Add(item);
                    }
                }
            }
        }
        private void PreencheListaQuestoes()
        {
            if (_questao != null)
            {
                listQuestoes.Items.Clear();
                if (ObtemMateriaSelecionada() != null)
                {
                    foreach (Questao questao in _questao)
                    {
                        if (ObtemMateriaSelecionada().Equals(questao.Materia))
                        {
                            _prova.Questoes.Add(questao);
                            listQuestoes.Items.Add(questao.Pergunta);
                        }
                    }
                }
            }
        }

        private void cbxSerie_SelectedValueChanged(object sender, EventArgs e)
        {
            PreencheComboMateria();
            listQuestoes.Items.Clear();
        }

        private void cbxDisciplina_SelectedValueChanged(object sender, EventArgs e)
        {
            PreencheComboMateria();
            listQuestoes.Items.Clear();
        }

        private void cbxMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            PreencheListaQuestoes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                if (_prova == null)
                {
                    _prova = new Prova();
                }
                _prova.QuantidadeQuestoes = (int)numericQuantidadeQuestoes.Value;
                _prova.Serie = cbxSerie.SelectedItem as Serie;
                _prova.Disciplina = cbxDisciplina.SelectedItem as Disciplina;
                _prova.Materia = cbxMateria.SelectedItem as Materia;
                _prova.Validar();
                embaralharQuestoes();
                
                _serviceProva.ValidaDuplicado(_prova);
                btnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = ex.Message;
            }
        }

        private void numericQuantidadeQuestoes_ValueChanged(object sender, EventArgs e)
        { /*
           if ((int)numericQuantidadeQuestoes.Value > _prova.Questoes.Count)
            {
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text= "Número de questões maior que as questões cadastradas";
                numericQuantidadeQuestoes.Value = numericQuantidadeQuestoes.Value - 1;
            }
            */
        }

        private static Random rng = new Random();

        public static List<Questao> DesordenarLista(List<Questao> input, int quantidade)
        {
            List<Questao> arr = input;
            List<Questao> arrDes = new List<Questao>();

            Random randNum = new Random();
            while (arr.Count > 0)
            {
                int val = randNum.Next(0, arr.Count - 1);
                arrDes.Add(arr[val]);
                arr.RemoveAt(val);
            }
            
            for (int i = 0; i < quantidade; i++)
            {
                arr.Add(arrDes[i]);
            }
            return arr;
        }

        private void embaralharQuestoes()
        {

            _prova.Questoes = DesordenarLista(_prova.Questoes, (int)numericQuantidadeQuestoes.Value);
           
        }
    }
}
