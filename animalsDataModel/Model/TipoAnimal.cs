//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace animalsDataModel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoAnimal
    {
        public TipoAnimal()
        {
            this.RegistroAnimal = new HashSet<RegistroAnimal>();
        }
    
        public int IdTipoAnimal { get; set; }
        public string Nome { get; set; }
    
        public virtual ICollection<RegistroAnimal> RegistroAnimal { get; set; }
    }
}
