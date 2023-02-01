using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoBabyGym.model
{
    public class Deltager
    {
        private string _forælderNavn;
        private string _adresse;
        private int _antalBørn;

        public String ForælderNavn { get => _forælderNavn; set => _forælderNavn = value; }
        public String Adresse { get => _adresse; set => _adresse = value; }
        public int AntalBørn { get => _antalBørn; set => _antalBørn = value; }

        public Deltager(string forælderNavn, string adresse, int antalBørn)
        {
            _forælderNavn = forælderNavn;
            _adresse = adresse;
            _antalBørn = antalBørn;
        }

        public override string ToString()
        {
            return $"Navn={_forælderNavn} Adresse={_adresse} Antal børn={_antalBørn}";
        }
    }
}
