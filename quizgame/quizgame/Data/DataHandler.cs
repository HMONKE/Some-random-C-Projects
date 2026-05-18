using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace quizgame.Data
{
     class DataHandler
    {
        private string kerdes;
        private int valasz;
        private int pont;
        private string temakor;
        private List<DataHandler> adatok=new List<DataHandler>();
        private int numberofQuestions;

        public string Kerdes
        {
            get { return kerdes; }
        }

        public int Valasz
        {
            get { return valasz; }
        }

        public int Pont
        {
            get { return pont; }
        }

        public string Temakor
        {
            get { return temakor; }
        }

        public List<DataHandler> Adatok
        {
            get { return adatok; }
        }

        public int NumberofQuestions { get { return numberofQuestions; } }

        public DataHandler(string kerdes, int valasz, int pont, string temakor)
        {
            this.kerdes = kerdes;
            this.valasz = valasz;
            this.pont = pont;
            this.temakor = temakor;
        }
        public DataHandler(int numberofquestions)
        {
            this.numberofQuestions = numberofquestions;

        }

        public DataHandler()
        {
            Beolvas("felszam.txt");
            SetData();
        }

        private List<DataHandler> Beolvas(string fname)
        {


            StreamReader sr = new StreamReader(fname);
            string[] tmb;
            while (!sr.EndOfStream)
            {
                kerdes = sr.ReadLine();
                tmb = sr.ReadLine().Split();
                valasz = int.Parse(tmb[0]);
                pont = int.Parse(tmb[1]);
                temakor = tmb[2];
                DataHandler dh = new DataHandler(kerdes, valasz, pont, temakor);
                adatok.Add(dh);
            }
            sr.Close();
            return adatok;
        }


        public void SetData()
        {
            numberofQuestions=Adatok.Count;
        }





    }
}
