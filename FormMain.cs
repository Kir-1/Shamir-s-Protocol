using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shamir
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormA formA = new FormA();
            formA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB.Show();
        }
    }
}
