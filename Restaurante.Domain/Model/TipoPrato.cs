using System;
using System.Collections.Generic;
using Restaurante.Domain.Repository;

namespace Restaurante.Domain
{
    public class TipoPrato : IEntity
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public List<Prato> Pratos { get; set; }
    }
}
