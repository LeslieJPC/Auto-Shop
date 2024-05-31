using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4AutoShop
{
    public partial class Form1 : Form
    //Coded By Leslie#####
    {
        public Form1()
        {
            InitializeComponent();
        }
        const decimal OilChange = 26.00m;
        const decimal Mixed = 10.00m;
        const decimal FullSynthetic = 20.00m;
        const decimal LubeJob = 18.00m;
        const decimal FullService = 6.00m;
        const decimal Premium = 9.00m;
        const decimal RadiatorFlush = 30.00m;
        const decimal TransmissionFlush = 80.00m;
        const decimal Inspection = 15.00m;
        const decimal ReplaceMuffler = 100.00m;
        const decimal TireRotation = 20.00m;
        const decimal taxrate = .06m;
        decimal serviceslabor;
        decimal parts;
        decimal finaltax;
        decimal fees;
        private decimal total = 0m;
        private void button1_Click(object sender, EventArgs e)
        //Code for Calculate button
        {
            serviceslabor = decimal.Parse(textBox2.Text) + total;
            parts = decimal.Parse(textBox1.Text);
            finaltax = taxrate * parts;
            MessageBox.Show("Calculating Your Total. Please Press the Ok Button Below.");
            fees = parts + finaltax + serviceslabor;
            textBox4.Text = parts.ToString("n2");
            textBox3.Text = serviceslabor.ToString("n2");
            textBox5.Text = finaltax.ToString("n2");
            textBox6.Text = fees.ToString("n2");
            GetInput(GetTextBox1());
            GetInput(GetTextBox2());
        }

        private TextBox GetTextBox1()
        {
            return textBox1;
        }

        private void GetInput(TextBox textBox1)
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Please input service and labor hours.");
            }
            catch (Exception)
            {

                throw;
            }
        }
        private TextBox GetTextBox2()
        {
            return textBox2;
        }

        private void button2_Click(object sender, EventArgs e)
            //Code for the clear button
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
            //code for the Exit Button
        {
            MessageBox.Show("We Appreciate Your Business. Have a great rest of your day!");
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            total += OilChange;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            total += Mixed;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            total += FullSynthetic;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            total += LubeJob;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            total += FullService;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            total += Premium;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            total += RadiatorFlush;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            total += TransmissionFlush;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            total += Inspection;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            total += ReplaceMuffler;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            total += TireRotation;
        }
    }
}
