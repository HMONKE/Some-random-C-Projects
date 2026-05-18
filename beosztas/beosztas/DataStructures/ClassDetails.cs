using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beosztas.DataStructures
{
    internal class ClassDetails
    {
       private string subject;
       private string teacher;
       private int lessonnumber;

        public string Subject
        {
            get { return subject; }
        }

        public string Teacher
        {
            get { return teacher; }
        }
        public int LessonNumber
        {
            get { return lessonnumber; }
        }

        public ClassDetails(string subject, string teacher, int lessonnumber)
        {
            this.subject = subject;
            this.teacher = teacher;
            this.lessonnumber = lessonnumber;
        }
    }
}
