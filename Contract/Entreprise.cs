using System;

namespace Contract
{
    class Entreprise
    {
        private string raisonSociale;
        private double ca;


        public string RaisonSociale
        {
            get { return raisonSociale.ToUpper(); }
            set { raisonSociale = value; }
        }

        public double CA
        {
            get { return ca; }
            set { ca = value; }
        }


        public Entreprise(string r, double ca){
            this.RaisonSociale = r;
            this.CA = ca;


        }
    }
}
