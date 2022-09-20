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
    public partial class FormAdministrareur : Form
    {
        User User;
        public static string typeOfExam;
        public FormAdministrareur(User u)
        {
            InitializeComponent();
            this.User = u;
        }

     
        private void FormAdministrareur_Load(object sender, EventArgs e)
        {
            this.Text = "Bienvenue Mr " + User.Login.ToUpper();
        }

        private void testCnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.User.Cn.ToString());
        }       


        private void gérerUtilisateursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGestionUtilisateurs f = new FormGestionUtilisateurs(this.User);

            foreach (Form fr in this.MdiChildren)
            {
                fr.Close();
            }

            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();

        }

        private void gestionMedicamentToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void examenBiologiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeOfExam = "bio";
            foreach (Form fc in this.MdiChildren)
            {
                fc.Close();
            }
            FormGestionExamenBiologiqueEtRadiologique f = new FormGestionExamenBiologiqueEtRadiologique(User);
            f.MdiParent = this;
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();

        }

        private void examenRadiologiqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            typeOfExam = "radio";

            FormGestionExamenBiologiqueEtRadiologique f = new FormGestionExamenBiologiqueEtRadiologique(this.User);
            f.MdiParent = this;
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void examenEndoscopiqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            typeOfExam = "endoscopique";

            FormGestionExamenBiologiqueEtRadiologique f = new FormGestionExamenBiologiqueEtRadiologique(this.User);
            f.MdiParent = this;
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();

        }

        private void examenAnatomopathologiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeOfExam = "anatomo";

            FormGestionExamenBiologiqueEtRadiologique f = new FormGestionExamenBiologiqueEtRadiologique(this.User);
            f.MdiParent = this;
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void réduireToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void fermerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changerSessionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new AnimatedLogin().Show();
            this.Visible = false;
        }

        private void roleSurMedicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            FormGestionRoles fm = new FormGestionRoles(this.User);
            fm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            fm.MdiParent = this;
            fm.Show();

        }
    }
}
