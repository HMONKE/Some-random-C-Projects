using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizgame.DataStructures;
using quizgame.Data;

namespace quizgame.Models
{
    internal class DisplayElements
    {

        public static void Showinformation(int min, int maxx,int numberOfQuestons, ref Label lblnumbers)
        {
                Label lbl = new Label();
                lbl.Text = $"Válaszadás értéke:{min}-{maxx} között lehetséges\n" +
                    $"A fájl összesen {numberOfQuestons} db kérdést tartalmaz\n";
                lblnumbers.Text = lbl.Text;
        }


        public static void ShowTopic(List<string> s, ref ComboBox cmbCategory)
        {

            foreach (string sl in s)
            {
                cmbCategory.Items.Add(sl);
            }
        }

        public static void ShowExam(string kerdes, ref Label lblquestion)
        {
            lblquestion.Text = kerdes;
        }
        public static void ShowAnswer(string valasz, ref Label lblCheck)
        {
            lblCheck.Text = valasz;
        }

        public static void ShowQuestions(string kerdes, ref Label lbl)
        {
                lbl.Text = kerdes;
        }
        public static void CheckAnswer(List<LongGameData> l,List<int> valaszok, ref Label lbl)
        {
            int helyesvalasz = 0;
            int osszpont = 0;
            foreach (LongGameData g in l)
            {
                osszpont += g.Pontok;
            }


            if (l[0].Valasz == valaszok[0])
            {
                helyesvalasz+=l[0].Pontok;
            }
            if (l[1].Valasz == valaszok[1])
            {
                helyesvalasz += l[1].Pontok;
            }
            if (l[2].Valasz == valaszok[2])
            {
                helyesvalasz += l[2].Pontok;
            }
            if (l[3].Valasz == valaszok[3])
            {
                helyesvalasz += l[3].Pontok;
            }
            if (l[4].Valasz == valaszok[4])
            {
                helyesvalasz += l[4].Pontok;
            }
            if (l[5].Valasz == valaszok[5])
            {
                helyesvalasz += l[5].Pontok;
            }
            if (l[6].Valasz == valaszok[6])
            {
                helyesvalasz += l[6].Pontok;
            }
            if (l[7].Valasz == valaszok[7])
            {
                helyesvalasz += l[7].Pontok;
            }
            if (l[8].Valasz == valaszok[8])
            {
                helyesvalasz += l[8].Pontok;
            }
            if (l[9].Valasz == valaszok[9])
            {
                helyesvalasz += l[9].Pontok;
            }

            lbl.Text =Convert.ToString($"{osszpont}/{helyesvalasz}");

        }





    }
}
