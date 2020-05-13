using System;
using System.Collections.Generic;

namespace Restaurante.Application
{
    public interface IAgendaCardapioApplication
    {
        void Insert(AgendaCardapioViewModel entity);

        void Update(AgendaCardapioViewModel entity);

        AgendaCardapioViewModel GetById(int id);

        void Delete(int id);

        List<AgendaCardapioViewModel> GetAll();
    }
}
