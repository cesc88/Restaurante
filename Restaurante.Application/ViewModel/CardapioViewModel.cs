using System;
using System.Collections.Generic;

namespace Restaurante.Application
{
    public class CardapioViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public List<PratoViewModel> Prato { get; set; }
    }
}
