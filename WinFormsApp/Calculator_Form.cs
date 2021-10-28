using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Calculator_Form : Form
    {
        double ms = 0;
        public Calculator_Form()
        {
            InitializeComponent();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            inputBox.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inputBox.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            inputBox.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            inputBox.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            inputBox.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            inputBox.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            inputBox.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            inputBox.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            inputBox.Text += "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            inputBox.Text += "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            inputBox.Text += ".";
        }

        //private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        //       (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void btnPlus_Click(object sender, EventArgs e)
        {
            inputBox.Text += "+";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                char[] array = inputBox.Text.ToCharArray();
                var arrayNumber = new List<string>();
                var arrayNumber2 = new List<string>();
                double finalScore = 0;
                double finalScore2 = 0;
                var opIndex = 0;
                string operation = "";
                string root = "";
                string reciprocal = "";
                string percent = "";
                double result = 0;
                var opCount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (int.TryParse($"{array[i]}", out var _) || array[i].Equals('.') || array[i].Equals('√') || array[i].Equals('r') || array[i].Equals('%'))

                    {
                        arrayNumber.Add($"{array[i]}");
                    }

                    else
                    {
                        opIndex = i;
                        break;
                    }
                }

                for (int i = opIndex; i < array.Length; i++)
                {
                    if (array[i].Equals('+'))
                    {
                        operation = "+";
                        opCount++;
                    }

                    if (array[i].Equals('-'))
                    {
                        operation = "-";
                        opCount++;
                    }

                    if (array[i].Equals('*'))
                    {
                        operation = "*";
                        opCount++;
                    }

                    if (array[i].Equals('/'))
                    {
                        operation = "/";
                        opCount++;
                    }

                    if (decimal.TryParse($"{array[i]}", out var _) || array[i].Equals('.') || array[i].Equals('√') || array[i].Equals('r') || array[i].Equals('%'))

                    {
                        arrayNumber2.Add($"{array[i]}");
                    }
                }
                if (opCount > 1)
                {
                    MessageBox.Show("Only one operation per input is allowed.");
                    inputBox.Text = null;
                    return;
                }

                for (int i = 0; i < arrayNumber.Count; i++)
                {
                    if (arrayNumber[i].Equals("√"))
                    {
                        root = "1√";
                        arrayNumber.RemoveAt(i);
                    }

                    if (arrayNumber[i].Equals("r"))
                    {
                        reciprocal = "1r";
                        arrayNumber.RemoveAt(i);
                    }

                    if (arrayNumber[i].Equals("%"))
                    {
                        percent = "1%";
                        arrayNumber.RemoveAt(i);
                    }
                }
            finalScore = double.Parse(String.Join("", arrayNumber.ToArray()));

            if (operation == "" && root == "1√")
            {
                result = Math.Sqrt(finalScore);
                inputBox.Text = result.ToString();
                return;
            }

            if (operation == "" && reciprocal == "1r")
            {
                result = (1 / finalScore);
                inputBox.Text = result.ToString();
                return;
            }

            if (operation == "" && percent == "1%")
            {
                result = finalScore/100;
                inputBox.Text = result.ToString();
                return;
            }

            if (root == "1√")
            {
                finalScore = Math.Sqrt(finalScore);
            }

            if (reciprocal == "1r")
            {
                finalScore = (1 / finalScore);
            }

            if (percent == "1%")
            {
                finalScore = (finalScore / 100);
            }


            for (int i = 0; i < arrayNumber2.Count; i++)
            {
                if (arrayNumber2[i].Equals("√"))
                {
                    root = "2√";
                    arrayNumber2.RemoveAt(i);
                }

                if (arrayNumber2[i].Equals("r"))
                {
                    reciprocal = "2r";
                    arrayNumber2.RemoveAt(i);
                }

                if (arrayNumber2[i].Equals("%"))
                {
                    percent = "2%";
                    arrayNumber2.RemoveAt(i);
                }
            }
            finalScore2 = double.Parse(String.Join("", arrayNumber2.ToArray()));


            if (root == "2√")
            {
                finalScore2 = Math.Sqrt(finalScore2);
            }

            if (reciprocal == "2r")
            {
                finalScore2 = (1 / finalScore2);
            }

            if (percent == "2%")
            {
                finalScore2 = finalScore * (finalScore2 / 100);
            }

            if (operation == "+")
            {
                result = finalScore + finalScore2;
            }

            if (operation == "-")
            {
                result = finalScore - finalScore2;
            }

            if (operation == "*")
            {
                result = finalScore * finalScore2;
            }

            if (operation == "/")
            {
                result = finalScore / finalScore2;
            }


            inputBox.Text = result.ToString();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                inputBox.Text = null;
            }
}

        private void btnC_Click(object sender, EventArgs e)
        {
            inputBox.Text = null;
        }

        private void btnSubtr_Click(object sender, EventArgs e)
        {
            inputBox.Text += "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            inputBox.Text += "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            inputBox.Text += "/";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            char[] array = inputBox.Text.ToCharArray();
            var arrayNumber = new List<string>();
            string finalScore = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse($"{array[i]}", out var _) || array[i].Equals('.'))
                {
                    arrayNumber.Add($"{array[i]}");
                }

                else
                {
                    break;
                }
            }

            for (int i = 0; i < arrayNumber.Count; i++)
            {
                finalScore = String.Join("", arrayNumber.ToArray());
                inputBox.Text = finalScore;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var array = inputBox.Text.ToCharArray();
            var list = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add($"{array[i]}");
            }
            list.RemoveAt(list.Count-1);
            inputBox.Text = null;

            for (int i = 0; i < list.Count; i++)
            {
                inputBox.Text += list[i]; 
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            inputBox.Text += "√";
        }

        private void btn1X_Click(object sender, EventArgs e)
        {
            inputBox.Text += "r";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            inputBox.Text += "%";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            inputBox.Text += "±";
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            char[] array = inputBox.Text.ToCharArray();
            var arrayNumber = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse($"{array[i]}", out var _) || array[i].Equals('.'))

                {
                    arrayNumber.Add($"{array[i]}");
                }

                else
                {
                    MessageBox.Show("Memory Store should be applied without operation symbols in input");
                    break;
                }
            }

            ms = double.Parse(String.Join("", arrayNumber.ToArray()));
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            inputBox.Text += ms;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            ms = 0;
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            char[] array = inputBox.Text.ToCharArray();
            var arrayNumber = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse($"{array[i]}", out var _) || array[i].Equals('.'))

                {
                    arrayNumber.Add($"{array[i]}");
                }

                else
                {
                    MessageBox.Show("Memory + should be applied without operation symbols in input");
                    break;
                }
            }

            ms += double.Parse(String.Join("", arrayNumber.ToArray()));
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {
            char[] array = inputBox.Text.ToCharArray();
            var arrayNumber = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse($"{array[i]}", out var _) || array[i].Equals('.'))

                {
                    arrayNumber.Add($"{array[i]}");
                }

                else
                {
                    MessageBox.Show("Memory + should be applied without operation symbols in input");
                    break;
                }
            }

            ms -= double.Parse(String.Join("", arrayNumber.ToArray()));
        }
    }
    
}
