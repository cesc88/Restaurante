using System;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Data.Repository
{
    public class PratosIngredientesRepository : RepositoryBase<PratosIngredientes>, IPratosIngredientesRepository
    {
        public PratosIngredientesRepository(Context context) : base(context)
        {
        }
    }
}
