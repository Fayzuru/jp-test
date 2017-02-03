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
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "test";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Test Kana ア";

            //DateTime dat = DateTime.Now;
            //textBox1.Text = ("The time: {0:d} at {0:t}", dat);
            //TimeZoneInfo tz = TimeZoneInfo.Local;

        }

        private void button73_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Placeholder to add reversed kana on below boxes on dropdown");


        }

        private void button60_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Default frmDefault = new Default();
            frm.Show();
            this.Hide();
            //frmDefault.Visible = false;
      
        
            //Create Form2.
            //public class Form2: Form

            //public Form2()

            //Text = "Form2";

            
        }
    }
}
