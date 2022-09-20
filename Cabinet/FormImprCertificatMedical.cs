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
    public partial class FormImprCertificatMedical : Form
    {
        public FormImprCertificatMedical()
        {
            InitializeComponent();
        }

        private void FormImprCertificatMedical_Load(object sender, EventArgs e)
        {
            try
            {

                switch (FormMedcin.TypeOfCertificat)
                {

                    case "withdate":
                        ReportCertificatMedical cr = new ReportCertificatMedical();
                        crystalReportViewer1.ReportSource = cr;
                        break;

                    case "withoutdate":
                        ReportCertificatMedicalSansDate cr2 = new ReportCertificatMedicalSansDate();
                        crystalReportViewer1.ReportSource = cr2;
                        break;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
