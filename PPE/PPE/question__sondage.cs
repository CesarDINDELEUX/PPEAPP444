//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE
{
    using System;
    using System.Collections.Generic;
    
    public partial class question__sondage
    {
        public question__sondage()
        {
            this.reponse__sondage = new HashSet<reponse__sondage>();
        }
    
        public int id { get; set; }
        public Nullable<int> sondage_id { get; set; }
        public string Intitule { get; set; }
    
        public virtual ICollection<reponse__sondage> reponse__sondage { get; set; }
        public virtual sondage sondage { get; set; }
    }
}
