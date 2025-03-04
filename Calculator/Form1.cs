using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a=int.Parse(txt1.Text);
            b=int.Parse(txt2.Text);
            Caculation c = new Caculation(a,b);
            kq = c.Exectute("+");
            txtKQ.Text=kq.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            Caculation c = new Caculation(a, b);
            kq = c.Exectute("-");
            txtKQ.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            Caculation c = new Caculation(a, b);
            kq = c.Exectute("*");
            txtKQ.Text = kq.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
           if(b != 0)
            {
                Caculation c = new Caculation(a, b);
                kq = c.Exectute("/");
                txtKQ.Text = kq.ToString();
            }
            else
            {
                txtKQ.Text = "Loi chia cho 0!";
            }
        }
        private void btN_Click(object sender, EventArgs e)
        {
            int n; 
            double x, kq;
            n = int.Parse(txt2.Text);
            x = double.Parse(txt1.Text);
            kq = Caculation.Power(x, n);
            txtKQ.Text = kq.ToString();
        }

    }
}
