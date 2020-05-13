using System;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Data.Repository
{
    public class AgendaRepository : RepositoryBase<Agenda>, IAgendaRepository
    {
        public AgendaRepository(Context context) : base(context)
        {
        }
    }
}
