using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Cabinet
{
    public class Dose
    {
        private Int32 idDose;
        private string dosage;
        private string periode;

        public Int32 IdDose
        {
            get { return idDose; }
            set { idDose = value; }
        }
      
        public string Dosage
        {
            get { return dosage; }
            set { dosage = value; }
        }
        public string Periode
        {
            get { return periode; }
            set { periode = value; }
        }

        public Dose(Int32 iddose,string dosage,string periode)
        {
            this.IdDose = iddose;
            this.Dosage = dosage;
            this.Periode = periode;
        }
        public Dose( string dosage, string periode)
        {
            
            this.Dosage = dosage;
            this.Periode = periode;
        }
        public static Int32 getIdDoseLastOnee(User user)
        {
            Int32 id;
            SqlCommand cmd = new SqlCommand("select MAX(id_dose) from dose",user.Cn);
            user.Cn.Open();
            id = Int32.Parse(cmd.ExecuteScalar().ToString());
            user.Cn.Close();
            return id;
        }
    }
}
