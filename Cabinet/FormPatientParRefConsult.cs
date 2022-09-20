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
    public partial class FormPatientParRefConsult : Form
    {
        User User;
        public FormPatientParRefConsult(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void btnchercher_Click(object sender, EventArgs e)
        {
            try
            {

                User.Cabinet.chercherPatientParRefConsultation(txtidconsultation.Text);
                dataGridView1.DataSource = User.Cabinet.dtPatients;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormPatientParRefConsult_Load(object sender, EventArgs e)
        {
            try
            {

                User.Cabinet.chercherPatientParRefConsultation(txtidconsultation.Text);
                dataGridView1.DataSource = User.Cabinet.dtPatients;
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

        private void ajouterÀLaListeDattenteToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void gererPatientToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //this is the true one 
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("La liste des patients est encore vide !");
            }
            else
            {
                int pos = dataGridView1.CurrentRow.Index;
                

                    User.Cabinet.CurrentPatient = new Patient(Int32.Parse(User.Cabinet.dtPatients.Rows[pos][0].ToString()), User.Cabinet.dtPatients.Rows[pos][1].ToString(), User.Cabinet.dtPatients.Rows[pos][2].ToString(), User.Cabinet.dtPatients.Rows[pos][3].ToString(), User.Cabinet.dtPatients.Rows[pos][4].ToString(), User.Cabinet.dtPatients.Rows[pos][5].ToString(), DateTime.Parse(User.Cabinet.dtPatients.Rows[pos][6].ToString()), User.Cabinet.dtPatients.Rows[pos][7].ToString(), float.Parse(User.Cabinet.dtPatients.Rows[pos][8].ToString()));


            }
        }

        private void guna2PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(User.Cabinet.CurrentPatient == null))
            {
                guna2PictureBox2.Visible = true;
                label9.Visible = true;
                label9.Text = "Hi I'm " + User.Cabinet.CurrentPatient.Prenom;
            }
           
        }

        private void guna2PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox2.Visible = false;
            label9.Visible = false;
        }
    }
}
