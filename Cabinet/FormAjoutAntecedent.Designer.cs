namespace Cabinet
{
    partial class FormAjoutAntecedent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutAntecedent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpatient = new System.Windows.Forms.Label();
            this.dataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.btnSupp = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.cmbmedicament = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cmbAntecedent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            // 
            // lblpatient
            // 
            this.lblpatient.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblpatient, "lblpatient");
            this.lblpatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpatient.Name = "lblpatient";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridView2.ThemeStyle.ReadOnly = true;
            this.dataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Turquoise;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click_1);
            // 
            // btnAjouter
            // 
            this.btnAjouter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnAjouter.CheckedState.Parent = this.btnAjouter;
            this.btnAjouter.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.CustomImages.Parent = this.btnAjouter;
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnAjouter, "btnAjouter");
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAjouter.HoverState.FillColor = System.Drawing.Color.MediumBlue;
            this.btnAjouter.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.HoverState.Parent = this.btnAjouter;
            this.btnAjouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.ShadowDecoration.Parent = this.btnAjouter;
            this.btnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAjouter.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnSupp.CheckedState.Parent = this.btnSupp;
            this.btnSupp.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSupp.CustomImages.Parent = this.btnSupp;
            this.btnSupp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSupp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnSupp, "btnSupp");
            this.btnSupp.ForeColor = System.Drawing.Color.White;
            this.btnSupp.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.HoverState.Parent = this.btnSupp;
            this.btnSupp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.ShadowDecoration.Parent = this.btnSupp;
            this.btnSupp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSupp.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnModifier.CheckedState.Parent = this.btnModifier;
            this.btnModifier.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnModifier.CustomImages.Parent = this.btnModifier;
            this.btnModifier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnModifier, "btnModifier");
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.HoverState.Parent = this.btnModifier;
            this.btnModifier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.ShadowDecoration.Parent = this.btnModifier;
            this.btnModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModifier.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnModifier.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // cmbmedicament
            // 
            this.cmbmedicament.BackColor = System.Drawing.Color.Transparent;
            this.cmbmedicament.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmedicament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmedicament.FocusedColor = System.Drawing.Color.Empty;
            this.cmbmedicament.FocusedState.Parent = this.cmbmedicament;
            resources.ApplyResources(this.cmbmedicament, "cmbmedicament");
            this.cmbmedicament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbmedicament.FormattingEnabled = true;
            this.cmbmedicament.HoverState.Parent = this.cmbmedicament;
            this.cmbmedicament.Items.AddRange(new object[] {
            resources.GetString("cmbmedicament.Items"),
            resources.GetString("cmbmedicament.Items1")});
            this.cmbmedicament.ItemsAppearance.Parent = this.cmbmedicament;
            this.cmbmedicament.Name = "cmbmedicament";
            this.cmbmedicament.ShadowDecoration.Parent = this.cmbmedicament;
            this.cmbmedicament.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbmedicament.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.cmbmedicament.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmbmedicament_MouseMove);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dataGridView2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnAjouter;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.btnModifier;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.btnSupp;
            // 
            // cmbAntecedent
            // 
            this.cmbAntecedent.BackColor = System.Drawing.Color.Transparent;
            this.cmbAntecedent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAntecedent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAntecedent.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAntecedent.FocusedState.Parent = this.cmbAntecedent;
            resources.ApplyResources(this.cmbAntecedent, "cmbAntecedent");
            this.cmbAntecedent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAntecedent.FormattingEnabled = true;
            this.cmbAntecedent.HoverState.Parent = this.cmbAntecedent;
            this.cmbAntecedent.Items.AddRange(new object[] {
            resources.GetString("cmbAntecedent.Items"),
            resources.GetString("cmbAntecedent.Items1")});
            this.cmbAntecedent.ItemsAppearance.Parent = this.cmbAntecedent;
            this.cmbAntecedent.Name = "cmbAntecedent";
            this.cmbAntecedent.ShadowDecoration.Parent = this.cmbAntecedent;
            this.cmbAntecedent.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbAntecedent.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cabinet.Properties.Resources.antecedents;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FormAjoutAntecedent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbAntecedent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbmedicament);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblpatient);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAjoutAntecedent";
            this.Load += new System.EventHandler(this.FormAjoutAntecedent_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormAjoutAntecedent_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblpatient;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridView2;
        public Guna.UI2.WinForms.Guna2Button btnAjouter;
        public Guna.UI2.WinForms.Guna2Button btnSupp;
        public Guna.UI2.WinForms.Guna2Button btnModifier;
        public Guna.UI2.WinForms.Guna2ComboBox cmbmedicament;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        public Guna.UI2.WinForms.Guna2ComboBox cmbAntecedent;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}