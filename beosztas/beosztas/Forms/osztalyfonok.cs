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
using beosztas.DataStructures;
using beosztas.Models;

namespace beosztas.Forms
{
    public partial class osztalyfonok : Form
    {
        OsztalyfonokHandler oh=new OsztalyfonokHandler();
        public osztalyfonok()
        {
            InitializeComponent();
        }

        private void osztalyfonok_Load(object sender, EventArgs e)
        {
            lblof.Text = "";
            List<Osztalyfonok> o=oh.SetList();
            DisplayElements.DisplayOf(o, ref lblof);

        }
    }
}
