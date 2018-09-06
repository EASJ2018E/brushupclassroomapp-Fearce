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

        public void PrintÅrstider()
        {
            foreach (var student in KlasseListe)
            {
                Console.WriteLine(student.Årstid());
            }
        }

        public void PrintAntalÅrstider()
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

            Console.WriteLine(
                $"{antalVinter} elever om vinteren, {antalForår} om foråret, {antalSommer} om sommeren og {antalEfterår} om efteråret");
        }

        public void PrintÅrstiderLinq()
        {
            Console.WriteLine(
                KlasseListe.Count(x => x.Fødselsdagsmåned == 1 || x.Fødselsdagsmåned == 2 || x.Fødselsdagsmåned == 12) +
                " elever om vinteren");
            Console.WriteLine(
                KlasseListe.Count(x => x.Fødselsdagsmåned == 3 || x.Fødselsdagsmåned == 4 || x.Fødselsdagsmåned == 5) +
                " elever om foråret");
            Console.WriteLine(
                KlasseListe.Count(x => x.Fødselsdagsmåned == 6 || x.Fødselsdagsmåned == 7 || x.Fødselsdagsmåned == 8) +
                " elever om sommeren");
            Console.WriteLine(
                KlasseListe.Count(x =>
                    x.Fødselsdagsmåned == 9 || x.Fødselsdagsmåned == 10 || x.Fødselsdagsmåned == 11) +
                " elever om efteråret");

        }

        public void PrintÅrstiderLinqReal()
        {
            var antalVinter = from c in KlasseListe
                where c.Fødselsdagsmåned == 1 || c.Fødselsdagsmåned == 2 || c.Fødselsdagsmåned == 12
                select c;
            var antalForår = from c in KlasseListe
                where c.Fødselsdagsmåned == 3 || c.Fødselsdagsmåned == 4 || c.Fødselsdagsmåned == 5
                select c;
            var antalSommer = from c in KlasseListe
                where c.Fødselsdagsmåned == 6 || c.Fødselsdagsmåned == 7 || c.Fødselsdagsmåned == 8
                select c;
            var antalEfterår = from c in KlasseListe
                where c.Fødselsdagsmåned == 9 || c.Fødselsdagsmåned == 10 || c.Fødselsdagsmåned == 11
                select c;
            Console.WriteLine(antalVinter.Count() + " elever om vinteren");
            Console.WriteLine(antalForår.Count() + " elever om foråret");
            Console.WriteLine(antalSommer.Count() + " elever om sommeren");
            Console.WriteLine(antalEfterår.Count() + " elever om efteråret");
        }
    }
}
