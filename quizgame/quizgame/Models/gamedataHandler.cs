using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quizgame.Data;
using quizgame.DataStructures;

namespace quizgame.Models
{
    internal class gamedataHandler
    {
        DataHandler dh =new DataHandler();
        gamedata g;
        public gamedataHandler()
        {
            SetData();
        }
        
        public gamedata  SetData()
        {

            int histornumb = 0;
            int geonumb = 0;
            int chemnumb = 0;
            int mathnumb = 0;
            int maxx = 0;
            int minn = dh.Adatok[0].Valasz;
            int questionnumb = dh.Adatok.Count;

            foreach (DataHandler d in dh.Adatok)
            {
                switch (dh.Temakor)
                {
                    case "tortenelem": histornumb++; break;
                    case "foldrajz": geonumb++; break;
                    case "kemia": chemnumb++; break;
                    case "matematika": mathnumb++; break;
                }
            }

            foreach (DataHandler d in dh.Adatok)
            {
                if (d.Valasz > maxx)
                {
                    maxx = d.Valasz;
                }
                if (d.Valasz < minn)
                {
                    minn = d.Valasz;
                }
            }


            g = new gamedata(questionnumb, mathnumb, geonumb, chemnumb, histornumb, minn, maxx);
            return g;
        }

        public List<string> Topicload()
        {
            List<string> g = new List<string>();
            foreach (DataHandler d in dh.Adatok)
            {
                if (!g.Contains(d.Temakor))
                {
                    g.Add(d.Temakor);
                }
            }


            return g;
        }

        public void Exam(string topic)
        {
            int kerdesdb = 0;
            int hanyadik = 0;
            string text;
            foreach (DataHandler d in dh.Adatok)
            {
                if (topic == d.Temakor)
                {
                    kerdesdb++;
                }
            }
            Random rnd = new Random();
            int rnd2=rnd.Next(kerdesdb);
            foreach (DataHandler d in dh.Adatok)
            {
                if(d.Temakor == topic)
                {
                    hanyadik++;
                    if(hanyadik == rnd2)
                    {
                        g.Question = d.Kerdes;
                        g.Answer = d.Valasz;
                    }
                }
            }

        }

        public string ertekeles(int valasz)
        {
            string text;
            if (valasz == g.Answer)
            {
                text = "A válasz helyes!";
            }
            else
            {
                text = $"Rossz választ adtál \nA helyes válasz {g.Answer} lett volna!";
            }
            return text;
        }


    }
}
