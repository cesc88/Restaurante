using System.Collections.Generic;
using AutoMapper;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Application
{
    public class AgendaApplication : IAgendaApplication
    {
        private readonly IAgendaRepository _repo;

        private readonly IMapper _mapper;

        public AgendaApplication(IAgendaRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<AgendaViewModel> GetAll()
        {
            return _mapper.Map<List<AgendaViewModel>>(_repo.GetAll());
        }

        public AgendaViewModel GetById(int id)
        {
            return _mapper.Map<AgendaViewModel>(_repo.GetById(id));
        }

        public void Insert(AgendaViewModel entity)
        {
            _repo.Insert(_mapper.Map<Agenda>(entity));
        }

        public void Update(AgendaViewModel entity)
        {
            _repo.Update(_mapper.Map<Agenda>(entity));
        }
    }
}
