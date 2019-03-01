using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezelo
{
    class Járat
    {
        public string jaratSzam { get; set; }
        public string repterHonnan { get; set; }
        public string repterHova { get; set; }
        public DateTime indulas { get; set; }
        public int keses { get; set; }

        public Járat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            this.jaratSzam = jaratSzam;
            this.repterHonnan = repterHonnan;
            this.repterHova = repterHova;
            this.indulas = indulas;
            keses = 0;
        }
    }
}
