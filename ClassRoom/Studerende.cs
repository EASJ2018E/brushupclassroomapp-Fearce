using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string Navn { get; private set; }
        public int Fødselsdagsmåned { get; private set; }
        public int Fødselsdagsår { get; private set; }

        public Studerende(string navn, int fødselsdagsmåned, int fødselsdagsår)
        {
            Navn = navn;
            Fødselsdagsmåned = fødselsdagsmåned;
            Fødselsdagsår = fødselsdagsår;
        }

        public override string ToString()
        {
            return $"{nameof(Navn)}: {Navn}, {nameof(Fødselsdagsmåned)}: {Fødselsdagsmåned}, {nameof(Fødselsdagsår)}: {Fødselsdagsår}";
        }
    }
}
