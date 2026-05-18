using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using beosztas.Data;
using beosztas.Models;
using beosztas.Forms;

namespace beosztas
{
    public partial class Form1 : Form
    {
        private mainformHandler mh=new mainformHandler();
        DataHandler dh=new DataHandler();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayElements.ShowBasics(mh.Tanarszam(),mh.Oraszam(),ref lblalapadatok);
            DisplayElements.ShowTeachers(mh.Tanarok(),ref cmbTanarok);
        }

        private void cmbTanarok_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayElements.ShowTeacherDetails(dh.Adatok, cmbTanarok.Text, ref lblInfo);
        }

        private void osztályfőnökökToolStripMenuItem_Click(object sender, EventArgs e)
        {
            osztalyfonok form=new osztalyfonok();
            form.ShowDialog();
        }

        private void osztályRészletelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassDetailsForm cd=new ClassDetailsForm();
            cd.ShowDialog();
        }
    }
}
