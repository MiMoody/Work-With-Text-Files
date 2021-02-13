using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Work_21_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



       
        private void button14_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty)
                {
                    continue;
                }
                if (radioButton1.Checked)
                {
                    listBox1.Items.Add(Str);
                }
                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d"))
                    {
                        listBox1.Items.Add(Str);
                    }
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w"))
                    {
                        listBox1.Items.Add(Str);
                    }
                }
            }
            listBox1.EndUpdate();



        }

      

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void открытьCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, System.Text.Encoding.UTF8);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void сохранитьCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                foreach (string element in listBox2.Items)
                {
                    Writer.WriteLine(element);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();

        }

        private void выходCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информация о приложении и разработчике");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            richTextBox1.Clear();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = true;
            checkBox4.Checked = false;


        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string search = textBox1.Text;
            if (checkBox1.Checked)
            {
                foreach (string element in listBox1.Items)
                {
                    if (element.Contains(search))
                    {
                        listBox3.Items.Add(element);
                    }
                }
            }
            if (checkBox2.Checked)
            {
                foreach (string element in listBox2.Items)
                {
                    if (element.Contains(search))
                    {
                        listBox3.Items.Add(element);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dop_Form AddRec = new Dop_Form();
            AddRec.Owner = this;
            AddRec.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                DeletedListElement(listBox1);
            }
            if(checkBox4.Checked)
            {
                DeletedListElement(listBox2);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            LineBreak(listBox1, listBox2);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            LineBreak(listBox2, listBox1);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            LineBreakALL(listBox1, listBox2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LineBreakALL(listBox2, listBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Алфавиту (по возрастанию)")
            {
                SortAlphaviteUp(listBox1);
            }
            if (comboBox1.Text == "Алфавиту (по убыванию)")
            {
                SortAlphaviteDown(listBox1);
            }
            if(comboBox1.Text == "Длине слова( по возрастанию)")
            {
                SortLenghtUp(listBox1);
            }
            if (comboBox1.Text == "Длине слова (по убыванию)")
            {
                SortLenghtDown(listBox1);
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Алфавиту (по возрастанию)" )
            {
                SortAlphaviteUp(listBox2);
            }
            if (comboBox2.Text == "Алфавиту (по убыванию)")
            {
                SortAlphaviteDown(listBox2);
            }
            if (comboBox2.Text == "Длине слова( по возрастанию)")
            {
                SortLenghtUp(listBox2);
            }
            if (comboBox2.Text == "Длине слова (по убыванию)")
            {
                SortLenghtDown(listBox2);
            }

        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }






        public void LineBreak(ListBox listBox1, ListBox listBox2)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i))
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                    listBox1.Items.RemoveAt(i);

                }
            }


        }


        public void DeletedListElement(ListBox listBox)
          {
            for (int i = 0; i <listBox.Items.Count; i++)
            {
                if (listBox.GetSelected(i))
                {
                    listBox.Items.RemoveAt(i);
                }
            }
             

        }
        public void LineBreakALL(ListBox listBox1, ListBox listBox2)
        {
            
                listBox2.Items.AddRange(listBox1.Items);
                listBox1.Items.Clear();

        }
        public void SortAlphaviteUp(ListBox listBox)
        {
            listBox.Sorted = true;
        }
        public void SortAlphaviteDown(ListBox listBox)
        {
            
            List<string> newitem = new List<string>();
            foreach(string s in listBox.Items)
            {
                newitem.Add(s)
  ;         }
            listBox.Items.Clear();
            newitem.Sort();
            newitem.Reverse();
            
            foreach(string s in newitem)
            {
                listBox.Items.Add(s);
            }
        }
        public void SortLenghtUp(ListBox listBox)
        {
            List<string> listSource = new List<string>();
            foreach (string s in listBox.Items)
            {
                listSource.Add(s);
            }
            listBox.Items.Clear();
            List<string> source = new List<string>();
            source = listSource.OrderBy(item => item.Length).ToList();
            foreach (string s in source)
            {
                listBox.Items.Add(s);
            }

        }
        public void SortLenghtDown(ListBox listBox)
        {
            List<string> listSource = new List<string>();
            foreach (string s in listBox.Items)
            {
                listSource.Add(s);
            }
            listBox.Items.Clear();
            List<string> source = new List<string>();
            source = listSource.OrderByDescending(item => item.Length).ToList();
            foreach (string s in source)
            {
                listBox.Items.Add(s);
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}

