using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cabinet
{
    public class Antecedent
    {
        private Int32 id_antecedent;
        private string medicament;
        private string antecedent;

        public Int32 Id_antecedent
        {
            get { return id_antecedent; }
            set { id_antecedent = value; }
        }
        public string Anteceden
        {
            get { return antecedent; }
            set { antecedent = value; }
        }
        public string Medicament
        {
            get { return medicament; }
            set { medicament = value; }
        }

        public Antecedent(string medcmnt,string Antec)
        {

            this.Medicament = medcmnt;
            this.Anteceden = Antec;
        
        }
        public Antecedent(Int32 id, string medcmnt, string anteced)
        {

            this.Medicament = medcmnt;
            this.Anteceden = anteced;
            this.Id_antecedent = id;

        }
    }
}
