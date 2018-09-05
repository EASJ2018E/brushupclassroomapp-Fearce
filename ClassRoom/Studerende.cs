﻿using System;
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

        public string Årstid()
        {
            switch (Fødselsdagsmåned)
            {
                case 12:
                case 1:
                case 2:
                    return "Vinter";
                case 3:
                case 4:
                case 5:
                    return "Forår";
                case 6:
                case 7:
                case 8:
                    return "Sommer";
                case 9:
                case 10:
                case 11:
                    return "Efterår";
                default:
                    return "Fejl i måned";
            }
        }   

        public override string ToString()
        {
            return $"{nameof(Navn)}: {Navn}, {nameof(Fødselsdagsmåned)}: {Fødselsdagsmåned}, {nameof(Fødselsdagsår)}: {Fødselsdagsår}";
        }
    }
}
