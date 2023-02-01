using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoBabyGym.model
{
    public class SvoemmeHold:Hold
    {
        public String SvoemmeHal { get; set; }

        public SvoemmeHold(int holdId, string holdNavn, int prisPrDeltager, int maxAntalBørn, string svoemmeHal):
            base( holdId,  holdNavn,  prisPrDeltager,  maxAntalBørn)
        {
            SvoemmeHal = svoemmeHal;
        }

        public override string ToString()
        {
            return base.ToString() + $", Svømmehal={SvoemmeHal}";
        }
    }
}
