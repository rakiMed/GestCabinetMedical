namespace Cabinet
{
    partial class FormUpdateMaladie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateMaladie));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.labelMR = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.txtmaladie = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // labelMR
            // 
            this.labelMR.AutoSize = true;
            this.labelMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMR.Location = new System.Drawing.Point(168, 66);
            this.labelMR.Name = "labelMR";
            this.labelMR.Size = new System.Drawing.Size(76, 24);
            this.labelMR.TabIndex = 5;
            this.labelMR.Text = "Maladie";
            // 
            // guna2Button1
            // 
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Button1.Location = new System.Drawing.Point(117, 157);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Mettre à jour";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Button1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2Button1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Button2.Location = new System.Drawing.Point(356, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(41, 27);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "X";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Button2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2Button2.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_CENTER;
            // 
            // txtmaladie
            // 
            this.txtmaladie.Animated = true;
            this.txtmaladie.BackColor = System.Drawing.Color.Transparent;
            this.txtmaladie.BorderRadius = 10;
            this.txtmaladie.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtmaladie.BorderThickness = 4;
            this.txtmaladie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaladie.DefaultText = "";
            this.txtmaladie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmaladie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmaladie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaladie.DisabledState.Parent = this.txtmaladie;
            this.txtmaladie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaladie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaladie.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtmaladie.FocusedState.Parent = this.txtmaladie;
            this.txtmaladie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaladie.HoverState.Parent = this.txtmaladie;
            this.txtmaladie.Location = new System.Drawing.Point(117, 110);
            this.txtmaladie.Name = "txtmaladie";
            this.txtmaladie.PasswordChar = '\0';
            this.txtmaladie.PlaceholderText = "";
            this.txtmaladie.SelectedText = "";
            this.txtmaladie.ShadowDecoration.BorderRadius = 8;
            this.txtmaladie.ShadowDecoration.Enabled = true;
            this.txtmaladie.ShadowDecoration.Parent = this.txtmaladie;
            this.txtmaladie.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.txtmaladie.ShortcutsEnabled = false;
            this.txtmaladie.Size = new System.Drawing.Size(180, 27);
            this.txtmaladie.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtmaladie.TabIndex = 7;
            // 
            // FormUpdateMaladie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(409, 290);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.txtmaladie);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.labelMR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 300);
            this.Name = "FormUpdateMaladie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormUpdateMaladie";
            this.Load += new System.EventHandler(this.FormUpdateMaladie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public System.Windows.Forms.Label labelMR;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        public Guna.UI2.WinForms.Guna2TextBox txtmaladie;
    }
}