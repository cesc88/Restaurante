using System;
using System.Collections.Generic;

namespace Restaurante.Application
{
    public interface IIngredienteApplication
    {
        void Insert(IngredienteViewModel entity);

        void Update(IngredienteViewModel entity);

        IngredienteViewModel GetById(int id);

        void Delete(int id);

        List<IngredienteViewModel> GetAll();
    }
}
