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

        public void AntalÅrstider()
        {
            int antalVinter = 0;
            int antalForår = 0;
            int antalSommer = 0;
            int antalEfterår = 0;
            foreach (var s in KlasseListe)
            {
                switch (s.Fødselsdagsmåned)
                {
                    case 12:
                    case 1:
                    case 2:
                        antalVinter++;
                        break;
                    case 3:
                    case 4:
                    case 5:
                        antalForår++;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        antalSommer++;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        antalEfterår++;
                        break;
                    default:
                        throw new ArgumentException("Fejl i måned");
                }
            }

            Console.WriteLine($"{antalVinter} elever om vinteren, {antalForår} om foråret, {antalSommer} om sommeren og {antalEfterår} om efteråret");
        }

    }
}
