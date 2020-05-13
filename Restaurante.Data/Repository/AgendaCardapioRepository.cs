using System;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Data.Repository
{
    public class AgendaCardapioRepository : RepositoryBase<AgendaCardapio>, IAgendaCardapioRepository
    {
        public AgendaCardapioRepository(Context context) : base(context)
        {
        }
    }
}
