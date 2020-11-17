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
    public partial class FormA : Form
    {
        int p;
        int eA;
        int dA;
        BigInteger m;
        int c2;
        public FormA()
        {
            InitializeComponent();
        }
       
        public static int RevNum(int a, int mod)
        {
            List<int> listX = new List<int>();
            listX.Add(1);
            listX.Add(0);
            List<int> listY = new List<int>();
            listY.Add(0);
            listY.Add(1);
            int i = 2;
            int mod1 = mod;
            int a1 = a;
            int r = mod%a;
            int q;
            while(r!=1)
            {
                q = mod1 / a1;
                r = mod1 % a1;
                listX.Add(listX[i - 2] - q * listX[i - 1]);
                listY.Add(listY[i - 2] - q * listY[i - 1]);
                mod1 = a1;
                a1 = r;
                i++;
            }

            int resX = listX[listX.Count - 1];
            int resY = listY[listY.Count - 1];
            if(resX<=0)
            {
                resX = mod + resX;
            }
            if(resY<=0)
            {
                resY = mod + resY;
            }
            if((a*resX)%mod == 1)
            {
                return resX;
            }
            else
            {
                return resY;
            }


        }
        public BigInteger ConvertNumber(string str)
        {
            m = 0;
            for(int i =0; i<str.Length;i++)
            {
                m += (Convert.ToInt32(str[i]) - 97) * Convert.ToInt32(Math.Pow(26, (str.Length - 1) - i));
            }

            return m;
        }
        public static int GetNOD(int val1, int val2)
        {
            while ((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2)
                    val1 %= val2;
                else
                    val2 %= val1;
            }
            return Math.Max(val1, val2);
        }


        private bool ChekP()
        {
            if(pTextBox.Text.Length == 0)
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }
            if(Int32.TryParse(pTextBox.Text,out p) == false)
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }
            if(p<=0)
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }
            
            return true;
        }
        private bool ChekM()
        {
            string resutl = "";
            for(int i = 0; i<mTextBox.Text.Length;i++)
            {
                if (Convert.ToInt32(mTextBox.Text[i]) <97 || Convert.ToInt32(mTextBox.Text[i]) > 122)
                {
                    continue;
                }
                resutl += mTextBox.Text[i];
            }
            if(resutl.Length ==0)
            {
                MessageBox.Show("M некорректно", "Ошибка");
                return false;
            }
            mTextBox.Text = resutl;
            return true;
        }

        private bool ChekEA()
        {
            if (eATextBox.Text.Length == 0)
            {
                MessageBox.Show("e<a> некорректно", "Ошибка");
                return false;
            }
            if (Int32.TryParse(eATextBox.Text, out eA) == false)
            {
                MessageBox.Show("e<a> некорректно", "Ошибка");
                return false;
            }
            /*if(eA >= p)
            {
                MessageBox.Show("e<a> некорректно", "Ошибка");
                return false;
            }*/


            if (GetNOD(eA,p-1)!=1)
            {
                MessageBox.Show("e<a> некорректно", "Ошибка");
                return false;
            }
            return true;

        }

        private bool ChekC2()
        {
            if (Int32.TryParse(c2TextBox.Text, out c2) == false)
            {
                
                return false;
            }
            if (c2 <= 0)
            {
               
                return false;
            }
            return true;

        }
        private bool Chek()
        {
            if(ChekP() && ChekM() && ChekEA())
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void canselButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (Chek() == true)
            {
                dA = RevNum(eA, p - 1);
                dATextBox.Text = dA.ToString();
                ConvertNumber(mTextBox.Text);
                pTextBox.Enabled = false;
                mTextBox.Enabled = false;
                eATextBox.Enabled = false;
                c1TextBox.Text = BigInteger.ModPow(m, eA, p).ToString();
               
                label6.Text = "Передайте Принимающему Значение С1 и получите значение С2";
                c1TextBox.Enabled = true;
                c2TextBox.Enabled = true;
                if (c2TextBox.Text.Length != 0)
                {
                    if (ChekC2() == false)
                    {
                        MessageBox.Show("C2 некорректно", "Ошибка");

                    }
                    c3TextBox.Text = BigInteger.ModPow(c2, dA, p).ToString();
                    label6.Text = "Передайте Принимающему Значение С3";
                    c1TextBox.Enabled = false;
                    c2TextBox.Enabled = false;
                    c3TextBox.Enabled = true;
                }

            }


        }

        private void c2TextBox_TextChanged(object sender, EventArgs e)
        {
            label6.Text = "Вставте С2 и нажмите Ок";
        }
    }
}
