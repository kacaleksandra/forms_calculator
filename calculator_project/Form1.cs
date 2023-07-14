using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace calculator_project
{
    public partial class Form1 : Form
    {
        private string tempNumber = "";
        private double? chosenNumber = null;
        private string tempOperation = "";
        private string chosenOperation = "";
        //wykrywanie etapu obliczeń
        private bool flag = false;
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_GotFocus(object sender, MouseEventArgs e)
        {
            HideCaret(textBox1.Handle);
        }

        private int ResolveLength(double? value)
        {
            if(value == null) return 0;

            var x = ((int)value).ToString("F0");
            return x.Length;
        }
        private string printNumbers(double? uniqueNumber)
        {
            if(uniqueNumber == 0)
            {
                return "0";
            }

            var l = ResolveLength(uniqueNumber);
            var sb = new StringBuilder();
            var size = 11 - l;
            size = size < 0 ? 0 : size;
            for (var i = 0; i < size; i++) sb.Append('#');

            int precision = 7;

            if (Math.Abs(uniqueNumber ?? 0) > Math.Pow(10, precision) || Math.Abs(uniqueNumber ?? 0) < Math.Pow(0.1, precision))
            {
                //var z = uniqueNumber?.ToString($"F0");
                //var z2 = uniqueNumber?.ToString($"E99");
                //var factor = z.Length - 1;
                //var x = uniqueNumber / Math.Pow(10, factor);
                //var vv = uniqueNumber?.ToString($"E99");
                //var zz = $"{vv.Substring(0, z.Length > precision ? precision : vv.Length)}E+{factor}";
                //return zz;
                //return uniqueNumber?.ToString($"0.{sb}E+0");
                var xx = uniqueNumber?.ToString($"0.{sb}E+0");
                return uniqueNumber?.ToString($"0.{sb}E+0");
            }
            else
            {
                return uniqueNumber?.ToString($"0.{sb}");
            }
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (flag == true)
            {
                textBox1.Text = "";
            }
            flag = false;
            if(tempNumber.Length >= 13)
            {
                errorProvider1.SetError(textBox1, "Za dużo znaków!");
            }
            else if(tempNumber == "0")
            {
                if ((sender as Button).Text != "0")
                {
                    tempNumber = (sender as Button).Text;
                    textBox1.Text = tempNumber;
                }
                else
                {
                    errorProvider1.SetError(textBox1, "Niepoprawny zapis");
                }
            }
            else 
            {
                tempNumber += (sender as Button).Text;
                textBox1.Text = tempNumber;
            }

        }

        private double? CalculateResult(string chosenOperation, double? chosenNumber)
        {
            if (textBox1.Text == "") return null;
            if(!double.TryParse(tempNumber, out double result))
            {
                return chosenNumber;
            }
            switch (chosenOperation)
            {
                case "+":
                    chosenNumber = chosenNumber + result;
                    break;
                case "-":
                    chosenNumber = chosenNumber - result;
                    break;
                case "x":
                    chosenNumber = chosenNumber * result;
                    break;
                case "/":
                    if(result == 0)
                    {
                        errorProvider1.SetError(textBox1, "Nie można dzielić przez 0! Powrócono do wartości dzielonej.");
                    }
                    else
                    {
                        chosenNumber = chosenNumber / result;
                    }
                    break;
                default:
                    chosenNumber = result;
                    break;
            }


            if (Math.Abs((double)chosenNumber) == double.PositiveInfinity)
            {
                errorProvider1.SetError(textBox1, "Liczba poza zakresem");
                return result;
            }
            else
            {
                textBox1.Text = printNumbers(chosenNumber);
                return chosenNumber;
            }
        }


        
        private void operationButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            tempOperation = (sender as Button).Text;
            chosenNumber = CalculateResult(chosenOperation, chosenNumber);
            if(chosenNumber != null)
            {
                chosenOperation = tempOperation;
                if (flag != true && tempNumber != "")
                {
                    tempNumber = "";
                }
                flag = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void cleanTextArea(object sender, EventArgs e)
        {
            Cleanup();
            textBox1.Text = "";
        }

        private void changeSign(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double tempNumberD = double.Parse(textBox1.Text);
                tempNumberD *= -1;
       

                if (tempNumber == "")
                {
                    chosenNumber *= -1;
                } else
                {
                   // chosenNumber *= -1;
                   //if(tempNumber != "")
                    tempNumber = (double.Parse(tempNumber) * -1).ToString();
                }
                //else
                //{
                //    tempNumber = tempNumberD.ToString();
                //}
                textBox1.Text = tempNumberD.ToString();
            }
            }

            private void Cleanup()
        {
            tempNumber = "";
            chosenOperation = "";
            flag = true;
        }

        private void addSeparator_Click(object sender, EventArgs e)
        {
            string separator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            if (textBox1.Text == "" ||  flag)
            {
                tempNumber = "0" + separator;
                textBox1.Text = tempNumber;
            }
            else if(textBox1.Text.IndexOf(separator) >= 0)
            {
                errorProvider1.SetError(textBox1, "Niepoprawny zapis");
            }
            else
            {
                if(tempNumber == "")
                {
                    tempNumber = "0" + separator;
                    textBox1.Text = tempNumber;
                }
                else
                {
                    tempNumber += separator;
                    textBox1.Text = tempNumber;
                }
            }
        }


        private void Result(object sender, EventArgs e)
        {
             chosenNumber = CalculateResult(chosenOperation, chosenNumber);
             Cleanup();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
