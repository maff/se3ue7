using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    [Serializable()]
    public class Termin
    {
        public Termin()
        {
        }

        public Termin(DateTime datum, int einheiten)
        {
            this.Datum = datum;
            this.Einheiten = einheiten;
        }

        private DateTime _datum;
        public DateTime Datum
        {
            get { return this._datum; }
            set { this._datum = value; }
        }

        private int _einheiten;
        public int Einheiten
        {
            get { return this._einheiten; }
            set { this._einheiten = value; }
        }
    }
}
