using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                         
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem.ToString()  == "São Paulo")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Indaiatuba");
                listBox2.Items.Add("São Paulo");
                listBox2.Items.Add("Campinas");
            }
            else if(listBox1.SelectedItem.ToString() == "Rio de Janeiro")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Rio de Janeiro");
                listBox2.Items.Add("Niterói");
                listBox2.Items.Add("Paraty");
            }
            else if (listBox1.SelectedItem.ToString() == "Minas Gerais")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Belo Horizonte");
                listBox2.Items.Add("Sobral");
                listBox2.Items.Add("Uberlândia");
            }
            else if (listBox1.SelectedItem.ToString() == "Espirito Santo")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Vitória");
                listBox2.Items.Add("Anchieta");
                listBox2.Items.Add("Alegria");
            }
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
