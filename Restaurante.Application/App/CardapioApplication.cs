using System.Collections.Generic;
using AutoMapper;
using Restaurante.Domain;
using Restaurante.Domain.Repository;

namespace Restaurante.Application
{
    public class CardapioApplication : ICardapioApplication
    {
        private readonly ICardapioRepository _repo;

        private readonly IMapper _mapper;

        public CardapioApplication(ICardapioRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<CardapioViewModel> GetAll()
        {
            return _mapper.Map<List<CardapioViewModel>>(_repo.GetAll());
        }

        public CardapioViewModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(CardapioViewModel entity)
        {
            _repo.Insert(_mapper.Map<Cardapio>(entity));
        }

        public void Update(CardapioViewModel entity)
        {
            _repo.Update(_mapper.Map<Cardapio>(entity));
        }
    }
}
