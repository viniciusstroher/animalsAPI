using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimaisAPI.ViewModels;
using animalsDataModel.Model;

namespace AnimaisAPI.AppCode
{
    public class AutoMapperConfig
    {
        private static bool IsRegistered { get; set; }

        public static void Register()
        {
            if (IsRegistered)
                return;

            //Adicionar todos maps de models para Application.ViewModels
            AutoMapper.Mapper.CreateMap<TipoAnimalViewModel, TipoAnimal>().ReverseMap();
            AutoMapper.Mapper.CreateMap<EstadoAnimalViewModel, EstadoAnimal>().ReverseMap();
            AutoMapper.Mapper.CreateMap<SituacaoAnimalViewModel, SituacaoAnimal>().ReverseMap();
            AutoMapper.Mapper.CreateMap<RegistroAnimalViewModel, RegistroAnimal>().ReverseMap();

            IsRegistered = true;
        }
    }
}
