using System.Collections.Generic;
using AutoMapper;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Application
{
    public class IngredienteApplication : IIngredienteApplication
    {

        private readonly IIngredienteRepository _repo;

        private readonly IMapper _mapper;

        public IngredienteApplication(IIngredienteRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<IngredienteViewModel> GetAll()
        {
            return _mapper.Map<List<IngredienteViewModel>>(_repo.GetAll());
        }

        public IngredienteViewModel GetById(int id)
        {
            return _mapper.Map<IngredienteViewModel>(_repo.GetById(id));
        }

        public void Insert(IngredienteViewModel entity)
        {
            _repo.Insert(_mapper.Map<Ingrediente>(entity));
        }

        public void Update(IngredienteViewModel entity)
        {
            _repo.Update(_mapper.Map<Ingrediente>(entity));
        }
    }
}
