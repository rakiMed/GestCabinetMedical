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
    public partial class FormImprExamenRD : Form
    {
        User user;
        public FormImprExamenRD(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void FormImprExamenRD_Load(object sender, EventArgs e)
        {
            ReportExamenRadio cr = new ReportExamenRadio();
            cr.SetParameterValue("@id_Consultation", user.Cabinet.CurrentConsultation.IdConsultation);
            crystalReportViewer1.ReportSource = cr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
