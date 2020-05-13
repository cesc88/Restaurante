using System.Collections.Generic;
using AutoMapper;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Application
{
    public class TipopratoApplication : ITipoPratoApplication
    {
        private readonly ITipoPratoRepository _repo;

        private readonly IMapper _mapper;

        public TipopratoApplication(ITipoPratoRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<TipoPratoViewModel> GetAll()
        {
            return _mapper.Map<List<TipoPratoViewModel>>(_repo.GetAll());
        }

        public TipoPratoViewModel GetById(int id)
        {
            return _mapper.Map<TipoPratoViewModel>(_repo.GetById(id));
        }

        public void Insert(TipoPratoViewModel entity)
        {
            _repo.Insert(_mapper.Map<TipoPrato>(entity));
        }

        public void Update(TipoPratoViewModel entity)
        {
            _repo.Update(_mapper.Map<TipoPrato>(entity));
        }
    }
}
