using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beosztas.DataStructures
{
    internal class Osztalyfonok
    {
        private string name;
        private string classs;

        public string Name
        {
            get { return name; }
        }

        public string Classs
        {
            get { return classs; }
        }

        public Osztalyfonok(string name, string classs)
        {
            this.name = name;
            this.classs = classs;
        }
    }
}
