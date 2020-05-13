using System;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Data.Repository
{
    public class PratoRepository : RepositoryBase<Prato>, IPratoRepository
    {
        public PratoRepository(Context context) : base(context)
        {
        }
    }
}
