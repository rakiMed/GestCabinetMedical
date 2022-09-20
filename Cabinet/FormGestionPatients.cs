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
    public partial class FormGestionPatients : Form
    {
        public User User;
        public FormGestionPatients(User u)
        {
            InitializeComponent();
            this.User = u;
        }

        private void FormGestionPatients_Load(object sender, EventArgs e)
        {
            try
            {
                User.Cabinet.chargerLesVille();
                cmbville.DataSource = User.Cabinet.dtville;
                cmbville.DisplayMember = User.Cabinet.dtville.Columns[0].ToString();
                dateTimePicker1.Value = DateTime.Now;
                cmbville.Text = "Khemisset";



                User.Cabinet.chargedtPatients();
                dataGridView1.DataSource = User.Cabinet.dtPatients;
                rdfemme.Checked = true;

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Nom";
                dataGridView1.Columns[2].HeaderText = "Prénom";
                dataGridView1.Columns[3].HeaderText = "CIN";
                dataGridView1.Columns[4].HeaderText = "Sexe";
                dataGridView1.Columns[5].HeaderText = "Tel";
                dataGridView1.Columns[6].HeaderText = "Date Naissance";
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].HeaderText = "Ville";
                dataGridView1.Columns[8].HeaderText = "Poids";
          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
              

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            
                
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        public void affecterLePatientAuxChamps()
        {
            this.txtnom.Text = User.Cabinet.CurrentPatient.Nom;
            this.txtprenom.Text = User.Cabinet.CurrentPatient.Prenom;
            this.txtcin.Text = User.Cabinet.CurrentPatient.Cin;
            this.txttel.Text = User.Cabinet.CurrentPatient.Telephone;
            this.cmbville.Text = User.Cabinet.CurrentPatient.Ville;
            this.txtpoids.Text = User.Cabinet.CurrentPatient.Poids.ToString();
            this.dateTimePicker1.Value = User.Cabinet.CurrentPatient.DateNaissance;

            if (User.Cabinet.CurrentPatient.Sexe.Equals("homme"))
            {
                rdhomme.Checked = true;
            }
            else
            {
                if (User.Cabinet.CurrentPatient.Sexe.Equals("femme"))
                {
                    rdfemme.Checked = true;
                }
            }
            if (User.Cabinet.CurrentPatient.Mutualiste.Equals("Oui"))
            {
               this.rdMutuelOui.Checked = true;
            }
            else
            {
                if (User.Cabinet.CurrentPatient.Mutualiste.Equals("Non"))
                {
                   this.rdMutuelNon.Checked = true;
                }
            }
        
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            
           
          
        }

        private void txtchangenom_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtchangcin_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void cmbchercherVille_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = User.Cabinet.dtPatients;
        }

        

        private void ajouterÀListeDattenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Cabinet.CurrentPatient==null)
            {
                MessageBox.Show("Vous devez d'abord choisir un patient !"); 
            }
            else
            {
                new FormGestionListeAttente(User).Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(User.Cabinet.CurrentPatient == null))
                {

                    if (MessageBox.Show("Voulez vous vraiment supprimer le patient ?", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        User.Cabinet.supprimerPatientDepuisListeAttentePourLeSupprimerDefinitefement();// supp liste att
                        User.Cabinet.supprimerAntecedentDuPatientSelectionne();// supp depuis antecedent
                        User.Cabinet.supprimerConsultationDuPatientSelectionne();// supp depuis Consultation
                        User.Cabinet.SupprimerPatient();
                        User.Cabinet.chargedtPatients();
                        dataGridView1.DataSource = User.Cabinet.dtPatients;
                        User.Cabinet.ViderTxtBox(this);
                    }
                    else
                    {
                        MessageBox.Show("La suppression a été annulée !");
                    }

                }
                else
                {
                    MessageBox.Show("Vous devez Selectionner un patient ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
           
            if (this.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("La liste des patients est encore vide !");
            }
            else
            {
                int pos = dataGridView1.CurrentRow.Index;
                
                    User.Cabinet.CurrentPatient = new Patient(Int32.Parse(User.Cabinet.dtPatients.Rows[pos][0].ToString()), User.Cabinet.dtPatients.Rows[pos][1].ToString(), User.Cabinet.dtPatients.Rows[pos][2].ToString(), User.Cabinet.dtPatients.Rows[pos][3].ToString(), User.Cabinet.dtPatients.Rows[pos][4].ToString(), User.Cabinet.dtPatients.Rows[pos][5].ToString(), DateTime.Parse(User.Cabinet.dtPatients.Rows[pos][6].ToString()), User.Cabinet.dtPatients.Rows[pos][7].ToString(), float.Parse(User.Cabinet.dtPatients.Rows[pos][8].ToString()),User.Cabinet.dtPatients.Rows[pos][9].ToString());
                    affecterLePatientAuxChamps();
                
              
              
            }

        }

        private void btnajouter_Click_1(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                MessageBox.Show("le nom ne doit pas etre vide !");
            }
            else
            {
                if (txtprenom.Text == "")
                {
                    MessageBox.Show("le prenom ne doit pas etre vide !");
                }
                else
                {
                    if (txtpoids.Text == "")
                    {
                        MessageBox.Show("Svp saisir une valeur de poids !");
                    }
                    else
                    {

                        try
                        {
                            string sexe = null;
                            string mutaliste = null;
                            if (rdfemme.Checked)
                            {
                                sexe = "femme";
                            }
                            else
                            {
                                if (rdhomme.Checked)
                                {
                                    sexe = "homme";
                                }
                            }
                            if (rdMutuelOui.Checked)
                            {
                                mutaliste = "Oui";

                            }
                            else
                            {
                                if (rdMutuelNon.Checked)
                                {
                                    mutaliste = "Non";
                                }
                            }


                            Patient p = new Patient(txtnom.Text, txtprenom.Text, txtcin.Text, sexe, txttel.Text, dateTimePicker1.Value, cmbville.Text, float.Parse(txtpoids.Text),mutaliste);
                            User.Cabinet.AjouterPatient(p);
                            User.Cabinet.chargedtPatients();
                            dataGridView1.DataSource = User.Cabinet.dtPatients;
                            ViderGunaTextBox();

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("SVP verifier la valeur du poids"); ;
                        }


                    }
                }
            }
        }

        private void btnNouveau_Click_1(object sender, EventArgs e)
        {
            ViderGunaTextBox();
            txtnom.Focus();
            User.Cabinet.CurrentPatient = null;
        }

        private void btnmodifier_Click_1(object sender, EventArgs e)
        {
            if (!(User.Cabinet.CurrentPatient == null))
            {
                if (txtnom.Text == "")
                {
                    MessageBox.Show("Le nom ne doit pas etre vide !");
                }
                else
                {
                    if (txtprenom.Text == "")
                    {
                        MessageBox.Show("Le prenom ne doit pas etre vide !");
                    }
                    else
                    {
                        if (txtpoids.Text == "")
                        {
                            MessageBox.Show("Veuillez saisir une valeur de poids svp !");
                        }
                        else
                        {
                            if (MessageBox.Show("Etes vous sur de modifier les informations du patient", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string sexe = null;
                                string mutaliste = null;
                                if (rdfemme.Checked)
                                {
                                    sexe = "femme";

                                }
                                else
                                {
                                    if (rdhomme.Checked)
                                    {
                                        sexe = "homme";
                                    }
                                }
                                if (rdMutuelOui.Checked)
                                {
                                    mutaliste = "Oui";

                                }
                                else
                                {
                                    if (rdMutuelNon.Checked)
                                    {
                                        mutaliste = "Non";
                                    }
                                }
                                try
                                {
                                    Patient p = new Patient(txtnom.Text, txtprenom.Text, txtcin.Text, sexe, txttel.Text, dateTimePicker1.Value, cmbville.Text, float.Parse(txtpoids.Text) ,mutaliste);
                                    User.Cabinet.modifierPatient(p);
                                    User.Cabinet.chargedtPatients();
                                    dataGridView1.DataSource = User.Cabinet.dtPatients;
                                }
                                catch (Exception)
                                {

                                    MessageBox.Show("La valeur du poids est incorrect svp vérifier la virgule");
                                }

                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un patient");
            }
        }

        private void btnsupp_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!(User.Cabinet.CurrentPatient == null))
                {

                    if (MessageBox.Show("Voulez vous vraiment supprimer le patient ?", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        User.Cabinet.supprimerPatientDepuisListeAttentePourLeSupprimerDefinitefement();// supp liste att
                        User.Cabinet.supprimerAntecedentDuPatientSelectionne();// supp depuis antecedent
                        User.Cabinet.SupprimerPatient();
                        User.Cabinet.chargedtPatients();
                        dataGridView1.DataSource = User.Cabinet.dtPatients;
                        ViderGunaTextBox();
                        User.Cabinet.CurrentPatient = null;
                    }
                    else
                    {
                        MessageBox.Show("La suppression a été annulée !");
                    }

                }
                else
                {
                    MessageBox.Show("Vous devez Selectionner un patient ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtchangenom_TextChanged_1(object sender, EventArgs e)
        {
            if (txtchangenom.Text == "")
            {
                User.Cabinet.chargedtPatients();
            }
            else
            {
                User.Cabinet.chercherPatientParNom(txtchangenom.Text);
            }

            dataGridView1.DataSource = User.Cabinet.dtPatients;
        }

        private void txtchangcin_TextChanged_1(object sender, EventArgs e)
        {
            if (txtchangcin.Text == "")
            {
                User.Cabinet.chargedtPatients();
            }
            else
            {
                User.Cabinet.chercherPatientParCin(txtchangcin.Text);
            }

            dataGridView1.DataSource = User.Cabinet.dtPatients;
        }

       
        public void ViderGunaTextBox()
        {
            txtnom.Clear();
            txtprenom.Clear();
            txtpoids.Clear();
            txtcin.Clear();
            txttel.Clear();
        
        }

        private void guna2PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(User.Cabinet.CurrentPatient==null))
            {
                guna2PictureBox2.Visible = true;
                label9.Visible = true;
                label9.Text = "Hi I'm "+User.Cabinet.CurrentPatient.Prenom;
            }
            
        }

        private void guna2PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox2.Visible = false;
            label9.Visible = false;
        }

       
    }
}
