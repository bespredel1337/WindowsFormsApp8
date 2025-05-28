using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partnerDataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.partnerDataSet.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partnerDataSet.partner". При необходимости она может быть перемещена или удалена.
            this.partnerTableAdapter.Fill(this.partnerDataSet.partner);
            ForceUpdate();
        }

        public void ForceUpdate()
        {
            foreach (partnerDataSet.partnerRow partner in partnerDataSet.partner)
            {
                UserControl1 card = new UserControl1();
                card.LoadData(partner);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.partnerTableAdapter.Update(this.partnerDataSet.partner);
            this.productTableAdapter.Update(this.partnerDataSet.product);
            flowLayoutPanel1.Controls.Clear();
            ForceUpdate();
        }
    }
}
