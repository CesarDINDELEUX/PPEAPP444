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
    
    public partial class cadeau
    {
        public int id { get; set; }
        public Nullable<int> quizz_id { get; set; }
        public string Intitule { get; set; }
        public string Url_img { get; set; }
    
        public virtual quizz quizz { get; set; }
    }
}
