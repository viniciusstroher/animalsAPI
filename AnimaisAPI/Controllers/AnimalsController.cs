using AnimaisAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using animalsDataModel;

namespace AnimaisAPI.Controllers
{
    //ToDo: Implementar Controller oficialmente
    //ToDo: Integrar com banco de dados
    public class AnimalsController : ApiController
    {
        [HttpGet, Route("GetAllAnimals")]
        public string GetAllAnimals() {
            return "todos os bixos";            
        }

        [HttpPost, Route("GetAllStates")]
        public List<EstadoAnimalViewModel> GetAllStates() {
            List<EstadoAnimalViewModel> listaViewModel;

            using (animalsDataModel.Model.SaveAPetEntities edmx = new animalsDataModel.Model.SaveAPetEntities()) {
                List<animalsDataModel.Model.EstadoAnimal> listaEntity = edmx.EstadoAnimal.ToList();
                listaViewModel = AutoMapper.Mapper.Map<List<EstadoAnimalViewModel>>(listaEntity);
            }

            return listaViewModel;
        }

        [HttpPost, Route("GetAllSituations")]
        public List<SituacaoAnimalViewModel> GetAllSituations()
        {
            List<SituacaoAnimalViewModel> listaViewModel;

            using (animalsDataModel.Model.SaveAPetEntities edmx = new animalsDataModel.Model.SaveAPetEntities())
            {
                List<animalsDataModel.Model.SituacaoAnimal> listaEntity = edmx.SituacaoAnimal.ToList();
                listaViewModel = AutoMapper.Mapper.Map<List<SituacaoAnimalViewModel>>(listaEntity);
            }

            return listaViewModel;
        }

        [HttpPost, Route("GetAllAnimalTipes")]
        public List<TipoAnimalViewModel> GetAllAnimalTipes()
        {
            List<TipoAnimalViewModel> listaViewModel;

            using (animalsDataModel.Model.SaveAPetEntities edmx = new animalsDataModel.Model.SaveAPetEntities())
            {
                List<animalsDataModel.Model.TipoAnimal> listaEntity = edmx.TipoAnimal.ToList();
                listaViewModel = AutoMapper.Mapper.Map<List<TipoAnimalViewModel>>(listaEntity);
            }

            return listaViewModel;
        }

        [HttpPost, Route("SavePetLocation")]
        public void SavePetLocation(RegistroAnimalViewModel savePetViewModel) {

        }
    }
}
