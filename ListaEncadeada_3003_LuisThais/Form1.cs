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
        int click = 0;
        int MAX;
        public Form1()
        {
            InitializeComponent();
            father.value = 8;
        }

        public Element FindLast(Element v) 
        {
            if (v.nextValue != null)
            {
                FindLast(v.nextValue);
            }
            return v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MAX = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= MAX; i++)
            {
                Element a = new Element();

                if (i == 0)
                {
                    a.value = father.value + 2;
                    father.nextValue = a;
                }
                else {
                    a.value = father.nextValue.value + 2;
                    father.nextValue.nextValue = a;            
                }
            }
            Console.WriteLine(father);
            Console.WriteLine(father.nextValue);
            Console.WriteLine(father.nextValue.nextValue);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = FindLast(father.nextValue).value.ToString();
        }
    }
}
