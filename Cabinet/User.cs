using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cabinet
{
   public class User
    {

      
        private string login;
        private string password;
        private string type;
        private Cabinet cabinet;
        private SqlConnection cn;

        public SqlConnection Cn
        {
            get { return cn; }
            set { cn = value; }
        }

        public Cabinet Cabinet
        {
            get { return cabinet; }
            set { cabinet = value; }
        }
        
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public User()
        { }
        public User(string log,string pass)
        {
          
            this.Login = log;
            this.Password = pass;
            Cabinet = new Cabinet(this);
        
        }

        public User(string login , string pass,string tp)
        {
            this.Login = login;
            this.Password = pass;
            this.Type = tp;
        
        }


      

        public virtual void AfficherInterface()
        { 
        
        }
    }
}
