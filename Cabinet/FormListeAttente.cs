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
    public partial class FormListeAttente : Form
    {
        User User;
        public FormListeAttente(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void FormListeAttente_Load(object sender, EventArgs e)
        {
            try
            {

                User.Cabinet.chargerListeAttente();
                dataGridView1.DataSource = User.Cabinet.dtListeAttente;
                dataGridView1.Columns[0].Visible = false;
                this.gunaLabel1.Text = (dataGridView1.Rows.Count) + " Patient(s) En Attente";

                dataGridView1.Columns[1].HeaderText = "Nom";
                dataGridView1.Columns[1].Width = 90;
                dataGridView1.Columns[2].HeaderText = "Prénom";
                dataGridView1.Columns[3].HeaderText = "CIN";
                dataGridView1.Columns[4].HeaderText = "Sexe";
                dataGridView1.Columns[5].HeaderText = "Date Naissance";
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].HeaderText = "Tel";
                dataGridView1.Columns[7].HeaderText = "Ville";
                dataGridView1.Columns[8].HeaderText = "Motif Visite";
                dataGridView1.Columns[8].Width = 120;
                dataGridView1.Columns[9].HeaderText = "Heure Arrivé";
                dataGridView1.Columns[9].Width = 120;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            int pos = dataGridView1.CurrentRow.Index;
            if (User.Cabinet.dtListeAttente.Rows.Count == 0)
            {
                MessageBox.Show("La liste d'attente est encore vide !");
            }
            else
            {
                if (pos < User.Cabinet.dtListeAttente.Rows.Count)
                {

                    User.Cabinet.CurrentListeAttente = new ListeAttente(Int32.Parse(User.Cabinet.dtListeAttente.Rows[pos][0].ToString()),DateTime.Parse(User.Cabinet.dtListeAttente.Rows[pos][9].ToString()), User.Cabinet.dtListeAttente.Rows[pos][8].ToString(), User.Cabinet.dtListeAttente.Rows[pos][10].ToString());
                }
                else
                {
                    MessageBox.Show("aucun patient est là !");
                }

            }
        }

        private void patientEstPartiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                if (User.Cabinet.CurrentListeAttente == null)
                {
                    MessageBox.Show("Vous devez selectionner un patient");
                }
                else
                {
                    if (MessageBox.Show("Etes vous sur de retirer ce patient de la liste d'attente ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        User.Cabinet.supprimerPatientDepuisListeAttente();
                        User.Cabinet.chargerListeAttente();
                        dataGridView1.DataSource = User.Cabinet.dtListeAttente;
                        dataGridView1.Columns[0].Visible = false;

                        this.gunaLabel1.Text = (dataGridView1.Rows.Count) + " Patient(s) En Attente";

                    }
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {

            int pos;
            if (User.Cabinet.dtListeAttente.Rows.Count == 0)
            {
                MessageBox.Show("La liste d'attente est encore vide !");
            }
            else
            {
                pos = dataGridView1.CurrentRow.Index;
                if (pos < User.Cabinet.dtListeAttente.Rows.Count)
                {

                    User.Cabinet.CurrentListeAttente = new ListeAttente(Int32.Parse(User.Cabinet.dtListeAttente.Rows[pos][0].ToString()), DateTime.Parse(User.Cabinet.dtListeAttente.Rows[pos][9].ToString()), User.Cabinet.dtListeAttente.Rows[pos][8].ToString(), User.Cabinet.dtListeAttente.Rows[pos][10].ToString());
                }
                else
                {
                    MessageBox.Show("aucun patient est là !");
                }

            }
        }
    }
}
