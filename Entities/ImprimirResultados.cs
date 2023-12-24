using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoLinq.Entities
{
    public class ImprimirResultados
    {
        public struct PrintResultS()
        {
            public DateTime Data;
            public string Home;
            public int GolHome;
            public int GolAway;
            public string Away;
            public int Gols;

            public override string ToString()
            {
                return $"{Data.Date} {Home} {GolHome} {GolAway} {Away} {Gols}";
            }

        }

        public record DadosParaImprimiR()
        {
            public string Data;
            public string Home;
            public int GolHome;
            public int GolAway;
            public string Away;
            public int Gols;

            public override string ToString()
            {
                return $"{Data} {Home} {GolHome} {GolAway} {Away}";
            }
        }
    }
}
