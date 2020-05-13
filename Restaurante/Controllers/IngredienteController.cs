using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application;

namespace Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {

        private readonly IIngredienteApplication _app;

        public IngredienteController(IIngredienteApplication app)
        {
            _app = app;
        }

        [HttpGet]
        public IEnumerable<IngredienteViewModel> Get()
        {
            return _app.GetAll();
        }

        [HttpGet("{id}")]
        public IngredienteViewModel Get(int id)
        {
            return _app.GetById(id);
        }

        [HttpPost]
        public IngredienteViewModel Post([FromBody] IngredienteViewModel ingrediente)
        {
            _app.Insert(ingrediente);
            return ingrediente;
        }

        [HttpPut]
        public IngredienteViewModel Put([FromBody] IngredienteViewModel ingrediente)
        {
            _app.Update(ingrediente);
            return ingrediente;
        }

        [HttpDelete("{id}")]
        public List<IngredienteViewModel> Delete(int id)
        {
            _app.Delete(id);
            return _app.GetAll();
        }

    }
}
