using System;

namespace Nomenclatures
{
    public class MatierePremiere : IComponent
    {
        public string Nom { get; set; }

        public int Id { get; set; }

        public string Description { get; set; }

        public TimeSpan? DureeConservation { get; set; }

        public FamilleMatierePremiere Famille { get; set; }
        public TimeSpan? DureeOptimaleUtilisation 
        { 
            get
            {
                if (Famille != null) return Famille.DureeOptimaleUtilisation;
                return null;
            }
        }

    }
}