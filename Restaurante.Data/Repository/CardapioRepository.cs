using System;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Data.Repository
{
    public class CardapioRepository : RepositoryBase<Cardapio>, ICardapioRepository
    {
        public CardapioRepository(Context context) : base(context)
        {
        }
    }
}
