using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp.Features.MateriaModule
{
    public class GerenciadorMateria : GerenciadorFormulario
    {
        ControlMateria _controlMateria;
        MateriaService _serviceMateria;
        SerieService _serviceSerie;
        DisciplinaService _serviceDisciplina;

        public GerenciadorMateria(MateriaService serviceMateria, SerieService serviceSerie, DisciplinaService serviceDisciplina)
        {
            _serviceSerie = serviceSerie;
            _serviceDisciplina = serviceDisciplina;
            _serviceMateria = serviceMateria;
            CarregarListagem();

        }

        public override void Adicionar()
        {
            FormMateria form = new FormMateria(_serviceMateria,_serviceDisciplina,_serviceSerie);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _serviceMateria.Adicionar(form.NovaMateria);
                List<Materia> materias = _serviceMateria.PegarTodos();
                _controlMateria.PopularListagemMaterias(materias);
            }
        }

        public override UserControl CarregarListagem()
        {
            if (_controlMateria == null)
            {
                _controlMateria = new ControlMateria(_serviceMateria);
            }
            _controlMateria.PopularListagemMaterias(_serviceMateria.PegarTodos());
            return _controlMateria;
        }

        public override void Editar()
        {
            try
            {
                Materia materiaSelecionada = _controlMateria.ObtemMateriaSelecionada();
                //Implementar método de editar (Quando for implementado o service)
                FormMateria form = new FormMateria(_serviceMateria, _serviceDisciplina, _serviceSerie);
                form.EditarMateria = materiaSelecionada;
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _serviceMateria.Editar(form.EditarMateria);
                }
                List<Materia> materias = _serviceMateria.PegarTodos();
                _controlMateria.PopularListagemMaterias(materias);

            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione uma Matéria!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Matéria";
        }

        public override void Remover()
        {
            try
            {
                Materia materiaSelecionada = _controlMateria.ObtemMateriaSelecionada();
                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja excluir a matéria " + materiaSelecionada.Nome,
                    "Excluir matéria?",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    _serviceMateria.Excluir(materiaSelecionada);
                    List<Materia> materias = _serviceMateria.PegarTodos();
                    _controlMateria.PopularListagemMaterias(materias);
                }
            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione uma Matéria!");
            }

            catch (Exception)
            {
                throw new Exception("Não é possível excluir, Matéria possui registros vinculados!");
            }
        }

        public override void Pesquisa(string texto)
        {
            try
            {
                List<Materia> materias = _serviceMateria.Pesquisar(texto);
                _controlMateria.PopularListagemMaterias(materias);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
