using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            sidePanel.Height = btnDashboard.Height;
            sidePanel.Top = btnDashboard.Top;
            firstCustomerControl1.BringToFront();
            /*btn_PReport.Enabled = false;
            btn_SReport.Enabled = false;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnDashboard.Height;
            sidePanel.Top = btnDashboard.Top;
            firstCustomerControl1.BringToFront();
/*          btn_PReport.Enabled = false;
            btn_SReport.Enabled = false;*/
        }

        private void btnEatin_Click(object sender, EventArgs e)
        {
            
            sidePanel.Height = btnStock.Height;
            sidePanel.Top = btnStock.Top;
            stock1.BringToFront();
            /*btn_PReport.Enabled = false;
            btn_SReport.Enabled = false;
            */
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            sidePanel.Height = btn_Report.Height;
            sidePanel.Top = btn_Report.Top;
           report1.BringToFront();
            /*btn_PReport.Enabled = true;
            btn_SReport.Enabled = true;*/
        }
        private void btn_PReport_Click(object sender, EventArgs e)
        {
            //productReport1.BringToFront();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timer1.Start();
            }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_PReport_Click_1(object sender, EventArgs e)
        {
            //PRepot pRepot = new PRepot();
          //  pRepot.Show();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_About.Height;
            sidePanel.Top = btn_About.Top;
            About about = new About();
            about.Show();
        }
    }
}
