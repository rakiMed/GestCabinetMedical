using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;




namespace Cabinet
{
    public class Consultation
    {
        private Int32 idConsultation;
        private Int32 idPatient;
        private DateTime dateConsultation;
        private string maladie;
        private string remarque;

        public string Remarque
        {
            get { return remarque; }
            set { remarque = value; }
        }
        
        public Int32 IdPatient
        {
            get { return idPatient; }
            set { idPatient = value; }
        }
  
        public DateTime DateConsultation
        {
            get { return dateConsultation; }
            set { dateConsultation = value; }
        }
        
        public string Maladie
        {
            get { return maladie; }
            set { maladie = value; }
        }
  
        public Int32 IdConsultation
        {
            get { return idConsultation; }
            set { idConsultation = value; }
        }


        public Consultation(Int32 idcons,Int32 idpatie,DateTime dtconsu,string mld,string rmrq)
        {

            this.IdConsultation = idcons;
            this.IdPatient = idpatie;
            this.DateConsultation = dtconsu;
            this.Maladie = mld;
            this.Remarque = rmrq;
        }
        public Consultation(Int32 idpatie, DateTime dtconsu, string mld, string rmrq)
        {

            
            this.IdPatient = idpatie;
            this.DateConsultation = dtconsu;
            this.Maladie = mld;
            this.Remarque = rmrq;
        }
        public Consultation(Int32 idConsu)
        {
            this.IdConsultation = idConsu;
        }
        public Consultation()
        { }
        public static void ajouterMedicamentPrescri(MedicamentPrescri mdc, User user)
        {
            SqlCommand cmd = new SqlCommand("insert into MedicamentPrescri values ('"+mdc.IdConsultation+"','"+mdc.Medicament+"','"+mdc.IdDose+"','"+mdc.DureeTraitement+"')", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
        }
        public static Int32 getIdConsultationLastOne(User user)
        {

            Int32 id=0;
            SqlDataReader dr;
            SqlCommand cmd1 = new SqlCommand("select * from consultation",user.Cn);
            user.Cn.Open();
            dr = cmd1.ExecuteReader();
            if (dr.HasRows)
            {
                user.Cn.Close();
                SqlCommand cmd = new SqlCommand("select MAX(id_consultation) from Consultation", user.Cn);
                user.Cn.Open();
                id = Int32.Parse(cmd.ExecuteScalar().ToString());
                user.Cn.Close();
                
            }
            else
            {
                user.Cn.Close();
                System.Windows.Forms.MessageBox.Show("Aucune Consultation existe pour le moment !");
                
            }

            return id;
        }
        public static void supprimerMedicamentPrescri(User user)
        {
            SqlCommand cmd = new SqlCommand("delete from medicamentPrescri where id_consultation='" + user.Cabinet.CurrentMedicamentPriscri.IdConsultation + "' and medicament='" + user.Cabinet.CurrentMedicamentPriscri.Medicament + "' and id_dose='"+user.Cabinet.CurrentMedicamentPriscri.IdDose+"'", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();

            SqlCommand cmd2 = new SqlCommand("delete from dose where id_dose='" + user.Cabinet.CurrentMedicamentPriscri.IdDose + "' ", user.Cn);
            user.Cn.Open();
            cmd2.ExecuteNonQuery();
            user.Cn.Close();

        }

        public static void ModifierDureeTraitementPourMedicamentPrescri(Int32 idConsultation, MedicamentPrescri mdc ,string NewDure,User user)
        {
            SqlCommand cmd = new SqlCommand("update medicamentPrescri set dureTraitement='" + NewDure + "' where id_consultation='" + idConsultation + "' and medicament='" + mdc.Medicament + "'", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
        }

        public static void CreerNouveauEvolution(Evolution ev,User user)
        {
            if (user.Cn.State==ConnectionState.Open)
            {
                user.Cn.Close(); 
            }


            SqlCommand cmd = new SqlCommand("insert into evolutions values ('"+ev.DateFirstControl+"')",user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
        
        }

        public static void appliquerEvolution(EvolutionST evoSousTrait, User user)
        {
            if (user.Cn.State == ConnectionState.Open)
            {
                user.Cn.Close();
            }


            SqlCommand cmd = new SqlCommand("insert into evolutionST values('"+evoSousTrait.IdEvolution+"','"+evoSousTrait.IdConsultation+"','"+evoSousTrait.IdPatient+"','"+evoSousTrait.State+"','"+evoSousTrait.DateControl+"') ", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();
        
        }
        public static Int32 getLastEvoId(User user)
        {
            if (user.Cn.State == ConnectionState.Open)
            {
                user.Cn.Close();
            }
            Int32 idEvo;

            SqlCommand cmd = new SqlCommand("select top 1 Id_Evo from Evolutions order by Id_Evo desc", user.Cn);
            user.Cn.Open();
            idEvo = Int32.Parse(cmd.ExecuteScalar().ToString());
            return idEvo;
        
        }

        public static void RemoveCurrentEvolution(User user)
        {
            if (user.Cn.State == ConnectionState.Open)
            {
                user.Cn.Close();
            }

            SqlCommand cmd = new SqlCommand("delete EvolutionST where id_Evo='"+user.Cabinet.CurrentEvolution.IdEvolution+"' and id_cons='"+user.Cabinet.CurrentEvolution.IdConsultation+"' ", user.Cn);
            user.Cn.Open();
            cmd.ExecuteNonQuery();
            user.Cn.Close();

        }
        
    }
}
