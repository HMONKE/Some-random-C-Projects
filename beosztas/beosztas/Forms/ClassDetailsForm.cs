using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using beosztas.Models;
using beosztas.DataStructures;
using beosztas.Data;

namespace beosztas.Forms
{
    public partial class ClassDetailsForm : Form
    {
        ClassDetailsHandler cd=new ClassDetailsHandler();
        DataHandler dt=new DataHandler();

        public ClassDetailsForm()
        {
            InitializeComponent();
        }

        private void ClassDetailsForm_Load(object sender, EventArgs e)
        {
            lblosszora.Text = "";
            List<string> cl = cd.SetClasses();
            DisplayElements.DisplayClasses(cl, ref cmbClass);
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DisplayElements.DisplayDetails(dt.Adatok, cmbClass.Text, ref lwiDetails,ref lblosszora);
        }
    }
}
