namespace Cabinet
{
    partial class FormGestionExamenBiologiqueEtRadiologique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionExamenBiologiqueEtRadiologique));
            this.txtexamen = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnajouter = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtexamen
            // 
            this.txtexamen.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtexamen.BorderThickness = 4;
            this.txtexamen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtexamen.DefaultText = "";
            this.txtexamen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtexamen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtexamen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtexamen.DisabledState.Parent = this.txtexamen;
            this.txtexamen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtexamen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtexamen.FocusedState.Parent = this.txtexamen;
            this.txtexamen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtexamen.HoverState.Parent = this.txtexamen;
            this.txtexamen.Location = new System.Drawing.Point(455, 249);
            this.txtexamen.Margin = new System.Windows.Forms.Padding(0, 0, 9, 9);
            this.txtexamen.Name = "txtexamen";
            this.txtexamen.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.txtexamen.PasswordChar = '\0';
            this.txtexamen.PlaceholderText = "";
            this.txtexamen.SelectedText = "";
            this.txtexamen.ShadowDecoration.BorderRadius = 20;
            this.txtexamen.ShadowDecoration.Parent = this.txtexamen;
            this.txtexamen.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.txtexamen.Size = new System.Drawing.Size(200, 36);
            this.txtexamen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtexamen.TabIndex = 0;
            this.txtexamen.TextChanged += new System.EventHandler(this.txtexamen_TextChanged);
            this.txtexamen.Click += new System.EventHandler(this.txtexamen_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnajouter.CheckedState.Parent = this.btnajouter;
            this.btnajouter.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnajouter.CustomImages.Parent = this.btnajouter;
            this.btnajouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnajouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.HoverState.Parent = this.btnajouter;
            this.btnajouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnajouter.Location = new System.Drawing.Point(455, 297);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.ShadowDecoration.Parent = this.btnajouter;
            this.btnajouter.Size = new System.Drawing.Size(200, 45);
            this.btnajouter.TabIndex = 1;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnajouter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnajouter.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(555, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Examens Biologiques";
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // btnSupp
            // 
            this.btnSupp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnSupp.CheckedState.Parent = this.btnSupp;
            this.btnSupp.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSupp.CustomImages.Parent = this.btnSupp;
            this.btnSupp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSupp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSupp.ForeColor = System.Drawing.Color.White;
            this.btnSupp.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.HoverState.Parent = this.btnSupp;
            this.btnSupp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupp.Location = new System.Drawing.Point(455, 361);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.ShadowDecoration.Parent = this.btnSupp;
            this.btnSupp.Size = new System.Drawing.Size(200, 45);
            this.btnSupp.TabIndex = 13;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSupp.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.BorderThickness = 2;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.guna2ComboBox1.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.guna2ComboBox1.Location = new System.Drawing.Point(667, 249);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(222, 36);
            this.guna2ComboBox1.TabIndex = 15;
            this.guna2ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ComboBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ComboBox1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            this.guna2ComboBox1.Click += new System.EventHandler(this.guna2ComboBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this.txtexamen;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.guna2Panel2.Location = new System.Drawing.Point(408, 222);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(500, 1);
            this.guna2Panel2.TabIndex = 66;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.guna2Panel1.Location = new System.Drawing.Point(417, 442);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(500, 1);
            this.guna2Panel1.TabIndex = 67;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Cabinet.Properties.Resources.kisscc0_laboratory_flasks_beaker_chemistry_chemical_substa_test_tube_5_5b71f238520832_073818401534194232336;
            this.guna2PictureBox1.Location = new System.Drawing.Point(426, 102);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(114, 114);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 68;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormGestionExamenBiologiqueEtRadiologique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1060, 638);
            this.ControlBox = false;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.txtexamen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionExamenBiologiqueEtRadiologique";
            this.Text = "Gestion Examens ";
            this.Load += new System.EventHandler(this.FormGestionExamenBiologiqueEtRadiologique_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtexamen;
        private Guna.UI2.WinForms.Guna2Button btnajouter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSupp;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}