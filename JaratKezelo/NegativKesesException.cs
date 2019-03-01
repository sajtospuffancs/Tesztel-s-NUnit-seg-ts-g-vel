using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezelo
{
    class NegativKesesException : Exception
    {

        public NegativKesesException(int keses) : base("Hibás késés: " + keses)
        {
        }

    }
}
