using System;
using System.Collections.Generic;
using Restaurante.Domain.Repository;

namespace Restaurante.Domain
{
    public class PratosIngredientes : IEntity
    {

        public int IdPrato { get; set; }

        public Prato Prato { get; set; }

        public int IdIngrediente { get; set; }

        public Ingrediente Ingrediente { get; set; }

        public int Id { get; set; }
    }
}
