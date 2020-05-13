using System;
using System.Collections.Generic;

namespace Restaurante.Application
{
    public class PratoViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<PratosIngredientesViewModel> PratosIngredientes { get; set; }

        public string Descricao { get; set; }

        public int IdTipoPrato { get; set; }

        public TipoPratoViewModel TipoPrato { get; set; }
    }
}
