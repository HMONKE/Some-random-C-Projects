using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using beosztas.Data;
using beosztas.DataStructures;

namespace beosztas.Models
{
    internal class mainformHandler
    {
        DataHandler dh=new DataHandler();


        public int Tanarszam()
        {
            List<string> tanarok=new List<string>();
            foreach (DataHandler d in dh.Adatok)
            {
                if (!tanarok.Contains(d.Tanar))
                {
                    tanarok.Add(d.Tanar);
                }
            }

            int tanardb=tanarok.Count;
            return tanardb;
        }
        public int Oraszam()
        {
            int oraszam=0;
            foreach (DataHandler d in dh.Adatok)
            {
                oraszam += d.Alkalom;
            }

            return oraszam;
        }

        public List<string> Tanarok()
        {
            List<string> Tanarok=new List<string>();

            foreach (DataHandler d in dh.Adatok)
            {
                if (!Tanarok.Contains(d.Tanar))
                {
                    Tanarok.Add(d.Tanar);
                }
            }

            return Tanarok;
        }


    }
}
