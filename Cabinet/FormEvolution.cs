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
    public partial class FormEvolution : Form
    {
        User user;
        public FormEvolution(User u)
        {

            InitializeComponent();

            this.user = u;
        }

        private void FormEvolution_Load(object sender, EventArgs e)
        {
            try
            {

                labelNom.Text = user.Cabinet.CurrentPatient.Nom;
                LabelPrenom.Text = user.Cabinet.CurrentPatient.Prenom;
                cmbState.Text = "Stable";


                user.Cabinet.chargerConsultation(user.Cabinet.getLastConsultationIdForThePatient(user.Cabinet.CurrentPatient.IdPatient));

                labelMaladie.Text = user.Cabinet.dtConsultation.Rows[0][3].ToString();
                labelRemarque.Text = user.Cabinet.dtConsultation.Rows[0][4].ToString();
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
                if (txtidconsultation.Text=="")
                {
                    
                    txtidconsultation.BorderColor = Color.Red;
                    labelNonVide.Visible = true;
                }
                else
                {
                    EvolutionST ev = new EvolutionST(Int32.Parse(txtidconsultation.Text), Consultation.getLastEvoId(user), user.Cabinet.CurrentPatient.IdPatient, cmbState.Text, DateTime.Now);
                    user.Cabinet.CurrentEvolution = ev;

                    Consultation.appliquerEvolution(ev, user);
                    dataGridView1.Visible = true;
                    guna2Button2.Visible = true;
                    user.Cabinet.chargerLastEvolutions();
                    dataGridView1.DataSource = user.Cabinet.dtEvolution;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "N° Consultation";
                    dataGridView1.Columns[3].HeaderText = "Etat Evolution";
                    dataGridView1.Columns[4].HeaderText = "Date du Control";

                }

                
                

            }
            catch (Exception )
            {
                
                MessageBox.Show("un seul etat evolution est peut etre appliquée");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("Aucun Etat Evolution à annuler ");
            }
            else
            {
                try
                {
                    Consultation.RemoveCurrentEvolution(user);
                    user.Cabinet.chargerLastEvolutions();
                    dataGridView1.DataSource = user.Cabinet.dtEvolution;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            
        }

        private void txtidconsultation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidconsultation_Click(object sender, EventArgs e)
        {
            
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
                if (dataGridView1.Rows.Count==0)
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message) ;
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
    }
}
