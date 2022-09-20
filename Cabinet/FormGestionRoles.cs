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
    public partial class FormGestionRoles : Form
    {
        User user;
        string stateMedcin;
        string stateSecretaire;
        public FormGestionRoles(User u)
        {

            InitializeComponent();
            this.user = u;
        }

        private void FormGestionRoles_Load(object sender, EventArgs e)
        {
            try
            {

                stateMedcin = user.Cabinet.chargerStateRoleMedicamentPourMedcin();
                stateSecretaire = user.Cabinet.chargerStateRoleMedicamentPourSecretaire();

                if (stateMedcin=="activé")
                {
                    rdMedcinEnebled.Checked = true;
                }
                else
                {
                    rdMedcinDesabled.Checked = true;
                }

                if (stateSecretaire=="activé")
                {
                    rdSecEnabled.Checked = true;
                }
                else
                {
                    RdSecDesabled.Checked = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rdMedcinEnebled_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                user.Cabinet.updateStateRoleMedicamentForMedcin("activé");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rdMedcinDesabled_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                user.Cabinet.updateStateRoleMedicamentForMedcin("desactivé");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rdSecEnabled_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                user.Cabinet.updateStateRoleMedicamentForSecretaire("activé");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void RdSecDesabled_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                user.Cabinet.updateStateRoleMedicamentForSecretaire("desactivé");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
