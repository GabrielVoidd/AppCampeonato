using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Campeonato_App.Models
{
    public class Confronto
    {
        public string Data { get; set; }

        //public Image BandeiraCasa;

        public string SelecaoCasa { get; set; }

        public int PlacarCasa { get; set; }

        public int PenaltisCasa { get; set; }

        public string Estadio { get; set; }

        //public Image BandeiraVisitante;

        public string SelecaoVisitante { get; set; }

        public int PlacarVisitante { get; set; }

        public int PenaltisVisitante { get; set; }

        public override string ToString()
        {
            return SelecaoCasa;
        }
    }
}
