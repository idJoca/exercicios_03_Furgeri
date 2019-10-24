using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            string text = textBox1.Text;
            listBox1.Items.Add(text);
            textBox1.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        
            for (int n = listBox1.Items.Count - 1; n >= 0; --n)
            {
                string text2 = textBox2.Text;
                if (listBox1.Items[n].ToString().Contains(text2))
                {
                    listBox1.Items.RemoveAt(n);
                }
            }
        }
    }
}
