namespace Cabinet
{
    partial class FormHistory
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnExamAnatom = new System.Windows.Forms.Button();
            this.btnEndos = new System.Windows.Forms.Button();
            this.btnInter = new System.Windows.Forms.Button();
            this.btnReglage = new System.Windows.Forms.Button();
            this.btntel = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.btnrep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblpatient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bntfermer = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlSide);
            this.panel1.Controls.Add(this.btnExamAnatom);
            this.panel1.Controls.Add(this.btnEndos);
            this.panel1.Controls.Add(this.btnInter);
            this.panel1.Controls.Add(this.btnReglage);
            this.panel1.Controls.Add(this.btntel);
            this.panel1.Controls.Add(this.btnclient);
            this.panel1.Controls.Add(this.btnrep);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 543);
            this.panel1.TabIndex = 0;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.pnlSide.Location = new System.Drawing.Point(3, 136);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(5, 75);
            this.pnlSide.TabIndex = 1;
            // 
            // btnExamAnatom
            // 
            this.btnExamAnatom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExamAnatom.FlatAppearance.BorderSize = 0;
            this.btnExamAnatom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamAnatom.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamAnatom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.btnExamAnatom.Image = global::Cabinet.Properties.Resources.Webp_net_resizeimage;
            this.btnExamAnatom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExamAnatom.Location = new System.Drawing.Point(0, 380);
            this.btnExamAnatom.Name = "btnExamAnatom";
            this.btnExamAnatom.Size = new System.Drawing.Size(200, 50);
            this.btnExamAnatom.TabIndex = 4;
            this.btnExamAnatom.Text = "Examen Anatomopathologique   ";
            this.btnExamAnatom.UseVisualStyleBackColor = true;
            this.btnExamAnatom.Click += new System.EventHandler(this.btnExamAnatom_Click);
            // 
            // btnEndos
            // 
            this.btnEndos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEndos.FlatAppearance.BorderSize = 0;
            this.btnEndos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndos.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.btnEndos.Image = global::Cabinet.Properties.Resources.endos;
            this.btnEndos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEndos.Location = new System.Drawing.Point(0, 330);
            this.btnEndos.Name = "btnEndos";
            this.btnEndos.Size = new System.Drawing.Size(200, 50);
            this.btnEndos.TabIndex = 3;
            this.btnEndos.Text = "Examen Endoscopique   ";
            this.btnEndos.UseVisualStyleBackColor = true;
            this.btnEndos.Click += new System.EventHandler(this.btnEndos_Click);
            // 
            // btnInter
            // 
            this.btnInter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInter.FlatAppearance.BorderSize = 0;
            this.btnInter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInter.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.btnInter.Image = global::Cabinet.Properties.Resources.ex_radio;
            this.btnInter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInter.Location = new System.Drawing.Point(0, 280);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(200, 50);
            this.btnInter.TabIndex = 2;
            this.btnInter.Text = "Examen Radiologique   ";
            this.btnInter.UseVisualStyleBackColor = true;
            this.btnInter.Click += new System.EventHandler(this.btnInter_Click);
            // 
            // btnReglage
            // 
            this.btnReglage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReglage.FlatAppearance.BorderSize = 0;
            this.btnReglage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReglage.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReglage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.btnReglage.Location = new System.Drawing.Point(0, 507);
            this.btnReglage.Name = "btnReglage";
            this.btnReglage.Size = new System.Drawing.Size(200, 36);
            this.btnReglage.TabIndex = 2;
            this.btnReglage.Text = "Info Patient";
            this.btnReglage.UseVisualStyleBackColor = true;
            this.btnReglage.Click += new System.EventHandler(this.btnReglage_Click);
            this.btnReglage.Leave += new System.EventHandler(this.btnReglage_Leave);
            // 
            // btntel
            // 
            this.btntel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntel.FlatAppearance.BorderSize = 0;
            this.btntel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.btntel.Image = global::Cabinet.Properties.Resources.examen;
            this.btntel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntel.Location = new System.Drawing.Point(0, 230);
            this.btntel.Name = "btntel";
            this.btntel.Size = new System.Drawing.Size(200, 50);
            this.btntel.TabIndex = 2;
            this.btntel.Text = "Examen Biologique";
            this.btntel.UseVisualStyleBackColor = true;
            this.btntel.Click += new System.EventHandler(this.btntel_Click);
            // 
            // btnclient
            // 
            this.btnclient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.btnclient.Image = global::Cabinet.Properties.Resources.medicament;
            this.btnclient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclient.Location = new System.Drawing.Point(0, 180);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(200, 50);
            this.btnclient.TabIndex = 2;
            this.btnclient.Text = "Medicament";
            this.btnclient.UseVisualStyleBackColor = true;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // btnrep
            // 
            this.btnrep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnrep.FlatAppearance.BorderSize = 0;
            this.btnrep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrep.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.btnrep.Image = global::Cabinet.Properties.Resources.maladies1;
            this.btnrep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrep.Location = new System.Drawing.Point(0, 130);
            this.btnrep.Name = "btnrep";
            this.btnrep.Size = new System.Drawing.Size(200, 50);
            this.btnrep.TabIndex = 2;
            this.btnrep.Text = "Maladies";
            this.btnrep.UseVisualStyleBackColor = true;
            this.btnrep.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblpatient);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 130);
            this.panel2.TabIndex = 1;
            // 
            // lblpatient
            // 
            this.lblpatient.AutoSize = true;
            this.lblpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpatient.Location = new System.Drawing.Point(54, 97);
            this.lblpatient.Name = "lblpatient";
            this.lblpatient.Size = new System.Drawing.Size(44, 15);
            this.lblpatient.TabIndex = 2;
            this.lblpatient.Text = "patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(60, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historique";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cabinet.Properties.Resources._208_2081718_past_history_icon_png_blue;
            this.pictureBox1.Location = new System.Drawing.Point(57, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // bntfermer
            // 
            this.bntfermer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.bntfermer.CheckedState.Parent = this.bntfermer;
            this.bntfermer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bntfermer.CustomImages.Parent = this.bntfermer;
            this.bntfermer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bntfermer.FillColor = System.Drawing.Color.Transparent;
            this.bntfermer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntfermer.ForeColor = System.Drawing.Color.White;
            this.bntfermer.HoverState.FillColor = System.Drawing.Color.Red;
            this.bntfermer.HoverState.Parent = this.bntfermer;
            this.bntfermer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bntfermer.Location = new System.Drawing.Point(802, 12);
            this.bntfermer.Name = "bntfermer";
            this.bntfermer.ShadowDecoration.Parent = this.bntfermer;
            this.bntfermer.Size = new System.Drawing.Size(36, 28);
            this.bntfermer.TabIndex = 1;
            this.bntfermer.Text = "X";
            this.bntfermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bntfermer.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.bntfermer.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.bntfermer.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.DataGridView1.Location = new System.Drawing.Point(384, 86);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(286, 296);
            this.DataGridView1.TabIndex = 60;
            this.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
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
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 31);
            this.label2.TabIndex = 59;
            this.label2.Text = "Historique Medicaments";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 9;
            this.guna2Elipse2.TargetControl = this.bntfermer;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(313, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 61;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(577, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 62;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.label3;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.label4;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(861, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntfermer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnrep;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.Button btntel;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btnReglage;
        private System.Windows.Forms.Label lblpatient;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnlSide;
        private Guna.UI2.WinForms.Guna2Button bntfermer;
        public Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        public System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.Button btnEndos;
        private System.Windows.Forms.Button btnExamAnatom;
    }
}

