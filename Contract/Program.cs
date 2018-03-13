using System;

namespace Contract
{
    class Program
    {
        private string nom;
        private string prenom;
        private string tel;
        //private string infos;
        private Entreprise entreprise;
 
        public string Nom
        {
            get { return nom.ToUpper(); }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom.ToUpper(); }
            set { prenom = value; }
        }
              
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public Entreprise Entreprise
        {
            get { return entreprise; }
            set { entreprise = value; }
        }

        public Program(String n, string p, string t, string e, double c){
            this.Nom = n;
            this.Prenom = p;
            this.Tel = tel;
            this.Entreprise = new Entreprise(e, c);
        }


        public string Infos(){
            return string.Format("{0}{1}\nTel:{2}Societe:{3}CA:{4}", this.Nom, this.Tel, this.Prenom, this.Entreprise.RaisonSociale, this.Entreprise.CA);
           
        }
              
    }
}
