using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp.Features.ProvaModule
{
    public class GerenciadorProva : GerenciadorFormulario
    {
        ControlProva _controlProva;
        ProvaService _serviceProva;
        DisciplinaService _serviceDisciplina;
        MateriaService _serviceMateria;
        SerieService _serviceSerie;
        QuestaoService _serviceQuestao;
        PDFService _servicePDF = new PDFService();
        CSVService _serviceCSV = new CSVService();
        XMLService _serviceXML = new XMLService();

        public GerenciadorProva(ProvaService serviceProva, DisciplinaService serviceDisciplina, MateriaService serviceMateria,
          SerieService serviceSerie, QuestaoService serviceQuestao)
        {
            _serviceProva = serviceProva;
            _serviceDisciplina = serviceDisciplina;
            _serviceMateria = serviceMateria;
            _serviceQuestao = serviceQuestao;
            _serviceSerie = serviceSerie;
            CarregarListagem();

        }

        public override void Adicionar()
        {
            FormProva form = new FormProva(_serviceProva, _serviceDisciplina, _serviceMateria, _serviceSerie, _serviceQuestao);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _serviceProva.Adicionar(form.NovaProva);
                List<Prova> provas = _serviceProva.PegarTodos();
                _controlProva.PopularListagemProvas(provas);
            }
        }

        public override UserControl CarregarListagem()
        {
            if (_controlProva == null)
            {
                _controlProva = new ControlProva(_serviceProva);
            }
            _controlProva.PopularListagemProvas(_serviceProva.PegarTodos());
            return _controlProva;
        }

        public override void Editar() { }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Prova";
        }

        public override void Remover()
        {
            try
            {
                Prova provaSelecionada = _controlProva.ObtemProvaSelecionada();
                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja excluir a prova " + provaSelecionada.ToString(),
                    "Excluir prova?",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    _serviceProva.Excluir(provaSelecionada);
                    List<Prova> provas = _serviceProva.PegarTodos();
                    _controlProva.PopularListagemProvas(provas);
                }
            }
            catch (Exception)
            {
                throw new Exception("Selecione uma Prova!");
            }
        }

        public override void GerarProva()
        {
            try
            {
                Prova provaSelecionada = _controlProva.ObtemProvaSelecionada();
                DialogResult resultado = MessageBox.Show(
                    "Deseja gerar a seguinte prova: " + provaSelecionada.ToString(),
                    "Gerar Prova",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    SalvarPDF(provaSelecionada);
                    //_serviceProva.DeleteProva(provaSelecionada);
                    //List<Prova> provas = _serviceProva.GetAllProvas();
                    //_controlProva.PopularListagemProvas(provas);
                }
            }
            catch (Exception)
            {
                throw new Exception("Selecione uma Prova!");
            }
        }

        private void SalvarPDF(Prova provaSelecionada)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = " PDF file |*.pdf";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _servicePDF.CriarProva(provaSelecionada, Path.GetFullPath(saveFileDialog.FileName));
                }
            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione uma Prova!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public override void GerarCSV()
        {
            try
            {
                Prova provaSelecionada = _controlProva.ObtemProvaSelecionada();
                DialogResult resultado = MessageBox.Show(
                    "Deseja exportar a seguinte prova em CSV: " + provaSelecionada.ToString(),
                    "Exportar Prova em CSV",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    ExportarCSV(provaSelecionada);
                }
            }
            catch (Exception)
            {
                throw new Exception("Selecione uma Prova!");
            }
        }
        private void ExportarCSV(Prova provaSelecionada)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = " CSV file |*.csv";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _serviceCSV.ExportarCSV(provaSelecionada, Path.GetFullPath(saveFileDialog.FileName));
                }
            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione uma Prova!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public override void GerarXML()
        {
            try
            {
                Prova provaSelecionada = _controlProva.ObtemProvaSelecionada();
                DialogResult resultado = MessageBox.Show(
                    "Deseja exportar a seguinte prova em XML: " + provaSelecionada.ToString(),
                    "Exportar Prova em XML",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    ExportarXML(provaSelecionada);
                }
            }
            catch (Exception)
            {
                throw new Exception("Selecione uma Prova!");
            }
        }

        private void ExportarXML(Prova provaSelecionada)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = " XML file |*.xml";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _serviceXML.ExportarXML(provaSelecionada, Path.GetFullPath(saveFileDialog.FileName));
                }
            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione uma Prova!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
