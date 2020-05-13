using System;
using System.Threading.Tasks;

namespace Restaurante.Application
{
    public interface IUsuarioApplication
    {
        Task<bool> InsertUser(UsuarioViewModel user);

        Task<string> Login(LoginViewModel login);
    }
}
