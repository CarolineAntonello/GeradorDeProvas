using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp.Features.DisciplinaModule
{
    public class GerenciadorDisciplina : GerenciadorFormulario
    {
        ControlDisciplina _controlDisciplina;
        DisciplinaService _serviceDisciplina;

        public GerenciadorDisciplina(DisciplinaService serviceDisciplina)
        {
            _serviceDisciplina = serviceDisciplina;
            CarregarListagem();
            
        }

        public override void Adicionar()
        {
            FormDisciplina form = new FormDisciplina(_serviceDisciplina);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _serviceDisciplina.Adicionar(form.NovaDisciplina);
                List<Disciplina> disciplinas = _serviceDisciplina.PegarTodos();
                _controlDisciplina.PopularListagemDisciplinas(disciplinas);
            }
        }

        public override UserControl CarregarListagem()
        {
           if(_controlDisciplina==null)
                _controlDisciplina = new ControlDisciplina(_serviceDisciplina);
            _controlDisciplina.PopularListagemDisciplinas(_serviceDisciplina.PegarTodos());
            return _controlDisciplina;
        }

        public override void Editar()
        {
            try
            {
                Disciplina disciplinaSelecionada = _controlDisciplina.ObtemDisciplinaSelecionada();
                FormDisciplina form = new FormDisciplina(_serviceDisciplina);
                form.EditarDisciplina = disciplinaSelecionada;
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _serviceDisciplina.Editar(form.EditarDisciplina);
                }
                List<Disciplina> disciplinas = _serviceDisciplina.PegarTodos();
                _controlDisciplina.PopularListagemDisciplinas(disciplinas);

            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione uma Disciplina!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Disciplina";
        }

        public override void Remover()
        {
            Disciplina disciplinaSelecionada = _controlDisciplina.ObtemDisciplinaSelecionada();
            try
            {
                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja excluir a disciplina " + disciplinaSelecionada.Nome + " ?",
                    "Excluir Disciplina",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    _serviceDisciplina.Excluir(disciplinaSelecionada);
                    List<Disciplina> disciplinas = _serviceDisciplina.PegarTodos();
                    _controlDisciplina.PopularListagemDisciplinas(disciplinas);
                }
            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione uma Disciplina!");
            }

            catch (Exception)
            {
                throw new Exception("Não é possível excluir, Disciplina possui registros vinculados!");
            }
        }

        public override void Pesquisa(string texto)
        {
            try
            {
                List<Disciplina> disciplinas = _serviceDisciplina.Pesquisar(texto);
                _controlDisciplina.PopularListagemDisciplinas(disciplinas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
