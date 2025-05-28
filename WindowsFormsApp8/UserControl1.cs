using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        public void LoadData(partnerDataSet.partnerRow partnerRow)
        {
            label1.Text = $"{partnerRow.OrgType} | {partnerRow.DirectorName}";
            label3.Text = partnerRow.Phone;
            label4.Text = partnerRow.Email;
            if (partnerRow.TotalSales >= 300000)
            {
                label2.Text = "15%";
            }
            if (partnerRow.TotalSales > 50000 && partnerRow.TotalSales < 300000)
            {
                label2.Text = "10%";
            }
            if (partnerRow.TotalSales <= 50000)
            {
                label2.Text = "5%";
            }
            else label2.Text = "0%";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
