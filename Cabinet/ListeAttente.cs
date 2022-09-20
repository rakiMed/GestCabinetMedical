using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cabinet
{
    public class ListeAttente
    {
        private Int32 id_patient;
        private string etat;
        private DateTime date;
        private string motifVisite;
        public Int32 Id_patient
        {
            get { return id_patient; }
            set { id_patient = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        

        public string MotifVisite
        {
            get { return motifVisite; }
            set { motifVisite = value; }
        }
   
        public string Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        public ListeAttente(Int32 id_pat,DateTime dt,string motif,string eta)
        {

            this.Id_patient = id_pat;
            this.Date = dt;
            this.MotifVisite = motif;
            this.Etat =eta;
        
        }

    }
}
