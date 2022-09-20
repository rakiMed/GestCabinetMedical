namespace Cabinet
{
    partial class FormPatientPourMecin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientPourMecin));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gererPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueConsultationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evolutionSousTraitementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premierControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiviDesControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbxPatient = new System.Windows.Forms.GroupBox();
            this.txtchangenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtchangcin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gunaLabel2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.grbxPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererPatientToolStripMenuItem,
            this.consulterToolStripMenuItem,
            this.historiqueConsultationsToolStripMenuItem,
            this.historiqueToolStripMenuItem,
            this.evolutionSousTraitementToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 114);
            // 
            // gererPatientToolStripMenuItem
            // 
            this.gererPatientToolStripMenuItem.Name = "gererPatientToolStripMenuItem";
            this.gererPatientToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.gererPatientToolStripMenuItem.Text = "Gerer Patient";
            this.gererPatientToolStripMenuItem.Click += new System.EventHandler(this.gererPatientToolStripMenuItem_Click);
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.consulterToolStripMenuItem.Text = "Antecedent";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.consulterToolStripMenuItem_Click);
            // 
            // historiqueConsultationsToolStripMenuItem
            // 
            this.historiqueConsultationsToolStripMenuItem.Name = "historiqueConsultationsToolStripMenuItem";
            this.historiqueConsultationsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.historiqueConsultationsToolStripMenuItem.Text = "Ses Consultations";
            this.historiqueConsultationsToolStripMenuItem.Click += new System.EventHandler(this.historiqueConsultationsToolStripMenuItem_Click);
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.historiqueToolStripMenuItem.Text = "Historique";
            this.historiqueToolStripMenuItem.Click += new System.EventHandler(this.historiqueToolStripMenuItem_Click);
            // 
            // evolutionSousTraitementToolStripMenuItem
            // 
            this.evolutionSousTraitementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.premierControlToolStripMenuItem,
            this.suiviDesControlsToolStripMenuItem});
            this.evolutionSousTraitementToolStripMenuItem.Name = "evolutionSousTraitementToolStripMenuItem";
            this.evolutionSousTraitementToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.evolutionSousTraitementToolStripMenuItem.Text = "Evolution Sous Traitement";
            // 
            // premierControlToolStripMenuItem
            // 
            this.premierControlToolStripMenuItem.Name = "premierControlToolStripMenuItem";
            this.premierControlToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.premierControlToolStripMenuItem.Text = "Premier Control";
            this.premierControlToolStripMenuItem.Click += new System.EventHandler(this.premierControlToolStripMenuItem_Click);
            // 
            // suiviDesControlsToolStripMenuItem
            // 
            this.suiviDesControlsToolStripMenuItem.Name = "suiviDesControlsToolStripMenuItem";
            this.suiviDesControlsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.suiviDesControlsToolStripMenuItem.Text = "Suivi des Controls";
            this.suiviDesControlsToolStripMenuItem.Click += new System.EventHandler(this.suiviDesControlsToolStripMenuItem_Click);
            // 
            // grbxPatient
            // 
            this.grbxPatient.Controls.Add(this.txtchangenom);
            this.grbxPatient.Controls.Add(this.txtchangcin);
            this.grbxPatient.Controls.Add(this.label4);
            this.grbxPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.grbxPatient.Location = new System.Drawing.Point(195, 79);
            this.grbxPatient.Name = "grbxPatient";
            this.grbxPatient.Size = new System.Drawing.Size(232, 141);
            this.grbxPatient.TabIndex = 7;
            this.grbxPatient.TabStop = false;
            this.grbxPatient.Text = "Chercher Par Patient";
            // 
            // txtchangenom
            // 
            this.txtchangenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtchangenom.DefaultText = "";
            this.txtchangenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtchangenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtchangenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtchangenom.DisabledState.Parent = this.txtchangenom;
            this.txtchangenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtchangenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchangenom.FocusedState.Parent = this.txtchangenom;
            this.txtchangenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchangenom.HoverState.Parent = this.txtchangenom;
            this.txtchangenom.Location = new System.Drawing.Point(26, 33);
            this.txtchangenom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtchangenom.Name = "txtchangenom";
            this.txtchangenom.PasswordChar = '\0';
            this.txtchangenom.PlaceholderText = "Nom Patient";
            this.txtchangenom.SelectedText = "";
            this.txtchangenom.ShadowDecoration.Parent = this.txtchangenom;
            this.txtchangenom.Size = new System.Drawing.Size(175, 29);
            this.txtchangenom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtchangenom.TabIndex = 0;
            this.txtchangenom.TextChanged += new System.EventHandler(this.txtchangenom_TextChanged_1);
            // 
            // txtchangcin
            // 
            this.txtchangcin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtchangcin.DefaultText = "";
            this.txtchangcin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtchangcin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtchangcin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtchangcin.DisabledState.Parent = this.txtchangcin;
            this.txtchangcin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtchangcin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchangcin.FocusedState.Parent = this.txtchangcin;
            this.txtchangcin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchangcin.HoverState.Parent = this.txtchangcin;
            this.txtchangcin.Location = new System.Drawing.Point(26, 88);
            this.txtchangcin.Margin = new System.Windows.Forms.Padding(4);
            this.txtchangcin.Name = "txtchangcin";
            this.txtchangcin.PasswordChar = '\0';
            this.txtchangcin.PlaceholderText = "CIN Patient";
            this.txtchangcin.SelectedText = "";
            this.txtchangcin.ShadowDecoration.Parent = this.txtchangcin;
            this.txtchangcin.Size = new System.Drawing.Size(175, 31);
            this.txtchangcin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtchangcin.TabIndex = 1;
            this.txtchangcin.TextChanged += new System.EventHandler(this.txtchangcin_TextChanged_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.label4.Location = new System.Drawing.Point(35, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 1);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 9;
            this.guna2Elipse1.TargetControl = this.txtchangenom;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 9;
            this.guna2Elipse2.TargetControl = this.txtchangcin;
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
            this.dataGridView1.Location = new System.Drawing.Point(176, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(976, 303);
            this.dataGridView1.TabIndex = 2;
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
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click_1);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.dataGridView1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gunaLabel2.Location = new System.Drawing.Point(455, 117);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(478, 41);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Liste des patients";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPatientPourMecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1386, 625);
            this.ControlBox = false;
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbxPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPatientPourMecin";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.FormPatientPourMecin_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grbxPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gererPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueConsultationsToolStripMenuItem;
        public System.Windows.Forms.GroupBox grbxPatient;
        public System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtchangcin;
        private Guna.UI2.WinForms.Guna2TextBox txtchangenom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        public System.Windows.Forms.Label gunaLabel2;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evolutionSousTraitementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premierControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suiviDesControlsToolStripMenuItem;
    }
}