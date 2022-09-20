using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cabinet
{
    public partial class FormSecretaire : Form
    {
        public User User;
        
        string stateSecretaire;

        public FormSecretaire(User u)
        {
            InitializeComponent();
            this.User = u;
        }

        private void FormSecretaire_Load(object sender, EventArgs e)
        {
            this.Text = "Bienvenue  mlle / mme " + User.Login.ToString();

            try
            {
               
                stateSecretaire = User.Cabinet.chargerStateRoleMedicamentPourSecretaire();
                if (stateSecretaire=="desactivé")
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

        private void gérerLesPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionPatients f = new FormGestionPatients(this.User);

            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            f.MdiParent = this;
            
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();

        }

        private void changerSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AnimatedLogin().Show();
            this.Visible = false;
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChercherPatient f = new FormChercherPatient(this.User);

            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            f.MdiParent = this;
           
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void gererAntecedentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            FormAntecedent fr = new FormAntecedent(this.User);
            fr.MdiParent = this;
            fr.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            fr.Show();
            

        }

        private void listeDattenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }

            FormListeAttente fr = new FormListeAttente(User);

            fr.MdiParent = this;
            fr.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            fr.Show();


        }

        private void chercherParRefConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }

            FormPatientParRefConsult fr = new FormPatientParRefConsult(User);

            fr.MdiParent = this;
            fr.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            fr.Show();
        }

        private void reduireToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
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

        private void calculatriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("WINWORD.exe");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("EXCEL.exe");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome.exe");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }


    }
}
