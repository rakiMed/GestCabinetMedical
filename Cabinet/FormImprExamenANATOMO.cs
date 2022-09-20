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
    public partial class FormImprExamenANATOMO : Form
    {
        User user;
        public FormImprExamenANATOMO(User u)
        {
            user = u;
            InitializeComponent();
        }

        private void FormImprExamenANATOMO_Load(object sender, EventArgs e)
        {
            ReportExamenANATOMO cr = new ReportExamenANATOMO();
            cr.SetParameterValue("@idConsultation", user.Cabinet.CurrentConsultation.IdConsultation);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
