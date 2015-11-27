using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalsDataModel.Model
{
    public class SaveAPetEntitiesDBInitializer : DropCreateDatabaseAlways<SaveAPetEntities>
    {
        protected override void Seed(SaveAPetEntities context)
        {
            try {
                IList<TipoAnimal> tpAnimal = new List<TipoAnimal>();

                tpAnimal.Add(new TipoAnimal() { Nome = "Gato" });
                tpAnimal.Add(new TipoAnimal() { Nome = "Cachorro" });

                foreach (TipoAnimal ta in tpAnimal)
                    context.TipoAnimal.Add(ta);



                IList<SituacaoAnimal> stdAnimal = new List<SituacaoAnimal>();

                stdAnimal.Add(new SituacaoAnimal() { Nome = "Fome" });
                stdAnimal.Add(new SituacaoAnimal() { Nome = "Doente" });
                stdAnimal.Add(new SituacaoAnimal() { Nome = "Assustado" });
                stdAnimal.Add(new SituacaoAnimal() { Nome = "Brabo" });

                foreach (SituacaoAnimal st in stdAnimal)
                    context.SituacaoAnimal.Add(st);






                context.SaveChanges();
               

                base.Seed(context);
            }catch(Exception e)
            {
                Debug.WriteLine("Bug: "+e.Message);
            }
        }
    }
}
