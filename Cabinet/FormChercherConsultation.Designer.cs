namespace Cabinet
{
    partial class FormChercherConsultation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChercherConsultation));
            this.grbxDate = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.grbxIdConsultation = new System.Windows.Forms.GroupBox();
            this.txtidconsultation = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnchercher = new Guna.UI2.WinForms.Guna2Button();
            this.grbxPatient = new System.Windows.Forms.GroupBox();
            this.txtCIN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerOrdonanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerExamenBiologiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerExamenRadiologiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerExamenAnatomopathologiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirExamenRadiologiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirExamenEndoscopiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirExamenAnatomopathologiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMaladieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierRemarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaLabel2 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.grbxDate.SuspendLayout();
            this.grbxIdConsultation.SuspendLayout();
            this.grbxPatient.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbxDate
            // 
            this.grbxDate.Controls.Add(this.dateTimePicker1);
            this.grbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.grbxDate.Location = new System.Drawing.Point(307, 438);
            this.grbxDate.Name = "grbxDate";
            this.grbxDate.Size = new System.Drawing.Size(312, 79);
            this.grbxDate.TabIndex = 4;
            this.grbxDate.TabStop = false;
            this.grbxDate.Text = "Chercher Par Date";
            this.grbxDate.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CheckedState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.FillColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.HoverState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 27);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShadowDecoration.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 36);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dateTimePicker1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.dateTimePicker1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.dateTimePicker1.Value = new System.DateTime(2020, 10, 28, 22, 6, 16, 679);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // grbxIdConsultation
            // 
            this.grbxIdConsultation.Controls.Add(this.txtidconsultation);
            this.grbxIdConsultation.Controls.Add(this.btnchercher);
            this.grbxIdConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxIdConsultation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.grbxIdConsultation.Location = new System.Drawing.Point(31, 354);
            this.grbxIdConsultation.Name = "grbxIdConsultation";
            this.grbxIdConsultation.Size = new System.Drawing.Size(270, 135);
            this.grbxIdConsultation.TabIndex = 5;
            this.grbxIdConsultation.TabStop = false;
            this.grbxIdConsultation.Text = "Chercher Par Ref Consultation";
            this.grbxIdConsultation.Visible = false;
            // 
            // txtidconsultation
            // 
            this.txtidconsultation.BorderRadius = 3;
            this.txtidconsultation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidconsultation.DefaultText = "";
            this.txtidconsultation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidconsultation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidconsultation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidconsultation.DisabledState.Parent = this.txtidconsultation;
            this.txtidconsultation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidconsultation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidconsultation.FocusedState.Parent = this.txtidconsultation;
            this.txtidconsultation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidconsultation.HoverState.Parent = this.txtidconsultation;
            this.txtidconsultation.Location = new System.Drawing.Point(37, 31);
            this.txtidconsultation.Margin = new System.Windows.Forms.Padding(4);
            this.txtidconsultation.Name = "txtidconsultation";
            this.txtidconsultation.PasswordChar = '\0';
            this.txtidconsultation.PlaceholderText = "Saisir Ref Consultation";
            this.txtidconsultation.SelectedText = "";
            this.txtidconsultation.ShadowDecoration.Parent = this.txtidconsultation;
            this.txtidconsultation.Size = new System.Drawing.Size(197, 44);
            this.txtidconsultation.TabIndex = 16;
            // 
            // btnchercher
            // 
            this.btnchercher.BorderRadius = 5;
            this.btnchercher.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnchercher.CheckedState.Parent = this.btnchercher;
            this.btnchercher.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnchercher.CustomImages.Parent = this.btnchercher;
            this.btnchercher.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnchercher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.btnchercher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnchercher.ForeColor = System.Drawing.Color.White;
            this.btnchercher.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchercher.HoverState.Parent = this.btnchercher;
            this.btnchercher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnchercher.Location = new System.Drawing.Point(37, 89);
            this.btnchercher.Name = "btnchercher";
            this.btnchercher.ShadowDecoration.Parent = this.btnchercher;
            this.btnchercher.Size = new System.Drawing.Size(197, 30);
            this.btnchercher.TabIndex = 16;
            this.btnchercher.Text = "Chercher";
            this.btnchercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnchercher.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnchercher.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnchercher.Click += new System.EventHandler(this.btnchercher_Click_1);
            // 
            // grbxPatient
            // 
            this.grbxPatient.Controls.Add(this.txtCIN);
            this.grbxPatient.Controls.Add(this.txtNom);
            this.grbxPatient.Controls.Add(this.label4);
            this.grbxPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.grbxPatient.Location = new System.Drawing.Point(808, 189);
            this.grbxPatient.Name = "grbxPatient";
            this.grbxPatient.Size = new System.Drawing.Size(248, 137);
            this.grbxPatient.TabIndex = 6;
            this.grbxPatient.TabStop = false;
            this.grbxPatient.Text = "Chercher Par Patient";
            this.grbxPatient.Visible = false;
            // 
            // txtCIN
            // 
            this.txtCIN.BorderRadius = 3;
            this.txtCIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCIN.DefaultText = "";
            this.txtCIN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCIN.DisabledState.Parent = this.txtCIN;
            this.txtCIN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCIN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCIN.FocusedState.Parent = this.txtCIN;
            this.txtCIN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCIN.HoverState.Parent = this.txtCIN;
            this.txtCIN.Location = new System.Drawing.Point(38, 83);
            this.txtCIN.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.PasswordChar = '\0';
            this.txtCIN.PlaceholderText = "Saisir CIN";
            this.txtCIN.SelectedText = "";
            this.txtCIN.ShadowDecoration.Parent = this.txtCIN;
            this.txtCIN.Size = new System.Drawing.Size(178, 38);
            this.txtCIN.TabIndex = 18;
            this.txtCIN.TextChanged += new System.EventHandler(this.txtCIN_TextChanged_1);
            // 
            // txtNom
            // 
            this.txtNom.BorderRadius = 3;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DefaultText = "";
            this.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.DisabledState.Parent = this.txtNom;
            this.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.FocusedState.Parent = this.txtNom;
            this.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.HoverState.Parent = this.txtNom;
            this.txtNom.Location = new System.Drawing.Point(38, 28);
            this.txtNom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.PlaceholderText = "Saisir Nom";
            this.txtNom.SelectedText = "";
            this.txtNom.ShadowDecoration.Parent = this.txtNom;
            this.txtNom.Size = new System.Drawing.Size(178, 38);
            this.txtNom.TabIndex = 17;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.label4.Location = new System.Drawing.Point(53, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 1);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerConsultationToolStripMenuItem,
            this.imprimerOrdonanceToolStripMenuItem,
            this.imprimerExamenBiologiqueToolStripMenuItem,
            this.imprimerExamenRadiologiqueToolStripMenuItem,
            this.imprimerExamenToolStripMenuItem,
            this.imprimerExamenAnatomopathologiqueToolStripMenuItem,
            this.prescriptionToolStripMenuItem,
            this.analysesToolStripMenuItem,
            this.voirExamenRadiologiqueToolStripMenuItem,
            this.voirExamenEndoscopiqueToolStripMenuItem,
            this.voirExamenAnatomopathologiqueToolStripMenuItem,
            this.modifierMaladieToolStripMenuItem,
            this.modifierRemarqueToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(292, 290);
            // 
            // supprimerConsultationToolStripMenuItem
            // 
            this.supprimerConsultationToolStripMenuItem.Name = "supprimerConsultationToolStripMenuItem";
            this.supprimerConsultationToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.supprimerConsultationToolStripMenuItem.Text = "Supprimer Consultation";
            this.supprimerConsultationToolStripMenuItem.Click += new System.EventHandler(this.supprimerConsultationToolStripMenuItem_Click);
            // 
            // imprimerOrdonanceToolStripMenuItem
            // 
            this.imprimerOrdonanceToolStripMenuItem.Name = "imprimerOrdonanceToolStripMenuItem";
            this.imprimerOrdonanceToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.imprimerOrdonanceToolStripMenuItem.Text = "Imprimer Ordonance";
            this.imprimerOrdonanceToolStripMenuItem.Click += new System.EventHandler(this.imprimerOrdonanceToolStripMenuItem_Click);
            // 
            // imprimerExamenBiologiqueToolStripMenuItem
            // 
            this.imprimerExamenBiologiqueToolStripMenuItem.Name = "imprimerExamenBiologiqueToolStripMenuItem";
            this.imprimerExamenBiologiqueToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.imprimerExamenBiologiqueToolStripMenuItem.Text = "Imprimer Examen Biologique";
            this.imprimerExamenBiologiqueToolStripMenuItem.Click += new System.EventHandler(this.imprimerExamenBiologiqueToolStripMenuItem_Click);
            // 
            // imprimerExamenRadiologiqueToolStripMenuItem
            // 
            this.imprimerExamenRadiologiqueToolStripMenuItem.Name = "imprimerExamenRadiologiqueToolStripMenuItem";
            this.imprimerExamenRadiologiqueToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.imprimerExamenRadiologiqueToolStripMenuItem.Text = "Imprimer Examen Radiologique";
            this.imprimerExamenRadiologiqueToolStripMenuItem.Click += new System.EventHandler(this.imprimerExamenRadiologiqueToolStripMenuItem_Click);
            // 
            // imprimerExamenToolStripMenuItem
            // 
            this.imprimerExamenToolStripMenuItem.Name = "imprimerExamenToolStripMenuItem";
            this.imprimerExamenToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.imprimerExamenToolStripMenuItem.Text = "Imprimer Examen Endoscopique";
            this.imprimerExamenToolStripMenuItem.Click += new System.EventHandler(this.imprimerExamenToolStripMenuItem_Click);
            // 
            // imprimerExamenAnatomopathologiqueToolStripMenuItem
            // 
            this.imprimerExamenAnatomopathologiqueToolStripMenuItem.Name = "imprimerExamenAnatomopathologiqueToolStripMenuItem";
            this.imprimerExamenAnatomopathologiqueToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.imprimerExamenAnatomopathologiqueToolStripMenuItem.Text = "Imprimer Examen Anatomopathologique";
            this.imprimerExamenAnatomopathologiqueToolStripMenuItem.Click += new System.EventHandler(this.imprimerExamenAnatomopathologiqueToolStripMenuItem_Click);
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.prescriptionToolStripMenuItem.Text = "Voir Prescription";
            this.prescriptionToolStripMenuItem.Click += new System.EventHandler(this.prescriptionToolStripMenuItem_Click);
            // 
            // analysesToolStripMenuItem
            // 
            this.analysesToolStripMenuItem.Name = "analysesToolStripMenuItem";
            this.analysesToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.analysesToolStripMenuItem.Text = "Voir Examen Biologique";
            this.analysesToolStripMenuItem.Click += new System.EventHandler(this.analysesToolStripMenuItem_Click);
            // 
            // voirExamenRadiologiqueToolStripMenuItem
            // 
            this.voirExamenRadiologiqueToolStripMenuItem.Name = "voirExamenRadiologiqueToolStripMenuItem";
            this.voirExamenRadiologiqueToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.voirExamenRadiologiqueToolStripMenuItem.Text = "Voir Examen Radiologique";
            this.voirExamenRadiologiqueToolStripMenuItem.Click += new System.EventHandler(this.voirExamenRadiologiqueToolStripMenuItem_Click);
            // 
            // voirExamenEndoscopiqueToolStripMenuItem
            // 
            this.voirExamenEndoscopiqueToolStripMenuItem.Name = "voirExamenEndoscopiqueToolStripMenuItem";
            this.voirExamenEndoscopiqueToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.voirExamenEndoscopiqueToolStripMenuItem.Text = "Voir Examen Endoscopique";
            this.voirExamenEndoscopiqueToolStripMenuItem.Click += new System.EventHandler(this.voirExamenEndoscopiqueToolStripMenuItem_Click);
            // 
            // voirExamenAnatomopathologiqueToolStripMenuItem
            // 
            this.voirExamenAnatomopathologiqueToolStripMenuItem.Name = "voirExamenAnatomopathologiqueToolStripMenuItem";
            this.voirExamenAnatomopathologiqueToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.voirExamenAnatomopathologiqueToolStripMenuItem.Text = "Voir Examen Anatomopathologique";
            this.voirExamenAnatomopathologiqueToolStripMenuItem.Click += new System.EventHandler(this.voirExamenAnatomopathologiqueToolStripMenuItem_Click);
            // 
            // modifierMaladieToolStripMenuItem
            // 
            this.modifierMaladieToolStripMenuItem.Name = "modifierMaladieToolStripMenuItem";
            this.modifierMaladieToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.modifierMaladieToolStripMenuItem.Text = "Modifier Maladie";
            this.modifierMaladieToolStripMenuItem.Click += new System.EventHandler(this.modifierMaladieToolStripMenuItem_Click);
            // 
            // modifierRemarqueToolStripMenuItem
            // 
            this.modifierRemarqueToolStripMenuItem.Name = "modifierRemarqueToolStripMenuItem";
            this.modifierRemarqueToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.modifierRemarqueToolStripMenuItem.Text = "Modifier Remarque";
            this.modifierRemarqueToolStripMenuItem.Click += new System.EventHandler(this.modifierRemarqueToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(140)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dataGridView1.Location = new System.Drawing.Point(83, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(697, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(140)))));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Click += new System.EventHandler(this.guna2DataGridView1_Click);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gunaLabel2.Location = new System.Drawing.Point(472, 106);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(621, 41);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "label5";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaLabel1.Location = new System.Drawing.Point(569, 354);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(211, 33);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "label5";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dataGridView1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 9;
            this.guna2Elipse2.TargetControl = this.gunaLabel1;
            // 
            // FormChercherConsultation
            // 
            this.AcceptButton = this.btnchercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1203, 565);
            this.ControlBox = false;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbxDate);
            this.Controls.Add(this.grbxIdConsultation);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.grbxPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChercherConsultation";
            this.Text = "Consultations";
            this.Load += new System.EventHandler(this.FormChercherConsultation_Load);
            this.grbxDate.ResumeLayout(false);
            this.grbxIdConsultation.ResumeLayout(false);
            this.grbxPatient.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grbxDate;
        public System.Windows.Forms.GroupBox grbxIdConsultation;
        public System.Windows.Forms.GroupBox grbxPatient;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerConsultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerOrdonanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierMaladieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierRemarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirExamenRadiologiqueToolStripMenuItem;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        public System.Windows.Forms.Label gunaLabel2;
        public Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label gunaLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.ToolStripMenuItem imprimerExamenBiologiqueToolStripMenuItem;
        public Guna.UI2.WinForms.Guna2Button btnchercher;
        private Guna.UI2.WinForms.Guna2TextBox txtidconsultation;
        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private Guna.UI2.WinForms.Guna2TextBox txtCIN;
        private System.Windows.Forms.ToolStripMenuItem imprimerExamenRadiologiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirExamenEndoscopiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirExamenAnatomopathologiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerExamenAnatomopathologiqueToolStripMenuItem;
    }
}