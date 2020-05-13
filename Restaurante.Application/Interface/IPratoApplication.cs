using System;
using System.Collections.Generic;

namespace Restaurante.Application
{
    public interface IPratoApplication
    {
        void Insert(PratoViewModel entity);

        void Update(PratoViewModel entity);

        PratoViewModel GetById(int id);

        void Delete(int id);

        List<PratoViewModel> GetAll();
    }
}
