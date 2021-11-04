using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cointer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalCentsNumber = (int)cents1.Value + 
                (int)cents2.Value * 2 +
                (int)cents5.Value * 5 +
                (int)cents10.Value * 10 +
                (int)cents10.Value * 20 +
                (int)cents10.Value * 50 +
                (int)eur1.Value * 100 +
                (int)eur2.Value * 200 +
                (int)eur5.Value * 500 +
                (int)eur10.Value * 1000 +
                (int)eur20.Value * 2000 +
                (int)eur50.Value * 5000 +
                (int)eur100.Value * 10000 +
                (int)eur200.Value * 20000 +
                (int)eur500.Value * 50000;

            result.Text = "You have the incredible quantity of... " + (float)totalCentsNumber / 100.0f + " euros!";
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            cents1.Value = 0;
            cents2.Value = 0;
            cents5.Value = 0;
            cents10.Value = 0;
            cents20.Value = 0;
            cents50.Value = 0;
            eur1.Value = 0;
            eur2.Value = 0;
            eur5.Value = 0;
            eur10.Value = 0;
            eur20.Value = 0;
            eur50.Value = 0;
            eur100.Value = 0;
            eur200.Value = 0;
            eur500.Value = 0;
        }
    }
}
