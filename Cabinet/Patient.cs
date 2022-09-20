using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cabinet
{
    public class Patient
    {
        private Int32 idPatient;
        private string nom;
        private string prenom;
        private string cin;
        private string sexe;
        private string telephone;
        private DateTime dateNaissance;
        private string ville;
        private float poids;
        private string mutualiste;

        public string Mutualiste
        {
            get { return mutualiste; }
            set { mutualiste = value; }
        }

        public float Poids
        {
            get { return poids; }
            set { poids = value; }
        }

       

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        public string Cin
        {
            get { return cin; }
            set { cin = value; }
        }
        public Int32 IdPatient
        {
            get { return idPatient; }
            set { idPatient = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public Patient(string nm,string prn,string cin,string sex,string tel,DateTime datnaiss,string ville,float poids,string mutuel)
        {
            this.Nom = nm;
            this.Prenom = prn;
            this.Cin = cin;
            this.Sexe = sex;
            this.DateNaissance = datnaiss;
            this.Ville = ville;
            this.Poids = poids;
            this.Telephone = tel;
            this.Mutualiste = mutuel;

    
        }
        public Patient(int id,string nm, string prn, string cin, string sex, string tel, DateTime datnaiss, string ville, float poids)
        {
            this.IdPatient = id;
            this.Nom = nm;
            this.Prenom = prn;
            this.Cin = cin;
            this.Sexe = sex;
            this.DateNaissance = datnaiss;
            this.Ville = ville;
            this.Poids = poids;
            this.Telephone = tel;

        }
        public Patient(int id)
        {
            this.IdPatient = id;
        }
        public Patient()
        {
            
        }
        public Patient(string nom,string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }
        public Patient(int id, string nm, string prn, string cin, string sex, string tel, DateTime datnaiss, string ville, float poids,string mutuel)
        {
            this.IdPatient = id;
            this.Nom = nm;
            this.Prenom = prn;
            this.Cin = cin;
            this.Sexe = sex;
            this.DateNaissance = datnaiss;
            this.Ville = ville;
            this.Poids = poids;
            this.Telephone = tel;
            this.Mutualiste = mutuel;

        }
    }
}
