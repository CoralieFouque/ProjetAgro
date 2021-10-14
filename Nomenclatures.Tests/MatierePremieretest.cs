using NUnit.Framework;
using System.Linq;
using System;

namespace Nomenclatures
{
    public class MatierePremiereTest
    {
        [Test]
        public void Ajout_matiere_premiere_BD()
        {
            using (var db = new NomenclaturesContext())
            {
                var newMatierePremiere = new MatierePremiere{
                    Nom = "chocolat",
                    Description = "coucou",
                    PourcentageHumidite = 50,
                    PoidsUnitaire = 1,
                    DureeConservation = TimeSpan.FromHours(10),
                    
                };
                db.MatierePremiere.Add(newMatierePremiere);
                db.SaveChanges();

                var MatierePremieres = db.MatierePremiere.ToList();
                var MP = MatierePremieres[0];
                db.Remove(MatierePremieres[0]);
                db.SaveChanges();

                Assert.AreEqual(MatierePremieres[0], newMatierePremiere);
            }
        }

    }
}