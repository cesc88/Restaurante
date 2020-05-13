using System.Collections.Generic;
using AutoMapper;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Application
{
    public class PratosIngredientesApplication : IPratosIngredientesApplication
    {
        private readonly IPratosIngredientesRepository _repo;

        private readonly IMapper _mapper;

        public PratosIngredientesApplication(IPratosIngredientesRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<PratosIngredientesViewModel> GetAll()
        {
            return _mapper.Map<List<PratosIngredientesViewModel>>(_repo.GetAll());
        }

        public PratosIngredientesViewModel GetById(int id)
        {
            return _mapper.Map<PratosIngredientesViewModel>(_repo.GetById(id));
        }

        public void Insert(PratosIngredientesViewModel entity)
        {
            _repo.Insert(_mapper.Map<PratosIngredientes>(entity));
        }

        public void Update(PratosIngredientesViewModel entity)
        {
            _repo.Update(_mapper.Map<PratosIngredientes>(entity));
        }
    }
}
