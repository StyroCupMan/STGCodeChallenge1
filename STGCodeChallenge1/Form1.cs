using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STGCodeChallenge1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = SumDigitsInString(txtInput.Text).ToString();

        }

        private int SumDigitsInString(string s)
        {
            int sum = 0;
            foreach (char c in s)
            {
                int i = ((int)c - 48);
                sum += (i >= 0 && i <= 9 ? i : 0);
            }

            return sum;
        }
    }
}
