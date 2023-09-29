using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoğrafiBilgiSistemiProjesi1
{
    public class Arac
    {
        private string plaka;
        private string type;
        private string from;
        private string to;
        private PointLatLng konum;

        public Arac(string plaka, string type, string from, string to,PointLatLng konum)
        {
            this.Plaka = plaka;
            this.Type = type;
            this.From = from;
            this.To = to;
            this.Konum = konum;
        }

        public string Plaka { get => plaka; set => plaka = value; }
        public string Type { get => type; set => type = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public PointLatLng Konum { get => konum; set => konum = value; }

        public override string ToString()
        {
            string str = Plaka + "\n " + Type + "\n " + From + " \n" + To ;
            return str;
        }
    }
}
