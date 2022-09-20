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
    public partial class FormPrescriptionViewr : Form
    {
        User User;
        public FormPrescriptionViewr(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void FormPrescriptionViewr_Load(object sender, EventArgs e)
        {
            try
            {

                Patient p;
                User.Cabinet.chargerDtMedicament();
                cmbmedicament.DataSource = User.Cabinet.dtMedicament;
                cmbmedicament.DisplayMember = User.Cabinet.dtMedicament.Columns[0].ToString();

                User.Cabinet.chargerDtMedicamentPrescri(User.Cabinet.CurrentConsultation.IdConsultation);
                DataGridView1.DataSource = User.Cabinet.dtMedicamentPrescri;
                DataGridView1.Columns[0].Visible = false;

                p = User.Cabinet.getNomPrenomPatientByIDConsultation(User.Cabinet.CurrentConsultation.IdConsultation);
                LabelPatient.Text = "Patient : " + p.Nom + "  " + p.Prenom + "";
                labelRefCons.Text = "Ref Consultation : " + User.Cabinet.CurrentConsultation.IdConsultation + " ";

                Point location = new Point(134, 160);
                this.DataGridView1.Location = location;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

                    }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaGoogleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == false)
            {
                this.btnAjouter.Visible = false;
                this.btnModifier.Visible = false;
                this.btnSupp.Visible = false;
                this.txtchercher.Visible = false;
                this.lstresult.Visible = false;
                this.cmbmedicament.Visible = false;
                this.cmbpreiode.Visible = false;
                this.cmbdose.Visible = false;
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.label4.Visible = false;
                this.cmbDuree.Visible = false;
                this.label5.Visible = false;
                Point location = new Point(134, 160);
                this.DataGridView1.Location = location;

                Point locationImageImpr = new Point(581,421);
                Point locationLabelImp = new Point(449,458);
                label6.Location = locationLabelImp;
                guna2PictureBoxImp.Location = locationImageImpr;

            }
            else
            {
                this.btnAjouter.Visible = true;
                this.btnModifier.Visible = true;
                this.btnSupp.Visible = true;
                this.txtchercher.Visible = true;

                this.cmbmedicament.Visible = true;
                this.cmbpreiode.Visible = true;
                this.cmbdose.Visible = true;
                this.label1.Visible = true;
                this.label2.Visible = true;
                this.label4.Visible = true;
                this.cmbDuree.Visible = true;
                this.label5.Visible = true;

                Point location = new Point(64, 381);
                this.DataGridView1.Location = location;


                Point locationImageImpr = new Point(686,631);
                Point locationLabelImp = new Point(554,668);
                label6.Location = locationLabelImp;
                guna2PictureBoxImp.Location = locationImageImpr;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Dose dose = new Dose(this.cmbdose.Text, cmbpreiode.Text);
                MedicamentPrescri.ajouterDose(dose, User);

                MedicamentPrescri mdcp = new MedicamentPrescri(User.Cabinet.CurrentConsultation.IdConsultation, cmbmedicament.Text, Dose.getIdDoseLastOnee(User), cmbDuree.Text);
                Consultation.ajouterMedicamentPrescri(mdcp, User);


                cmbmedicament.Text = "autre";
                cmbpreiode.Text = "";
                User.Cabinet.chargerDtMedicamentPrescri(User.Cabinet.CurrentConsultation.IdConsultation);
                DataGridView1.DataSource = User.Cabinet.dtMedicamentPrescri;

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }     
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
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
                        User.Cabinet.chargerDtMedicamentPrescri(User.Cabinet.CurrentConsultation.IdConsultation);
                        DataGridView1.DataSource = User.Cabinet.dtMedicamentPrescri;
                        DataGridView1.Columns[0].Visible = false;

                        cmbmedicament.Text = "autre";
                        cmbpreiode.Text = "";
                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
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
                        User.Cabinet.chargerDtMedicamentPrescri(User.Cabinet.CurrentConsultation.IdConsultation);
                        DataGridView1.DataSource = User.Cabinet.dtMedicamentPrescri;
                        DataGridView1.Columns[0].Visible = false;

                        cmbmedicament.Text = "autre";
                        cmbpreiode.Text = "";
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            int pos;

            if (DataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("La liste est encore vide !");
            }
            else
            {
                pos = DataGridView1.CurrentRow.Index;


                User.Cabinet.CurrentMedicamentPriscri = new MedicamentPrescri(Consultation.getIdConsultationLastOne(User), User.Cabinet.dtMedicamentPrescri.Rows[pos][1].ToString(), Int32.Parse(User.Cabinet.dtMedicamentPrescri.Rows[pos][0].ToString()), User.Cabinet.dtMedicamentPrescri.Rows[pos][4].ToString());
                this.cmbmedicament.Text = User.Cabinet.CurrentMedicamentPriscri.Medicament;
                this.cmbdose.Text = User.Cabinet.dtMedicamentPrescri.Rows[pos][2].ToString();
                cmbpreiode.Text = User.Cabinet.dtMedicamentPrescri.Rows[pos][3].ToString();
                cmbDuree.Text = User.Cabinet.CurrentMedicamentPriscri.DureeTraitement;


            }
        }

        private void btnAjouter_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnAjouter_MouseLeave(object sender, EventArgs e)
        {
            btnAjouter.Text = "Ajouter";
        }

        private void btnAjouter_MouseMove(object sender, MouseEventArgs e)
        {
            btnAjouter.Text = "                     Ajouter";
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

        private void FormPrescriptionViewr_MouseClick(object sender, MouseEventArgs e)
        {
            lstresult.Visible = false;
        }

        private void guna2PictureBoxImp_MouseMove(object sender, MouseEventArgs e)
        {
            label6.Visible = true;
        }

        private void guna2PictureBoxImp_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void guna2PictureBoxImp_Click(object sender, EventArgs e)
        {
            new FormOrdonance(User).Show();
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            txtchercher.Clear();
        }

        private void labelClear_MouseHover(object sender, EventArgs e)
        {

           
        }
    }
}
