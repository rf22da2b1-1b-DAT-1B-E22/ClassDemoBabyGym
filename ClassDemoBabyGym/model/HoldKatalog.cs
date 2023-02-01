using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoBabyGym.model
{
    public class HoldKatalog
    {
        private List<Hold> _hold = new List<Hold>() ;

        public HoldKatalog()
        {
            //_hold= new List<Hold>();
        }


        public void TilføjHold(Hold hold)
        {
            Hold FundetHold = FindHold(hold.HoldId);
            
            if(FundetHold is null) // findes ikke i forvejen
            {
                _hold.Add(hold);
            }
            else
            {
                throw new ArgumentException($"Hold med id {hold.HoldId} findes i forvejen");
            }
        }

        public Hold FindHold(int holdId)
        {
            foreach(Hold hold in _hold)
            {
                if (hold.HoldId == holdId)
                {
                    return hold;
                }
            }




            return null;
        }


        public override string ToString()
        {
            String str = "[";
            foreach (Hold hold in _hold)
            {
                str = str + ", " + hold.ToString();
            }
            str = str + "]";

            return str;

            //return String.Join(", ", _hold);
        }
    }
}
