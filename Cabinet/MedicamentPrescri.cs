using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Cabinet
{
   public  class MedicamentPrescri
    {
        private Int32 idConsultation;
        private Int32 idDose;
        private string medicament;
        private string dureeTraitement;

        public string DureeTraitement
        {
            get { return dureeTraitement; }
            set { dureeTraitement = value; }
        }
        public Int32 IdConsultation
        {
            get { return idConsultation; }
            set { idConsultation = value; }
        }
        public string Medicament
        {
            get { return medicament; }
            set { medicament = value; }
        }
        public Int32 IdDose
        {
            get { return idDose; }
            set { idDose = value; }
        }
        
      

        public MedicamentPrescri(Int32 idcons,string mdcm,Int32 idDs,string dureeTrait)
        {
            this.IdConsultation = idcons;
            this.Medicament = mdcm;
            this.IdDose = idDs;
            this.dureeTraitement = dureeTrait;
        
        }
        public MedicamentPrescri(Int32 idcons, string mdcm, Int32 idDs)
        {
            this.IdConsultation = idcons;
            this.Medicament = mdcm;
            this.IdDose = idDs;
            

        }

        public static void ajouterDose(Dose dose,User user)
        {

            SqlCommand cmd = new SqlCommand("insert into dose values ('"+dose.Dosage+"','"+dose.Periode+"')",user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
        
        }
        public static void modifierDose(Dose dose, User user)
        {


            SqlCommand cmd = new SqlCommand("UPDATE dose set dosage='"+dose.Dosage+"',periode='"+dose.Periode+"' where id_dose='"+user.Cabinet.CurrentMedicamentPriscri.IdDose+"'", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
        
        }
    }
}
