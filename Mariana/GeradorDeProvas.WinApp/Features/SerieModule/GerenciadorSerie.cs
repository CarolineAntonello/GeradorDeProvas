using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeradorDeProvas.WinApp.Features.SerieModule
{
    class GerenciadorSerie : GerenciadorFormulario
    {
        ControlSerie _controlSerie;
        SerieService _serviceSerie;

        public GerenciadorSerie(SerieService serviceSerie)
        {
            _serviceSerie = serviceSerie;
            CarregarListagem();
        }

        public override void Adicionar()
        {
            FormSerie form = new FormSerie(_serviceSerie);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _serviceSerie.Adicionar(form.NovaSerie);
                List<Serie> series = _serviceSerie.PegarTodos();
                _controlSerie.PopularListagemSeries(series);
            }
        }

        public override UserControl CarregarListagem()
        {
            if (_controlSerie == null)
                _controlSerie = new ControlSerie(_serviceSerie);

            _controlSerie.PopularListagemSeries(_serviceSerie.PegarTodos());
            return _controlSerie;
        }

        public override void Editar()
        {
            try
            {
                Serie serieSelecionada = _controlSerie.ObtemSerieSelecionada();
                //Implementar método de editar (Quando for implementado o service)
                FormSerie form = new FormSerie(_serviceSerie);
                form.EditarSerie = serieSelecionada;
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _serviceSerie.Editar(form.EditarSerie);
                    List<Serie> series = _serviceSerie.PegarTodos();
                    _controlSerie.PopularListagemSeries(series);
                    serieSelecionada = null;
                }
            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione uma série");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Série";
        }

        public override void Remover()
        {
            Serie serieSelecionada = _controlSerie.ObtemSerieSelecionada();
            try
            {
                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja excluir a série " + serieSelecionada.Nome + " ?",
                    "Excluir Série",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    _serviceSerie.Excluir(serieSelecionada);
                    List<Serie> series = _serviceSerie.PegarTodos();
                    _controlSerie.PopularListagemSeries(series);
                }
            }
            catch (Exception)
            {
                if(serieSelecionada != null)
                    if (_serviceSerie.TemMateria(serieSelecionada) != null)
                        throw new Exception("Não é possivel excluir série vinculada a matéria!");
                throw new Exception("Selecione uma Serie!");
            }
        }

        public override void Pesquisa(string texto)
        {
            try
            {
                List<Serie> serie = _serviceSerie.Pesquisar(texto);
                _controlSerie.PopularListagemSeries(serie);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
