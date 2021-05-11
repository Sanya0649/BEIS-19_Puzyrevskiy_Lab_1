using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEIS_19_Puzyrevskiy_Lab_1
{
    public partial class LB1 : Form
    {
        public LB1()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Read1.Text);
            double b = Convert.ToDouble(Read2.Text);
            Output.Text = Convert.ToString(a + b);
            Oper.Text = "Сложение";
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Read1.Text);
            double b = Convert.ToDouble(Read2.Text);
            Output.Text = Convert.ToString(a - b);
            Oper.Text = "Вычитание";
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Read1.Text);
            double b = Convert.ToDouble(Read2.Text);
            Output.Text = Convert.ToString(a * b);
            Oper.Text = "Умножение";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Read1.Text);
            double b = Convert.ToDouble(Read2.Text);
            Output.Text = Convert.ToString(a / b);
            Oper.Text = "Деление";
        }
    }
}
