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
        private readonly List<string> voornamen;

        //constructor
        public Persoon(List<string> voornamen)
        {
            //lege lijst is niet ok
            if (!voornamen.Any())
            {
                throw new ArgumentException();
            }

            foreach (var voornaam in voornamen)
            {
                //ergens een lege string of nullelement dan exception
                if (voornaam == string.Empty)
                {
                    throw new ArgumentException();
                }
                //naam meerdere keren voorkomt dan exception
                var groepen = voornamen.GroupBy(v => v);
                foreach (var groep in groepen)
                {
                    if (groep.Count() > 1)
                    {
                        throw new ArgumentException();
                    }
                }
                

            }
            this.voornamen = voornamen;
        }

        //method
        //override
        public override string ToString()
        {
            //return base.ToString();
            //throw new NotImplementedException();
            string stringVoornamen = "";
            foreach (var voornaam in voornamen)
            {
                stringVoornamen += voornaam + " ";
            }
            return stringVoornamen;
        }

    }
}
