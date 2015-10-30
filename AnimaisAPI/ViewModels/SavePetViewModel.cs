using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaisAPI.ViewModels
{
    public class SavePetViewModel
    {
        public Enums.AnimalTypes animalType { get; set; }

        public Enums.AnimalHealthStatus healthStatus { get; set; }

        public string description { get; set; }

        public string latitude { get; set; }

        public string longitude { get; set; }
    }
}
