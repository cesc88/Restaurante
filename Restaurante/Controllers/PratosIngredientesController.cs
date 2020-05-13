using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application;

namespace Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratosIngredientesController : ControllerBase
    {
        private readonly IPratosIngredientesApplication _app;

        public PratosIngredientesController(IPratosIngredientesApplication app)
        {
            _app = app;
        }

        [HttpGet]
        public IEnumerable<PratosIngredientesViewModel> Get()
        {
            return _app.GetAll();
        }

        [HttpGet("{id}")]
        public PratosIngredientesViewModel Get(int id)
        {
            return _app.GetById(id);
        }

        [HttpPost]
        public ActionResult<PratosIngredientesViewModel> Post([FromBody] PratosIngredientesViewModel pratosIngredientes)
        {
            _app.Insert(pratosIngredientes);
            return Ok(pratosIngredientes);
        }

        [HttpPut]
        public PratosIngredientesViewModel Put([FromBody] PratosIngredientesViewModel pratosIngredientes)
        {
            _app.Update(pratosIngredientes);
            return pratosIngredientes;
        }

        [HttpDelete("{id}")]
        public List<PratosIngredientesViewModel> Delete(int id)
        {
            _app.Delete(id);
            return _app.GetAll();
        }
    }
}
