namespace Cabinet
{
    using System.Windows.Forms;
    using System;
    partial class FormGestionMedicament
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
        /// 
        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionMedicament));
            this.cmbmedicament = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmedicament = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtchercher = new Guna.UI2.WinForms.Guna2TextBox();
            this.lstresult = new System.Windows.Forms.ListBox();
            this.btnsupp = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelClear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbmedicament
            // 
            this.cmbmedicament.BackColor = System.Drawing.Color.Transparent;
            this.cmbmedicament.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmedicament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmedicament.FocusedColor = System.Drawing.Color.Empty;
            this.cmbmedicament.FocusedState.Parent = this.cmbmedicament;
            this.cmbmedicament.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbmedicament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbmedicament.FormattingEnabled = true;
            this.cmbmedicament.HoverState.Parent = this.cmbmedicament;
            this.cmbmedicament.ItemHeight = 30;
            this.cmbmedicament.ItemsAppearance.Parent = this.cmbmedicament;
            this.cmbmedicament.Location = new System.Drawing.Point(192, 266);
            this.cmbmedicament.Name = "cmbmedicament";
            this.cmbmedicament.ShadowDecoration.Parent = this.cmbmedicament;
            this.cmbmedicament.Size = new System.Drawing.Size(274, 36);
            this.cmbmedicament.TabIndex = 61;
            this.cmbmedicament.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmbmedicament.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(76, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "Medicament";
            // 
            // txtmedicament
            // 
            this.txtmedicament.BorderThickness = 3;
            this.txtmedicament.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmedicament.DefaultText = "";
            this.txtmedicament.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmedicament.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmedicament.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedicament.DisabledState.Parent = this.txtmedicament;
            this.txtmedicament.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedicament.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmedicament.FocusedState.Parent = this.txtmedicament;
            this.txtmedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedicament.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmedicament.HoverState.Parent = this.txtmedicament;
            this.txtmedicament.Location = new System.Drawing.Point(192, 204);
            this.txtmedicament.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmedicament.Name = "txtmedicament";
            this.txtmedicament.PasswordChar = '\0';
            this.txtmedicament.PlaceholderText = "Saisir Medicament";
            this.txtmedicament.SelectedText = "";
            this.txtmedicament.ShadowDecoration.Parent = this.txtmedicament;
            this.txtmedicament.Size = new System.Drawing.Size(274, 36);
            this.txtmedicament.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtmedicament.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(17, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Nouveau Medicament";
            // 
            // txtchercher
            // 
            this.txtchercher.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
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
            this.txtchercher.Location = new System.Drawing.Point(492, 266);
            this.txtchercher.Name = "txtchercher";
            this.txtchercher.PasswordChar = '\0';
            this.txtchercher.PlaceholderText = "Chercher Medicament";
            this.txtchercher.SelectedText = "";
            this.txtchercher.ShadowDecoration.Parent = this.txtchercher;
            this.txtchercher.Size = new System.Drawing.Size(329, 36);
            this.txtchercher.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtchercher.TabIndex = 65;
            this.txtchercher.TextChanged += new System.EventHandler(this.txtchercher_TextChanged_1);
            // 
            // lstresult
            // 
            this.lstresult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstresult.FormattingEnabled = true;
            this.lstresult.ItemHeight = 18;
            this.lstresult.Location = new System.Drawing.Point(492, 302);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(329, 108);
            this.lstresult.TabIndex = 64;
            this.lstresult.Visible = false;
            this.lstresult.Click += new System.EventHandler(this.lstresult_Click_1);
            // 
            // btnsupp
            // 
            this.btnsupp.BorderRadius = 3;
            this.btnsupp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnsupp.CheckedState.Parent = this.btnsupp;
            this.btnsupp.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsupp.CustomImages.Parent = this.btnsupp;
            this.btnsupp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsupp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnsupp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsupp.ForeColor = System.Drawing.Color.White;
            this.btnsupp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsupp.HoverState.FillColor = System.Drawing.Color.MediumBlue;
            this.btnsupp.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.HoverState.Parent = this.btnsupp;
            this.btnsupp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsupp.Location = new System.Drawing.Point(479, 394);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.ShadowDecoration.Parent = this.btnsupp;
            this.btnsupp.Size = new System.Drawing.Size(207, 36);
            this.btnsupp.TabIndex = 67;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsupp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnsupp.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click_1);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BorderRadius = 3;
            this.BtnAjouter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.BtnAjouter.CheckedState.Parent = this.BtnAjouter;
            this.BtnAjouter.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAjouter.CustomImages.Parent = this.BtnAjouter;
            this.BtnAjouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAjouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjouter.ForeColor = System.Drawing.Color.White;
            this.BtnAjouter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAjouter.HoverState.FillColor = System.Drawing.Color.MediumBlue;
            this.BtnAjouter.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.HoverState.Parent = this.BtnAjouter;
            this.BtnAjouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAjouter.Location = new System.Drawing.Point(226, 394);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.ShadowDecoration.Parent = this.BtnAjouter;
            this.BtnAjouter.Size = new System.Drawing.Size(200, 36);
            this.BtnAjouter.TabIndex = 66;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAjouter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnAjouter.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(340, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 25);
            this.label11.TabIndex = 68;
            this.label11.Text = "Gestion Des Medicament";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.guna2Panel1.Location = new System.Drawing.Point(62, 151);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(720, 1);
            this.guna2Panel1.TabIndex = 69;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.guna2Panel2.Location = new System.Drawing.Point(62, 351);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(720, 1);
            this.guna2Panel2.TabIndex = 70;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Cabinet.Properties.Resources.Pílula_teste;
            this.guna2PictureBox1.Location = new System.Drawing.Point(188, 22);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(146, 113);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 71;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.labelClear);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Controls.Add(this.lstresult);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.guna2Panel2);
            this.guna2Panel3.Controls.Add(this.cmbmedicament);
            this.guna2Panel3.Controls.Add(this.guna2Panel1);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.label11);
            this.guna2Panel3.Controls.Add(this.txtmedicament);
            this.guna2Panel3.Controls.Add(this.btnsupp);
            this.guna2Panel3.Controls.Add(this.txtchercher);
            this.guna2Panel3.Controls.Add(this.BtnAjouter);
            this.guna2Panel3.Location = new System.Drawing.Point(282, 37);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(864, 459);
            this.guna2Panel3.TabIndex = 72;
            this.guna2Panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.guna2Panel3_MouseClick);
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.BackColor = System.Drawing.Color.White;
            this.labelClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.Location = new System.Drawing.Point(796, 273);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(17, 16);
            this.labelClear.TabIndex = 72;
            this.labelClear.Text = "X";
            this.labelClear.Visible = false;
            this.labelClear.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormGestionMedicament
            // 
            this.AcceptButton = this.BtnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1185, 788);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestionMedicament";
            this.Text = "Gestion Médicament";
            this.Load += new System.EventHandler(this.FormGestionMedicament_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormGestionMedicament_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbmedicament;
        public Label label4;
        public Guna.UI2.WinForms.Guna2TextBox txtmedicament;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtchercher;
        public ListBox lstresult;
        private Guna.UI2.WinForms.Guna2Button btnsupp;
        private Guna.UI2.WinForms.Guna2Button BtnAjouter;
        private Label label11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Label labelClear;
    }
}