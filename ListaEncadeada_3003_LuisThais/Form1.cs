using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEncadeada_3003_LuisThais
{
    public partial class Form1 : Form
    {

        Element father = new Element();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public Element FindElement(Element b, int c)
        {
            while (b.nextValue != null && c > count)
            {
                b = b.nextValue;
                count++;
            }
            return b; 

        }

        public Element FindLast(Element v) 
        {
            while (v.nextValue != null)
            {
               v = v.nextValue;
               count++;
            }
            return v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            father.value = Convert.ToInt32(random.Next(0,100));
            label1.Text = father.value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = FindLast(father.nextValue).value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Element a = new Element();
            a.value = Convert.ToInt32(random.Next(0,100));
            FindLast(father).nextValue = a;
            label1.Text += a.value.ToString();
        }

    }
}
