namespace Cabinet
{
    partial class FormListeAttentePourMedcin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListeAttentePourMedcin));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.antecedentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueConsultationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evolutionSousTraitementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premierControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerDerniersControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaLabel2 = new System.Windows.Forms.Label();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.labelTotal = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antecedentsToolStripMenuItem,
            this.examinerToolStripMenuItem,
            this.historiqueConsultationsToolStripMenuItem,
            this.historiqueToolStripMenuItem,
            this.evolutionSousTraitementToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 114);
            // 
            // antecedentsToolStripMenuItem
            // 
            this.antecedentsToolStripMenuItem.Name = "antecedentsToolStripMenuItem";
            this.antecedentsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.antecedentsToolStripMenuItem.Text = "Antecedents";
            this.antecedentsToolStripMenuItem.Click += new System.EventHandler(this.antecedentsToolStripMenuItem_Click);
            // 
            // examinerToolStripMenuItem
            // 
            this.examinerToolStripMenuItem.Name = "examinerToolStripMenuItem";
            this.examinerToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.examinerToolStripMenuItem.Text = "Examiner";
            this.examinerToolStripMenuItem.Click += new System.EventHandler(this.examinerToolStripMenuItem_Click);
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
            this.chargerDerniersControlsToolStripMenuItem});
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
            // chargerDerniersControlsToolStripMenuItem
            // 
            this.chargerDerniersControlsToolStripMenuItem.Name = "chargerDerniersControlsToolStripMenuItem";
            this.chargerDerniersControlsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.chargerDerniersControlsToolStripMenuItem.Text = "Suivi des Controls";
            this.chargerDerniersControlsToolStripMenuItem.Click += new System.EventHandler(this.chargerDerniersControlsToolStripMenuItem_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(95, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 196);
            this.dataGridView1.TabIndex = 5;
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
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gunaLabel2.Location = new System.Drawing.Point(312, 97);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(627, 41);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "Patients dans la salle d\'attente";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.dataGridView1;
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotal.Location = new System.Drawing.Point(1050, 389);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(211, 33);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "label5";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 9;
            this.guna2Elipse2.TargetControl = this.labelTotal;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormListeAttentePourMedcin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1386, 431);
            this.ControlBox = false;
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListeAttentePourMedcin";
            this.ShowIcon = false;
            this.Text = "Liste d\'attente";
            this.Load += new System.EventHandler(this.FormListeAttentePourMedcin_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem antecedentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examinerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueConsultationsToolStripMenuItem;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        public System.Windows.Forms.Label gunaLabel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        public System.Windows.Forms.Label labelTotal;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evolutionSousTraitementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premierControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerDerniersControlsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}