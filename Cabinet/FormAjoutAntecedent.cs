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
    public partial class FormAjoutAntecedent : Form
    {
        User User;
        public FormAjoutAntecedent(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void FormAjoutAntecedent_Load(object sender, EventArgs e)
        {
            try
            {

                dataGridView2.ForeColor = Color.Red;
                this.lblpatient.Text = "Antecedents du patient " + User.Cabinet.CurrentPatient.Nom + " " + User.Cabinet.CurrentPatient.Prenom + "";
                User.Cabinet.chargerDtAntecedent(User.Cabinet.CurrentPatient);
                dataGridView2.DataSource = User.Cabinet.dtAntecedent;
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].HeaderText = "Antecedent";
                dataGridView2.Columns[2].HeaderText = "Medicament";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtchercher_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtchercher_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstresult_Click(object sender, EventArgs e)
        {

        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show("La liste des antecedents est encore vide !");
                }
                else
                {
                    int pos = dataGridView2.CurrentRow.Index;

                    User.Cabinet.CurrentAntecedent = new Antecedent(Int32.Parse(User.Cabinet.dtAntecedent.Rows[pos][0].ToString()), User.Cabinet.dtAntecedent.Rows[pos][2].ToString(), User.Cabinet.dtAntecedent.Rows[pos][1].ToString());

                    cmbmedicament.Text = User.Cabinet.CurrentAntecedent.Medicament;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            try
            {
                Antecedent ant = new Antecedent(cmbmedicament.Text, cmbAntecedent.Text);
                User.Cabinet.ajouterAntecedent(ant);

                User.Cabinet.chargerDtAntecedent(User.Cabinet.CurrentPatient);
                dataGridView2.DataSource = User.Cabinet.dtAntecedent;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer cet anticedent?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    User.Cabinet.supprimerAntecedent();
                    User.Cabinet.chargerDtAntecedent(User.Cabinet.CurrentPatient);
                    dataGridView2.DataSource = User.Cabinet.dtAntecedent;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (User.Cabinet.CurrentAntecedent == null)
                {
                    MessageBox.Show("Vous devez selectionner un anticedent à modifier !");
                }
                else
                {

                    Antecedent ant = new Antecedent(cmbmedicament.Text, cmbAntecedent.Text);
                    User.Cabinet.modifierAntecedent(ant);
                    User.Cabinet.chargerDtAntecedent(User.Cabinet.CurrentPatient);
                    dataGridView2.DataSource = User.Cabinet.dtAntecedent;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtchercher_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtlibelleanticedent_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void cmbmedicament_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void FormAjoutAntecedent_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        
    }
}
