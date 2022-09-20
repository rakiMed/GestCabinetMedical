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
    public partial class FormAntecedent : Form
    {
       
        User User;
        int compteur = 0;
        FormNotification fn;
        public FormAntecedent(User u)
        {
            InitializeComponent();
            this.User = u;
        }

        private void FormAntecedent_Load(object sender, EventArgs e)
        {
            try
            {
                User.Cabinet.chargedtPatients();
                dataGridView1.DataSource = User.Cabinet.dtPatients;
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

       
        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void antecedentDuPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Cabinet.CurrentPatient==null)
            {
                MessageBox.Show("Aucun patient n'est selectionné ");
            }
            else
            {

                fn = new FormNotification();
                fn.lbn.Text = ""+User.Cabinet.CurrentPatient.Prenom+" "+User.Cabinet.CurrentPatient.Nom+" est selectionné(e)";
                fn.Show();
                timer1.Enabled = true;
                
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            compteur++;
            
            if (compteur==5)
            {
                fn.Close();
                timer1.Enabled = false;
                compteur = 0;
                new FormAjoutAntecedent(User).Show();
            }
        }

        

       
     
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                User.Cabinet.chargedtPatients();
            }
            else
            {
                User.Cabinet.chercherPatientParNom(txtnom.Text);
            }

            dataGridView1.DataSource = User.Cabinet.dtPatients;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtcin.Text == "")
            {
                User.Cabinet.chargedtPatients();
            }
            else
            {
                User.Cabinet.chercherPatientParCin(txtcin.Text);
            }

            dataGridView1.DataSource = User.Cabinet.dtPatients;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (User.Cabinet.CurrentPatient == null)
            {
                MessageBox.Show("Aucun patient n'est selectionné ");
            }
            else
            {

                fn = new FormNotification();
                fn.lbn.Text = "" + User.Cabinet.CurrentPatient.Prenom + " " + User.Cabinet.CurrentPatient.Nom + " est selectionné(e)";
                fn.Show();
                timer1.Enabled = true;



            }
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("La liste des patients est encore vide !");
                }
                else
                {
                    int pos = dataGridView1.CurrentRow.Index;
                    User.Cabinet.CurrentPatient = new Patient(Int32.Parse(User.Cabinet.dtPatients.Rows[pos][0].ToString()), User.Cabinet.dtPatients.Rows[pos][1].ToString(), User.Cabinet.dtPatients.Rows[pos][2].ToString(), User.Cabinet.dtPatients.Rows[pos][3].ToString(), User.Cabinet.dtPatients.Rows[pos][4].ToString(), User.Cabinet.dtPatients.Rows[pos][5].ToString(), DateTime.Parse(User.Cabinet.dtPatients.Rows[pos][6].ToString()), User.Cabinet.dtPatients.Rows[pos][7].ToString(), float.Parse(User.Cabinet.dtPatients.Rows[pos][8].ToString()));



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

    
        
    }
}
