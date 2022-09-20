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
    public partial class FormChercherConsultation : Form
    {
        User user;
        public FormChercherConsultation(User u)
        {
            this.user = u;
            InitializeComponent();
        }

        private void FormChercherConsultation_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns[0].HeaderText = "Ref Consultation";
                dataGridView1.Columns[1].HeaderText = "Nom";
                dataGridView1.Columns[2].HeaderText = "Prénom";
                dataGridView1.Columns[3].HeaderText = "CIN";
                dataGridView1.Columns[4].HeaderText = "Maladie";
                dataGridView1.Columns[5].HeaderText = "Remarque";
                dataGridView1.Columns[6].HeaderText = "Date Consultation";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
          
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            user.Cabinet.chargerConsultationParDate(dateTimePicker1.Value);
            dataGridView1.DataSource = user.Cabinet.dtConsultation;
            gunaLabel1.Text = "Nombre De Consultation :" + (dataGridView1.Rows.Count);
        }

        private void txtidconsultation_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void txtCIN_TextChanged(object sender, EventArgs e)
        {

            
           
        }

        private void btnchercher_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            

           
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void analysesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void supprimerConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                   if (user.Cabinet.CurrentConsultation==null)
                 {
                MessageBox.Show("Vous devez selectionner une Consultation !");
                 }
                  else
                  {
                if (MessageBox.Show("Voullez Vous Vraiment Supprimer la Consultation :" + user.Cabinet.CurrentConsultation.IdConsultation + "", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    user.Cabinet.SupprimerConsultation(user.Cabinet.CurrentConsultation.IdConsultation);
                    user.Cabinet.CurrentConsultation = null;
                    switch (FormMedcin.WishOne)
                    {
                        case "tous": user.Cabinet.chargerTousLesconsultation();
                                     dataGridView1.DataSource = user.Cabinet.dtConsultation;
                                     gunaLabel1.Text = "Nombre De Consultation :" + (dataGridView1.Rows.Count);
                            break;
                        case "date": dateTimePicker1.Value = DateTime.Now;
                                     user.Cabinet.chargerConsultationParDate(dateTimePicker1.Value);
                                     dataGridView1.DataSource = user.Cabinet.dtConsultation;
                                     gunaLabel1.Text = "Nombre De Consultation :" + (dataGridView1.Rows.Count);
                            break;
                        case "ref": user.Cabinet.chargerConsultationParID(Int32.Parse(txtidconsultation.Text));
                                    dataGridView1.DataSource = user.Cabinet.dtConsultation;
                                     gunaLabel1.Text = "Nombre De Consultation :" + (dataGridView1.Rows.Count);
                            break;
                        case "patient": user.Cabinet.chargerConsultationParNomPatient(txtNom.Text);
                                         dataGridView1.DataSource = user.Cabinet.dtConsultation;
                                         gunaLabel1.Text = "Nombre De Consultation :" + (dataGridView1.Rows.Count );
                            break;
                        case "derniere": user.Cabinet.chargerConsultationParID(Consultation.getIdConsultationLastOne(user));
                                         dataGridView1.DataSource = user.Cabinet.dtConsultation;
                                         gunaLabel1.Text = "Nombre De Consultation :" + (dataGridView1.Rows.Count);
                            break;
                    }


                }
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
           
        }

        private void imprimerOrdonanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Cabinet.CurrentConsultation==null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation à Imprimer");
            }
            else
            {
                FormOrdonance f = new FormOrdonance(user);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
            
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Cabinet.CurrentConsultation==null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation");
            }
            else
            {
                new FormPrescriptionViewr(user).Show();
            }
        }

        private void modifierMaladieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Cabinet.CurrentConsultation==null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation !");   
            }
            else
            {
                FormUpdateMaladie f = new FormUpdateMaladie(user, this.MdiParent);
                f.Show();
            }
          
        }

        private void modifierRemarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Cabinet.CurrentConsultation == null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation !");
            }
            else
            {
                FormUpdateMaladie f = new FormUpdateMaladie(user, this.MdiParent);
                f.labelMR.Text = "Remarque";
                f.Show();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            try
            {


                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("La liste des Consultation est encore vide !");
                }
                else
                {
                    int pos = dataGridView1.CurrentRow.Index;

                    user.Cabinet.CurrentConsultation = new Consultation(Int32.Parse(user.Cabinet.dtConsultation.Rows[pos][0].ToString()));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                user.Cabinet.chargerConsultationParDate(dateTimePicker1.Value);
                dataGridView1.DataSource = user.Cabinet.dtConsultation;
                gunaLabel1.Text = "Nombre De Consultation :" + (dataGridView1.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void imprimerExamenBiologiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (user.Cabinet.CurrentConsultation == null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation d'abord !");
            }
            else
            {
                FormImprExamenBG f = new FormImprExamenBG(user);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show(); 
            }
            
            
        }

        private void btnchercher_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtidconsultation.Text == "")
                {
                    MessageBox.Show("saisir un reference d'abord !");
                }
                else
                {
                    user.Cabinet.chargerConsultationParID(Int32.Parse(txtidconsultation.Text));
                    dataGridView1.DataSource = user.Cabinet.dtConsultation;
                    this.gunaLabel1.Text = "Nombre De Consultation :" + (dataGridView1.Rows.Count);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }

        private void txtNom_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                user.Cabinet.chargerConsultationParNomPatient(txtNom.Text);
                dataGridView1.DataSource = user.Cabinet.dtConsultation;
                this.gunaLabel1.Text = "Nombre De Consultation :" + (dataGridView1.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtCIN_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                user.Cabinet.chargerConsultationParCinPatient(txtCIN.Text);
                dataGridView1.DataSource = user.Cabinet.dtConsultation;
                this.gunaLabel1.Text = "Nombre De Consultation :" + (dataGridView1.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void voirExamenRadiologiqueToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void imprimerExamenRadiologiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Cabinet.CurrentConsultation == null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation d'abord !");
            }
            else
            {
                FormImprExamenRD f = new FormImprExamenRD(user);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void voirExamenEndoscopiqueToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void imprimerExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Cabinet.CurrentConsultation == null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation d'abord !");
            }
            else
            {
                FormImprExamenENDO f = new FormImprExamenENDO(user);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        private void voirExamenAnatomopathologiqueToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void imprimerExamenAnatomopathologiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Cabinet.CurrentConsultation == null)
            {
                MessageBox.Show("Vous devez selectionner une Consultation d'abord !");
            }
            else
            {
                FormImprExamenANATOMO f = new FormImprExamenANATOMO(user);
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                f.Show();
            }
        }

        
        
    }
}
