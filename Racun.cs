using System;

namespace HelloWorld
{
    internal class Racun
    {
        public event EventHandler<double> StanjePromjenjeno;

        //public double Stanje { get; private set; }

        private double _stanje;

        public double Stanje
        {
            get { return _stanje; }
            private set 
            { 
                _stanje = value;
                StanjePromjenjeno?.Invoke(this, value);
            }
        }

        public void Uplati(double iznos)
        {
            Stanje += iznos;
            // _stanje = iznos;
            
            //if (StanjePromjenjeno != null)
            //{
            //    StanjePromjenjeno.Invoke(this, Stanje);
            //}
        }

        public void Isplati(double iznos)
        {
            Stanje -= iznos;

            //StanjePromjenjeno?.Invoke(this, Stanje);
        }

        public void IsplatiSve()
        {
            Stanje = 0;
        }
    }
}
