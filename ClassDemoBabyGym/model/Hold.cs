using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoBabyGym.model
{
    public class Hold
    {
        // instansfelter
        private int _holdId;
        private String _holdNavn;
        private int _prisPrDeltager;
        private int _maxAntalBørn;



        private List<Deltager> _deltagerListe;

        // properties
        public int HoldId
        {
            get { return _holdId; }
            set { _holdId = value; }
        }

        public String HoldNavn { 
            get { return _holdNavn; } 
            set { _holdNavn = value; } 
        }
        public int PrisPrDeltager 
        { 
            get { return _prisPrDeltager; }
            set{  _prisPrDeltager = value;} 
        }
        public int MaxAntalBørn
        {
            get { return _maxAntalBørn; }
            set { _maxAntalBørn = value; }
        }

        public Hold(int holdId, string holdNavn, int prisPrDeltager, int maxAntalBørn)
        {
            _holdId = holdId;
            _holdNavn = holdNavn;
            _prisPrDeltager = prisPrDeltager;
            _maxAntalBørn = maxAntalBørn;

            _deltagerListe= new List<Deltager>();
        }

        public int AntalTilmeldte()
        {
            int sum = 0;
            foreach(Deltager deltager in _deltagerListe)
            {
                sum = sum + deltager.AntalBørn;
            }

            return sum;
        }


        public void TilmeldDeltager(Deltager deltager)
        {
            int friePladser = _maxAntalBørn - AntalTilmeldte();

            if (friePladser >= deltager.AntalBørn)
            {
                _deltagerListe.Add(deltager);
            }
            else
            {
                Console.WriteLine("Der er ikke plads til dine børn");
            }
        }



        public override string ToString()
        {
            return $"HoldId= {_holdId}, Navn={_holdNavn}, Pris={_prisPrDeltager}, max antal={_maxAntalBørn}";
        }
    }
}
