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
    public partial class FormPatientPourMecin : Form
    {
        User User;
        
        public FormPatientPourMecin(User u)
        {
            this.User = u;
           
            InitializeComponent();
        }

        private void FormPatientPourMecin_Load(object sender, EventArgs e)
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

        private void txtchangenom_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtchangenom.Text == "")
                {
                    User.Cabinet.chargedtPatients();
                }
                else
                {
                    User.Cabinet.chercherPatientParNom(txtchangenom.Text);
                }

                dataGridView1.DataSource = User.Cabinet.dtPatients;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtchangcin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            

        }

        private void gererPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (User.Cabinet.CurrentPatient == null)
            {
                MessageBox.Show("Aucun patient n'est selectionné ");
            }
            else
            {
               
                FormGestionPatients f = new FormGestionPatients(User);
                f.MdiParent = this.MdiParent;
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
                f.affecterLePatientAuxChamps();

               
            }
        }

        private void changerCouleurInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Cabinet.CurrentPatient==null)
            {
                MessageBox.Show("Vous devez selectionner un patient !");
            }
            else
            {
                new FormAjoutAntecedent(User).Show();
            }
            
        }

        private void historiqueConsultationsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void txtchangenom_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

                if (txtchangenom.Text == "")
                {
                    User.Cabinet.chargedtPatients();
                }
                else
                {
                    User.Cabinet.chercherPatientParNom(txtchangenom.Text);
                }

                dataGridView1.DataSource = User.Cabinet.dtPatients;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtchangcin_TextChanged_1(object sender, EventArgs e)
        {

            try
            {

                if (txtchangcin.Text == "")
                {
                    User.Cabinet.chargedtPatients();
                }
                else
                {
                    User.Cabinet.chercherPatientParCin(txtchangcin.Text);
                }

                dataGridView1.DataSource = User.Cabinet.dtPatients;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            int pos = dataGridView1.CurrentRow.Index;
            if (User.Cabinet.dtPatients.Rows.Count == 0)
            {
                MessageBox.Show("La liste des patients est encore vide !");
            }
            else
            {
                if (pos < User.Cabinet.dtPatients.Rows.Count)
                {
                    User.Cabinet.CurrentPatient = new Patient(Int32.Parse(User.Cabinet.dtPatients.Rows[pos][0].ToString()), User.Cabinet.dtPatients.Rows[pos][1].ToString(), User.Cabinet.dtPatients.Rows[pos][2].ToString(), User.Cabinet.dtPatients.Rows[pos][3].ToString(), User.Cabinet.dtPatients.Rows[pos][4].ToString(), User.Cabinet.dtPatients.Rows[pos][5].ToString(), DateTime.Parse(User.Cabinet.dtPatients.Rows[pos][6].ToString()), User.Cabinet.dtPatients.Rows[pos][7].ToString(), float.Parse(User.Cabinet.dtPatients.Rows[pos][8].ToString()),User.Cabinet.dtPatients.Rows[pos][9].ToString());

                }
                else
                {
                    MessageBox.Show("ce patient n'est pas encore crée !");
                }

            }
        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormHistory(this, User).Show();
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MdiParent.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void premierControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void suiviDesControlsToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
