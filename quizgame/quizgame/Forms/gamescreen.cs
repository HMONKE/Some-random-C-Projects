using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quizgame.Data;
using quizgame.DataStructures;
using quizgame.Models;

namespace quizgame.Forms
{
    public partial class gamescreen : Form
    {
        private gamedataHandler gh=new gamedataHandler();
        public gamescreen()
        {
            InitializeComponent();
        }

        private void gamescreen_Load(object sender, EventArgs e)
        {
            gamedata g = gh.SetData();
            List<string> topics=gh.Topicload();
            DisplayElements.Showinformation(g.MinvaluofAnswer,g.MaxvaluofAnswer,g.NumberofQuestions, ref lblnumbers);
            DisplayElements.ShowTopic(topics, ref cmbCategory);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAnswer.Text = "";
            lblCheck.Text = "";
            gamedata g = gh.SetData();
            gh.Exam(cmbCategory.SelectedItem.ToString());
            DisplayElements.ShowExam(g.Question, ref lblquestion);
        }

        private void btnValasz_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "")
            {
                MessageBox.Show("Kérem adjon választ a kérdésre!");
            }
            else
            {
                DisplayElements.ShowAnswer(gh.ertekeles(int.Parse(txtAnswer.Text)),ref lblCheck);
            }
        }

        private void btnlngGame_Click(object sender, EventArgs e)
        {
            LongGame lng=new LongGame();
            lng.Show();
        }
    }
}
