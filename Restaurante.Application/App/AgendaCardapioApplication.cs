using System.Collections.Generic;
using AutoMapper;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Application
{
    public class AgendaCardapioApplication : IAgendaCardapioApplication
    {
        private readonly IAgendaCardapioRepository _repo;

        private readonly IMapper _mapper;

        public AgendaCardapioApplication(IAgendaCardapioRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<AgendaCardapioViewModel> GetAll()
        {
            return _mapper.Map<List<AgendaCardapioViewModel>>(_repo.GetAll());
        }

        public AgendaCardapioViewModel GetById(int id)
        {
            return _mapper.Map<AgendaCardapioViewModel>(_repo.GetById(id));
        }

        public void Insert(AgendaCardapioViewModel entity)
        {
            _repo.Insert(_mapper.Map<AgendaCardapio>(entity));
        }

        public void Update(AgendaCardapioViewModel entity)
        {
            _repo.Update(_mapper.Map<AgendaCardapio>(entity));
        }
    }
}
