//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proiect_BD.Resources
{
    using System;
    using System.Collections.Generic;
    
    public partial class Potential_client_
    {
        public decimal Lead_ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Task { get; set; }
        public int Caretaker { get; set; }
        public Nullable<System.DateTime> Data_inchiere_contract { get; set; }
    
        public virtual Leads__Ponturi_ Leads__Ponturi_ { get; set; }
        public virtual Utilizatori Utilizatori { get; set; }
    }
}