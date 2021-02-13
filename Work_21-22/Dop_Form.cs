using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_21_22
{
    public partial class Dop_Form : Form
    {
        public Dop_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;
            if (textBox1.Text != string.Empty)
            {
                if (this.radioButton1.Checked == true)
                {
                    Main.listBox1.Items.Add(this.textBox1.Text);
                }
                else
                {
                    Main.listBox2.Items.Add(this.textBox1.Text);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели текст!!!!!!!");
            }

        }
    }
}
