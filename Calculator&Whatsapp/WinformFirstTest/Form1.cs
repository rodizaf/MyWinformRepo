using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformFirstTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GetNumAaB(out double a ,out double b)
        {
             a = Convert.ToInt32(firstNameTextBox.Text);
             b = Convert.ToInt32(secondNumberTextBox.Text);
            Debug.WriteLine($"Numbers from text box a = {a} = {b}");
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            double a, b;
            GetNumAaB(out a, out b);
         
            double c = a + b;
            resultLabel.Text = $"Result = {c}";
        }

        private void multipleBtn_Click(object sender, EventArgs e)
        {
            double a, b;
            GetNumAaB(out a, out b);

            double c = a * b;
            resultLabel.Text = $"Result = {c}";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            double a, b;
            GetNumAaB(out a, out b);

            double c = a - b;
            resultLabel.Text = $"Result = {c}";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {


           
                double a, b;
                GetNumAaB(out a, out b);

                double c = a / b;
                resultLabel.Text = $"Result = {c}";
            
            
            

                Console.WriteLine(e);
            
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
