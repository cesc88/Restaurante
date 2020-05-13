using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using Restaurante.Domain.Repository;
using Restaurante.Application.ViewModel;
using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Restaurante.Application.App
{
    public class UsuarioApplication : IUsuarioApplication
    {

        private readonly IUsuarioRepository _repo;

        private readonly Token _token;

        public UsuarioApplication(IUsuarioRepository repo, IOptions<Token> token)
        {
            _repo = repo;
            _token = token?.Value;
        }

        public async Task<bool> InsertUser(UsuarioViewModel user)
        {
            return await _repo.InsertUser(user.Nome, user.Email, user.Senha);
        }

        public async Task<string> Login(LoginViewModel login)
        {
            var user = await _repo.Login(login.Email, login.Senha);
            return GerarToken(user);
        }

        private string GerarToken(IdentityUser user)
        {
            if (user == null) return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_token.Secret);

            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = _token.Emissor,
                Audience = _token.ValidadeEm,
                Expires = DateTime.UtcNow.AddHours(_token.ExpiracaoHoras),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(descriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
