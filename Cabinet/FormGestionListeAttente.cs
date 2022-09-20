using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cabinet
{
    public partial class FormGestionListeAttente : Form
    {
        User User;
        public FormGestionListeAttente(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void FormGestionListeAttente_Load(object sender, EventArgs e)
        {
            lblpatient.Text = User.Cabinet.CurrentPatient.Nom + " " + User.Cabinet.CurrentPatient.Prenom;
        }

      

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmotif.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un motif de visite !");
                }
                else
                {
                    ListeAttente ls = new ListeAttente(User.Cabinet.CurrentPatient.IdPatient, DateTime.Now, txtmotif.Text, "En attente");
                    User.Cabinet.AjouterAlaListeDattente(ls);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
