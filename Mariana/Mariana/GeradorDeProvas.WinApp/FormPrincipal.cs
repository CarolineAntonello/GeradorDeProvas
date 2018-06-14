using GeradorDeProvas.Aplication;
using GeradorDeProvas.Infra.IOC;
using GeradorDeProvas.WinApp.Features.DisciplinaModule;
using GeradorDeProvas.WinApp.Features.MateriaModule;
using GeradorDeProvas.WinApp.Features.ProvaModule;
using GeradorDeProvas.WinApp.Features.QuestaoModule;
using GeradorDeProvas.WinApp.Features.SerieModule;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp
{
    public partial class FormPrincipal : Form
    {
        GerenciadorFormulario _gerenciador;
        GerenciadorDisciplina _gerenciadorDisciplina;
        GerenciadorSerie _gerenciadorSerie;
        GerenciadorMateria _gerenciadorMateria;
        GerenciadorProva _gerenciadorProva;
        GerenciadorQuestao _gerenciadorQuestao;

        QuestaoService _serviceQuestao = new QuestaoService(RepositorioIOC.questao);
        MateriaService _serviceMateria = new MateriaService(RepositorioIOC.materia);
        DisciplinaService _serviceDisciplina = new DisciplinaService(RepositorioIOC.disciplina);
        SerieService _serviceSerie = new SerieService(RepositorioIOC.serie);
        ProvaService _serviceProva = new ProvaService(RepositorioIOC.prova);


        public FormPrincipal()
        {
            InitializeComponent();
            lbStatus.ForeColor = Color.Red;
            statusButton(false);
        }

        private void menuItemDisciplina_Click(object sender, EventArgs e)
        {
            if (_gerenciadorDisciplina == null)
                _gerenciadorDisciplina = new GerenciadorDisciplina(_serviceDisciplina);
            statusButton(true);
            CarregarCadastro(_gerenciadorDisciplina);
        }

        private void menuItemSerie_Click(object sender, EventArgs e)
        {
            if (_gerenciadorSerie == null)
                _gerenciadorSerie = new GerenciadorSerie(_serviceSerie);
            statusButton(true);
            CarregarCadastro(_gerenciadorSerie);
        }
        private void menuItemMateria_Click(object sender, EventArgs e)
        {
            if (_gerenciadorMateria == null)
                _gerenciadorMateria = new GerenciadorMateria(_serviceMateria,_serviceSerie,_serviceDisciplina);
            statusButton(true);
            CarregarCadastro(_gerenciadorMateria);
        }

        private void CarregarCadastro(GerenciadorFormulario gerenciador)
        {
            _gerenciador = gerenciador;
            toolStripPrincipal.Enabled = true;
            lblTipoCadastro.Font = new Font(lblTipoCadastro.Font, FontStyle.Bold);
            lblTipoCadastro.Text = _gerenciador.ObtemTipoCadastro();
            UserControl listagem = _gerenciador.CarregarListagem();
            listagem.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(listagem);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                _gerenciador.Adicionar();

            }
            catch (Exception ex)
            {
                lbStatus.Text = ex.Message;
            }
        }

        private void menuItemSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                _gerenciador.Editar();
            }
            catch (Exception ex)
            {
                lbStatus.Text = ex.Message;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                _gerenciador.Remover();
            }
            catch (Exception ex)
            {
                lbStatus.Text = ex.Message;
            }
        }
        
        private void statusButton(bool status)
        {
            btnAdicionar.Enabled = status;
            btnEditar.Enabled = status;
            btnRemover.Enabled = status;

            btnEditar.Visible = true;
            btnGerarProva.Visible = false;
            btnExportarCSV.Visible = false;
            btnExportarXML.Visible = false;
        }

        private void menuItemCadastrarProva_Click(object sender, EventArgs e)
        {
            if (_gerenciadorProva == null)
                _gerenciadorProva = new GerenciadorProva(_serviceProva, _serviceDisciplina, _serviceMateria, _serviceSerie, _serviceQuestao);
            statusButton(true);
            statusButtonsProva();
            CarregarCadastro(_gerenciadorProva);
        }

        private void statusButtonsProva()
        {
            btnEditar.Visible = false;
            btnGerarProva.Visible = true;
            btnExportarCSV.Visible = true;
            btnExportarXML.Visible = true;
        }

        private void menuItemQuestao_Click(object sender, EventArgs e)
        {
            if (_gerenciadorQuestao == null)
                _gerenciadorQuestao = new GerenciadorQuestao(_serviceQuestao,_serviceMateria);
            statusButton(true);
            CarregarCadastro(_gerenciadorQuestao);
        }

        private void buttonGerarProva_Click(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                _gerenciador.GerarProva();
            }
            catch (Exception ex)
            {
                lbStatus.Text = ex.Message;
            }
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                _gerenciador.GerarCSV();
            }
            catch (Exception ex)
            {
                lbStatus.Text = ex.Message;
            }
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            try
            {
                lbStatus.Text = string.Empty;
                _gerenciador.GerarXML();
            }
            catch (Exception ex)
            {
                lbStatus.Text = ex.Message;
            }
        }
    }
}
