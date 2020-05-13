using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application;

namespace Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {

        private readonly IAgendaApplication _app;

        public AgendaController(IAgendaApplication app)
        {
            _app = app;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<AgendaViewModel> Get()
        {
            return _app.GetAll();
        }

        [HttpGet("{id}")]
        public AgendaViewModel Get(int id)
        {
             return _app.GetById(id);
        }

        [HttpPost]
        public AgendaViewModel Post([FromBody] AgendaViewModel agenda)
        {
            _app.Insert(agenda);
            return agenda;
        }

        [HttpPut]
        public AgendaViewModel Put([FromBody] AgendaViewModel agenda)
        {
            _app.Update(agenda);
            return agenda;
        }

        [HttpDelete("{id}")]
        public List<AgendaViewModel> Delete(int id)
        {
            _app.Delete(id);
            return _app.GetAll();
        }
    }
}
