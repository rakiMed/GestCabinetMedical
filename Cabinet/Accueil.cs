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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }
        Int32 cmpt = 0;
        Int32 progressvalue = 0;
        private void Accueil_Load(object sender, EventArgs e)
        {

            
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            cmpt++;
            
            progressvalue = progressvalue + 10;
            progressBar1.Value = progressvalue;
            if (cmpt == 10)
            {
                this.Visible = false;
                new AnimatedLogin().Show();
                
                timer1.Enabled = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
