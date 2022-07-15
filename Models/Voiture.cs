using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence.Models
{
    public class Voiture
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Marque { get; set; }
        public double Prix { get; set; }
        public DateTime Date_ajout { get; set; }
    }
}