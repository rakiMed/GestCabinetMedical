namespace Cabinet
{
    partial class FormMedcin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedcin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tousLesPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDattenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tousLesConsultationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherParDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherParRefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherParPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derniereConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificatMedicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificatMedicalDateVideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reduireToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.imprimésToolStripMenuItem,
            this.reduireToolStripMenuItem1,
            this.sessionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 41);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tousLesPatientsToolStripMenuItem,
            this.listeDattenteToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(61, 37);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // tousLesPatientsToolStripMenuItem
            // 
            this.tousLesPatientsToolStripMenuItem.Name = "tousLesPatientsToolStripMenuItem";
            this.tousLesPatientsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tousLesPatientsToolStripMenuItem.Text = "Tous les patients";
            this.tousLesPatientsToolStripMenuItem.Click += new System.EventHandler(this.tousLesPatientsToolStripMenuItem_Click);
            // 
            // listeDattenteToolStripMenuItem
            // 
            this.listeDattenteToolStripMenuItem.Name = "listeDattenteToolStripMenuItem";
            this.listeDattenteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listeDattenteToolStripMenuItem.Text = "Liste d\'attente";
            this.listeDattenteToolStripMenuItem.Click += new System.EventHandler(this.listeDattenteToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tousLesConsultationsToolStripMenuItem,
            this.chercherParDateToolStripMenuItem,
            this.chercherParRefToolStripMenuItem,
            this.chercherParPatientToolStripMenuItem,
            this.derniereConsultationToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 37);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // tousLesConsultationsToolStripMenuItem
            // 
            this.tousLesConsultationsToolStripMenuItem.Name = "tousLesConsultationsToolStripMenuItem";
            this.tousLesConsultationsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tousLesConsultationsToolStripMenuItem.Text = "Tous les Consultations";
            this.tousLesConsultationsToolStripMenuItem.Click += new System.EventHandler(this.tousLesConsultationsToolStripMenuItem_Click);
            // 
            // chercherParDateToolStripMenuItem
            // 
            this.chercherParDateToolStripMenuItem.Name = "chercherParDateToolStripMenuItem";
            this.chercherParDateToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.chercherParDateToolStripMenuItem.Text = "Chercher Par Date";
            this.chercherParDateToolStripMenuItem.Click += new System.EventHandler(this.chercherParDateToolStripMenuItem_Click);
            // 
            // chercherParRefToolStripMenuItem
            // 
            this.chercherParRefToolStripMenuItem.Name = "chercherParRefToolStripMenuItem";
            this.chercherParRefToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.chercherParRefToolStripMenuItem.Text = "Chercher Par ref";
            this.chercherParRefToolStripMenuItem.Click += new System.EventHandler(this.chercherParRefToolStripMenuItem_Click);
            // 
            // chercherParPatientToolStripMenuItem
            // 
            this.chercherParPatientToolStripMenuItem.Name = "chercherParPatientToolStripMenuItem";
            this.chercherParPatientToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.chercherParPatientToolStripMenuItem.Text = "Chercher Par Patient";
            this.chercherParPatientToolStripMenuItem.Click += new System.EventHandler(this.chercherParPatientToolStripMenuItem_Click);
            // 
            // derniereConsultationToolStripMenuItem
            // 
            this.derniereConsultationToolStripMenuItem.Name = "derniereConsultationToolStripMenuItem";
            this.derniereConsultationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.derniereConsultationToolStripMenuItem.Text = "Derniere Consultation";
            this.derniereConsultationToolStripMenuItem.Click += new System.EventHandler(this.derniereConsultationToolStripMenuItem_Click);
            // 
            // imprimésToolStripMenuItem
            // 
            this.imprimésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.certificatMedicalToolStripMenuItem,
            this.certificatMedicalDateVideToolStripMenuItem});
            this.imprimésToolStripMenuItem.Name = "imprimésToolStripMenuItem";
            this.imprimésToolStripMenuItem.Size = new System.Drawing.Size(69, 37);
            this.imprimésToolStripMenuItem.Text = "Imprimés";
            this.imprimésToolStripMenuItem.Click += new System.EventHandler(this.imprimésToolStripMenuItem_Click);
            // 
            // certificatMedicalToolStripMenuItem
            // 
            this.certificatMedicalToolStripMenuItem.Name = "certificatMedicalToolStripMenuItem";
            this.certificatMedicalToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.certificatMedicalToolStripMenuItem.Text = "Certificat Medical";
            this.certificatMedicalToolStripMenuItem.Click += new System.EventHandler(this.certificatMedicalToolStripMenuItem_Click);
            // 
            // certificatMedicalDateVideToolStripMenuItem
            // 
            this.certificatMedicalDateVideToolStripMenuItem.Name = "certificatMedicalDateVideToolStripMenuItem";
            this.certificatMedicalDateVideToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.certificatMedicalDateVideToolStripMenuItem.Text = "Certificat Medical Date Vide";
            this.certificatMedicalDateVideToolStripMenuItem.Click += new System.EventHandler(this.certificatMedicalDateVideToolStripMenuItem_Click);
            // 
            // reduireToolStripMenuItem1
            // 
            this.reduireToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reduireToolStripMenuItem2});
            this.reduireToolStripMenuItem1.Name = "reduireToolStripMenuItem1";
            this.reduireToolStripMenuItem1.Size = new System.Drawing.Size(59, 37);
            this.reduireToolStripMenuItem1.Text = "Réduire";
            this.reduireToolStripMenuItem1.Click += new System.EventHandler(this.reduireToolStripMenuItem1_Click);
            // 
            // reduireToolStripMenuItem2
            // 
            this.reduireToolStripMenuItem2.Name = "reduireToolStripMenuItem2";
            this.reduireToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.reduireToolStripMenuItem2.Text = "Réduire";
            this.reduireToolStripMenuItem2.Click += new System.EventHandler(this.reduireToolStripMenuItem2_Click);
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerSessionToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(58, 37);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // changerSessionToolStripMenuItem
            // 
            this.changerSessionToolStripMenuItem.Name = "changerSessionToolStripMenuItem";
            this.changerSessionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.changerSessionToolStripMenuItem.Text = "Changer Session";
            this.changerSessionToolStripMenuItem.Click += new System.EventHandler(this.changerSessionToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fermerToolStripMenuItem.Text = "Quitter";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionMédicamentsToolStripMenuItem});
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(91, 37);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // gestionMédicamentsToolStripMenuItem
            // 
            this.gestionMédicamentsToolStripMenuItem.Name = "gestionMédicamentsToolStripMenuItem";
            this.gestionMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionMédicamentsToolStripMenuItem.Text = "Gestion Médicaments";
            this.gestionMédicamentsToolStripMenuItem.Click += new System.EventHandler(this.gestionMédicamentsToolStripMenuItem_Click);
            // 
            // FormMedcin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(685, 390);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMedcin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMedcin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tousLesPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDattenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tousLesConsultationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherParDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherParRefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherParPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derniereConsultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reduireToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem imprimésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificatMedicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificatMedicalDateVideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionMédicamentsToolStripMenuItem;
    }
}