using System;
using System.Collections.Generic;

namespace Restaurante.Application
{
    public interface IPratosIngredientesApplication
    {
        void Insert(PratosIngredientesViewModel entity);

        void Update(PratosIngredientesViewModel entity);

        PratosIngredientesViewModel GetById(int id);

        void Delete(int id);

        List<PratosIngredientesViewModel> GetAll();
    }
}
