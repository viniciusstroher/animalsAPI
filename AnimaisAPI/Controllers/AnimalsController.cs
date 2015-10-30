using AnimaisAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

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

        [HttpPost, Route("SavePetLocation")]
        public void SavePetLocation(SavePetViewModel savePetViewModel) {
            if (savePetViewModel.animalType == Enums.AnimalTypes.Other) {
                savePetViewModel.description = "Outro animal";
            }
        }
    }
}
