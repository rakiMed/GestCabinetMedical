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
    public partial class FormEvolutionNextControls : Form
    {
        User user;
        public FormEvolutionNextControls(User u)
        {
            this.user = u;
            InitializeComponent();
        }

        private void FormEvolutionNextControls_Load(object sender, EventArgs e)
        {

            try
            {

                labelNom.Text = user.Cabinet.CurrentPatient.Nom;
                LabelPrenom.Text = user.Cabinet.CurrentPatient.Prenom;
                cmbState.Text = "Stable";

                user.Cabinet.chargerConsultation(user.Cabinet.getLastConsultationIdForThePatient(user.Cabinet.CurrentPatient.IdPatient));

                labelMaladie.Text = user.Cabinet.dtConsultation.Rows[0][3].ToString();
                labelRemarque.Text = user.Cabinet.dtConsultation.Rows[0][4].ToString();


                user.Cabinet.chargerLastEvolutionWithAllConsultation(Consultation.getLastEvoId(user));
                dataGridView1.DataSource = user.Cabinet.dtEvolution;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[1].HeaderText = "N° Consultation";
                dataGridView1.Columns[3].HeaderText = "Etat Evolution";
                dataGridView1.Columns[4].HeaderText = "Date du Control";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidconsultation.Text == "")
                {
                    labelNonVide.Visible = true;
                    txtidconsultation.BorderColor = Color.Red;
                }
                else
                {
                    EvolutionST ev = new EvolutionST(Int32.Parse(txtidconsultation.Text), Consultation.getLastEvoId(user), user.Cabinet.CurrentPatient.IdPatient, cmbState.Text, DateTime.Now);
                    user.Cabinet.CurrentEvolution = ev;

                    Consultation.appliquerEvolution(ev, user);
                    
                    guna2Button2.Visible = true;
                    user.Cabinet.chargerLastEvolutionWithAllConsultation(ev.IdEvolution);
                    dataGridView1.DataSource = user.Cabinet.dtEvolution;

                }




            }
            catch (Exception)
            {

                MessageBox.Show("un seul etat evolution est peut etre appliquée");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Consultation.RemoveCurrentEvolution(user);
                user.Cabinet.chargerLastEvolutionWithAllConsultation(user.Cabinet.CurrentEvolution.IdEvolution);
                dataGridView1.DataSource = user.Cabinet.dtEvolution;
                guna2Button2.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtidconsultation_MouseClick(object sender, MouseEventArgs e)
        {
            txtidconsultation.BorderColor = Color.FromArgb(213, 218, 223);
            labelNonVide.Visible = false;
        }

        private void voirPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Cabinet.CurrentConsultation == null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation");
            }
            else
            {
                new FormPrescriptionViewr(user).Show();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("aucun evolution n'est appliqué");
                }
                else
                {
                    Int32 idCons = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());

                    user.Cabinet.CurrentConsultation = new Consultation();
                    user.Cabinet.CurrentConsultation.IdConsultation = idCons;
                }

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }

                 
        }

        private void examensBiologiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultation.TypeOfExamen = "bio";
            if (user.Cabinet.CurrentConsultation == null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation");
            }
            else
            {
                new FormDemmandeExamen(user).Show();
            }
        }

        private void examensRadiologiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultation.TypeOfExamen = "radio";
            if (user.Cabinet.CurrentConsultation == null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation");
            }
            else
            {
                new FormDemmandeExamen(user).Show();
            }
        }

        private void examensEndoscopiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultation.TypeOfExamen = "endoscopique";
            if (user.Cabinet.CurrentConsultation == null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation");
            }
            else
            {
                new FormDemmandeExamen(user).Show();
            }
        }

        private void examenAnatomopathologiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultation.TypeOfExamen = "anatomo";
            if (user.Cabinet.CurrentConsultation == null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation");
            }
            else
            {
                new FormDemmandeExamen(user).Show();
            }
        }

        private void labelNonVide_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelnumCons_Click(object sender, EventArgs e)
        {

        }

        private void txtidconsultation_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
