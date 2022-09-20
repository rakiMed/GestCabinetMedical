using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Cabinet
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

       

        

        private void btnConnexion_Click(object sender, EventArgs e)
        {
           

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                User u = new User(txtlogin.Text, txtpassword.Text);

                //u.Cn = new SqlConnection("server=192.168.0.104; database=GestCabinet ; integrated security=false ;user ID=med;password=123456");
                u.Cn = new SqlConnection("database=GestCabinet ; integrated security=true");
                u.Cabinet.AuthentifierMoi();
                txtpassword.Clear();
                txtpassword.Focus();
                if (u.Cabinet.EtatConnexion)
                {
                    this.Visible = false;
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
