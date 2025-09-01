using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class GeneratedReports : Form
    {
        public GeneratedReports()
        {
            InitializeComponent();
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            Reports_1 report = new Reports_1();
            report.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports_2 report = new Reports_2();
            report.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports_3 report = new Reports_3();
            report.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports_4 report = new Reports_4();
            report.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports_5 report = new Reports_5();
            report.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports_6 report = new Reports_6();
            report.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reports_7 report = new Reports_7();
            report.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reports_8 report = new Reports_8();
            report.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
