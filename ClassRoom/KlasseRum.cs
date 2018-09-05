using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> KlasseListe { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            KlasseListe = new List<Studerende>();
        }
        /* Der skal nu implementeres en metode som tæller op for klassen hvor mange der har fødselsdag i hver årstid. Denne metode returnerer ikke noget, men skal bare skrive resultatet ud i konsollen 
           Hvor skal denne metode ligge ?
           
           hint. se om du kan kode det via et linq statement
           
           Kald metoden.
           
           Husk at comitte og pushe til Git repo (GitHub). :octocat:*/

        public void PrintÅrstider()
        {
            foreach (var student in KlasseListe)
            {
                Console.WriteLine(student.Årstid());
            }
        }

    }
}
