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
    public partial class FormPrescriptionMedicaments : Form
    {
        User User;
        public FormPrescriptionMedicaments(User u)
        {
            this.User = u;
            InitializeComponent();
        }

      

        private void txtchercher_TextChanged(object sender, EventArgs e)
        {
            try
            {

                User.Cabinet.chercherMedicament(txtchercher.Text);
                lstresult.DataSource = User.Cabinet.dtMedicament;
                lstresult.DisplayMember = User.Cabinet.dtMedicament.Columns[0].ToString();
                lstresult.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtchercher_Click(object sender, EventArgs e)
        {
            txtchercher.Clear();
            txtchercher.ForeColor = Color.Black;
        }

        private void lstresult_Click(object sender, EventArgs e)
        {
            cmbmedicament.Text = lstresult.Text;
            txtchercher.Clear();
            lstresult.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Dose dose = new Dose(this.cmbdose.Text, cmbpreiode.Text);
                MedicamentPrescri.ajouterDose(dose, User);

                MedicamentPrescri mdcp = new MedicamentPrescri(Consultation.getIdConsultationLastOne(User), cmbmedicament.Text, Dose.getIdDoseLastOnee(User), cmbDuree.Text);
                Consultation.ajouterMedicamentPrescri(mdcp, User);


                cmbmedicament.Text = "autre";
                cmbpreiode.Text = "";
                User.Cabinet.chargerDtMedicamentPrescri(Consultation.getIdConsultationLastOne(User));
                DataGridView1.DataSource = User.Cabinet.dtMedicamentPrescri;

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormPrescriptionMedicaments_Load(object sender, EventArgs e)
        {
            try
            {

                User.Cabinet.chargerDtMedicament();
                cmbmedicament.DataSource = User.Cabinet.dtMedicament;
                cmbmedicament.DisplayMember = User.Cabinet.dtMedicament.Columns[0].ToString();

                User.Cabinet.chargerDtMedicamentPrescri(Consultation.getIdConsultationLastOne(User));
                DataGridView1.DataSource = User.Cabinet.dtMedicamentPrescri;
                DataGridView1.Columns[0].Visible = false;
                Patient p;
                p = User.Cabinet.getNomPrenomPatientByIDConsultation(User.Cabinet.CurrentConsultation.IdConsultation);
                LabelPatient.Text = "Patient : " + p.Nom + "  " + p.Prenom + "";
                labelRefCons.Text = "Ref Consultation : " + User.Cabinet.CurrentConsultation.IdConsultation + " ";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           

            
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {

                Dose dose = new Dose(this.cmbdose.Text, cmbpreiode.Text);
                MedicamentPrescri.ajouterDose(dose, User);

                MedicamentPrescri mdcp = new MedicamentPrescri(Consultation.getIdConsultationLastOne(User), cmbmedicament.Text, Dose.getIdDoseLastOnee(User), cmbDuree.Text);
                Consultation.ajouterMedicamentPrescri(mdcp, User);


                cmbmedicament.Text = "autre";
                cmbpreiode.Text = " ";
                cmbdose.Text = " ";
                User.Cabinet.chargerDtMedicamentPrescri(Consultation.getIdConsultationLastOne(User));
                DataGridView1.DataSource = User.Cabinet.dtMedicamentPrescri;
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnmodifier_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (User.Cabinet.CurrentMedicamentPriscri == null)
                {
                    MessageBox.Show("Vous devez selectioner un medicament !");
                }
                else
                {
                    if (MessageBox.Show("Voullez vous vraiment modifier ce medicament ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Dose dose = new Dose(this.cmbdose.Text, cmbpreiode.Text);
                        MedicamentPrescri.modifierDose(dose, User);
                        Consultation.ModifierDureeTraitementPourMedicamentPrescri(User.Cabinet.CurrentMedicamentPriscri.IdConsultation, User.Cabinet.CurrentMedicamentPriscri, cmbDuree.Text, User);
                        User.Cabinet.chargerDtMedicamentPrescri(Consultation.getIdConsultationLastOne(User));
                        DataGridView1.DataSource = User.Cabinet.dtMedicamentPrescri;
                        DataGridView1.Columns[0].Visible = false;

                        cmbmedicament.Text = "autre";
                        cmbpreiode.Text = "";
                        cmbdose.Text = "";
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (User.Cabinet.CurrentMedicamentPriscri == null)
                {
                    MessageBox.Show("Vous devez selectioner un medicament !");
                }
                else
                {
                    if (MessageBox.Show("Voullez vous vraiment Retirer ce medicament ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Consultation.supprimerMedicamentPrescri(User);
                        User.Cabinet.chargerDtMedicamentPrescri(Consultation.getIdConsultationLastOne(User));
                        DataGridView1.DataSource = User.Cabinet.dtMedicamentPrescri;
                        DataGridView1.Columns[0].Visible = false;

                        cmbmedicament.Text = "autre";
                        cmbpreiode.Text = "";
                        cmbdose.Text = "";
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_Click_2(object sender, EventArgs e)
        {
            int pos;
            pos = DataGridView1.CurrentRow.Index;
            if (User.Cabinet.dtMedicamentPrescri.Rows.Count == 0)
            {
                MessageBox.Show("La liste est encore vide !");
            }
            else
            {
                if (pos < User.Cabinet.dtMedicamentPrescri.Rows.Count)
                {
                    User.Cabinet.CurrentMedicamentPriscri = new MedicamentPrescri(Consultation.getIdConsultationLastOne(User), User.Cabinet.dtMedicamentPrescri.Rows[pos][1].ToString(), Int32.Parse(User.Cabinet.dtMedicamentPrescri.Rows[pos][0].ToString()),User.Cabinet.dtMedicamentPrescri.Rows[pos][4].ToString());
                    this.cmbmedicament.Text = User.Cabinet.CurrentMedicamentPriscri.Medicament;
                    this.cmbdose.Text = User.Cabinet.dtMedicamentPrescri.Rows[pos][2].ToString();
                    cmbpreiode.Text = User.Cabinet.dtMedicamentPrescri.Rows[pos][3].ToString();
                    cmbDuree.Text = User.Cabinet.CurrentMedicamentPriscri.DureeTraitement;
                }
                else
                {
                    MessageBox.Show("Vous devez preciser votre selection !");
                }

            }
        }

        private void FormPrescriptionMedicaments_MouseClick(object sender, MouseEventArgs e)
        {
            lstresult.Visible = false;
        }

        private void txtchercher_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

                User.Cabinet.chercherMedicament(txtchercher.Text);
                lstresult.DataSource = User.Cabinet.dtMedicament;
                lstresult.DisplayMember = User.Cabinet.dtMedicament.Columns[0].ToString();
                lstresult.Visible = true;
                if (txtchercher.Text.Length > 0)
                {
                    labelClear.Visible = true;
                }
                else
                {
                    labelClear.Visible = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstresult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cmbmedicament.Text = "autre";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cmbmedicament.Text = "autre";
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FormGestionMedicament f= new FormGestionMedicament(User);
            f.ControlBox = true;
            f.MinimizeBox = true;
            f.MaximizeBox = true;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            System.Drawing.Size size = new Size(864, 499);
            f.Size = size;
            f.guna2Panel3.Top = 1;
            f.guna2Panel3.Left = 1;
            f.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            f.Show();

        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            txtchercher.Clear();
        }        
    }
}
