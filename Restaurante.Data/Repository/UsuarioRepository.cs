using System;
using Restaurante.Domain.Repository;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Restaurante.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UsuarioRepository(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> InsertUser(string nome, string email, string senha)
        {
            var user = new IdentityUser()
            {
                UserName = nome,
                Email = email,
                EmailConfirmed = true
            };

            var callback = await _userManager.CreateAsync(user, email);

            return callback.Succeeded;
        }

        public async Task<IdentityUser> Login(string email, string senha)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null &&
                await _userManager.CheckPasswordAsync(user, senha))
            {
                return user;
            }

            return null;
        }
    }
}
