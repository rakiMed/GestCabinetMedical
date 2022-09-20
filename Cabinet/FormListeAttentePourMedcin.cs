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
    public partial class FormListeAttentePourMedcin : Form
    {
        User User;
        public FormListeAttentePourMedcin(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void FormListeAttentePourMedcin_Load(object sender, EventArgs e)
        {
            try
            {

                User.Cabinet.chargerListeAttente();
                dataGridView1.DataSource = User.Cabinet.dtListeAttente;
                dataGridView1.Columns[0].Visible = false;
                labelTotal.Text = (dataGridView1.Rows.Count) + " Patient(s) En Attente";



                dataGridView1.Columns[1].HeaderText = "Nom";
                dataGridView1.Columns[1].Width = 90;

                dataGridView1.Columns[2].HeaderText = "Prénom";
                dataGridView1.Columns[3].HeaderText = "CIN";
                dataGridView1.Columns[4].HeaderText = "Sexe";
                dataGridView1.Columns[5].HeaderText = "Date Naissance";
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].HeaderText = "Tel";
                dataGridView1.Columns[7].HeaderText = "Ville";
                dataGridView1.Columns[8].HeaderText = "Motif Visite";
                dataGridView1.Columns[8].Width = 120;
                dataGridView1.Columns[9].HeaderText = "Heure Arrivé";
                dataGridView1.Columns[9].Width = 120;

                timer1.Enabled = true;
                timer1.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void patientEstPartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (User.Cabinet.CurrentListeAttente == null)
                {
                    MessageBox.Show("Vous devez selectionner un patient");
                }
                else
                {
                    if (MessageBox.Show("Etes vous sur de retirer ce patient de la liste d'attente ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        User.Cabinet.supprimerPatientDepuisListeAttente();
                        User.Cabinet.chargerListeAttente();
                        dataGridView1.DataSource = User.Cabinet.dtListeAttente;
                        dataGridView1.Columns[0].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gererPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void antecedentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Cabinet.CurrentPatient == null)
            {
                MessageBox.Show("Aucun patient n'est selectionné ");
            }
            else
            {

                new FormAjoutAntecedent(User).Show();

            }
        }

        private void examinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Cabinet.CurrentPatient == null)
            {
                MessageBox.Show("Aucun patient n'est selectionné ");
            }
            else
            {

                FormConsultation f = new FormConsultation(User);
                f.MdiParent = this.MdiParent;
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();

            }

            
          
            

        }

        private void historiqueConsultationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Cabinet.CurrentPatient == null)
            {
                MessageBox.Show("Aucun patient n'est selectionné ");
            }
            else
            {
                try
                {
                    FormMedcin.WishOne = "HistoryPatient";
                    User.Cabinet.CurrentConsultation = null;// pour metre a 0 le currentConsultation a chaque basculer entre menustrip liste, parceque la currentCunsultation peut garder l'existance malgré dans un cas quand on a aucun existance 


                    foreach (Form fc in this.MdiChildren)
                    {
                        fc.Close();

                    }

                    FormChercherConsultation f = new FormChercherConsultation(User);

                    f.MdiParent = this.MdiParent;
                    f.WindowState = System.Windows.Forms.FormWindowState.Maximized;


                    User.Cabinet.chargerConsultationParIDPatient(User.Cabinet.CurrentPatient.IdPatient);
                    f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
                    f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count);

                    System.Drawing.Size sz = new Size(1100, 350);
                    Point locat = new Point(140, 180);
                    f.dataGridView1.Size = sz;
                    f.dataGridView1.Location = locat;


                    //locat label guna
                    Point locattxt = new Point(1030, 550);
                    f.gunaLabel1.Location = locattxt;
                    //



                    // locat and  and text guna label2 
                    Point locatGunaLabel2 = new Point(390, 90);

                    f.gunaLabel2.Location = locatGunaLabel2;

                    f.gunaLabel2.Text = "Les Consultation du Patient  : " + User.Cabinet.CurrentPatient.Nom + " " + User.Cabinet.CurrentPatient.Prenom + "";
                    //
                    f.Show();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("La liste d'attente est encore vide !");
                }
                else
                {
                    int pos = dataGridView1.CurrentRow.Index;

                    User.Cabinet.CurrentPatient = User.Cabinet.getPatientById(Int32.Parse(User.Cabinet.dtListeAttente.Rows[pos][0].ToString()));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Cabinet.CurrentPatient == null)
            {
                MessageBox.Show("Aucun patient n'est selectionné ");
            }
            else
            {
                new FormHistory(this, User).Show();
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                this.MdiParent.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            }
            
        }

        private void premierControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Cabinet.CurrentPatient == null)
            {
                MessageBox.Show("Aucun patient n'est selectionné ");
            }
            else
            {
                if (MessageBox.Show("Vous avez Choissi Le Premier Control ! Continuer ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Evolution evo = new Evolution(DateTime.Now);
                    Consultation.CreerNouveauEvolution(evo, User);


                    foreach (Form f in this.MdiChildren)
                    {
                        f.Close();
                    }

                    FormEvolution fe = new FormEvolution(User);
                    fe.MdiParent = this.MdiParent;
                    fe.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    fe.Show();

                }
            }
                    

            
            
        }

        private void chargerDerniersControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Cabinet.CurrentPatient == null)
            {
                MessageBox.Show("Aucun patient n'est selectionné ");
            }
            else
            {
                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                }

                FormEvolutionNextControls fe = new FormEvolutionNextControls(User);
                fe.MdiParent = this.MdiParent;
                fe.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                fe.Show();
            }
                       
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                User.Cabinet.chargerListeAttente();
                dataGridView1.DataSource = User.Cabinet.dtListeAttente;
                dataGridView1.Columns[0].Visible = false;
                labelTotal.Text = (dataGridView1.Rows.Count) + " Patient(s) En Attente";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
