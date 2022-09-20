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
    public partial class FormOrdonance : Form
    {
        User user;
        public FormOrdonance(User u)
        {
            this.user = u;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormOrdonance_Load(object sender, EventArgs e)
        {


            ReportOrdonnancee cr = new ReportOrdonnancee();
            cr.SetParameterValue("@idConsultation", user.Cabinet.CurrentConsultation.IdConsultation);
            crystalReportViewer1.ReportSource = cr;
          
            
        }
    }
}
