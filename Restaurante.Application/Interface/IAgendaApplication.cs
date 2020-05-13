using System;
using System.Collections.Generic;

namespace Restaurante.Application
{
    public interface IAgendaApplication
    {
        void Insert(AgendaViewModel entity);

        void Update(AgendaViewModel entity);

        AgendaViewModel GetById(int id);

        void Delete(int id);

        List<AgendaViewModel> GetAll();
    }
}
