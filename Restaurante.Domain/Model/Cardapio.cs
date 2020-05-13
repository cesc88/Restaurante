using System;
using System.Collections.Generic;
using Restaurante.Domain.Repository;

namespace Restaurante.Domain
{
    public class Cardapio : IEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public List<AgendaCardapio> agendaCardapios { get; set; }

        public List<Prato> Pratos { get; set; }
    }
}
