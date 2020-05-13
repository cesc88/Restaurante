using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application;

namespace Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaCardapioController : ControllerBase
    {
        private readonly IAgendaCardapioApplication _app;

        public AgendaCardapioController(IAgendaCardapioApplication app)
        {
            _app = app;
        }

        [HttpGet]
        public IEnumerable<AgendaCardapioViewModel> Get()
        {
            return _app.GetAll();
        }

        [HttpGet("{id}")]
        public AgendaCardapioViewModel Get(int id)
        {
            return _app.GetById(id);
        }

        [HttpPost]
        public AgendaCardapioViewModel Post([FromBody] AgendaCardapioViewModel agendaCardapio)
        {
            _app.Update(agendaCardapio);
            return agendaCardapio;
        }

        [HttpPut]
        public AgendaCardapioViewModel Put([FromBody] AgendaCardapioViewModel agendaCardapio)
        {
            _app.Update(agendaCardapio);
            return agendaCardapio;
        }

        [HttpDelete("{id}")]
        public List<AgendaCardapioViewModel> Delete(int id)
        {
            _app.Delete(id);
            return _app.GetAll();
        }
    }
}
