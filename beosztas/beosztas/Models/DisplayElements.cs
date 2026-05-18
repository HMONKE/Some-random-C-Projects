using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using beosztas.Data;
using beosztas.DataStructures;

namespace beosztas.Models
{
    internal class DisplayElements
    {
        public static void ShowBasics(int tanardb, int oraszamdb, ref Label lbl)
        {
            lbl.Text = $"Az iskolában összesen {tanardb} tanár dolgozik, {oraszamdb} óraszámban. ";
        }
        public static void ShowTeachers(List<string> tanarok, ref ComboBox cmb )
        {
            foreach (string s in tanarok)
            {
                cmb.Items.Add(s);
            }
        }
        public static void ShowTeacherDetails(List<DataHandler> reszletek,string nev, ref Label lbl )
        {
            lbl.Text = "";
            foreach (DataHandler s in reszletek)
            {
                if (s.Tanar == nev)
                {
                    lbl.Text += $"{s.Tantargy} {s.Osztaly} {s.Alkalom}\n";
                }
            }
        }

        public static void DisplayOf(List<Osztalyfonok> of, ref Label lbl)
        {
            foreach (Osztalyfonok o in of)
            {
                lbl.Text += $"{o.Classs} - {o.Name}\n";
            }
        }

        public static void DisplayClasses(List<string> classes, ref ComboBox cb)
        {
            foreach (string i in classes)
            {
                cb.Items.Add(i);
            }
        }

        public static void DisplayDetails(List<DataHandler>dh,string classs,ref ListView lwi, ref Label lbl)
        {
            int oraossz = 0;
            lbl.Text = "";
            lwi.Items.Clear();
            foreach (DataHandler d in dh)
            {
                if (classs == d.Osztaly)
                {
                    ListViewItem lvi= new ListViewItem(Convert.ToString(d.Tantargy));
                    lvi.SubItems.Add(Convert.ToString(d.Tanar));
                    lvi.SubItems.Add(Convert.ToString(d.Alkalom));
                    lwi.Items.Add(lvi);
                    oraossz += d.Alkalom;
                }
            }
            lbl.Text =$"A {classs} osztálynak heti {oraossz.ToString()} órája van!" ;
        }
    }
}
