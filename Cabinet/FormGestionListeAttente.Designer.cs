namespace Cabinet
{
    partial class FormGestionListeAttente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionListeAttente));
            this.lblpatient = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.txtmotif = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // lblpatient
            // 
            this.lblpatient.AutoSize = true;
            this.lblpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpatient.Location = new System.Drawing.Point(108, 44);
            this.lblpatient.Name = "lblpatient";
            this.lblpatient.Size = new System.Drawing.Size(76, 25);
            this.lblpatient.TabIndex = 2;
            this.lblpatient.Text = "label2";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Purple;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Button2.Location = new System.Drawing.Point(348, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(41, 27);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "X";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Button2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2Button2.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // txtmotif
            // 
            this.txtmotif.Animated = true;
            this.txtmotif.BackColor = System.Drawing.Color.Transparent;
            this.txtmotif.BorderRadius = 10;
            this.txtmotif.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtmotif.BorderThickness = 4;
            this.txtmotif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmotif.DefaultText = "";
            this.txtmotif.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmotif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmotif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmotif.DisabledState.Parent = this.txtmotif;
            this.txtmotif.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmotif.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmotif.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtmotif.FocusedState.Parent = this.txtmotif;
            this.txtmotif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmotif.HoverState.Parent = this.txtmotif;
            this.txtmotif.Location = new System.Drawing.Point(110, 104);
            this.txtmotif.Name = "txtmotif";
            this.txtmotif.PasswordChar = '\0';
            this.txtmotif.PlaceholderText = "Motif De visite";
            this.txtmotif.SelectedText = "";
            this.txtmotif.ShadowDecoration.BorderRadius = 8;
            this.txtmotif.ShadowDecoration.Enabled = true;
            this.txtmotif.ShadowDecoration.Parent = this.txtmotif;
            this.txtmotif.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.txtmotif.ShortcutsEnabled = false;
            this.txtmotif.Size = new System.Drawing.Size(180, 27);
            this.txtmotif.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtmotif.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnAjouter.CheckedState.Parent = this.btnAjouter;
            this.btnAjouter.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAjouter.CustomImages.Parent = this.btnAjouter;
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.HoverState.Parent = this.btnAjouter;
            this.btnAjouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.Location = new System.Drawing.Point(110, 155);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.ShadowDecoration.Parent = this.btnAjouter;
            this.btnAjouter.Size = new System.Drawing.Size(180, 45);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter à La salle d\'Attente";
            this.btnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAjouter.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnAjouter.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FormGestionListeAttente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(401, 279);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtmotif);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.lblpatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionListeAttente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter à la liste d\'attente";
            this.Load += new System.EventHandler(this.FormGestionListeAttente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpatient;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        public Guna.UI2.WinForms.Guna2TextBox txtmotif;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}