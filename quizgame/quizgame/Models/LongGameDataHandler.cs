using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quizgame.Data;
using quizgame.DataStructures;

namespace quizgame.Models
{
    internal class LongGameDataHandler
    {

        DataHandler dh=new DataHandler();
        LongGameData lg;
        int vel;
        string kerdes;
        int valasz;
        int pontok;

        public LongGameDataHandler()
        {
            Uploads();
        }


        public List<LongGameData> Uploads()
        {

            List<int> velszam=new List<int>();
            List<LongGameData> adatok=new List<LongGameData>();
            int db = dh.NumberofQuestions;

            Random rand = new Random();

            //while (adatok.Count!=10)
            //{
            //    vel = rand.Next(db);
            //    kerdes = dh.Adatok[vel].Kerdes;
            //    valasz = dh.Adatok[vel].Valasz;
            //    pontok = dh.Adatok[vel].Pont;
            //    lg = new LongGameData(kerdes, valasz, pontok);
            //    if (!adatok.Contains(lg))
            //    {
            //        adatok.Add(lg);
            //    }

            //}

            for (int i = 0; i < 10; i++)
            {
                vel = rand.Next(db);
                if (!velszam.Contains(vel))
                {
                    kerdes = dh.Adatok[vel].Kerdes;
                    valasz = dh.Adatok[vel].Valasz;
                    pontok = dh.Adatok[vel].Pont;
                    lg = new LongGameData(kerdes,valasz,pontok);
                    adatok.Add(lg);
                    velszam.Add(vel);
                }
                else
                {
                    i--;
                }
            }
            return adatok;
        }


    }
}
