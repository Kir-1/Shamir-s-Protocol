using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Shamir
{
    public partial class FormB : Form
    {
        int eB;
        int p;
        int c1;
        int c3;
        int dB;
        BigInteger m;
        public FormB()
        {
            InitializeComponent();
        }

       



        private void CanselButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private string ConverNumber(BigInteger num)
        {
            string result1 = "";
            string result2 = "";
            result2 = num.ToString();
            int num1 = Int32.Parse(result2);
            result2 = "";
            while (num1!=0)
            {
                result1 += Convert.ToChar((num1 % 26) + 97);
                num1 /= 26;
            }
            for(int i =result1.Length-1; i>=0;i--)
            {
                result2 += result1[i];
            }
            return result2;
        }

        private bool ChekP()
        {
            if (pTextBox.Text.Length == 0)
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }
            if (Int32.TryParse(pTextBox.Text, out p) == false)
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }
            if (p <= 0)
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }

            return true;
        }
        private bool ChekEB()
        {
            if (eBTextBox.Text.Length == 0)
            {
                MessageBox.Show("e<b> некорректно", "Ошибка");
                return false;
            }
            if (Int32.TryParse(eBTextBox.Text, out eB) == false)
            {
                MessageBox.Show("e<b> некорректно", "Ошибка");
                return false;
            }
            /*if(eA >= p)
            {
                MessageBox.Show("e<a> некорректно", "Ошибка");
                return false;
            }*/


            if (FormA.GetNOD(eB, p - 1) != 1)
            {
                MessageBox.Show("e<b> некорректно", "Ошибка");
                return false;
            }
            return true;

        }

        private bool ChekC1()
        {
            if (Int32.TryParse(c1TextBox.Text, out c1) == false)
            {

                return false;
            }
            if (c1 <= 0)
            {

                return false;
            }
            return true;

        }
        private bool ChekC3()
        {
            if (Int32.TryParse(c3TextBox.Text, out c3) == false)
            {

                return false;
            }
            if (c3 <= 0)
            {

                return false;
            }
            return true;

        }
        private bool Chek()
        {
            if(ChekP()&&ChekEB())
            {
                return true;
            }
            return false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(Chek() == true)
            {
                pTextBox.Enabled = false;
                eBTextBox.Enabled = false;
                dB = FormA.RevNum(eB, p - 1);
                dBTextBox.Text = dB.ToString();
                c1TextBox.Enabled = true;
                label6.Text = "Вставте Значение С1 и Нажимите Ок";
                if(c1TextBox.Text.Length !=0)
                {
                    if(ChekC1() == true)
                    {
                        c2TextBox.Text = BigInteger.ModPow(c1, eB, p).ToString();
                        label6.Text = "Передайте значение С2 Принимающему и Получите С3";
                        c1TextBox.Enabled = false;
                        c2TextBox.Enabled = true;
                        c3TextBox.Enabled = true;
                        
                    }
                    else
                    {
                        MessageBox.Show("C1 некорректно", "Ошибка");
                    }
                   
                }
                if(c3TextBox.Text.Length !=0)
                {
                    if (ChekC3() == true)
                    {
                        c3TextBox.Enabled = false;
                        c2TextBox.Enabled = false;
                        m = BigInteger.ModPow(c3, dB, p);

                        mTextBox.Text = ConverNumber(m);
                        label6.Text = "Готово";


                    }
                    else
                    {
                        MessageBox.Show("C3 некорректно", "Ошибка");
                    }
                }
            }
        }

        private void c3TextBox_TextChanged(object sender, EventArgs e)
        {
            label6.Text = "Вставте С3 и нажмите Ок";
            
        }
    }
}
