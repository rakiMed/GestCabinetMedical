namespace Cabinet
{
    partial class FormPrescriptionViewr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrescriptionViewr));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstresult = new System.Windows.Forms.ListBox();
            this.labelRefCons = new System.Windows.Forms.Label();
            this.LabelPatient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.btnSupp = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtchercher = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbmedicament = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbdose = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbpreiode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbDuree = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2PictureBoxImp = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelClear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxImp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(97, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Medicament";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(130, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Periode";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(148, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Dose";
            this.label1.Visible = false;
            // 
            // lstresult
            // 
            this.lstresult.AllowDrop = true;
            this.lstresult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstresult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstresult.FormattingEnabled = true;
            this.lstresult.IntegralHeight = false;
            this.lstresult.ItemHeight = 18;
            this.lstresult.Location = new System.Drawing.Point(529, 157);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(314, 145);
            this.lstresult.TabIndex = 37;
            this.lstresult.Visible = false;
            this.lstresult.Click += new System.EventHandler(this.lstresult_Click);
            // 
            // labelRefCons
            // 
            this.labelRefCons.AutoSize = true;
            this.labelRefCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefCons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRefCons.Location = new System.Drawing.Point(12, 22);
            this.labelRefCons.Name = "labelRefCons";
            this.labelRefCons.Size = new System.Drawing.Size(51, 16);
            this.labelRefCons.TabIndex = 49;
            this.labelRefCons.Text = "label3";
            // 
            // LabelPatient
            // 
            this.LabelPatient.AutoSize = true;
            this.LabelPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelPatient.Location = new System.Drawing.Point(12, 44);
            this.LabelPatient.Name = "LabelPatient";
            this.LabelPatient.Size = new System.Drawing.Size(51, 16);
            this.LabelPatient.TabIndex = 50;
            this.LabelPatient.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Modifier";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.AutoRoundedCorners = true;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.BorderRadius = 10;
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerBorderRadius = 6;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(400, 74);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(48, 22);
            this.guna2ToggleSwitch1.TabIndex = 53;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.BorderRadius = 10;
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderRadius = 6;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnAjouter.CheckedState.Parent = this.btnAjouter;
            this.btnAjouter.CustomImages.HoveredImage = global::Cabinet.Properties.Resources.add_1_ico;
            this.btnAjouter.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.CustomImages.Parent = this.btnAjouter;
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAjouter.HoverState.FillColor = System.Drawing.Color.MediumBlue;
            this.btnAjouter.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.HoverState.Parent = this.btnAjouter;
            this.btnAjouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.Location = new System.Drawing.Point(64, 330);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.ShadowDecoration.Parent = this.btnAjouter;
            this.btnAjouter.Size = new System.Drawing.Size(773, 45);
            this.btnAjouter.TabIndex = 54;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAjouter.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnAjouter.Visible = false;
            this.btnAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            this.btnAjouter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAjouter_MouseMove);
            this.btnAjouter.Click += new System.EventHandler(this.guna2Button1_Click);
            this.btnAjouter.MouseHover += new System.EventHandler(this.btnAjouter_MouseHover);
            // 
            // btnModifier
            // 
            this.btnModifier.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnModifier.CheckedState.Parent = this.btnModifier;
            this.btnModifier.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnModifier.CustomImages.Parent = this.btnModifier;
            this.btnModifier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.HoverState.Parent = this.btnModifier;
            this.btnModifier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModifier.Location = new System.Drawing.Point(657, 381);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.ShadowDecoration.Parent = this.btnModifier;
            this.btnModifier.Size = new System.Drawing.Size(180, 120);
            this.btnModifier.TabIndex = 55;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModifier.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnModifier.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnModifier.Visible = false;
            this.btnModifier.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // btnSupp
            // 
            this.btnSupp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnSupp.CheckedState.Parent = this.btnSupp;
            this.btnSupp.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSupp.CustomImages.Parent = this.btnSupp;
            this.btnSupp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSupp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSupp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSupp.ForeColor = System.Drawing.Color.White;
            this.btnSupp.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.HoverState.Parent = this.btnSupp;
            this.btnSupp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupp.Location = new System.Drawing.Point(657, 507);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.ShadowDecoration.Parent = this.btnSupp;
            this.btnSupp.Size = new System.Drawing.Size(180, 120);
            this.btnSupp.TabIndex = 56;
            this.btnSupp.Text = "Retirer Medicament";
            this.btnSupp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSupp.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnSupp.Visible = false;
            this.btnSupp.Click += new System.EventHandler(this.guna2Button1_Click_2);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 30;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.DataGridView1.Location = new System.Drawing.Point(64, 381);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(587, 246);
            this.DataGridView1.TabIndex = 57;
            this.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridView1.ThemeStyle.ReadOnly = true;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Turquoise;
            this.DataGridView1.Click += new System.EventHandler(this.guna2DataGridView1_Click);
            // 
            // txtchercher
            // 
            this.txtchercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtchercher.DefaultText = "";
            this.txtchercher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtchercher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtchercher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtchercher.DisabledState.Parent = this.txtchercher;
            this.txtchercher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtchercher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchercher.FocusedState.Parent = this.txtchercher;
            this.txtchercher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchercher.HoverState.Parent = this.txtchercher;
            this.txtchercher.Location = new System.Drawing.Point(529, 121);
            this.txtchercher.Name = "txtchercher";
            this.txtchercher.PasswordChar = '\0';
            this.txtchercher.PlaceholderText = "Chercher Medicament";
            this.txtchercher.SelectedText = "";
            this.txtchercher.ShadowDecoration.Parent = this.txtchercher;
            this.txtchercher.Size = new System.Drawing.Size(314, 36);
            this.txtchercher.TabIndex = 58;
            this.txtchercher.Visible = false;
            this.txtchercher.TextChanged += new System.EventHandler(this.txtchercher_TextChanged_1);
            // 
            // cmbmedicament
            // 
            this.cmbmedicament.BackColor = System.Drawing.Color.Transparent;
            this.cmbmedicament.BorderThickness = 2;
            this.cmbmedicament.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmedicament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmedicament.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbmedicament.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbmedicament.FocusedState.Parent = this.cmbmedicament;
            this.cmbmedicament.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbmedicament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbmedicament.FormattingEnabled = true;
            this.cmbmedicament.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbmedicament.HoverState.Parent = this.cmbmedicament;
            this.cmbmedicament.ItemHeight = 30;
            this.cmbmedicament.ItemsAppearance.Parent = this.cmbmedicament;
            this.cmbmedicament.Location = new System.Drawing.Point(224, 121);
            this.cmbmedicament.Name = "cmbmedicament";
            this.cmbmedicament.ShadowDecoration.Parent = this.cmbmedicament;
            this.cmbmedicament.Size = new System.Drawing.Size(278, 36);
            this.cmbmedicament.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbmedicament.TabIndex = 59;
            this.cmbmedicament.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbmedicament.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.cmbmedicament.Visible = false;
            // 
            // cmbdose
            // 
            this.cmbdose.BackColor = System.Drawing.Color.Transparent;
            this.cmbdose.BorderThickness = 2;
            this.cmbdose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbdose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdose.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbdose.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbdose.FocusedState.Parent = this.cmbdose;
            this.cmbdose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbdose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbdose.FormattingEnabled = true;
            this.cmbdose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbdose.HoverState.Parent = this.cmbdose;
            this.cmbdose.ItemHeight = 30;
            this.cmbdose.Items.AddRange(new object[] {
            "1 cp",
            "1/2 cp",
            "1/4 cp",
            "1 sac",
            "1 supp",
            "1 cas",
            "1 cam",
            "1 inj",
            "1 ab",
            "1 gtte",
            "1 app",
            "1 pu"});
            this.cmbdose.ItemsAppearance.Parent = this.cmbdose;
            this.cmbdose.Location = new System.Drawing.Point(224, 163);
            this.cmbdose.Name = "cmbdose";
            this.cmbdose.ShadowDecoration.Parent = this.cmbdose;
            this.cmbdose.Size = new System.Drawing.Size(278, 36);
            this.cmbdose.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbdose.TabIndex = 60;
            this.cmbdose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbdose.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.cmbdose.Visible = false;
            // 
            // cmbpreiode
            // 
            this.cmbpreiode.BackColor = System.Drawing.Color.Transparent;
            this.cmbpreiode.BorderThickness = 2;
            this.cmbpreiode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbpreiode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpreiode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbpreiode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbpreiode.FocusedState.Parent = this.cmbpreiode;
            this.cmbpreiode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbpreiode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbpreiode.FormattingEnabled = true;
            this.cmbpreiode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbpreiode.HoverState.Parent = this.cmbpreiode;
            this.cmbpreiode.ItemHeight = 30;
            this.cmbpreiode.Items.AddRange(new object[] {
            "matin avant repas",
            "matin apres repas",
            "avant dejeuner",
            "apres dejeuner",
            "avant diner",
            "apres diner"});
            this.cmbpreiode.ItemsAppearance.Parent = this.cmbpreiode;
            this.cmbpreiode.Location = new System.Drawing.Point(224, 205);
            this.cmbpreiode.Name = "cmbpreiode";
            this.cmbpreiode.ShadowDecoration.Parent = this.cmbpreiode;
            this.cmbpreiode.Size = new System.Drawing.Size(278, 36);
            this.cmbpreiode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbpreiode.TabIndex = 61;
            this.cmbpreiode.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbpreiode.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.cmbpreiode.Visible = false;
            // 
            // cmbDuree
            // 
            this.cmbDuree.BackColor = System.Drawing.Color.Transparent;
            this.cmbDuree.BorderThickness = 2;
            this.cmbDuree.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDuree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDuree.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbDuree.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbDuree.FocusedState.Parent = this.cmbDuree;
            this.cmbDuree.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDuree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDuree.FormattingEnabled = true;
            this.cmbDuree.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbDuree.HoverState.Parent = this.cmbDuree;
            this.cmbDuree.ItemHeight = 30;
            this.cmbDuree.Items.AddRange(new object[] {
            "1 jour",
            "2 jours",
            "3 jours ",
            "4 jours ",
            "5 jours ",
            "6 jours",
            "1 semaine",
            "10 jours",
            "2 semaines",
            "20 jours ",
            "3 semaines",
            "1 mois",
            "2 mois",
            "3 mois ",
            "6 mois ",
            "1 année"});
            this.cmbDuree.ItemsAppearance.Parent = this.cmbDuree;
            this.cmbDuree.Location = new System.Drawing.Point(224, 249);
            this.cmbDuree.Name = "cmbDuree";
            this.cmbDuree.ShadowDecoration.Parent = this.cmbDuree;
            this.cmbDuree.Size = new System.Drawing.Size(278, 36);
            this.cmbDuree.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbDuree.TabIndex = 65;
            this.cmbDuree.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbDuree.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.cmbDuree.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(62, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "Durée Traitement";
            this.label5.Visible = false;
            // 
            // guna2PictureBoxImp
            // 
            this.guna2PictureBoxImp.Image = global::Cabinet.Properties.Resources.print;
            this.guna2PictureBoxImp.Location = new System.Drawing.Point(581, 421);
            this.guna2PictureBoxImp.Name = "guna2PictureBoxImp";
            this.guna2PictureBoxImp.ShadowDecoration.Parent = this.guna2PictureBoxImp;
            this.guna2PictureBoxImp.Size = new System.Drawing.Size(135, 80);
            this.guna2PictureBoxImp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBoxImp.TabIndex = 66;
            this.guna2PictureBoxImp.TabStop = false;
            this.guna2PictureBoxImp.MouseLeave += new System.EventHandler(this.guna2PictureBoxImp_MouseLeave);
            this.guna2PictureBoxImp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2PictureBoxImp_MouseMove);
            this.guna2PictureBoxImp.Click += new System.EventHandler(this.guna2PictureBoxImp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Imprimer Ordonnance";
            this.label6.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cabinet.Properties.Resources.prescript;
            this.pictureBox1.Location = new System.Drawing.Point(508, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.BackColor = System.Drawing.Color.White;
            this.labelClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.Location = new System.Drawing.Point(820, 131);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(17, 16);
            this.labelClear.TabIndex = 74;
            this.labelClear.Text = "X";
            this.labelClear.Visible = false;
            this.labelClear.Click += new System.EventHandler(this.labelClear_Click);
            this.labelClear.MouseHover += new System.EventHandler(this.labelClear_MouseHover);
            // 
            // FormPrescriptionViewr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(898, 708);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2PictureBoxImp);
            this.Controls.Add(this.cmbDuree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbpreiode);
            this.Controls.Add(this.cmbdose);
            this.Controls.Add(this.cmbmedicament);
            this.Controls.Add(this.txtchercher);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelPatient);
            this.Controls.Add(this.labelRefCons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstresult);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrescriptionViewr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prescription";
            this.Load += new System.EventHandler(this.FormPrescriptionViewr_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormPrescriptionViewr_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxImp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox lstresult;
        private System.Windows.Forms.Label labelRefCons;
        private System.Windows.Forms.Label LabelPatient;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btnAjouter;
        public Guna.UI2.WinForms.Guna2Button btnModifier;
        public Guna.UI2.WinForms.Guna2Button btnSupp;
        public Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtchercher;
        private Guna.UI2.WinForms.Guna2ComboBox cmbmedicament;
        private Guna.UI2.WinForms.Guna2ComboBox cmbdose;
        private Guna.UI2.WinForms.Guna2ComboBox cmbpreiode;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDuree;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxImp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelClear;
    }
}