using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Designed by Liya Cao, Student# : 300930050.
 * Last Date Modified : 2019/07/26
 * Description : This is a calculator used for calculating body mass index (BMI) by entering you height and weight.
 * Revision 1 : GUI created.
 * Revision 2 : main function completed.
 * Revision 3 : Add keyboard from 0-9 for user input.
 */
namespace WindowsFormsApp1
{
    public partial class BMICalculatorForm : Form
    {
        private string selectedInut = "";
        public BMICalculatorForm()
        {
            InitializeComponent();
            this.heightUnit.Text = "inches";
            this.weightUnit.Text = "pounds";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Myheighttextbox_TextChanged(object sender, EventArgs e)
        {
            if((this.myheighttextbox.Text != null) && (this.myheighttextbox.Text.Length > 0))
            {
                bool isNumeric = int.TryParse(this.myheighttextbox.Text, out int n);
                if (!isNumeric)
                {
                    MessageBox.Show("Please enter a number.");
                }
            }
            
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text = "";
            this.myWeightTextbox.Text = "";
            this.myheighttextbox.Text = "";
            this.radioButtonImperial.Checked = false;
            this.radioButtonMetric.Checked = false;
        }

        private void RadioButtonImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonImperial.Checked)
            {
                this.radioButtonMetric.Checked = false;
                this.heightUnit.Text = "inches";
                this.weightUnit.Text = "pounds";
            }
        }

        private void RadioButtonMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonMetric.Checked)
            {
                this.radioButtonImperial.Checked = false;
                this.heightUnit.Text = "cm";
                this.weightUnit.Text = "kg";
            }
        }

        private void MyWeightTextbox_TextChanged(object sender, EventArgs e)
        {
            if ((this.myWeightTextbox.Text != null) && (this.myWeightTextbox.Text.Length > 0))
            {
                bool isNumeric = int.TryParse(this.myWeightTextbox.Text, out int n);
                if (!isNumeric)
                {
                    MessageBox.Show("Please enter a number.");
                }
            }
               
        }

        private void Sevenbutton_Click(object sender, EventArgs e)
        {
            if (this.selectedInut.Equals("height"))
            {
                this.myheighttextbox.Text += "7";
                this.myheighttextbox.Focus();
            }
            else if (this.selectedInut.Equals("weight"))
            {
                this.myWeightTextbox.Text += "7";
                this.myWeightTextbox.Focus();
            }
        }

        private void Eightbutton_Click(object sender, EventArgs e)
        {
            if (this.selectedInut.Equals("height"))
            {
                this.myheighttextbox.Text += "8";
                this.myheighttextbox.Focus();
            }
            else if (this.selectedInut.Equals("weight"))
            {
                this.myWeightTextbox.Text += "8";
                this.myWeightTextbox.Focus();
            }
        }

        private void Ninebutton_Click(object sender, EventArgs e)
        {
            if (this.selectedInut.Equals("height"))
            {
                this.myheighttextbox.Text += "9";
                this.myheighttextbox.Focus();
            }
            else if (this.selectedInut.Equals("weight"))
            {
                this.myWeightTextbox.Text += "9";
                this.myWeightTextbox.Focus();
            }
        }

        private void Fourbutton_Click(object sender, EventArgs e)
        {
            if (this.selectedInut.Equals("height"))
            {
                this.myheighttextbox.Text += "4";
                this.myheighttextbox.Focus();
            }
            else if (this.selectedInut.Equals("weight"))
            {
                this.myWeightTextbox.Text += "4";
                this.myWeightTextbox.Focus();
            }
        }

        private void Fivebutton_Click(object sender, EventArgs e)
        {
            if (this.selectedInut.Equals("height"))
            {
                this.myheighttextbox.Text += "5";
                this.myheighttextbox.Focus();
            }
            else if (this.selectedInut.Equals("weight"))
            {
                this.myWeightTextbox.Text += "5";
                this.myWeightTextbox.Focus();
            }
        }

        private void Sixbutton_Click(object sender, EventArgs e)
        {
            if (this.selectedInut.Equals("height"))
            {
                this.myheighttextbox.Text += "6";
                this.myheighttextbox.Focus();
            }
            else if (this.selectedInut.Equals("weight"))
            {
                this.myWeightTextbox.Text += "6";
                this.myWeightTextbox.Focus();
            }
        }

        private void Onebutton_Click(object sender, EventArgs e)
        {
            if (this.selectedInut.Equals("height"))
            {
                this.myheighttextbox.Text += "1";
                this.myheighttextbox.Focus();
            }
            else if (this.selectedInut.Equals("weight"))
            {
                this.myWeightTextbox.Text += "1";
                this.myWeightTextbox.Focus();
            }
        }

        private void Twobutton_Click(object sender, EventArgs e)
        {
            if (this.selectedInut.Equals("height"))
            {
                this.myheighttextbox.Text += "2";
                this.myheighttextbox.Focus();
            }
            else if (this.selectedInut.Equals("weight"))
            {
                this.myWeightTextbox.Text += "2";
                this.myWeightTextbox.Focus();
            }
        }

        private void Threebutton_Click(object sender, EventArgs e)
        {
            if (this.selectedInut.Equals("height"))
            {
                this.myheighttextbox.Text += "3";
                this.myheighttextbox.Focus();
            }
            else if (this.selectedInut.Equals("weight"))
            {
                this.myWeightTextbox.Text += "3";
                this.myWeightTextbox.Focus();
            }
        }

        private void Zerobutton_Click(object sender, EventArgs e)
        {
            if (this.selectedInut.Equals("height"))
            {
                this.myheighttextbox.Text += "0";
                this.myheighttextbox.Focus();
            }
            else if (this.selectedInut.Equals("weight"))
            {
                this.myWeightTextbox.Text += "0";
                this.myWeightTextbox.Focus();
            }
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(this.myheighttextbox.Text, out int n);
            bool isNumeric2 = int.TryParse(this.myWeightTextbox.Text, out int n2);
            if(isNumeric && isNumeric2)
            {
                if (radioButtonImperial.Checked)
                {
                    double bmi = Convert.ToDouble(this.myWeightTextbox.Text) / Convert.ToDouble(Convert.ToDouble(this.myheighttextbox.Text) * Convert.ToDouble(this.myheighttextbox.Text)) * 703;
                    if (bmi >= 30)
                    {
                        this.resultTextBox.Text = "BMI : " + bmi.ToString("0.0") + "; Obesity";
                    }
                    else if (bmi >= 25)
                    {
                        this.resultTextBox.Text = "BMI : " + bmi.ToString("0.0") + "; Overweight";
                    }
                    else if (bmi >= 18.5)
                    {
                        this.resultTextBox.Text = "BMI : " + bmi.ToString("0.0") + "; Normal weight";
                    }
                    else
                    {
                        this.resultTextBox.Text = "BMI : " + bmi.ToString("0.0") + "; Underweight";
                    }
                }
                else
                {
                    double bmi = Convert.ToDouble(this.myWeightTextbox.Text) / Convert.ToDouble(Convert.ToDouble(this.myheighttextbox.Text) / 100 * Convert.ToDouble(this.myheighttextbox.Text) / 100);
                    if (bmi >= 30)
                    {
                        this.resultTextBox.Text = "BMI : " + bmi.ToString("0.0") + "; Obesity";
                    }
                    else if (bmi >= 25)
                    {
                        this.resultTextBox.Text = "BMI : " + bmi.ToString("0.0") + "; Overweight";
                    }
                    else if (bmi >= 18.5)
                    {
                        this.resultTextBox.Text = "BMI : " + bmi.ToString("0.0") + "; Normal weight";
                    }
                    else
                    {
                        this.resultTextBox.Text = "BMI : " + bmi.ToString("0.0") + "; Underweight";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.");
            }
            
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void Myheighttextbox_Click(object sender, EventArgs e)
        {
            this.selectedInut = "height";
        }

        private void Myheighttextbox_Click(object sender, MouseEventArgs e)
        {
            this.selectedInut = "height";
        }

        private void Myheighttextbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.selectedInut = "height";
        }

        private void Myheighttextbox_DoubleClick(object sender, EventArgs e)
        {
            this.selectedInut = "height";
        }

        private void MyWeightTextbox_Click(object sender, EventArgs e)
        {
            this.selectedInut = "weight";
        }

        private void MyWeightTextbox_DoubleClick(object sender, EventArgs e)
        {
            this.selectedInut = "weight";
        }

        private void MyWeightTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            this.selectedInut = "weight";
        }

        private void MyWeightTextbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.selectedInut = "weight";
        }
    }
}
