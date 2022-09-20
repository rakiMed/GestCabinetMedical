namespace Cabinet
{
    partial class FormSecretaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretaire));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDattenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherParRefConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererAntecedentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reduireToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.anticeToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.reduireToolStripMenuItem1,
            this.sessionToolStripMenuItem,
            this.outilsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesPatientsToolStripMenuItem,
            this.chercherToolStripMenuItem,
            this.listeDattenteToolStripMenuItem,
            this.chercherParRefConsultationToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(61, 35);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // gérerLesPatientsToolStripMenuItem
            // 
            this.gérerLesPatientsToolStripMenuItem.Name = "gérerLesPatientsToolStripMenuItem";
            this.gérerLesPatientsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.gérerLesPatientsToolStripMenuItem.Text = "Gérer Les Patients";
            this.gérerLesPatientsToolStripMenuItem.Click += new System.EventHandler(this.gérerLesPatientsToolStripMenuItem_Click);
            // 
            // chercherToolStripMenuItem
            // 
            this.chercherToolStripMenuItem.Name = "chercherToolStripMenuItem";
            this.chercherToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.chercherToolStripMenuItem.Text = "Chercher ";
            this.chercherToolStripMenuItem.Click += new System.EventHandler(this.chercherToolStripMenuItem_Click);
            // 
            // listeDattenteToolStripMenuItem
            // 
            this.listeDattenteToolStripMenuItem.Name = "listeDattenteToolStripMenuItem";
            this.listeDattenteToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.listeDattenteToolStripMenuItem.Text = "Liste d\'attente";
            this.listeDattenteToolStripMenuItem.Click += new System.EventHandler(this.listeDattenteToolStripMenuItem_Click);
            // 
            // chercherParRefConsultationToolStripMenuItem
            // 
            this.chercherParRefConsultationToolStripMenuItem.Name = "chercherParRefConsultationToolStripMenuItem";
            this.chercherParRefConsultationToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.chercherParRefConsultationToolStripMenuItem.Text = "Chercher Par Ref Consultation";
            this.chercherParRefConsultationToolStripMenuItem.Click += new System.EventHandler(this.chercherParRefConsultationToolStripMenuItem_Click);
            // 
            // anticeToolStripMenuItem
            // 
            this.anticeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererAntecedentToolStripMenuItem});
            this.anticeToolStripMenuItem.Name = "anticeToolStripMenuItem";
            this.anticeToolStripMenuItem.Size = new System.Drawing.Size(80, 35);
            this.anticeToolStripMenuItem.Text = "Antecedent";
            // 
            // gererAntecedentToolStripMenuItem
            // 
            this.gererAntecedentToolStripMenuItem.Name = "gererAntecedentToolStripMenuItem";
            this.gererAntecedentToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gererAntecedentToolStripMenuItem.Text = "Gerer Antecedent";
            this.gererAntecedentToolStripMenuItem.Click += new System.EventHandler(this.gererAntecedentToolStripMenuItem_Click);
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionMédicamentsToolStripMenuItem});
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(91, 35);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // gestionMédicamentsToolStripMenuItem
            // 
            this.gestionMédicamentsToolStripMenuItem.Name = "gestionMédicamentsToolStripMenuItem";
            this.gestionMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionMédicamentsToolStripMenuItem.Text = "Gestion Médicaments";
            this.gestionMédicamentsToolStripMenuItem.Click += new System.EventHandler(this.gestionMédicamentsToolStripMenuItem_Click);
            // 
            // reduireToolStripMenuItem1
            // 
            this.reduireToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reduireToolStripMenuItem2});
            this.reduireToolStripMenuItem1.Name = "reduireToolStripMenuItem1";
            this.reduireToolStripMenuItem1.Size = new System.Drawing.Size(59, 35);
            this.reduireToolStripMenuItem1.Text = "Réduire";
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
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(58, 35);
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
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatriceToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.chromeToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 35);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // calculatriceToolStripMenuItem
            // 
            this.calculatriceToolStripMenuItem.Name = "calculatriceToolStripMenuItem";
            this.calculatriceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculatriceToolStripMenuItem.Text = "Calculatrice";
            this.calculatriceToolStripMenuItem.Click += new System.EventHandler(this.calculatriceToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // chromeToolStripMenuItem
            // 
            this.chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
            this.chromeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chromeToolStripMenuItem.Text = "Chrome";
            this.chromeToolStripMenuItem.Click += new System.EventHandler(this.chromeToolStripMenuItem_Click);
            // 
            // FormSecretaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 397);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSecretaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSecretaire_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererAntecedentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDattenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherParRefConsultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reduireToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionMédicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem;
    }
}