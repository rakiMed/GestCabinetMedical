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
    public partial class FormUpdateMaladie : Form
    {
        User User;
        Form parent;
        public FormUpdateMaladie(User u,Form par)
        {
            this.User = u;
           this.parent = par;
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
                       
        }

        private void FormUpdateMaladie_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        public void allConsultationAreUpdated()
        {
            try
            {

                FormChercherConsultation f = new FormChercherConsultation(User);

                f.MdiParent = this.parent;
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                User.Cabinet.chargerTousLesconsultation();
                f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
                System.Drawing.Size sz = new Size(1100, 350);
                Point locat = new Point(140, 150);
                f.dataGridView1.Size = sz;
                f.dataGridView1.Location = locat;
                Point locattxt = new Point(1025, 515);
                f.gunaLabel1.Location = locattxt;
                f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count);

                // locat and  and text guna label2 
                Point locatGunaLabel2 = new Point(500, 80);

                f.gunaLabel2.Location = locatGunaLabel2;

                f.gunaLabel2.Text = "Toutes Les Consultations";
                //

                f.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        public void DateConsultationAreUpdated()
        {
            try
            {

                FormChercherConsultation f = new FormChercherConsultation(User);

                f.MdiParent = this.parent;
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                f.dateTimePicker1.Value = DateTime.Now;
                User.Cabinet.chargerConsultationParDate(f.dateTimePicker1.Value);
                f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
                f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count);


                System.Drawing.Size sz = new Size(1100, 350);
                Point locat = new Point(140, 180);
                f.dataGridView1.Size = sz;
                f.dataGridView1.Location = locat;
                f.grbxDate.Visible = true;
                // locat label guna
                Point locattxt = new Point(1030, 550);
                f.gunaLabel1.Location = locattxt;
                //

                Point locationGrbx = new Point(144, 60);
                f.grbxDate.Location = locationGrbx;

                // locat and  and text guna label2 
                Point locatGunaLabel2 = new Point(550, 90);

                f.gunaLabel2.Location = locatGunaLabel2;

                f.gunaLabel2.Text = "Les Consultations Selon La Date";
                //

                f.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        public void refConsultationUpdated()
        {

            try
            {

                FormChercherConsultation f = new FormChercherConsultation(User);

                f.MdiParent = this.parent;
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                User.Cabinet.chargerConsultationParID(0);
                f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
                f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count);


                System.Drawing.Size sz = new Size(1100, 350);
                Point locat = new Point(140, 180);
                f.dataGridView1.Size = sz;
                f.dataGridView1.Location = locat;
                f.grbxIdConsultation.Visible = true;


                // location groupebox ref

                Point locatgrbx = new Point(145, 55);
                f.grbxIdConsultation.Location = locatgrbx;
                //

                //locat label guna
                Point locattxt = new Point(1030, 550);
                f.gunaLabel1.Location = locattxt;
                //

                // locat and  and text guna label2 
                Point locatGunaLabel2 = new Point(550, 90);

                f.gunaLabel2.Location = locatGunaLabel2;

                f.gunaLabel2.Text = "La Consultation Selon le Référence";
                //
                f.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        public void patientConsultationUpdated()
        {
            try
            {

                FormChercherConsultation f = new FormChercherConsultation(User);

                f.MdiParent = this.parent;
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                // seulement pour charger le vide dans la datagrid view pour qui elle contient des columns qui sont modifiés en load on ajoute ce code entre les deux commentaires suivants

                User.Cabinet.chargerConsultationParNomPatient(" ");
                f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
                f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count);
                // fin code
                System.Drawing.Size sz = new Size(1100, 350);
                Point locat = new Point(140, 180);
                f.dataGridView1.Size = sz;
                f.dataGridView1.Location = locat;
                f.grbxPatient.Visible = true;

                //locat label guna
                Point locattxt = new Point(1030, 550);
                f.gunaLabel1.Location = locattxt;
                //

                // location groupebox patient

                Point locatgrbx = new Point(145, 40);
                f.grbxPatient.Location = locatgrbx;
                //

                // locat and  and text guna label2 
                Point locatGunaLabel2 = new Point(550, 90);

                f.gunaLabel2.Location = locatGunaLabel2;

                f.gunaLabel2.Text = "Les Consultation Selon le Patient";
                //
                f.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        public void lastConsultationIsUpdated()
        {
            try
            {

                FormChercherConsultation f = new FormChercherConsultation(User);

                f.MdiParent = this.parent;
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                User.Cabinet.chargerConsultationParID(Consultation.getIdConsultationLastOne(User));
                f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
                System.Drawing.Size sz = new Size(1100, 350);
                Point locat = new Point(140, 180);
                f.dataGridView1.Size = sz;
                f.dataGridView1.Location = locat;
                //locat label guna
                Point locattxt = new Point(1030, 550);
                f.gunaLabel1.Location = locattxt;
                //
                f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count);

                // locat and  and text guna label2 
                Point locatGunaLabel2 = new Point(500, 90);

                f.gunaLabel2.Location = locatGunaLabel2;

                f.gunaLabel2.Text = "La dernière Consultation";
                //
                f.Show();
                if (User.Cabinet.dtConsultation.Rows.Count == 1)
                {
                    User.Cabinet.CurrentConsultation = new Consultation(Int32.Parse(User.Cabinet.dtConsultation.Rows[0][0].ToString()));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        public void HistoryPatientUpdated()
        {
            try
            {

                FormChercherConsultation f = new FormChercherConsultation(User);

                f.MdiParent = this.parent;
                f.WindowState = System.Windows.Forms.FormWindowState.Maximized;


                User.Cabinet.chargerConsultationParIDPatient(User.Cabinet.CurrentPatient.IdPatient);
                f.dataGridView1.DataSource = User.Cabinet.dtConsultation;
                f.gunaLabel1.Text = "Nombre De Consultation :" + (f.dataGridView1.Rows.Count);

                System.Drawing.Size sz = new Size(1100, 350);
                Point locat = new Point(140, 180);
                f.dataGridView1.Size = sz;
                f.dataGridView1.Location = locat;


                //locat label guna
                Point locattxt = new Point(1030, 550);
                f.gunaLabel1.Location = locattxt;
                //



                // locat and  and text guna label2 
                Point locatGunaLabel2 = new Point(550, 90);

                f.gunaLabel2.Location = locatGunaLabel2;

                f.gunaLabel2.Text = "Les Consultation duP atient '" + User.Cabinet.CurrentPatient.Nom + "' '" + User.Cabinet.CurrentPatient.Prenom + "'";
                //
                f.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (labelMR.Text.Equals("Remarque"))
            {
                try
                {

                    User.Cabinet.UpdateRemarqueConsultation(txtmaladie.Text, User.Cabinet.CurrentConsultation.IdConsultation);
                    this.Close();
                    MessageBox.Show("La modification à été effectuée avec succes !");

                    switch (FormMedcin.WishOne)
                    {
                        case "tous": allConsultationAreUpdated();
                            break;
                        case "date": DateConsultationAreUpdated();
                            break;
                        case "ref": refConsultationUpdated();
                            break;
                        case "patient": patientConsultationUpdated();
                            break;
                        case "derniere": lastConsultationIsUpdated();
                            break;
                        case "HistoryPatient": HistoryPatientUpdated();
                            break;

                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {

                    User.Cabinet.UpdateMaladieConsultation(txtmaladie.Text, User.Cabinet.CurrentConsultation.IdConsultation);
                    this.Close();
                    MessageBox.Show("La modification à été effectuée avec succes !");

                    switch (FormMedcin.WishOne)
                    {
                        case "tous": allConsultationAreUpdated();
                            break;
                        case "date": DateConsultationAreUpdated();
                            break;
                        case "ref": refConsultationUpdated();
                            break;
                        case "patient": patientConsultationUpdated();
                            break;
                        case "derniere": lastConsultationIsUpdated();
                            break;
                        case "HistoryPatient": HistoryPatientUpdated();
                            break;
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
