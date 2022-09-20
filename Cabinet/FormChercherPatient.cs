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
    public partial class FormChercherPatient : Form
    {
        public User User;
        public FormChercherPatient(User u)
        {
            InitializeComponent();
            this.User = u;
        }

        private void FormChercherPatient_Load(object sender, EventArgs e)
        {
            try
            {
                User.Cabinet.chargedtPatients();
                dataGridView1.DataSource = User.Cabinet.dtPatients;
                gunaLabel1.Text = "Nombre Total Des Patients: " + (dataGridView1.Rows.Count).ToString();

                dataGridView1.Columns[0].HeaderText = "Id Patient";
                dataGridView1.Columns[1].HeaderText = "Nom";
                dataGridView1.Columns[2].HeaderText = "Prénom";
                dataGridView1.Columns[3].HeaderText = "CIN";
                dataGridView1.Columns[4].HeaderText = "Sexe";
                dataGridView1.Columns[5].HeaderText = "Tel";
                dataGridView1.Columns[6].HeaderText = "Date Naissance";
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].HeaderText = "Ville";
                dataGridView1.Columns[8].HeaderText = "Poids";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

      
       

        private void gererCePatientToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (User.Cabinet.CurrentPatient == null)
                {
                    MessageBox.Show("Vous devez selectionner un patient");
                }
                else
                {
                    FormGestionPatients f = new FormGestionPatients(User);
                    f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    f.MdiParent = this.MdiParent;
                    f.Show();
                    f.affecterLePatientAuxChamps();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void ajouterÀLaListeDattenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (User.Cabinet.CurrentPatient == null)
                {
                    MessageBox.Show("Vous devez d'abord choisir un patient !");
                }
                else
                {
                    new FormGestionListeAttente(User).Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtcin_TextChanged_1(object sender, EventArgs e)
        {
            try
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
                this.gunaLabel1.Text = "Nombre Total Des Patients: " + (dataGridView1.Rows.Count).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtnom_TextChanged_1(object sender, EventArgs e)
        {
            try
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
                this.gunaLabel1.Text = "Nombre Total Des Patients: " + (dataGridView1.Rows.Count).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
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

        private void guna2PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {

                if (!(User.Cabinet.CurrentPatient == null))
                {
                    guna2PictureBox2.Visible = true;
                    label9.Visible = true;
                    label9.Text = "Hi I'm " + User.Cabinet.CurrentPatient.Prenom;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void guna2PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox2.Visible = false;
            label9.Visible = false;
        }
    }
}
