namespace Cabinet
{
    partial class FormPrescriptionMedicaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrescriptionMedicaments));
            this.lstresult = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmedicament = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbdose = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbpreiode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtchercher = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.btnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.btnmodifier = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.LabelPatient = new System.Windows.Forms.Label();
            this.labelRefCons = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDuree = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelClear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstresult
            // 
            this.lstresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstresult.FormattingEnabled = true;
            this.lstresult.ItemHeight = 18;
            this.lstresult.Location = new System.Drawing.Point(504, 214);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(328, 94);
            this.lstresult.TabIndex = 23;
            this.lstresult.Visible = false;
            this.lstresult.SelectedIndexChanged += new System.EventHandler(this.lstresult_SelectedIndexChanged);
            this.lstresult.Click += new System.EventHandler(this.lstresult_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(95, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Medicament";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(146, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(128, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Periode";
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
            this.cmbmedicament.Location = new System.Drawing.Point(218, 178);
            this.cmbmedicament.Name = "cmbmedicament";
            this.cmbmedicament.ShadowDecoration.Parent = this.cmbmedicament;
            this.cmbmedicament.Size = new System.Drawing.Size(261, 36);
            this.cmbmedicament.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbmedicament.TabIndex = 34;
            this.cmbmedicament.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbmedicament.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
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
            this.cmbdose.Location = new System.Drawing.Point(218, 225);
            this.cmbdose.Name = "cmbdose";
            this.cmbdose.ShadowDecoration.Parent = this.cmbdose;
            this.cmbdose.Size = new System.Drawing.Size(261, 36);
            this.cmbdose.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbdose.TabIndex = 35;
            this.cmbdose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbdose.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
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
            this.cmbpreiode.Location = new System.Drawing.Point(218, 273);
            this.cmbpreiode.Name = "cmbpreiode";
            this.cmbpreiode.ShadowDecoration.Parent = this.cmbpreiode;
            this.cmbpreiode.Size = new System.Drawing.Size(261, 36);
            this.cmbpreiode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbpreiode.TabIndex = 36;
            this.cmbpreiode.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbpreiode.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            // 
            // txtchercher
            // 
            this.txtchercher.BorderThickness = 3;
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
            this.txtchercher.Location = new System.Drawing.Point(504, 178);
            this.txtchercher.Name = "txtchercher";
            this.txtchercher.PasswordChar = '\0';
            this.txtchercher.PlaceholderText = "Chercher Medicament";
            this.txtchercher.SelectedText = "";
            this.txtchercher.ShadowDecoration.Parent = this.txtchercher;
            this.txtchercher.Size = new System.Drawing.Size(328, 36);
            this.txtchercher.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtchercher.TabIndex = 37;
            this.txtchercher.TextChanged += new System.EventHandler(this.txtchercher_TextChanged_1);
            // 
            // btnAjouter
            // 
            this.btnAjouter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnAjouter.CheckedState.Parent = this.btnAjouter;
            this.btnAjouter.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.CustomImages.Parent = this.btnAjouter;
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAjouter.HoverState.FillColor = System.Drawing.Color.MediumBlue;
            this.btnAjouter.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.HoverState.Parent = this.btnAjouter;
            this.btnAjouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.Location = new System.Drawing.Point(53, 392);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.ShadowDecoration.Parent = this.btnAjouter;
            this.btnAjouter.Size = new System.Drawing.Size(773, 45);
            this.btnAjouter.TabIndex = 55;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAjouter.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnSupprimer.CheckedState.Parent = this.btnSupprimer;
            this.btnSupprimer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSupprimer.CustomImages.Parent = this.btnSupprimer;
            this.btnSupprimer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSupprimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.HoverState.Parent = this.btnSupprimer;
            this.btnSupprimer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupprimer.Location = new System.Drawing.Point(647, 570);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.ShadowDecoration.Parent = this.btnSupprimer;
            this.btnSupprimer.Size = new System.Drawing.Size(180, 120);
            this.btnSupprimer.TabIndex = 58;
            this.btnSupprimer.Text = "Retirer Medicament";
            this.btnSupprimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupprimer.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSupprimer.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnmodifier
            // 
            this.btnmodifier.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnmodifier.CheckedState.Parent = this.btnmodifier;
            this.btnmodifier.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnmodifier.CustomImages.Parent = this.btnmodifier;
            this.btnmodifier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnmodifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnmodifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.HoverState.Parent = this.btnmodifier;
            this.btnmodifier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmodifier.Location = new System.Drawing.Point(647, 444);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.ShadowDecoration.Parent = this.btnmodifier;
            this.btnmodifier.Size = new System.Drawing.Size(180, 120);
            this.btnmodifier.TabIndex = 57;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnmodifier.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnmodifier.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click_1);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
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
            this.DataGridView1.Location = new System.Drawing.Point(53, 443);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(587, 246);
            this.DataGridView1.TabIndex = 59;
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
            this.DataGridView1.Click += new System.EventHandler(this.DataGridView1_Click_2);
            // 
            // LabelPatient
            // 
            this.LabelPatient.AutoSize = true;
            this.LabelPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelPatient.Location = new System.Drawing.Point(22, 41);
            this.LabelPatient.Name = "LabelPatient";
            this.LabelPatient.Size = new System.Drawing.Size(51, 16);
            this.LabelPatient.TabIndex = 61;
            this.LabelPatient.Text = "label5";
            // 
            // labelRefCons
            // 
            this.labelRefCons.AutoSize = true;
            this.labelRefCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefCons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRefCons.Location = new System.Drawing.Point(22, 19);
            this.labelRefCons.Name = "labelRefCons";
            this.labelRefCons.Size = new System.Drawing.Size(51, 16);
            this.labelRefCons.TabIndex = 60;
            this.labelRefCons.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(56, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Durée Traitement";
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
            this.cmbDuree.Location = new System.Drawing.Point(218, 322);
            this.cmbDuree.Name = "cmbDuree";
            this.cmbDuree.ShadowDecoration.Parent = this.cmbDuree;
            this.cmbDuree.Size = new System.Drawing.Size(261, 36);
            this.cmbDuree.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbDuree.TabIndex = 63;
            this.cmbDuree.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbDuree.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            // 
            // guna2Button1
            // 
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Button1.Location = new System.Drawing.Point(504, 151);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(158, 21);
            this.guna2Button1.TabIndex = 64;
            this.guna2Button1.Text = "Gérer Médicaments";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Button1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2Button1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cabinet.Properties.Resources.prescript;
            this.pictureBox1.Location = new System.Drawing.Point(331, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.BackColor = System.Drawing.Color.White;
            this.labelClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.Location = new System.Drawing.Point(809, 188);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(17, 16);
            this.labelClear.TabIndex = 73;
            this.labelClear.Text = "X";
            this.labelClear.Visible = false;
            this.labelClear.Click += new System.EventHandler(this.labelClear_Click);
            // 
            // FormPrescriptionMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(901, 696);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.cmbDuree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelPatient);
            this.Controls.Add(this.labelRefCons);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtchercher);
            this.Controls.Add(this.cmbpreiode);
            this.Controls.Add(this.cmbdose);
            this.Controls.Add(this.cmbmedicament);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstresult);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrescriptionMedicaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicaments à priscrire";
            this.Load += new System.EventHandler(this.FormPrescriptionMedicaments_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormPrescriptionMedicaments_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lstresult;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbmedicament;
        private Guna.UI2.WinForms.Guna2ComboBox cmbdose;
        private Guna.UI2.WinForms.Guna2ComboBox cmbpreiode;
        private Guna.UI2.WinForms.Guna2TextBox txtchercher;
        public Guna.UI2.WinForms.Guna2Button btnAjouter;
        public Guna.UI2.WinForms.Guna2Button btnSupprimer;
        public Guna.UI2.WinForms.Guna2Button btnmodifier;
        public Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        private System.Windows.Forms.Label LabelPatient;
        private System.Windows.Forms.Label labelRefCons;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDuree;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelClear;
    }
}