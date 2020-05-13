using System;
using System.Collections.Generic;

namespace Restaurante.Application
{
    public interface ITipoPratoApplication
    {
        void Insert(TipoPratoViewModel entity);

        void Update(TipoPratoViewModel entity);

        TipoPratoViewModel GetById(int id);

        void Delete(int id);

        List<TipoPratoViewModel> GetAll();
    }
}
