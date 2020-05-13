using System;
using System.Collections.Generic;
using Restaurante.Domain.Repository;

namespace Restaurante.Domain
{
    public class Agenda : IEntity
    {
        public int Id { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public List<AgendaCardapio> AgendaCardapios { get; set; }
    }
}
