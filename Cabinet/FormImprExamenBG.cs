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
    public partial class FormImprExamenBG : Form
    {
        User User;
        public FormImprExamenBG(User u)
        {
            this.User = u;
            InitializeComponent();
        }

        private void FormImprExamenBG_Load(object sender, EventArgs e)
        {
            ReportExamenBio cr = new ReportExamenBio();
            cr.SetParameterValue("@idConsultation", User.Cabinet.CurrentConsultation.IdConsultation);
            crystalReportViewer1.ReportSource = cr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
