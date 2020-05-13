﻿using System;
using System.Collections.Generic;

namespace Restaurante.Application
{
    public class AgendaViewModel
    {
        public int Id { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public List<AgendaCardapioViewModel> AgendaCardapio { get; set; }
    }
}
