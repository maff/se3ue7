using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    [Serializable()]
    public class Veranstaltung
    {
        public Veranstaltung()
        {
        }

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

        public void addStudent(Student student)
        {
            if (student.Anwesenheit.Length != this.Termine.Count)
                throw new ArgumentException("Anzahl der Anwesenheitseinträge muss gleich der Anzahl der Termine sein.");

            this.Studenten.Add(student);
        }

        public void addTermin(Termin termin)
        {
            this.Termine.Add(termin);
        }

        private List<Termin> _termine = new List<Termin>();
        public List<Termin> Termine
        {
            get { return this._termine; }
            set { this._termine = value; }
        }

        private List<Student> _studenten = new List<Student>();
        public List<Student> Studenten
        {
            get { return this._studenten; }
            set { this._studenten = value; }
        }

        public string toString()
        {
            return this.Titel + " - " + this.Semester + " (" + this.Lektor + ")";
        }
    }
}
