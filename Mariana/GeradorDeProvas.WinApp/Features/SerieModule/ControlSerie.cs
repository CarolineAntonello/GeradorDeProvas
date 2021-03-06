﻿using System.Collections.Generic;
using System.Windows.Forms;
using GeradorDeProvas.Aplication;
using GeradorDeProvas.Domain;

namespace GeradorDeProvas.WinApp.Features.SerieModule
{
    public partial class ControlSerie : UserControl
    {
        SerieService _serviceSerie;
        public ControlSerie(SerieService serviceSerie)
        {
            _serviceSerie = serviceSerie;
            InitializeComponent();
        }
        
        public void PopularListagemSeries(List<Serie> series)
        {
            if (series != null)
            {
                listSerie.Items.Clear();

                foreach (Serie c in series)
                {
                    listSerie.Items.Add(c);
                }
            }
        }

        internal Serie ObtemSerieSelecionada()
        {
            return (Serie)listSerie.SelectedItem;
        }
        
    }
}
