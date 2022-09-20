using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cabinet
{
    public partial class FormHistory : Form
    {
        Form formDemandant;
        User User;
        public FormHistory(Form f,User u)
        {
            this.formDemandant = f;
            this.User = u;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pour le style

            btnrep.BackColor = Color.FromArgb(46,51,73);
            this.btnclient.BackColor = Color.FromArgb(24,30,54);
            this.btnExamAnatom.BackColor = Color.FromArgb(24, 30, 54);
            this.btntel.BackColor = Color.FromArgb(24, 30, 54);
            this.btnInter.BackColor = Color.FromArgb(24, 30, 54);
            this.btnReglage.BackColor = Color.FromArgb(24, 30, 54);
            this.btnEndos.BackColor = Color.FromArgb(24, 30, 54);

            pnlSide.Top = btnrep.Top;
            pnlSide.Height = btnrep.Height;
            pnlSide.Left = btnrep.Left;
            //

            try
            {

                this.DataGridView1.Visible = true;

                User.Cabinet.HistoriqueMaladies(User.Cabinet.CurrentPatient.IdPatient);
                this.DataGridView1.DataSource = User.Cabinet.dtHistoriqueMaladies;
                DataGridView1.Columns[0].HeaderText = "Maladies";
                DataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                label2.Text = "Historique Maladies ";
                Point locatlb = new Point(385, 40);
                label2.Location = locatlb;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            


            
            
        }

        private void btnclient_Click(object sender, EventArgs e)
        {// pour le style
            this.btnclient.BackColor = Color.FromArgb(46, 51, 73);
            this.btnExamAnatom.BackColor = Color.FromArgb(24, 30, 54);
            btnrep.BackColor = Color.FromArgb(24, 30, 54);   
            this.btntel.BackColor = Color.FromArgb(24, 30, 54);
            this.btnInter.BackColor = Color.FromArgb(24, 30, 54);
            this.btnReglage.BackColor = Color.FromArgb(24, 30, 54);
            this.btnEndos.BackColor = Color.FromArgb(24, 30, 54);


            pnlSide.Top = btnclient.Top;
            pnlSide.Height = btnclient.Height;
            pnlSide.Left = btnclient.Left;
            //
            this.DataGridView1.Visible = true;

            try
            {

                User.Cabinet.HistoriqueMedicamentPourPatient(User.Cabinet.CurrentPatient.IdPatient);
                this.DataGridView1.DataSource = User.Cabinet.dtHistoriqueMedicament;
                DataGridView1.Columns[0].HeaderText = "Medicament";
                DataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                label2.Text = "Historique Medicaments";
                Point loc = new Point(360, 40);
                label2.Location = loc;
          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btntel_Click(object sender, EventArgs e)
        {
            // pour le style
            this.btntel.BackColor = Color.FromArgb(46, 51, 73);

            this.btnclient.BackColor = Color.FromArgb(24, 30, 54);
            this.btnExamAnatom.BackColor = Color.FromArgb(24, 30, 54);
            btnrep.BackColor = Color.FromArgb(24, 30, 54);
            this.btnEndos.BackColor = Color.FromArgb(24, 30, 54);
            this.btnInter.BackColor = Color.FromArgb(24, 30, 54);
            this.btnReglage.BackColor = Color.FromArgb(24, 30, 54);

            pnlSide.Top = btntel.Top;
            pnlSide.Height = btntel.Height;
            pnlSide.Left = btntel.Left;
            //

            try
            {

                this.DataGridView1.Visible = true;
                User.Cabinet.HistoriqueExamenBiologiques(User.Cabinet.CurrentPatient.IdPatient);
                this.DataGridView1.DataSource = User.Cabinet.dtHistoriqueExamen;
                DataGridView1.Columns[0].HeaderText = "Examen Biologique";
                DataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                label2.Text = "Historique Examens Biologiques";
                Point locationlb = new Point(300, 40);
                label2.Location = locationlb;
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnInter_Click(object sender, EventArgs e)
        {

            
            this.btnInter.BackColor = Color.FromArgb(46, 51, 73);
            this.btnExamAnatom.BackColor = Color.FromArgb(24, 30, 54);

            this.btntel.BackColor = Color.FromArgb(24, 30, 54);

            this.btnclient.BackColor = Color.FromArgb(24, 30, 54);

            btnrep.BackColor = Color.FromArgb(24, 30, 54);

            this.btnEndos.BackColor = Color.FromArgb(24, 30, 54);
            this.btnReglage.BackColor = Color.FromArgb(24, 30, 54);


            pnlSide.Top = btnInter.Top;
            pnlSide.Height = btnInter.Height;
            pnlSide.Left = btnInter.Left;

            try
            {

                this.DataGridView1.Visible = true;
                User.Cabinet.HistoriqueExamenRadiologiques(User.Cabinet.CurrentPatient.IdPatient);
                this.DataGridView1.DataSource = User.Cabinet.dtHisoriqueExamenRadio;
                DataGridView1.Columns[0].HeaderText = "Examen Radiologique";
                DataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                label2.Text = "Historique Examens Radiologiques";
                Point locationlb = new Point(300, 40);
                label2.Location = locationlb;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReglage_Click(object sender, EventArgs e)
        {
            this.btnReglage.BackColor = Color.FromArgb(46, 51, 73);

            this.btnExamAnatom.BackColor = Color.FromArgb(24, 30, 54);
            this.btnInter.BackColor = Color.FromArgb(24, 30, 54);


            this.btntel.BackColor = Color.FromArgb(24, 30, 54);
            this.btnEndos.BackColor = Color.FromArgb(24, 30, 54);
            this.btnclient.BackColor = Color.FromArgb(24, 30, 54);

            btnrep.BackColor = Color.FromArgb(24, 30, 54);
            pnlSide.Top = btnReglage.Top;
            pnlSide.Height = btnReglage.Height;
            pnlSide.Left = btnReglage.Left;

            label3.Visible = true;
            label4.Visible = true;
            this.DataGridView1.Visible = false;
            this.label2.Text = "Infos Patient";


            int anneNaiss = User.Cabinet.CurrentPatient.DateNaissance.Year;
            int anneeActuel = DateTime.Now.Year;
            int age = anneeActuel - anneNaiss;

            label3.Text = "Age :"+age+" ans";
            label4.Text ="Poids :"+User.Cabinet.CurrentPatient.Poids.ToString() + " KG";




            


            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pour le style
            btnrep.BackColor = Color.FromArgb(46, 51, 73);
            pnlSide.Top = btnrep.Top;
            pnlSide.Height = btnrep.Height;
            pnlSide.Left = btnrep.Left;
            //

            try
            {

                lblpatient.Text = User.Cabinet.CurrentPatient.Nom + " " + User.Cabinet.CurrentPatient.Prenom;
                User.Cabinet.HistoriqueMaladies(User.Cabinet.CurrentPatient.IdPatient);
                this.DataGridView1.DataSource = User.Cabinet.dtHistoriqueMaladies;
                DataGridView1.Columns[0].HeaderText = "Maladies";
                DataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                label2.Text = "Historique Maladies ";
                Point locatlb = new Point(385, 40);
                label2.Location = locatlb;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Top = this.Top - 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Top = this.Top + 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Left = this.Left - 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Left = this.Left + 10;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
           
           this.formDemandant.WindowState = System.Windows.Forms.FormWindowState.Maximized;
           this.formDemandant.MdiParent.WindowState = System.Windows.Forms.FormWindowState.Maximized; 
             
        }

        private void btnReglage_Leave(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            
        }

        private void btnEndos_Click(object sender, EventArgs e)
        {
            this.btnEndos.BackColor = Color.FromArgb(46, 51, 73);
            this.btnExamAnatom.BackColor = Color.FromArgb(24, 30, 54);
            this.btnInter.BackColor = Color.FromArgb(24, 30, 54);
            this.btntel.BackColor = Color.FromArgb(24, 30, 54);

            this.btnclient.BackColor = Color.FromArgb(24, 30, 54);

            btnrep.BackColor = Color.FromArgb(24, 30, 54);


            this.btnReglage.BackColor = Color.FromArgb(24, 30, 54);


            pnlSide.Top = btnEndos.Top;
            pnlSide.Height = btnEndos.Height;
            pnlSide.Left = btnEndos.Left;
            

            //that side of design 

            try
            {

                this.DataGridView1.Visible = true;
                User.Cabinet.HistoriqueExamenEndoscopique(User.Cabinet.CurrentPatient.IdPatient);
                this.DataGridView1.DataSource = User.Cabinet.dtHitoriqueExamenEndoscopique;
                DataGridView1.Columns[0].HeaderText = "Examen Endiscopique";
                DataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                label2.Text = "Historique Examens Endiscopiques";
                Point locationlb = new Point(300, 40);
                label2.Location = locationlb;
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnExamAnatom_Click(object sender, EventArgs e)
        {
            this.btnExamAnatom.BackColor = Color.FromArgb(46, 51, 73);
            
            this.btnEndos.BackColor = Color.FromArgb(24, 30, 54);          
            this.btnInter.BackColor = Color.FromArgb(24, 30, 54);
            this.btntel.BackColor = Color.FromArgb(24, 30, 54);

            this.btnclient.BackColor = Color.FromArgb(24, 30, 54);

            btnrep.BackColor = Color.FromArgb(24, 30, 54);


            this.btnReglage.BackColor = Color.FromArgb(24, 30, 54);


            pnlSide.Top = btnExamAnatom.Top;
            pnlSide.Height = btnExamAnatom.Height;
            pnlSide.Left = btnExamAnatom.Left;

            //that was for style

            try
            {

                this.DataGridView1.Visible = true;
                User.Cabinet.HistoriqueExamenAnatomo(User.Cabinet.CurrentPatient.IdPatient);
                this.DataGridView1.DataSource = User.Cabinet.dtHistoriqueExamenAnatomo;
                DataGridView1.Columns[0].HeaderText = "Examen Anatomopathologique";
                DataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                label2.Text = "Historique Examens Anatomopathologiques";
                Point locationlb = new Point(240, 40);
                label2.Location = locationlb;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
