using Campeonato_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato_App.ViewModels
{
    class PrincipalViewModel
    {
        public List<Confronto> confrontos { get; set; }

        public PrincipalViewModel()
        {
            confrontos = new List<Confronto>();

            confrontos.Add(new Confronto
            {
                Data = "08/07/2014",

                SelecaoCasa = "Holanda",

                PlacarCasa = 0,

                PenaltisCasa = 4,

                Estadio = "Arena Fonte Nova",

                SelecaoVisitante = "Costa Rica",

                PlacarVisitante = 0,

                PenaltisVisitante = 3
            });

            confrontos.Add(new Confronto
            {
                Data = "08/07/2014",

                SelecaoCasa = "Brasil",

                PlacarCasa = 1,

                Estadio = "Mineirão",

                SelecaoVisitante = "Alemanha",

                PlacarVisitante = 7
            });
        }
    }
}
