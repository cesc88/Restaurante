using System;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Data.Repository
{
    public class TipoPratoRepository : RepositoryBase<TipoPrato>, ITipoPratoRepository
    {
        public TipoPratoRepository(Context context) : base(context)
        {
        }
    }
}
