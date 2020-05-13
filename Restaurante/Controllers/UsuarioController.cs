using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application;

namespace Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController
    {

        private readonly IUsuarioApplication _app;

        public UsuarioController(IUsuarioApplication app)
        {
            _app = app;
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] UsuarioViewModel user)
        {
            return await _app.InsertUser(user);
        }

        [HttpPost("Login")]
        public async Task<string> Login(LoginViewModel login)
        {
            return await _app.Login(login);
        }
    }
}
