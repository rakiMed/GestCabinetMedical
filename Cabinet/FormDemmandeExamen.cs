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
    public partial class FormDemmandeExamen : Form
    {
        User User;
        public FormDemmandeExamen(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void FormDemmandeExamen_Load(object sender, EventArgs e)
        {
            try
            {
                switch (FormConsultation.TypeOfExamen)
                {

                    case "radio":
                        label1.Text = "Examen Radiologique";
                        this.Text = "Gerer les examens radiologique";
                        guna2PictureBox1.Image = Properties.Resources.radio2;
                        label2.Visible = true;
                        User.Cabinet.chargerExamenRadiologique();
                        guna2ComboBox1.DataSource = User.Cabinet.dtExamenRadiologique;
                        guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenRadiologique.Columns[0].ToString();

                        User.Cabinet.chargerExamenRadioDemmande(User.Cabinet.CurrentConsultation.IdConsultation);
                        dataGridView1.DataSource = User.Cabinet.dtExamenRadioDemmandee;
                        //dataGridView1.Columns[0].Visible = false;
                        if (dataGridView1.Rows.Count > 0)
                        {
                            dataGridView1.Visible = true;
                            btnRetirer.Visible = true;
                            label2.Visible = false;
                        }
                        break;

                    case "anatomo":
                        label1.Text = "Examen AnatomoPathologique";
                        label1.Left = 250;
                        this.Text = "Gerer les examens Anatomopathologiques";
                        guna2PictureBox1.Image = Properties.Resources.anatomo1;

                        label2.Visible = true;
                        User.Cabinet.chargerExamenAnatomo();
                        guna2ComboBox1.DataSource = User.Cabinet.dtExamenAnatomo;
                        guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenAnatomo.Columns[0].ToString();

                        User.Cabinet.chargerExamenAnatomoDemmande(User.Cabinet.CurrentConsultation.IdConsultation);
                        dataGridView1.DataSource = User.Cabinet.dtExamenAnatomoDemmande;
                        //dataGridView1.Columns[0].Visible = false;
                        if (dataGridView1.Rows.Count > 0)
                        {
                            dataGridView1.Visible = true;
                            btnRetirer.Visible = true;
                            label2.Visible = false;
                        }
                        break;

                    case "endoscopique":
                        label1.Text = "Examen Endoscopique";
                        this.Text = "Gerer les examens Endoscopiques";
                        guna2PictureBox1.Image = Properties.Resources.endo;
                        label2.Visible = true;
                        User.Cabinet.chargerExamenEndoscopique();
                        guna2ComboBox1.DataSource = User.Cabinet.dtExamensEndoscopiques;
                        guna2ComboBox1.DisplayMember = User.Cabinet.dtExamensEndoscopiques.Columns[0].ToString();

                        User.Cabinet.chargerExamenEndoscopiqueDemmande(User.Cabinet.CurrentConsultation.IdConsultation);
                        dataGridView1.DataSource = User.Cabinet.dtExamenEndoscopiqueDemmande;
                        //dataGridView1.Columns[0].Visible = false;
                        if (dataGridView1.Rows.Count > 0)
                        {
                            dataGridView1.Visible = true;
                            btnRetirer.Visible = true;
                            label2.Visible = false;
                        }

                        break;

                    default:
                        label2.Visible = true;
                        this.Text = "Gerer les examens Biologique";
                        guna2PictureBox1.Image = Properties.Resources.bio;
                        User.Cabinet.chargerExamensBiologique();
                        guna2ComboBox1.DataSource = User.Cabinet.dtExamenBiologique;
                        guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenBiologique.Columns[0].ToString();

                        User.Cabinet.chargerExamensBiologiqueDemmande(User.Cabinet.CurrentConsultation.IdConsultation);
                        dataGridView1.DataSource = User.Cabinet.dtExamenDemmande;
                        dataGridView1.Columns[0].Visible = false;
                        if (dataGridView1.Rows.Count > 0)
                        {
                            dataGridView1.Visible = true;
                            btnRetirer.Visible = true;
                            label2.Visible = false;

                        }

                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btndemmander_Click(object sender, EventArgs e)
        {
           

            switch (FormConsultation.TypeOfExamen)
            {
                case "radio":
                    dataGridView1.Visible = true;
                    btnRetirer.Visible = true;
                    label2.Visible = false;

                    try
                    {
                        User.Cabinet.AjouterExamenRadioDemmande(guna2ComboBox1.Text, User.Cabinet.CurrentConsultation.IdConsultation);
                        User.Cabinet.chargerExamenRadioDemmande(User.Cabinet.CurrentConsultation.IdConsultation);

                        dataGridView1.DataSource = User.Cabinet.dtExamenRadioDemmandee;
                        //dataGridView1.Columns[0].Visible = false;



                    }
                    catch (Exception)
                    {


                        MessageBox.Show("examen dejà demmandé !");
                    }

                    break;

                case "anatomo":
                    dataGridView1.Visible = true;
                    btnRetirer.Visible = true;
                    label2.Visible = false;

                    try
                    {
                        User.Cabinet.AjouterExamenAnatomoDemmande(guna2ComboBox1.Text, User.Cabinet.CurrentConsultation.IdConsultation);
                        User.Cabinet.chargerExamenAnatomoDemmande(User.Cabinet.CurrentConsultation.IdConsultation);

                        dataGridView1.DataSource = User.Cabinet.dtExamenAnatomoDemmande;
                        



                    }
                    catch (Exception)
                    {


                        MessageBox.Show("examen dejà demmandé !");
                    }
                    break;

                case "endoscopique":
                    dataGridView1.Visible = true;
                    btnRetirer.Visible = true;
                    label2.Visible = false;

                    try
                    {
                        User.Cabinet.AjouterExamenEndoscopiqueDemmande(guna2ComboBox1.Text, User.Cabinet.CurrentConsultation.IdConsultation);
                        User.Cabinet.chargerExamenEndoscopiqueDemmande(User.Cabinet.CurrentConsultation.IdConsultation);

                        dataGridView1.DataSource = User.Cabinet.dtExamenEndoscopiqueDemmande;
                        
                    }
                    catch (Exception)
                    {


                        MessageBox.Show("examen dejà demmandé !");
                    }
                    break;


                    // default is always for  bio exams
                default:
                    dataGridView1.Visible = true;
                    btnRetirer.Visible = true;
                    label2.Visible = false;

                    try
                    {
                        User.Cabinet.ajouterExamenDemmande(guna2ComboBox1.Text, User.Cabinet.CurrentConsultation.IdConsultation);
                        User.Cabinet.chargerExamensBiologiqueDemmande(User.Cabinet.CurrentConsultation.IdConsultation);

                        dataGridView1.DataSource = User.Cabinet.dtExamenDemmande;
                        dataGridView1.Columns[0].Visible = false;



                    }
                    catch (Exception)
                    {

                        MessageBox.Show("examen dejà demmandé !");
                    }
                    break;
            } 
                            
         }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(64,64,64);
            
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {


            try
            {

                switch (FormConsultation.TypeOfExamen)
                {
                    case "radio":
                        if (MessageBox.Show("Voulez vous vraiment retirer cet examen", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            User.Cabinet.SupprimerExamenRadioDemmandee(dataGridView1.CurrentCell.Value.ToString(), User.Cabinet.CurrentConsultation.IdConsultation);
                            User.Cabinet.chargerExamenRadioDemmande(User.Cabinet.CurrentConsultation.IdConsultation);

                            dataGridView1.DataSource = User.Cabinet.dtExamenRadioDemmandee;
                            //dataGridView1.Columns[0].Visible = false;

                            if (dataGridView1.Rows.Count == 0)
                            {

                                dataGridView1.Visible = false;
                                btnRetirer.Visible = false;
                                label2.Visible = true;
                            }
                        }
                        break;
                    case "anatomo":
                        if (MessageBox.Show("Voulez vous vraiment retirer cet examen", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            User.Cabinet.SupprimerExamenAnatomoDemmandee(dataGridView1.CurrentCell.Value.ToString(), User.Cabinet.CurrentConsultation.IdConsultation);
                            User.Cabinet.chargerExamenAnatomoDemmande(User.Cabinet.CurrentConsultation.IdConsultation);

                            dataGridView1.DataSource = User.Cabinet.dtExamenAnatomoDemmande;
                            //dataGridView1.Columns[0].Visible = false;

                            if (dataGridView1.Rows.Count == 0)
                            {

                                dataGridView1.Visible = false;
                                btnRetirer.Visible = false;
                                label2.Visible = true;
                            }
                        }
                        break;
                    case "endoscopique":
                        if (MessageBox.Show("Voulez vous vraiment retirer cet examen", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            User.Cabinet.SupprimerExamenEndoscopiqueDemmandee(dataGridView1.CurrentCell.Value.ToString(), User.Cabinet.CurrentConsultation.IdConsultation);
                            User.Cabinet.chargerExamenEndoscopiqueDemmande(User.Cabinet.CurrentConsultation.IdConsultation);

                            dataGridView1.DataSource = User.Cabinet.dtExamenEndoscopiqueDemmande;
                            //dataGridView1.Columns[0].Visible = false;

                            if (dataGridView1.Rows.Count == 0)
                            {

                                dataGridView1.Visible = false;
                                btnRetirer.Visible = false;
                                label2.Visible = true;
                            }
                        }

                        break;

                    // default is always  for bio exams
                    default:
                        if (MessageBox.Show("Voulez vous vraiment retirer cet examen", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            User.Cabinet.supprimerExamenDemmande(dataGridView1.CurrentCell.Value.ToString(), User.Cabinet.CurrentConsultation.IdConsultation);
                            User.Cabinet.chargerExamensBiologiqueDemmande(User.Cabinet.CurrentConsultation.IdConsultation);

                            dataGridView1.DataSource = User.Cabinet.dtExamenDemmande;
                            dataGridView1.Columns[0].Visible = false;

                            if (dataGridView1.Rows.Count == 0)
                            {

                                dataGridView1.Visible = false;
                                btnRetirer.Visible = false;
                                label2.Visible = true;
                            }
                        }

                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
                     
        }
    }
}
