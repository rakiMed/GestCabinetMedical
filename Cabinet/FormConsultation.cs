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
    public partial class FormConsultation : Form
    {
        public static string HistoriqueType;
        User User;
        public static string TypeOfExamen;
        public FormConsultation(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void FormConsultation_Load(object sender, EventArgs e)
        {
            try
            {
                this.labelPatient.Text = " Patient En Cours De Consultation :" + User.Cabinet.CurrentPatient.Nom + " " + User.Cabinet.CurrentPatient.Prenom;
                Consultation consultation = new Consultation(User.Cabinet.CurrentPatient.IdPatient, DateTime.Now, txtmaladie.Text, txtremarque.Text);

                User.Cabinet.ajouterConsultation(consultation);
                User.Cabinet.CurrentConsultation = new Consultation();
                User.Cabinet.CurrentConsultation.IdConsultation = Consultation.getIdConsultationLastOne(User);
                this.labelnumCons.Text = "Consultation ID:" + User.Cabinet.CurrentConsultation.IdConsultation;

                this.txtmaladie.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(User.Cabinet.CurrentPatient.Poids.ToString() + " KG");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
                        
        }

        private void btnannulerConsultation_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

      

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
            
        }

       

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnValiderConsultation_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmaladie.Text == "")
                {
                    MessageBox.Show("Vous devez remplir le champ maladie ");
                }
                else
                {
                    if (MessageBox.Show("Valider et Quitter La consultation ?", "Etes vous sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        User.Cabinet.updateConsultation(Consultation.getIdConsultationLastOne(User), txtmaladie.Text, txtremarque.Text);
                        MessageBox.Show("La Consultation est bien validée !");

                        User.Cabinet.retirerPatientduSalleAttente(User.Cabinet.CurrentPatient);
                        FormListeAttentePourMedcin f = new FormListeAttentePourMedcin(User);
                        f.MdiParent = this.MdiParent;
                        f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                        f.Show();


                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnannulerConsultation_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Voulez Vous Vraiment Annuler La Consultation ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    User.Cabinet.SupprimerConsultation(Consultation.getIdConsultationLastOne(User));

                    FormListeAttentePourMedcin f = new FormListeAttentePourMedcin(User);
                    f.MdiParent = this.MdiParent;
                    f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    f.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }

        private void btnImpriExamenB_Click(object sender, EventArgs e)
        {
            FormImprExamenBG f = new FormImprExamenBG(User);
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new FormPrescriptionMedicaments(User).Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            TypeOfExamen = "bio";
            new FormDemmandeExamen(User).Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FormOrdonance f = new FormOrdonance(User);
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            FormAjoutAntecedent f = new FormAjoutAntecedent(User);
            f.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            f.btnAjouter.Visible = false;
            f.btnSupp.Visible = false;
            f.btnModifier.Visible = false;
            f.lblpatient.BackColor = Color.Transparent;
            
            f.label4.Visible = false;
            Point p = new Point(29, 80);

            Point size = new Point(733, 355);
            f.dataGridView2.Location = p;


            System.Drawing.Size sz = new Size(733, 300);
            f.Size = sz;
            f.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(User.Cabinet.CurrentPatient.Poids.ToString() + " KG");
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            int anneNaiss = User.Cabinet.CurrentPatient.DateNaissance.Year;
            int anneeActuel = DateTime.Now.Year;
            int age = anneeActuel - anneNaiss;
            MessageBox.Show(age + " ans");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            new FormHistory(this, User).Show();
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MdiParent.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void guna2Panel21_MouseMove(object sender, MouseEventArgs e)
        {
                guna2Panel21.BackColor = Color.FromArgb(46, 51, 73);      
                System.Windows.Forms.Padding p =new System.Windows.Forms.Padding(1,1,1,1);
                guna2Panel21.CustomBorderThickness = p;
            
        }

        private void guna2Panel21_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel21.BackColor = Color.FromArgb(24, 30, 54);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(0, 0,0,0);
            guna2Panel21.CustomBorderThickness = p;
        }

        private void guna2Panel11_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel11.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel11.CustomBorderThickness = p;
            txtmaladie.Focus();
        }

        private void guna2Panel11_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel11.BackColor = Color.FromArgb(24, 30, 54);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(0, 0, 0, 0);
            guna2Panel11.CustomBorderThickness = p;
        }

        private void guna2Panel6_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel6.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel6.CustomBorderThickness = p;
        }

        private void guna2Panel6_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel6.BackColor = Color.FromArgb(24, 30, 54);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(0, 0, 0, 0);
            guna2Panel6.CustomBorderThickness = p;
        }

        private void guna2Panel16_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel16.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel16.CustomBorderThickness = p;
        }

        private void guna2Panel16_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel16.BackColor = Color.FromArgb(24, 30, 54);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(0, 0, 0, 0);
            guna2Panel16.CustomBorderThickness = p;
        }

        private void guna2Panel26_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel26.BackColor = Color.FromArgb(24, 30, 54);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(0, 0, 0, 0);
            guna2Panel26.CustomBorderThickness = p;
        }

        private void guna2Panel26_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel26.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel26.CustomBorderThickness = p;
        }

        private void guna2Panel5_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel5.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel5.CustomBorderThickness = p;
        }

        private void guna2Panel5_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel5.BackColor = Color.FromArgb(24, 30, 54);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(0, 0, 0, 0);
            guna2Panel5.CustomBorderThickness = p;
        }

        private void txtmaladie_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel11.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel11.CustomBorderThickness = p;
        }

        private void txtremarque_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel11.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel11.CustomBorderThickness = p;
        }

        private void guna2Button2_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel21.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel21.CustomBorderThickness = p;
        }

        private void guna2Button3_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel21.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel21.CustomBorderThickness = p;
        }

        private void guna2Button6_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel6.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel6.CustomBorderThickness = p;
        }

        private void guna2Button7_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel6.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel6.CustomBorderThickness = p;
        }

        private void guna2Button8_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel6.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel6.CustomBorderThickness = p;
        }

        private void guna2Button9_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel5.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel5.CustomBorderThickness = p;
        }

        private void guna2Button4_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel26.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel26.CustomBorderThickness = p;
        }

        private void btnImpriExamenB_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel26.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel26.CustomBorderThickness = p;
        }

        private void guna2Button1_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel16.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel16.CustomBorderThickness = p;
        }

        private void btnValiderConsultation_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel16.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel16.CustomBorderThickness = p;
        }

        private void btnannulerConsultation_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel16.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Padding p = new System.Windows.Forms.Padding(1, 1, 1, 1);
            guna2Panel16.CustomBorderThickness = p;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            TypeOfExamen = "radio";
            new FormDemmandeExamen(User).Show();
        }

        private void btnImpriExamenRD_Click(object sender, EventArgs e)
        {
            FormImprExamenRD f = new FormImprExamenRD(User);
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void btnDemmandeEndoscopie_Click(object sender, EventArgs e)
        {
            TypeOfExamen = "endoscopique";
            new FormDemmandeExamen(User).Show();
        }

        private void btnImprEndosco_Click(object sender, EventArgs e)
        {
            FormImprExamenENDO f = new FormImprExamenENDO(User);
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void btnDemmandeAnatomo_Click(object sender, EventArgs e)
        {
            TypeOfExamen = "anatomo";
            new FormDemmandeExamen(User).Show();
        }

        private void btnImpriExAnaT_Click(object sender, EventArgs e)
        {
            FormImprExamenANATOMO f = new FormImprExamenANATOMO(User);
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();

        }

        

      

       

       
    }
}
