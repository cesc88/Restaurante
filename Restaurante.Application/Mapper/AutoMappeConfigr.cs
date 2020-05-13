using System;
using AutoMapper;
using Restaurante.Domain;

namespace Restaurante.Application.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(x => x.AllowNullCollections = true);
        }

        public AutoMapperConfig()
        {
            CreateMap<Agenda, AgendaViewModel>().ReverseMap();
            CreateMap<AgendaCardapio, AgendaCardapioViewModel>().ReverseMap();
            CreateMap<Cardapio, CardapioViewModel>().ReverseMap();
            CreateMap<Ingrediente, IngredienteViewModel>().ReverseMap();
            CreateMap<PratosIngredientes, PratosIngredientesViewModel>().ReverseMap();
            CreateMap<Prato, PratoViewModel>().ReverseMap();
            CreateMap<TipoPrato, TipoPratoViewModel>().ReverseMap();
        }
    }
}
