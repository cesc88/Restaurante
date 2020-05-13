using System.Collections.Generic;
using AutoMapper;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Application
{
    public class PratoApplication : IPratoApplication
    {
        private readonly IPratoRepository _repo;

        private readonly IMapper _mapper;

        public PratoApplication(IPratoRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<PratoViewModel> GetAll()
        {
             return _mapper.Map<List<PratoViewModel>>(_repo.GetAll());
        }

        public PratoViewModel GetById(int id)
        {
            return _mapper.Map<PratoViewModel>(_repo.GetById(id));
        }

        public void Insert(PratoViewModel entity)
        {
            _repo.Insert(_mapper.Map<Prato>(entity));
        }

        public void Update(PratoViewModel entity)
        {
            _repo.Update(_mapper.Map<Prato>(entity));
        }
    }
}
