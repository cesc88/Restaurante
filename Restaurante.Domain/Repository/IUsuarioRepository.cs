using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Restaurante.Domain.Repository
{
    public interface IUsuarioRepository
    {
        Task<bool> InsertUser(string login, string email, string senha);

        Task<IdentityUser> Login(string email, string senha);
    }
}
