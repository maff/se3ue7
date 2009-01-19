using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Veranstaltung
    {
        public List<Veranstaltungstermin> Termine = new List<Veranstaltungstermin>();
        public List<Student> Studenten = new List<Student>();

        private string _titel;
        public string Titel
        {
            get { return this._titel; }
            set { this._titel = value; }
        }

        private string _lektor;
        public string Lektor
        {
            get { return this._lektor; }
            set { this._lektor = value; }
        }

        private string _semester;
        public string Semester
        {
            get { return this._semester; }
            set { this._semester = value; }
        }

        public string toString()
        {
            return this.Titel + " - " + this.Semester + " (" + this.Lektor + ")";
        }
    }
}
