using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {

              KlasseRum klasse = new KlasseRum();
            klasse.KlasseNavn = "3B";
            klasse.SemesterStart = DateTime.Parse("04-09-2018");
            klasse.KlasseListe.Add(new Studerende("Kevin", 11, 93));
            klasse.KlasseListe.Add(new Studerende("Michael", 1, 91));


        }
    }
}
