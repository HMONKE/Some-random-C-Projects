using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizgame.DataStructures;
using quizgame.Models;

namespace quizgame.Forms
{
    public partial class LongGame : Form
    {
        LongGameDataHandler dgh=new LongGameDataHandler();
        List<LongGameData> list;
        public LongGame()
        {
            InitializeComponent();
        }

        private void LongGame_Load(object sender, EventArgs e)
        {
            list = dgh.Uploads();
            DisplayElements.ShowQuestions(list[0].Kerdes, ref lbl1keredes);
            DisplayElements.ShowQuestions(list[1].Kerdes, ref lbl2keredes);
            DisplayElements.ShowQuestions(list[2].Kerdes, ref lbl3keredes);
            DisplayElements.ShowQuestions(list[3].Kerdes, ref lbl4keredes);
            DisplayElements.ShowQuestions(list[4].Kerdes, ref lbl5keredes);
            DisplayElements.ShowQuestions(list[5].Kerdes, ref lbl6keredes);
            DisplayElements.ShowQuestions(list[6].Kerdes, ref lbl7keredes);
            DisplayElements.ShowQuestions(list[7].Kerdes, ref lbl8keredes);
            DisplayElements.ShowQuestions(list[8].Kerdes, ref lbl9keredes);
            DisplayElements.ShowQuestions(list[9].Kerdes, ref lbl10keredes);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            List<int> megoldasok=new List<int>();

            megoldasok.Add(int.Parse(txtvalasz1.Text));
            megoldasok.Add(int.Parse(txtvalasz2.Text));
            megoldasok.Add(int.Parse(txtvalasz3.Text));
            megoldasok.Add(int.Parse(txtvalasz4.Text));
            megoldasok.Add(int.Parse(txtvalasz5.Text));
            megoldasok.Add(int.Parse(txtvalasz6.Text));
            megoldasok.Add(int.Parse(txtvalasz7.Text));
            megoldasok.Add(int.Parse(txtvalasz8.Text));
            megoldasok.Add(int.Parse(txtvalasz9.Text));
            megoldasok.Add(int.Parse(txtvalasz10.Text));

            DisplayElements.CheckAnswer(list, megoldasok, ref lblElertPont);
        }
    }
}
