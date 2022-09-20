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
    public partial class FormGestionMedicament : Form
    {
        User User;
       
        public FormGestionMedicament(User u)
        {
            this.User = u;
            
            
            InitializeComponent();
        }

       

        private void FormGestionMedicament_Load(object sender, EventArgs e)
        {
            try
            {

                txtchercher.ForeColor = Color.Gray;
                User.Cabinet.chargerDtMedicament();
                cmbmedicament.DataSource = User.Cabinet.dtMedicament;
                cmbmedicament.DisplayMember = User.Cabinet.dtMedicament.Columns[0].ToString();
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            
           
        }

        private void txtchercher_Leave(object sender, EventArgs e)
        {

        }

        private void txtchercher_TextChanged(object sender, EventArgs e)
        {

            try
            {

                User.Cabinet.chercherMedicament(txtchercher.Text);
                lstresult.DataSource = User.Cabinet.dtMedicament;
                lstresult.DisplayMember = User.Cabinet.dtMedicament.Columns[0].ToString();
                lstresult.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtchercher_Click(object sender, EventArgs e)
        {
            txtchercher.Clear();
            txtchercher.ForeColor = Color.Black;
        }

        private void lstresult_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstresult_Click(object sender, EventArgs e)
        {

            cmbmedicament.Text = lstresult.Text;
            txtchercher.Text = "Chercher Medicament";
            txtchercher.ForeColor = Color.Gray;
            lstresult.Visible = false;
        }

        private void lstresult_Leave(object sender, EventArgs e)
        {
            lstresult.Visible = false;
        }

        private void lstresult_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtchercher_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

                User.Cabinet.chercherMedicament(txtchercher.Text);
                lstresult.DataSource = User.Cabinet.dtMedicament;
                lstresult.DisplayMember = User.Cabinet.dtMedicament.Columns[0].ToString();
                lstresult.Visible = true;
                if (txtchercher.Text.Length>0)
                {
                    labelClear.Visible = true;
                }
                else
                {
                    labelClear.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstresult_Click_1(object sender, EventArgs e)
        {
            cmbmedicament.Text = lstresult.Text;
            txtchercher.Clear();
            lstresult.Visible = false;
        }

        private void FormGestionMedicament_MouseClick(object sender, MouseEventArgs e)
        {
            lstresult.Visible = false;
        }

        private void BtnAjouter_Click_1(object sender, EventArgs e)
        {
            if (txtmedicament.Text == "")
            {
                MessageBox.Show("Vous devez saisir un medicament ");
            }
            else
            {
                try
                {
                    User.Cabinet.ajouterMedicament(txtmedicament.Text);
                    User.Cabinet.chargerDtMedicament();
                    cmbmedicament.DataSource = User.Cabinet.dtMedicament;
                    cmbmedicament.DisplayMember = User.Cabinet.dtMedicament.Columns[0].ToString();
                    txtmedicament.Clear();
                    txtmedicament.Focus();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); ;
                }

            }
        }

        private void btnsupp_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbmedicament.Text != "")
                {

                    if (MessageBox.Show("Voulez vous vraiment supprimer ce medicament ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        User.Cabinet.supprimerMedicament(cmbmedicament.Text);
                        User.Cabinet.chargerDtMedicament();
                        cmbmedicament.DataSource = User.Cabinet.dtMedicament;
                        cmbmedicament.DisplayMember = User.Cabinet.dtMedicament.Columns[0].ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Aucun medicament n'est dans la liste !");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Panel3_MouseClick(object sender, MouseEventArgs e)
        {
            lstresult.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtchercher.Clear();
        }

       
        
    }
}
