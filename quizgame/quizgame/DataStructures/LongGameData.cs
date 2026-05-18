using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quizgame.Data;
using quizgame.DataStructures;

namespace quizgame.DataStructures
{
    internal class LongGameData
    {

        private string kerdes;
        private int valasz;
        private int pontok;
        private int szerzettpont;
        private List<LongGameData> kerdesek = new List<LongGameData>();


        public string Kerdes
        {
            get { return kerdes; }
        }
        public int Valasz { get { return valasz; } }
        public int Pontok { get { return pontok; } }
        public int Szerzettpont { get { return szerzettpont; } set { szerzettpont = value; } }
        public List<LongGameData> Kerdesek { get { return kerdesek; } set { kerdesek = value; } }

        public LongGameData()
        {

        }
        public LongGameData(string kerdes, int valasz, int pontok)
        {
            this.kerdes = kerdes;
            this.valasz = valasz;
            this.pontok = pontok;
        }
    }
}
