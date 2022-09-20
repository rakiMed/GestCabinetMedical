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
    public partial class FormGestionUtilisateurs : Form
    {
        User User;
        DataTable dttype;
        public FormGestionUtilisateurs(User u)
        {
            InitializeComponent();
            this.User = u;
            
        }

        private void FormGestionUtilisateurs_Load(object sender, EventArgs e)
        {
            try
            {

                User.Cabinet.ChargerDtUtilisateurs();
                dataGridView1.DataSource = User.Cabinet.dtutilisateurs;
                dttype = User.Cabinet.getdt("select * from type");

                cmbtype.DataSource = dttype;
                cmbtype.DisplayMember = dttype.Columns[0].ToString();
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            






            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void affecterLesChamps(User u)
        {

            txtlogin.Text = u.Login;
            txtpassword.Text = u.Password;
            cmbtype.Text = u.Type;
        
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            if (txtlogin.Text == "")
            {
                MessageBox.Show("Login ne doit pas etre vide !");
            }
            else
            {
                if (txtpassword.Text == "")
                {
                    MessageBox.Show("le mot de passe ne doit pas etre vide !");
                }
                else
                {
                    if (!(txtpassword.Text.Equals(txtconfirm.Text)))
                    {
                        MessageBox.Show("les mots de passe ne correspondent pas ! ");
                    }
                    else
                    {
                        try
                        {

                            User u = new User(txtlogin.Text, txtpassword.Text, cmbtype.Text);
                            this.User.Cabinet.AjouterUtilisateur(u);
                            User.Cabinet.ChargerDtUtilisateurs();
                            dataGridView1.DataSource = User.Cabinet.dtutilisateurs;
                            txtlogin.Clear();
                            txtpassword.Clear();
                            txtconfirm.Clear();
                            txtlogin.Focus();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }

                }

            }
        }

        private void btnmodifier_Click_1(object sender, EventArgs e)
        {
            if (User.Cabinet.CurrentUser == null)
            {
                MessageBox.Show("veuillez selectionner un utilisateur ");
            }
            else
            {
                if (txtlogin.Text == "")
                {
                    MessageBox.Show("veuillez selectionner un utilisateur ");
                }
                else
                {



                    if (txtconfirm.Text == "")
                    {
                        MessageBox.Show("vous devez confirmer le mot de passe");
                    }
                    else
                    {
                        if (!(txtconfirm.Text.Equals(txtpassword.Text)))
                        {
                            MessageBox.Show("les mots de passe ne sont pas identiques !");
                        }
                        else
                        {
                            try
                            {

                                User u = new User(txtlogin.Text, txtpassword.Text, cmbtype.Text);
                                User.Cabinet.modifierUtilisateur(u);
                                User.Cabinet.ChargerDtUtilisateurs();
                                dataGridView1.DataSource = User.Cabinet.dtutilisateurs;
                                txtlogin.Clear();
                                txtpassword.Clear();
                                txtconfirm.Clear();

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }                        }
                    }
                }

            }

        }

        private void btnsupp_Click_1(object sender, EventArgs e)
        {
            if (!(User.Cabinet.CurrentUser == null))
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer l'utilisateur ?", "attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        User.Cabinet.SupprimerUtilisateur();
                        User.Cabinet.ChargerDtUtilisateurs();
                        dataGridView1.DataSource = User.Cabinet.dtutilisateurs;
                        txtlogin.Clear();
                        txtpassword.Clear();
                        txtconfirm.Clear();
                        txtlogin.Focus();
                    }
                    catch (Exception  ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    MessageBox.Show("l'utilisateur n'est pas supprimé !");
                }


            }
            else
            {
                MessageBox.Show("Vous devez selectionner un utilisateur ");
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            int pos;
            pos = dataGridView1.CurrentRow.Index;
            User.Cabinet.CurrentUser = new User(User.Cabinet.dtutilisateurs.Rows[pos][0].ToString(), User.Cabinet.dtutilisateurs.Rows[pos][1].ToString(), User.Cabinet.dtutilisateurs.Rows[pos][2].ToString());

            affecterLesChamps(User.Cabinet.CurrentUser);
        }
    }
}
