using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cabinet
{
    public partial class AnimatedLogin : Form
    {
        List<Image> images = new List<Image>();
        public AnimatedLogin()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnimatedLogin_Load(object sender, EventArgs e)
        {
            images.Add(Properties.Resources.textbox_user_1);
            images.Add(Properties.Resources.textbox_user_2);
            images.Add(Properties.Resources.textbox_user_3);
            images.Add(Properties.Resources.textbox_user_4);
            images.Add(Properties.Resources.textbox_user_5);
            images.Add(Properties.Resources.textbox_user_6);
            images.Add(Properties.Resources.textbox_user_7);
            images.Add(Properties.Resources.textbox_user_8);
            images.Add(Properties.Resources.textbox_user_9);
            images.Add(Properties.Resources.textbox_user_10);
            images.Add(Properties.Resources.textbox_user_11);
            images.Add(Properties.Resources.textbox_user_12);
            images.Add(Properties.Resources.textbox_user_13);
            images.Add(Properties.Resources.textbox_user_14);
            images.Add(Properties.Resources.textbox_user_15);
            images.Add(Properties.Resources.textbox_user_16);
            images.Add(Properties.Resources.textbox_user_17);
            images.Add(Properties.Resources.textbox_user_18);
            images.Add(Properties.Resources.textbox_user_19);
            images.Add(Properties.Resources.textbox_user_20);
            images.Add(Properties.Resources.textbox_user_21);
            images.Add(Properties.Resources.textbox_user_22);
            images.Add(Properties.Resources.textbox_user_23);
            images.Add(Properties.Resources.textbox_user_24);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtlogin.Text.Length > 0 && txtlogin.Text.Length <= 22)
            {
                pictureBox1.Image = images[txtlogin.Text.Length - 1];
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txtlogin.Text.Length <= 0)
                pictureBox1.Image = Properties.Resources.debut;
            else
                pictureBox1.Image = images[22];
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text.Length > 0)
                pictureBox1.Image = images[txtlogin.Text.Length - 1];
            else
                pictureBox1.Image = Properties.Resources.debut;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.textbox_password;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtlogin.Text.Length > 0)
                pictureBox1.Image = images[txtlogin.Text.Length - 1];
            else
                pictureBox1.Image = Properties.Resources.debut;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                User u = new User(txtlogin.Text, txtpassword.Text);

                //u.Cn = new SqlConnection("server=192.168.0.104; database=GestCabinet ; integrated security=false ;user ID=med;password=123456");
                u.Cn = new SqlConnection("database=GestCabinet ; integrated security=true");
                u.Cabinet.AuthentifierMoi();
                txtpassword.Clear();
                txtpassword.Focus();
                if (u.Cabinet.EtatConnexion)
                {
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
