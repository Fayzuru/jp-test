using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text = ("Person, Ningen, 人間 ");
        ;
      
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Output.Text = ("Two People, Futari");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Output.Text = ("Woman");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Default frmDefault = new Default();
            frmDefault.Show();
            this.Hide();
        }
    }
}
