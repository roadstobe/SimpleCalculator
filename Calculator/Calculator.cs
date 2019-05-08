using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        static List<string> outPut = new List<string>();
        public Calculator()
        {
            InitializeComponent();
            outPut.Add("");
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (sender as Button);
            switch (b.Text)
            {
                case ",":
                    {
                        outPut[outPut.Count - 1] += ",";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "0":
                    {
                        outPut[outPut.Count - 1] += ",";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "1":
                    {
                        outPut[outPut.Count - 1] += "1";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "2":
                    {
                        outPut[outPut.Count - 1] += "2";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "3":
                    {
                        outPut[outPut.Count - 1] += "3";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "4":
                    {
                        outPut[outPut.Count - 1] += "4";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "5":
                    {
                        outPut[outPut.Count - 1] += "5";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "6":
                    {
                        outPut[outPut.Count - 1] += "6";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "7":
                    {
                        outPut[outPut.Count - 1] += "7";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "8":
                    {
                        outPut[outPut.Count - 1] += "8";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "9":
                    {
                        outPut[outPut.Count - 1] += "9";
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        break;
                    }
                case "+":
                    {
                        outPut.Add("+");
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        outPut.Add("");
                        break;
                    }
                case "-":
                    {
                        outPut.Add("-");
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        outPut.Add("");
                        break;
                    }
                case "*":
                    {
                        outPut.Add("*");
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        outPut.Add("");
                        break;
                    }
                case "/":
                     {
                        outPut.Add("/");
                        textBoxOutPut.Text = outPut[outPut.Count - 1];
                        outPut.Add("");
                        break;
                    }
                case "=":
                    {
                        if(outPut.Count >= 2)
                        {
                            List<double> count = new List<double>();
                            textBoxOutPut.Text = "=";
                            double result = 0;
                            double tmp = 0;
                            for (int i = 0; i < outPut.Count; i++)
                            {
                                if (double.TryParse(outPut[i], out tmp))
                                {
                                    count.Add(tmp);
                                }
                            }
                            int j = 0;
                            for (int i = 0; i < outPut.Count; i++)
                            {
                                if (outPut[i] == "+")
                                {
                                    if (j < count.Count - 1 && count.Count > 2)
                                    {
                                        j++;
                                        result = tmp + count[j];
                                        j++;
                                    }
                                    else if (j < count.Count - 1)
                                    {
                                        j++;
                                        result = tmp + count[j];
                                    }
                                    else
                                    {
                                        result += tmp;
                                    }
                                }
                                else if (outPut[i] == "-")
                                {
                                    if (j < count.Count - 1 && count.Count > 2)
                                    {
                                        j++;
                                        result = tmp - count[j];
                                        j++;
                                    }
                                    else if (j < count.Count - 1)
                                    {
                                        j++;
                                        result = tmp - count[j];
                                    }
                                    else
                                    {
                                        result -= tmp;
                                    }
                                }
                                else if (outPut[i] == "*")
                                {
                                    if (j < count.Count - 1 && count.Count > 2)
                                    {
                                        j++;
                                        result = tmp * count[j];
                                        j++;
                                    }
                                    else if (j < count.Count - 1)
                                    {
                                        j++;
                                        result = tmp * count[j];
                                    }
                                    else
                                    {
                                        result *= tmp;
                                    }
                                }
                                else if (outPut[i] == "/")
                                {
                                    if (j < count.Count - 1 && count.Count > 2)
                                    {
                                        j++;
                                        result = tmp / count[j];
                                        j++;
                                    }
                                    else if (j < count.Count - 1)
                                    {
                                        j++;
                                        result = tmp / count[j];
                                    }
                                    else
                                    {
                                        result /= tmp;
                                    }
                                }
                                else
                                {
                                    tmp = count[j];
                                }
                            }
                            textBoxOutPut.Text = result.ToString();
                            outPut.Clear();
                            outPut.Add("");
                        }
                        break;
                    }
                case "<-":
                    {
                        string temp = outPut[outPut.Count - 1];
                        if (temp.Length > 0)
                        {
                            char[] ch = new char[temp.Length - 1];
                            for (int i = 0; i < temp.Length - 1; i++)
                            {
                                ch[i] = temp[i];
                            }
                            temp = new string(ch);
                            outPut[outPut.Count - 1] = temp;
                            textBoxOutPut.Text = outPut[outPut.Count - 1];
                        }
                        break;
                    }
                case "Clear":
                    {
                        outPut.Clear();
                        textBoxOutPut.Text = "";
                        outPut.Add("");
                        break;
                    }
            }
        }


        private void Write(object sender, KeyEventArgs e)
        {
            Button b = (sender as Button);
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        if (outPut.Count >= 2)
                        {
                            List<double> count = new List<double>();
                            textBoxOutPut.Text = "=";
                            double result = 0;
                            double tmp = 0;
                            for (int i = 0; i < outPut.Count; i++)
                            {
                                if (double.TryParse(outPut[i], out tmp))
                                {
                                    count.Add(tmp);
                                }
                            }
                            int j = 0;
                            for (int i = 0; i < outPut.Count; i++)
                            {
                                if (outPut[i] == "+")
                                {
                                    if (j < count.Count - 1 && count.Count > 2)
                                    {
                                        j++;
                                        result = tmp + count[j];
                                        j++;
                                    }
                                    else if (j < count.Count - 1)
                                    {
                                        j++;
                                        result = tmp + count[j];
                                    }
                                    else
                                    {
                                        result += tmp;
                                    }
                                }
                                else if (outPut[i] == "-")
                                {
                                    if (j < count.Count - 1 && count.Count > 2)
                                    {
                                        j++;
                                        result = tmp - count[j];
                                        j++;
                                    }
                                    else if (j < count.Count - 1)
                                    {
                                        j++;
                                        result = tmp - count[j];
                                    }
                                    else
                                    {
                                        result -= tmp;
                                    }
                                }
                                else if (outPut[i] == "*")
                                {
                                    if (j < count.Count - 1 && count.Count > 2)
                                    {
                                        j++;
                                        result = tmp * count[j];
                                        j++;
                                    }
                                    else if (j < count.Count - 1)
                                    {
                                        j++;
                                        result = tmp * count[j];
                                    }
                                    else
                                    {
                                        result *= tmp;
                                    }
                                }
                                else if (outPut[i] == "/")
                                {
                                    if (j < count.Count - 1 && count.Count > 2)
                                    {
                                        j++;
                                        result = tmp / count[j];
                                        j++;
                                    }
                                    else if (j < count.Count - 1)
                                    {
                                        j++;
                                        result = tmp / count[j];
                                    }
                                    else
                                    {
                                        result /= tmp;
                                    }
                                }
                                else
                                {
                                    tmp = count[j];
                                }
                            }
                            textBoxOutPut.Text = result.ToString();
                            outPut.Clear();
                            outPut.Add("");
                        }
                        break;
                    }
            }
        }
    }
}
