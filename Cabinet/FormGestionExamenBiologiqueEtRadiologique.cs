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
    public partial class FormGestionExamenBiologiqueEtRadiologique : Form
    {
        User User;

        public FormGestionExamenBiologiqueEtRadiologique(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void FormGestionExamenBiologiqueEtRadiologique_Load(object sender, EventArgs e)
        {

        }

        private void FormGestionExamenBiologiqueEtRadiologique_Load_1(object sender, EventArgs e)
        {
            try
            {

                switch (FormAdministrareur.typeOfExam)
                {
                    case "radio":
                        label1.Text = "Examen Radiologique";
                        guna2PictureBox1.Image = Properties.Resources.radioo;
                        User.Cabinet.chargerExamenRadiologique();
                        guna2ComboBox1.DataSource = User.Cabinet.dtExamenRadiologique;
                        guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenRadiologique.Columns[0].ToString();
                        txtexamen.Clear();
                        break;

                    case "anatomo":
                        label1.Text = "Examen Anatomopathologique";
                        guna2PictureBox1.Image = Properties.Resources.anatomo;
                        User.Cabinet.chargerExamenAnatomo();
                        guna2ComboBox1.DataSource = User.Cabinet.dtExamenAnatomo;
                        guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenAnatomo.Columns[0].ToString();
                        txtexamen.Clear();

                        break;

                    case "endoscopique":
                        label1.Text = "Examen Endoscopique";
                        guna2PictureBox1.Image = Properties.Resources.endoscopie;
                        User.Cabinet.chargerExamenEndoscopique();
                        guna2ComboBox1.DataSource = User.Cabinet.dtExamensEndoscopiques;
                        guna2ComboBox1.DisplayMember = User.Cabinet.dtExamensEndoscopiques.Columns[0].ToString();
                        txtexamen.Clear();
                        break;


                    default:
                        User.Cabinet.chargerExamensBiologique();
                        guna2ComboBox1.DataSource = User.Cabinet.dtExamenBiologique;
                        guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenBiologique.Columns[0].ToString();
                        txtexamen.Clear();
                        break;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                

                
            
            
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {


            switch (FormAdministrareur.typeOfExam)
            {

                case "radio":

                    if (txtexamen.Text == "")
                    {
                        txtexamen.BorderColor = Color.Red;
                        MessageBox.Show("Vous devez saisir un examen radiologique !");
                        txtexamen.Focus();
                    }
                    else
                    {
                        try
                        {
                            User.Cabinet.AjouterExamenRadiologique(txtexamen.Text);
                         
                            User.Cabinet.chargerExamenRadiologique();
                            guna2ComboBox1.DataSource = User.Cabinet.dtExamenRadiologique;
                            guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenRadiologique.Columns[0].ToString();

                            txtexamen.Clear();
                            txtexamen.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                     }
                    break;

                case "anatomo":
                    if (txtexamen.Text == "")
                    {
                        txtexamen.BorderColor = Color.Red;
                        MessageBox.Show("Vous devez saisir un examen Anatomopathologique !");
                        txtexamen.Focus();
                    }
                    else
                    {
                        try
                        {
                            User.Cabinet.AjouterExamenAnatomo(txtexamen.Text);
                         
                            User.Cabinet.chargerExamenAnatomo();
                            guna2ComboBox1.DataSource = User.Cabinet.dtExamenAnatomo;
                            guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenAnatomo.Columns[0].ToString();

                            txtexamen.Clear();
                            txtexamen.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                    break;

                case "endoscopique":
                    if (txtexamen.Text == "")
                    {
                        txtexamen.BorderColor = Color.Red;
                        MessageBox.Show("Vous devez saisir un examen Endoscopique !");
                        txtexamen.Focus();
                    }
                    else
                    {
                        try
                        {
                            User.Cabinet.AjouterExamenEndoscopique(txtexamen.Text);
                         
                            User.Cabinet.chargerExamenEndoscopique();
                            guna2ComboBox1.DataSource = User.Cabinet.dtExamensEndoscopiques;
                            guna2ComboBox1.DisplayMember = User.Cabinet.dtExamensEndoscopiques.Columns[0].ToString();

                            txtexamen.Clear();
                            txtexamen.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }

                    break;

                default:
                    if (txtexamen.Text == "")
                    {
                        txtexamen.BorderColor = Color.Red;
                        MessageBox.Show("Vous devez saisir un examen biologique !");
                        txtexamen.Focus();
                    }
                    else
                    {
                        try
                        {
                            User.Cabinet.AjouterAnalyse(txtexamen.Text);
                            

                            User.Cabinet.chargerExamensBiologique();
                            guna2ComboBox1.DataSource = User.Cabinet.dtExamenBiologique;
                            guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenBiologique.Columns[0].ToString();

                            txtexamen.Clear();
                            txtexamen.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                            
                        }
                     }
                    break;
            }
                
        
            
        }

        private void guna2ComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtexamen.Text = guna2ComboBox1.Text;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
           


            
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {

            try
            {
                switch (FormAdministrareur.typeOfExam)
                {

                    case "radio":
                        if (txtexamen.Text == "")
                        {
                            guna2ComboBox1.BorderColor = Color.Red;
                            MessageBox.Show("Vous devez Selectionner un examen radiologique !");

                        }
                        else
                        {
                            if (MessageBox.Show("Voulez vous vraiment supprimer cet examen", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                User.Cabinet.SupprimerExamenRadio(guna2ComboBox1.Text);
                                MessageBox.Show("Examen supprimé avec succes !");

                                User.Cabinet.chargerExamenRadiologique();
                                guna2ComboBox1.DataSource = User.Cabinet.dtExamenRadiologique;
                                guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenRadiologique.Columns[0].ToString();

                                txtexamen.Clear();
                                txtexamen.Focus();
                            }

                        }

                        break;

                    case "anatomo":
                        if (txtexamen.Text == "")
                        {
                            guna2ComboBox1.BorderColor = Color.Red;
                            MessageBox.Show("Vous devez Selectionner un examen Anatomopathologique !");

                        }
                        else
                        {
                            if (MessageBox.Show("Voulez vous vraiment supprimer cet examen", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                User.Cabinet.SupprimerExamenAnatomo(guna2ComboBox1.Text);
                                MessageBox.Show("Examen supprimé avec succes !");

                                User.Cabinet.chargerExamenAnatomo();
                                guna2ComboBox1.DataSource = User.Cabinet.dtExamenAnatomo;
                                guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenAnatomo.Columns[0].ToString();

                                txtexamen.Clear();
                                txtexamen.Focus();
                            }

                        }
                        break;

                    case "endoscopique":

                        if (txtexamen.Text == "")
                        {
                            guna2ComboBox1.BorderColor = Color.Red;
                            MessageBox.Show("Vous devez Selectionner un examen Endoscopique !");

                        }
                        else
                        {
                            if (MessageBox.Show("Voulez vous vraiment supprimer cet examen", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                User.Cabinet.SupprimerExamenEndoscopique(guna2ComboBox1.Text);
                                MessageBox.Show("Examen supprimé avec succes !");

                                User.Cabinet.chargerExamenEndoscopique();
                                guna2ComboBox1.DataSource = User.Cabinet.dtExamensEndoscopiques;
                                guna2ComboBox1.DisplayMember = User.Cabinet.dtExamensEndoscopiques.Columns[0].ToString();

                                txtexamen.Clear();
                                txtexamen.Focus();
                            }

                        }
                        break;


                    default:
                        if (txtexamen.Text == "")
                        {
                            guna2ComboBox1.BorderColor = Color.Red;
                            MessageBox.Show("Vous devez Selectionner un examen !");

                        }
                        else
                        {
                            if (MessageBox.Show("Voulez vous vraiment supprimer cet examen", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                User.Cabinet.SupprimerAnalyse(guna2ComboBox1.Text);
                                MessageBox.Show("Examen supprimé avec succes !");

                                User.Cabinet.chargerExamensBiologique();
                                guna2ComboBox1.DataSource = User.Cabinet.dtExamenBiologique;
                                guna2ComboBox1.DisplayMember = User.Cabinet.dtExamenBiologique.Columns[0].ToString();

                                txtexamen.Clear();
                                txtexamen.Focus();
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

        private void txtexamen_TextChanged(object sender, EventArgs e)
        {
            txtexamen.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void txtexamen_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(247,184,41);
        }
    }
}
