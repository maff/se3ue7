using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Student
    {
        public Student()
        {
        }

        public Student(string vorname, string nachname, int matrikelnummer)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Matrikelnummer = matrikelnummer;
        }

        private string _vorname;
        public string Vorname
        {
            get { return this._vorname; }
            set { this._vorname = value; }
        }

        private string _nachname;
        public string Nachname
        {
            get { return this._nachname; }
            set { this._nachname = value; }
        }

        private int _matrikelnummer;
        public int Matrikelnummer
        {
            get { return this._matrikelnummer; }
            set { this._matrikelnummer = value; }
        }

        public string toString()
        {
            return this.Vorname + " " + this.Nachname;
        }
    }
}
