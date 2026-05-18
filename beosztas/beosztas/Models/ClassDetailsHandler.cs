using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using beosztas.Data;
using beosztas.DataStructures;

namespace beosztas.Models
{
    internal class ClassDetailsHandler
    {
        DataHandler dh=new DataHandler();
        ClassDetails cd;


        public List<ClassDetails> SetList()
        {
            List<ClassDetails> list= new List<ClassDetails>();

            foreach (DataHandler d in dh.Adatok)
            {
                cd = new ClassDetails(d.Tantargy, d.Tanar, d.Alkalom);
                list.Add(cd);
            }


            return list;
        }

        public List<string> SetClasses()
        {
            List<string> list= new List<string>();
            foreach (DataHandler d in dh.Adatok)
            {
                if(!list.Contains(d.Osztaly))
                list.Add(d.Osztaly);
            }
            return list;
        }


    }
}
