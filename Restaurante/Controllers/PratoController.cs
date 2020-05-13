using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application;

namespace Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {

        private readonly IPratoApplication _app;

        public PratoController(IPratoApplication app)
        {
            _app = app;
        }

        [HttpGet]
        public IEnumerable<PratoViewModel> Get()
        {
            return _app.GetAll();
        }

        [HttpGet("{id}")]
        public PratoViewModel Get(int id)
        {
            return _app.GetById(id);
        }

        [HttpPost]
        public ActionResult<PratoViewModel> Post([FromBody] PratoViewModel prato)
        {
            _app.Insert(prato);
            return Ok(prato);
        }

        [HttpPut]
        public ActionResult<PratoViewModel> Put([FromBody] PratoViewModel prato)
        {
            _app.Update(prato);
            return Ok(prato);
        }

        [HttpDelete("{id}")]
        public List<PratoViewModel> Delete(int id)
        {
            _app.Delete(id);
            return _app.GetAll();
        }
    }
}
