using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МИЖОРО
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8))
                e.KeyChar = (char)0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8))
                e.KeyChar = (char)0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int xn = int.Parse(textBox1.Text);//численность
            double a = double.Parse(textBox2.Text);//кофф роста
            int c = int.Parse(textBox3.Text);//отлов
            int count = (int.Parse(textBox4.Text))+1;//длительность
            double b = double.Parse(textBox8.Text);//коэфициент перенаселённости

            int startXN = xn;

            double[] x = new double[count];
            double[] y = new double[count];

            int index = 0;

            for (int i = 0; i < count; i++)
            {
                
                if (xn <= 0)
                {
                    y[i] = 0;
                    x[i] = 5 * index;
                }
                else
                {
                    x[i] = 0 + 5 * i;
                    y[i] = xn;
                    xn = (int)((a - xn * b) * xn - c);
                    index++;
                }                
            }

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = int.Parse(textBox4.Text);
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 5;
            chart1.Series[0].Points.DataBindXY(x, y);
            
            if (xn <= 0)
            {
                Form f2 = new Form2();
                f2.Show();
                textBox6.Text = 0.ToString();
                textBox7.Text = (-startXN).ToString();
            }
            else
            {
                textBox6.Text = xn.ToString();
                textBox7.Text = (xn - startXN).ToString();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8))
                e.KeyChar = (char)0;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.KeyChar = (char)0;
            }

            if (e.KeyChar == '-' && ((sender as TextBox).Text.IndexOf('-') > -1 || (sender as TextBox).SelectionStart != 0))
            {
                e.KeyChar = (char)0;
            }

            if (e.KeyChar == ',' && ((sender as TextBox).Text.IndexOf(',') > -1 || (sender as TextBox).SelectionStart == 0))
            {
                e.KeyChar = (char)0;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&& e.KeyChar != ',' && e.KeyChar!='-')
            {
                e.KeyChar = (char)0;
            }

            if (e.KeyChar == '-' && ((sender as TextBox).Text.IndexOf('-')> -1 || (sender as TextBox).SelectionStart != 0))
            { 
                e.KeyChar = (char)0; 
            }

            if (e.KeyChar == ',' && ((sender as TextBox).Text.IndexOf(',') > -1 || (sender as TextBox).SelectionStart == 0))
            {
                e.KeyChar = (char)0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
