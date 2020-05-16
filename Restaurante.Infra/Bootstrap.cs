using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Restaurante.Domain.Repository;
using Restaurante.Data.Repository;
using Restaurante.Application;
using Restaurante.Data;

namespace Restaurante.Infra
{
    public class Bootstrap
    {
        public static void ServiceRegister(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IAgendaRepository, AgendaRepository>();
            services.AddScoped<IAgendaCardapioRepository, AgendaCardapioRepository>();
            services.AddScoped<ICardapioRepository, CardapioRepository>();
            services.AddScoped<IIngredienteRepository, IngredienteRepository>();
            services.AddScoped<IPratosIngredientesRepository, PratosIngredientesRepository>();
            services.AddScoped<IPratoRepository, PratoRepository>();
            services.AddScoped<ITipoPratoRepository, TipoPratoRepository>();

            services.AddScoped<IAgendaApplication, AgendaApplication>();
            services.AddScoped<IAgendaCardapioApplication, AgendaCardapioApplication>();
            services.AddScoped<ICardapioApplication, CardapioApplication>();
            services.AddScoped<IIngredienteApplication, IngredienteApplication>();
            services.AddScoped<IPratosIngredientesApplication, PratosIngredientesApplication>();
            services.AddScoped<IPratoApplication, PratoApplication>();
            services.AddScoped<ITipoPratoApplication, TipopratoApplication>();
            services.AddScoped<IUsuarioApplication, UsuarioApplication>();

            services.AddDbContext<Context>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("MyConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<Context>();
        }
    }
}
