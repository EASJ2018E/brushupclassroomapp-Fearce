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
            klasse.KlasseListe.Add(new Studerende("Michael", 2, 91));
            klasse.KlasseListe.Add(new Studerende("Michael", 3, 91));
            klasse.KlasseListe.Add(new Studerende("Michael", 1, 91));
            klasse.KlasseListe.Add(new Studerende("Michael", 9, 91));
            klasse.KlasseListe.Add(new Studerende("Michael", 9, 91));
            klasse.KlasseListe.Add(new Studerende("Michael", 9, 91));
            //klasse.KlasseListe.Add(new Studerende("Michael", 13, 91)); //giver exception
            Console.WriteLine("\n printer antallet af årstider");
            klasse.PrintAntalÅrstider(); //
            Console.WriteLine("\n printer årstiderne");
            klasse.PrintÅrstider();
            Console.WriteLine("\n printer antallet af årstider linq");

            klasse.PrintÅrstiderLinq();

            Console.WriteLine("\n printer antallet af årstider linq real tror jeg");
            klasse.PrintÅrstiderLinqReal();
            Console.WriteLine("\n printer de sturendes info");

           
            foreach (var student in klasse.KlasseListe)
            {
                Console.WriteLine(student);
            }


            Console.ReadKey();



        }
    }
}
