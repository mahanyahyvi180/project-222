using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp91
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate double t(int x);
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            mydelegate t = new mydelegate(Factorial);
            listBox1.Items.Add(Factorial(x));
        }

        private double Factorial(int x)
        {
            double s = 1;
            for (int temp = x; temp >= 1; temp--)
                s = s * temp;

            return s;
        }
    }
}
