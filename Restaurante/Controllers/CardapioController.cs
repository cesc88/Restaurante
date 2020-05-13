using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application;

namespace Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardapioController : ControllerBase
    {
        private readonly ICardapioApplication _app;

        public CardapioController(ICardapioApplication app)
        {
            _app = app;
        }

        [HttpGet]
        public IEnumerable<CardapioViewModel> Get()
        {
             return _app.GetAll();
        }

        [HttpGet("{id}")]
        public CardapioViewModel Get(int id)
        {
            return _app.GetById(id);
        }

        [HttpPost]
        public CardapioViewModel Post([FromBody] CardapioViewModel cardapio)
        {
            _app.Insert(cardapio);
            return cardapio;
        }

        [HttpPut]
        public CardapioViewModel Put([FromBody] CardapioViewModel cardapio)
        {
            _app.Update(cardapio);
            return cardapio;
        }

        [HttpDelete("{id}")]
        public List<CardapioViewModel> Delete(int id)
        {
            _app.Delete(id);
            return _app.GetAll();
        }
    }
}
