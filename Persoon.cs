using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NielsKelchtermansEindTestTDD
{
    public class Persoon
    {
        //prop
        private List<string> voornamenValue;

        public List<string> Voornamen
        {
            get
            {
                //return voornamenValue;
                throw new NotImplementedException();
            }
            set
            {
                //voornamenValue = value;
                throw new NotImplementedException();
            }
        }

        //constructor
        public Persoon(List<string> voornamen)
        {
            this.Voornamen = voornamen;
        }

        //method
        //override
        public override string ToString()
        {
            //return base.ToString();
            throw new NotImplementedException();
        }

    }
}
