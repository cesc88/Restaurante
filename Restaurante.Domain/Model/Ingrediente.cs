using System;
using System.Collections.Generic;
using Restaurante.Domain.Repository;

namespace Restaurante.Domain
{
    public class Ingrediente : IEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime Validade { get; set; }

        public List<PratosIngredientes> PratosIngredientes { get; set; }
    }
}
