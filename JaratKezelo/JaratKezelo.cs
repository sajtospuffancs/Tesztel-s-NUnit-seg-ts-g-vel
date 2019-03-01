using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezelo
{
    public class JaratKezelo
    {
        string jaratSzam;
        string repterHonnan;
        string repterHova;
        DateTime indulas;
        int keses;


        void ujJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            this.jaratSzam = jaratSzam;
            this.repterHonnan = repterHonnan;
            this.repterHova = repterHova;
            this.indulas = indulas;
            keses = 0;
        }

        void Keses(string jaratSzam, int keses)
        {
            this.jaratSzam = jaratSzam;
            this.keses += keses;
        }

        void Keses(string jaratSam, TimeSpan keses)
        {

        }

    }
}
