using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Cabinet
{
    public partial class FormMedcin : Form
    {
        User User;
        public static string TypeOfCertificat;
        public static string WishOne;
        string stateMedcin;
        public FormMedcin(User u)
        {
            InitializeComponent();
            this.User = u;
        }

        private void tousLesPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            FormPatientPourMecin fr = new FormPatientPourMecin(this.User);
            fr.MdiParent = this;
            fr.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            fr.Show();
            
           
            
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changerSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
             new AnimatedLogin().Show();
             this.Visible = false;
        }

        private void listeDattenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }

            FormListeAttentePourMedcin f = new FormListeAttentePourMedcin(User);
            f.MdiParent = this;
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void FormMedcin_Load(object sender, EventArgs e)
        {
            this.Text = "Bienvenue Mr " + User.Login.ToUpper();
            try
            {

                stateMedcin = User.Cabinet.chargerStateRoleMedicamentPourMedcin();
                if (stateMedcin == "desactivé")
                {
                    médicamentsToolStripMenuItem.Visible = false;
                }
                else
                {
                    médicamentsToolStripMenuItem.Visible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void tousLesConsultationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                User.Cabinet.CurrentConsultation = null;// pour metre a 0 le currentConsultation a chaque basculer entre menustrip liste, parceque la currentCunsultation peut garder l'existance malgré dans un cas quand on a aucun existance 

                WishOne = "tous";

                foreach (Form fc in this.MdiChildren)
                {
                    fc.Close();

                }

                FormChercherConsultation f = new FormChercherConsultation(User);

                f.MdiParent = this;
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                User.Cabinet.chargerTousLesconsultation();
                f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
                System.Drawing.Size sz = new Size(1100, 350);
                Point locat = new Point(140, 150);
                f.dataGridView1.Size = sz;
                f.dataGridView1.Location = locat;
                Point locattxt = new Point(1025, 515);
                f.gunaLabel1.Location = locattxt;
                f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count);

                // locat and  and text guna label2 
                Point locatGunaLabel2 = new Point(400, 80);

                f.gunaLabel2.Location = locatGunaLabel2;

                f.gunaLabel2.Text = "Toutes Les Consultations";
                //

                f.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void chercherParDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.Cabinet.CurrentConsultation = null;// pour metre a 0 le currentConsultation a chaque basculer entre menustrip liste, parceque la currentCunsultation peut garder l'existance malgré dans un cas quand on a aucun existance 
            
            WishOne = "date";
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();

            }

            FormChercherConsultation f = new FormChercherConsultation(User);

            f.MdiParent = this;
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.dateTimePicker1.Value = DateTime.Now;
            User.Cabinet.chargerConsultationParDate(f.dateTimePicker1.Value);
            f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
            f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count);


            System.Drawing.Size sz = new Size(1100, 350);
            Point locat = new Point(140, 180);
            f.dataGridView1.Size = sz;
            f.dataGridView1.Location = locat;
            f.grbxDate.Visible = true;
            // locat label guna
            Point locattxt = new Point(1030,550);
            f.gunaLabel1.Location = locattxt;
            //

            Point locationGrbx = new Point(144,60);
            f.grbxDate.Location = locationGrbx;

            // locat and  and text guna label2 
            Point locatGunaLabel2 = new Point(450, 90);
        
            f.gunaLabel2.Location = locatGunaLabel2;
          
            f.gunaLabel2.Text = "Les Consultations Selon La Date";
            //

            f.Show();

        }

        private void chercherParRefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.Cabinet.CurrentConsultation = null;// pour metre a 0 le currentConsultation a chaque basculer entre menustrip liste, parceque la currentCunsultation peut garder l'existance malgré dans un cas quand on a aucun existance 
            
            WishOne = "ref";
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();

            }

            FormChercherConsultation f = new FormChercherConsultation(User);

            f.MdiParent = this;
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            User.Cabinet.chargerConsultationParID(0);
            f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
            f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count );


            System.Drawing.Size sz = new Size(1100, 350);
            Point locat = new Point(140, 200);
            f.dataGridView1.Size = sz;
            f.dataGridView1.Location = locat;
            f.grbxIdConsultation.Visible = true;
            

            // location groupebox ref

            Point locatgrbx = new Point(145, 55);
            f.grbxIdConsultation.Location = locatgrbx;
            //

            //locat label guna
            Point locattxt = new Point(1030, 570);
            f.gunaLabel1.Location = locattxt;
            //

            // locat and  and text guna label2 
            Point locatGunaLabel2 = new Point(450, 90);
            
            f.gunaLabel2.Location = locatGunaLabel2;

            f.gunaLabel2.Text = "La Consultation Selon la Référence";
            //
            f.Show();
        }

        private void chercherParPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.Cabinet.CurrentConsultation = null;// pour metre a 0 le currentConsultation a chaque basculer entre menustrip liste, parceque la currentCunsultation peut garder l'existance malgré dans un cas quand on a aucun existance 
            
            WishOne = "patient";
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();

            }

            FormChercherConsultation f = new FormChercherConsultation(User);

            f.MdiParent = this;
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
           // seulement pour charger le vide dans la datagrid view pour qui elle contient des columns qui sont modifiés en load on ajoute ce code entre les deux commentaires suivants

            User.Cabinet.chargerConsultationParNomPatient(" ");
            f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
            f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count);
            // fin code
            System.Drawing.Size sz = new Size(1100, 350);
            Point locat = new Point(140, 200);
            f.dataGridView1.Size = sz;
            f.dataGridView1.Location = locat;
            f.grbxPatient.Visible = true;

            //locat label guna
            Point locattxt = new Point(1030, 570);
            f.gunaLabel1.Location = locattxt;
            //

            // location groupebox patient

            Point locatgrbx = new Point(145, 40);
            f.grbxPatient.Location = locatgrbx;
            //

            // locat and  and text guna label2 
            Point locatGunaLabel2 = new Point(450, 90);

            f.gunaLabel2.Location = locatGunaLabel2;

            f.gunaLabel2.Text = "Les Consultation Selon le Patient";
            //
            f.Show();
        }

        private void derniereConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
           
            WishOne = "derniere";
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();

            }

            FormChercherConsultation f = new FormChercherConsultation(User);

            f.MdiParent = this;
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            User.Cabinet.chargerConsultationParID(Consultation.getIdConsultationLastOne(User));
            f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
            System.Drawing.Size sz = new Size(1100, 350);
            Point locat = new Point(140, 180);
            f.dataGridView1.Size = sz;
            f.dataGridView1.Location = locat;
            //locat label guna
            Point locattxt = new Point(1030, 550);
            f.gunaLabel1.Location = locattxt;
            //
            f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count );

            // locat and  and text guna label2 
            Point locatGunaLabel2 = new Point(400, 90);

            f.gunaLabel2.Location = locatGunaLabel2;

            f.gunaLabel2.Text = "La dernière Consultation";
            //
            f.Show();

            if (User.Cabinet.dtConsultation.Rows.Count==1)
            {
                User.Cabinet.CurrentConsultation = new Consultation(Int32.Parse(User.Cabinet.dtConsultation.Rows[0][0].ToString()));

            }
            
        }

        private void reduireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reduireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void reduireToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormMessenger(User).Show();
        }

        private void certificatMedicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfCertificat = "withdate";
            FormImprCertificatMedical f = new FormImprCertificatMedical();
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void imprimésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void certificatMedicalDateVideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfCertificat = "withoutdate";
            FormImprCertificatMedical f = new FormImprCertificatMedical();
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void gestionMédicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            FormGestionMedicament fm = new FormGestionMedicament(this.User);
            fm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            fm.MdiParent = this;

            fm.Show();
        }
       
    }
}
