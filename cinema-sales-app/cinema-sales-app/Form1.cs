using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_sales_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        int cash = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int ticket, popcorn, tea, water, total;

            ticket = Convert.ToInt32(TxtTicket.Text);
            popcorn = Convert.ToInt32(TxtPopcorn.Text);

            tea = Convert.ToInt32(TxtTea.Text);
            water = Convert.ToInt32(TxtWater.Text);

            total = ticket * 80 + popcorn * 50 + tea * 20 + water * 5;
            LblTotal.Text = total.ToString() + " TL";


            cash = cash + total;
            LblCash.Text = cash.ToString() + " TL";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtPopcorn.Text = " ";
            TxtTea.Text = " ";
            TxtTicket.Text = " ";
            TxtWater.Text = " ";
            TxtTicket.Focus();
        }
    }
}
