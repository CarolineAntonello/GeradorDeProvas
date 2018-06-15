using System.Collections.Generic;
using System.Windows.Forms;
using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;

namespace GeradorDeProvas.WinApp.Features.QuestaoModule
{
    public partial class ControlQuestao : UserControl
    {

        QuestaoService _serviceQuestao;
        public ControlQuestao(QuestaoService serviceQuestao)
        {
            _serviceQuestao = serviceQuestao;
            InitializeComponent();
        }

        public void PopularListagemQuestoes(List<Questao> Questoes)
        {
            if (Questoes != null)
            {
                listQuestao.Items.Clear();

                foreach (Domain.Questao c in Questoes)
                {
                    listQuestao.Items.Add(c);
                }
            }
        }

        internal Questao ObtemQuestaoSelecionada()
        {

            return (Questao)listQuestao.SelectedItem;
        }
    }
}
