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
    public partial class FormImprExamenENDO : Form
    {
        User user;
        public FormImprExamenENDO(User u)
        {
            this.user = u;
            InitializeComponent();
        }

        private void FormImprExamenENDO_Load(object sender, EventArgs e)
        {
            ReportExamenEndo cr = new ReportExamenEndo();
            cr.SetParameterValue("@idConsultation", user.Cabinet.CurrentConsultation.IdConsultation);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
