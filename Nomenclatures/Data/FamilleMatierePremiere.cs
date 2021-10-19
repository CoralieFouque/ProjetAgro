using System;
using System.ComponentModel.DataAnnotations;

namespace Nomenclatures.Data
{
    public class FamilleMatierePremiere
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        public TimeSpan? DureeOptimaleUtilisation { get; set; }
    }
}