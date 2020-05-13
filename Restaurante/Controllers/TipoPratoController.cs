using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application;

namespace Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPratoController : ControllerBase
    {

        private readonly ITipoPratoApplication _app;

        public TipoPratoController(ITipoPratoApplication app)
        {
            _app = app;
        }

        [HttpGet]
        public IEnumerable<TipoPratoViewModel> Get()
        {
            return _app.GetAll();
        }

        [HttpGet("{id}")]
        public TipoPratoViewModel Get(int id)
        {
            return _app.GetById(id);
        }


        [HttpPost]
        public ActionResult<TipoPratoViewModel> Post([FromBody] TipoPratoViewModel tipoPrato)
        {
            _app.Insert(tipoPrato);
            return Ok(tipoPrato);
        }

        [HttpPut]
        public TipoPratoViewModel Put([FromBody] TipoPratoViewModel tipoPrato)
        {
            _app.Update(tipoPrato);
            return tipoPrato;
        }

        [HttpDelete("{id}")]
        public List<TipoPratoViewModel> Delete(int id)
        {
            _app.Delete(id);
            return _app.GetAll();
        }
    }
}
