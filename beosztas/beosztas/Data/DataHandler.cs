using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace beosztas.Data
{
    internal class DataHandler
    {
        private string tanar;
        private string tantargy;
        private string osztaly;
        private int alkalom;
        private List<DataHandler> adatok = new List<DataHandler>();

        public string Tanar { get { return tanar; } }
        public string Tantargy { get { return tantargy; } }
        public string Osztaly { get { return osztaly; } }
        public int Alkalom { get { return alkalom; } }
        public List<DataHandler> Adatok { get { return adatok; } }



        public DataHandler(string tanar, string tantargy, string osztaly, int alkalom)
        {
            this.tanar=tanar;
            this.tantargy=tantargy;
            this.osztaly=osztaly;
            this.alkalom=alkalom;
        }

        public DataHandler()
        {
            Beolvas();
        }



        private List<DataHandler> Beolvas()
        {
            StreamReader sr = new StreamReader("beosztas.txt");
            while (!sr.EndOfStream)
            {
                DataHandler dh = new DataHandler(sr.ReadLine(),sr.ReadLine(),sr.ReadLine(),int.Parse(sr.ReadLine()));
                adatok.Add(dh);
            }
            sr.Close();
            return adatok;
        }

    }
}
