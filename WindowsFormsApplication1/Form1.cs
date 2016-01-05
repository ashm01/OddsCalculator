using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Getting the odds from the two input text boxes
            try
            {
                if(decimalRadioButton.Checked)
                {
                    if (comboBox1.SelectedItem == "1")
                    {
                        double stake = double.Parse(stakeInput.Text);
                        double odd1 = double.Parse(line1Input.Text);
                        double result = stake * odd1;
                        label4.Text = result.ToString();

                    }
                    else if (comboBox1.SelectedItem == "2")
                    {
                        double stake = double.Parse(stakeInput.Text);
                        double odd1 = double.Parse(line1Input.Text);
                        double odd2 = double.Parse(line2Input.Text);
                        double result = stake * odd1 * odd2;
                        label4.Text = result.ToString();

                    }
                    else if (comboBox1.SelectedItem == "3")
                    {
                        double stake = double.Parse(stakeInput.Text);
                        double odd1 = double.Parse(line1Input.Text);
                        double odd2 = double.Parse(line2Input.Text);
                        double odd3 = double.Parse(line3Input.Text);
                        double result = stake * odd1 * odd2 * odd3;
                        label4.Text = result.ToString();

                    }
                    else if (comboBox1.SelectedItem == "4")
                    {

                        double stake = double.Parse(stakeInput.Text);
                        double odd1 = double.Parse(line1Input.Text);
                        double odd2 = double.Parse(line2Input.Text);
                        double odd3 = double.Parse(line3Input.Text);
                        double odd4 = double.Parse(line4Input.Text);
                        double result = stake * odd1 * odd2 * odd3 * odd4;
                        label4.Text = result.ToString();
                    }
                    else if (comboBox1.SelectedItem == "5")
                    {

                        double stake = double.Parse(stakeInput.Text);
                        double odd1 = double.Parse(line1Input.Text);
                        double odd2 = double.Parse(line2Input.Text);
                        double odd3 = double.Parse(line3Input.Text);
                        double odd4 = double.Parse(line4Input.Text);
                        double odd5 = double.Parse(line5Input.Text);
                        double result = stake * odd1 * odd2 * odd3 * odd4 * odd5;
                        label4.Text = result.ToString();
                    }
                    
                }else if(fractionRadioButton.Checked)
                {
                    if (comboBox1.SelectedItem == "1")
                    {
                        double stake = double.Parse(stakeInput.Text);
                        string odd1 = line1Input.Text;
                        string[] odd1split = Regex.Split(odd1, "/");
                        double decimalOdd1 = (double.Parse(odd1split[0]) / double.Parse(odd1split[1])) + 1;
                        double result = stake * decimalOdd1;
                        label4.Text = Math.Round(result, 2).ToString();

                    }
                    else if (comboBox1.SelectedItem == "2")
                    {
                        double stake = double.Parse(stakeInput.Text);
                        string odd1 = line1Input.Text;
                        string odd2 = line2Input.Text;
                        string[] odd1split = Regex.Split(odd1, "/");
                        string[] odd2split = Regex.Split(odd2, "/");
                        double decimalOdd1 = (double.Parse(odd1split[0]) / double.Parse(odd1split[1])) + 1;
                        double decimalOdd2 = (double.Parse(odd2split[0]) / double.Parse(odd2split[1])) + 1;
                        double result = stake * decimalOdd1 * decimalOdd2;
                        label4.Text = Math.Round(result, 2).ToString();

                    }
                    else if (comboBox1.SelectedItem == "3")
                    {
                        double stake = double.Parse(stakeInput.Text);
                        string odd1 = line1Input.Text;
                        string odd2 = line2Input.Text;
                        string odd3 = line3Input.Text;
                        string[] odd1split = Regex.Split(odd1, "/");
                        string[] odd2split = Regex.Split(odd2, "/");
                        string[] odd3split = Regex.Split(odd3, "/");
                        double decimalOdd1 = (double.Parse(odd1split[0]) / double.Parse(odd1split[1])) + 1;
                        double decimalOdd2 = (double.Parse(odd2split[0]) / double.Parse(odd2split[1])) + 1;
                        double decimalOdd3 = (double.Parse(odd3split[0]) / double.Parse(odd3split[1])) + 1;
                        double result = stake * decimalOdd1 * decimalOdd2 * decimalOdd3;
                        label4.Text = Math.Round(result, 2).ToString();

                    }
                    else if (comboBox1.SelectedItem == "4")
                    {
                        double stake = double.Parse(stakeInput.Text);
                        string odd1 = line1Input.Text;
                        string odd2 = line2Input.Text;
                        string odd3 = line3Input.Text;
                        string odd4 = line4Input.Text;
                        string[] odd1split = Regex.Split(odd1, "/");
                        string[] odd2split = Regex.Split(odd2, "/");
                        string[] odd3split = Regex.Split(odd3, "/");
                        string[] odd4split = Regex.Split(odd4, "/");
                        double decimalOdd1 = (double.Parse(odd1split[0]) / double.Parse(odd1split[1])) + 1;
                        double decimalOdd2 = (double.Parse(odd2split[0]) / double.Parse(odd2split[1])) + 1;
                        double decimalOdd3 = (double.Parse(odd3split[0]) / double.Parse(odd3split[1])) + 1;
                        double decimalOdd4 = (double.Parse(odd4split[0]) / double.Parse(odd4split[1])) + 1;
                        double result = stake * decimalOdd1 * decimalOdd2 * decimalOdd3 * decimalOdd4;
                        label4.Text = Math.Round(result, 2).ToString();

                    }
                    else if (comboBox1.SelectedItem == "5")
                    {
                        double stake = double.Parse(stakeInput.Text);
                        string odd1 = line1Input.Text;
                        string odd2 = line2Input.Text;
                        string odd3 = line3Input.Text;
                        string odd4 = line4Input.Text;
                        string odd5 = line5Input.Text;
                        string[] odd1split = Regex.Split(odd1, "/");
                        string[] odd2split = Regex.Split(odd2, "/");
                        string[] odd3split = Regex.Split(odd3, "/");
                        string[] odd4split = Regex.Split(odd4, "/");
                        string[] odd5split = Regex.Split(odd5, "/");
                        double decimalOdd1 = (double.Parse(odd1split[0]) / double.Parse(odd1split[1])) + 1;
                        double decimalOdd2 = (double.Parse(odd2split[0]) / double.Parse(odd2split[1])) + 1;
                        double decimalOdd3 = (double.Parse(odd3split[0]) / double.Parse(odd3split[1])) + 1;
                        double decimalOdd4 = (double.Parse(odd4split[0]) / double.Parse(odd4split[1])) + 1;
                        double decimalOdd5 = (double.Parse(odd5split[0]) / double.Parse(odd5split[1])) + 1;
                        double result = stake * decimalOdd1 * decimalOdd2 * decimalOdd3 * decimalOdd4 * decimalOdd5;
                        label4.Text = Math.Round(result, 2).ToString();

                    }
                    
                
                }
                else
                {
                    MessageBox.Show("Please select type of odds!");
                }
                
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "1")
            {
                line1Label.Visible = true;
                line1Input.Visible = true;
                line2Label.Visible = false;
                line2Input.Visible = false;
                line3Label.Visible = false;
                line3Input.Visible = false;
                line4Label.Visible = false;
                line4Input.Visible = false;
                line5Label.Visible = false;
                line5Input.Visible = false;

            }else if(comboBox1.SelectedItem == "2")
            {
                line1Label.Visible = true;
                line1Input.Visible = true;
                line2Label.Visible = true;
                line2Input.Visible = true;
                line3Label.Visible = false;
                line3Input.Visible = false;
                line4Label.Visible = false;
                line4Input.Visible = false;
                line5Label.Visible = false;
                line5Input.Visible = false;

            }else if(comboBox1.SelectedItem == "3")
            {
                line1Label.Visible = true;
                line1Input.Visible = true;
                line2Label.Visible = true;
                line2Input.Visible = true;
                line3Label.Visible = true;
                line3Input.Visible = true;
                line4Label.Visible = false;
                line4Input.Visible = false;
                line5Label.Visible = false;
                line5Input.Visible = false;

            }else if(comboBox1.SelectedItem == "4")
            {
                line1Label.Visible = true;
                line1Input.Visible = true;
                line2Label.Visible = true;
                line2Input.Visible = true;
                line3Label.Visible = true;
                line3Input.Visible = true;
                line4Label.Visible = true;
                line4Input.Visible = true;
                line5Label.Visible = false;
                line5Input.Visible = false;

            }
            else if (comboBox1.SelectedItem == "5")
            {
                line1Label.Visible = true;
                line1Input.Visible = true;
                line2Label.Visible = true;
                line2Input.Visible = true;
                line3Label.Visible = true;
                line3Input.Visible = true;
                line4Label.Visible = true;
                line4Input.Visible = true;
                line5Label.Visible = true;
                line5Input.Visible = true;

            }
        
        
        }

    }
}
