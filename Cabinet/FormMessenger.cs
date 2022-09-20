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
    public partial class FormMessenger : Form
    {
        User User;
        public FormMessenger(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {

            Message msg = new Message(txtMessage.Text,User.Login,"NonLu");
            User.Cabinet.EnvoyerUnMessage(msg);
            this.guna2TextBox1.AppendText(User.Cabinet.LireMessage());

            txtMessage.Clear();
            
        }
    }
}
