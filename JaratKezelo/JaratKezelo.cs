using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezelo
{
    public class JaratKezelo
    {
        public class Járat
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

        public List<Járat> jaratok = new List<Járat>();

        public void ujJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            foreach(Járat sz in jaratok)
            {
                if(sz.jaratSzam.Contains(jaratSzam))
                {
                    throw new ArgumentException();
                }
            }
                jaratok.Add(new Járat(jaratSzam, repterHonnan, repterHova, indulas));
        }
        /// <summary>
        /// késés percben megadandó
        /// </summary>
        /// <param name="jaratSzam"></param>
        /// <param name="keses"></param>
        public void Keses(string jaratSzam, int keses)
        {
            foreach(Járat sz in jaratok)
            {
                if (sz.jaratSzam.Equals(jaratSzam))
                {
                    if (sz.keses - keses < 0)
                    {
                        throw new NegativKesesException(keses);
                    }
                    else
                    {
                        sz.keses += keses;
                    }
                }
            }
        }

        
       /* void Keses(string jaratSam, TimeSpan keses)
        {

        }*/


        public DateTime MikorIndul(string jaratSzam)
        {
            foreach (Járat sz in jaratok)
            {
                if (sz.jaratSzam.Equals(jaratSzam))
                {
                    DateTime pontosindulas = sz.indulas.AddMinutes(sz.keses);
                    return pontosindulas;
                }
                else
                {
                }
            }
            throw new ArgumentException();
        }

        public List<string> JaratokRepuloterrol(string repter)
        {
            List<string> jaratokinnen = new List<string>();
            foreach(Járat sz in jaratok)
            {
                if (sz.repterHonnan.Equals(repter))
                {
                    jaratokinnen.Add(sz.jaratSzam);
                }
            }
            return jaratokinnen;
        }

    }
}
