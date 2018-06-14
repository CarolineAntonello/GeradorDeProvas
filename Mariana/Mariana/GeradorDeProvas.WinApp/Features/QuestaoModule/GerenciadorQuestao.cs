using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp.Features.QuestaoModule
{
    public class GerenciadorQuestao : GerenciadorFormulario
    {

        ControlQuestao _controlQuestao;
        QuestaoService _serviceQuestao;
        MateriaService _serviceMateria;

        public GerenciadorQuestao(QuestaoService serviceQuestao, MateriaService serviceMateria)
        {
            _serviceMateria = serviceMateria;
            _serviceQuestao = serviceQuestao;
            CarregarListagem();

        }

        public override void Adicionar()
        {
            FormQuestao form = new FormQuestao(_serviceQuestao,_serviceMateria);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _serviceQuestao.Adicionar(form.NovaQuestao);
                List<Questao> questoes = _serviceQuestao.PegarTodos();
                _controlQuestao.PopularListagemQuestoes(questoes);
            }
        }

        public override UserControl CarregarListagem()
        {
            if (_controlQuestao == null)
                _controlQuestao = new ControlQuestao(_serviceQuestao);

            _controlQuestao.PopularListagemQuestoes(_serviceQuestao.PegarTodos());
            return _controlQuestao;
        }

        public override void Editar()
        {
            try
            {
                Questao materiaSelecionada = _controlQuestao.ObtemQuestaoSelecionada();
                FormQuestao form = new FormQuestao(_serviceQuestao, _serviceMateria);
                form.EditarQuestao = materiaSelecionada;
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _serviceQuestao.Editar(form.EditarQuestao);
                }
                List<Questao> questoes = _serviceQuestao.PegarTodos();
                _controlQuestao.PopularListagemQuestoes(questoes);

            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione uma questão");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Questão";
        }

        public override void Remover()
        {
            try
            {
                Questao questaoSelecionada = _controlQuestao.ObtemQuestaoSelecionada();
                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja excluir a questão?" + questaoSelecionada.ToString(),
                    "Excluir questão?",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    _serviceQuestao.Excluir(questaoSelecionada);
                    List<Questao> questoes = _serviceQuestao.PegarTodos();
                    _controlQuestao.PopularListagemQuestoes(questoes);
                }
            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione uma Questão!");
            }

            catch (Exception)
            {
                throw new Exception("Não é possível excluir, Questão possui registros vinculados!");
            }
        }

    }
}
