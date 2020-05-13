using System;
using System.Collections.Generic;

namespace Restaurante.Application
{
    public interface ICardapioApplication
    {
        void Insert(CardapioViewModel entity);

        void Update(CardapioViewModel entity);

        CardapioViewModel GetById(int id);

        void Delete(int id);

        List<CardapioViewModel> GetAll();
    }
}
