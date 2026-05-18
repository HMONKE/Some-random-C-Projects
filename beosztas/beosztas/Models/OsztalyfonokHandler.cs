using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using beosztas.Data;
using beosztas.DataStructures;

namespace beosztas.Models
{
    internal class OsztalyfonokHandler
    {
        DataHandler dh=new DataHandler();
        Osztalyfonok of;

        public List<Osztalyfonok> SetList()
        {
            List<Osztalyfonok> ofl=new List<Osztalyfonok>();

            foreach (DataHandler d in dh.Adatok)
            {
                if (d.Tantargy == "osztalyfonoki")
                {
                    of = new Osztalyfonok(d.Tanar, d.Osztaly);
                    ofl.Add(of);
                }
            }

            return ofl;
        }







    }
}
