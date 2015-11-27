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
    //ToDo: Utilizar RetornoViewModel como padrão
    public class AnimalsController : ApiController
    {
        [HttpGet, Route("GetAllTags")]
        public List<RegistroAnimalViewModel> GetAllTags()
        {
            List<RegistroAnimalViewModel> listaViewModel;

            using (animalsDataModel.Model.SaveAPetEntities edmx = new animalsDataModel.Model.SaveAPetEntities())
            {
                List<animalsDataModel.Model.RegistroAnimal> listaEntity = edmx.RegistroAnimal.ToList();
                listaViewModel = AutoMapper.Mapper.Map<List<RegistroAnimalViewModel>>(listaEntity);
            }

            return listaViewModel;
        }

        [HttpPost, Route("GetAllStates")]
        public List<EstadoAnimalViewModel> GetAllStates()
        {
            List<EstadoAnimalViewModel> listaViewModel;

            using (animalsDataModel.Model.SaveAPetEntities edmx = new animalsDataModel.Model.SaveAPetEntities())
            {
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
        public bool SavePetLocation(RegistroAnimalViewModel registroViewModel)
        {
            try
            {
                using (animalsDataModel.Model.SaveAPetEntities edmx = new animalsDataModel.Model.SaveAPetEntities())
                {
                    animalsDataModel.Model.RegistroAnimal registroEntity = AutoMapper.Mapper.Map<animalsDataModel.Model.RegistroAnimal>(registroViewModel);

                    edmx.RegistroAnimal.Add(registroEntity);
                    edmx.SaveChanges();
                }
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        [HttpPost, Route("UpdatePetLocation")]
        public bool UpdatePetLocation(RegistroAnimalViewModel registroViewModel) {
            try
            {
                using (animalsDataModel.Model.SaveAPetEntities edmx = new animalsDataModel.Model.SaveAPetEntities())
                {
                    animalsDataModel.Model.RegistroAnimal tag = edmx.RegistroAnimal.FirstOrDefault(o => o.IdRegistroAnimal == registroViewModel.IdRegistroAnimal);

                    if (tag == null)
                        return false;

                    tag.Descricao = registroViewModel.Descricao;
                    tag.IdEstadoAnimal = registroViewModel.IdEstadoAnimal;
                    tag.IdSituacaoAnimal = registroViewModel.IdSituacaoAnimal;
                    tag.Latitude = (decimal)registroViewModel.Latitude;
                    tag.Longitude = (decimal)registroViewModel.Longitude;

                    edmx.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
