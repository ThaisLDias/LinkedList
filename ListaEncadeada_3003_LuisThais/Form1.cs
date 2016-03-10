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
        int num;
        Random rdm = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public Element AddElementAt(int where, int value)
        {
            Element memory = new Element();
            memory = FindElement(where).CopyElement();

            Element insert = new Element();
            insert.value = value;
            insert.nextValue = memory;

            FindElement(where - 1).nextValue = insert;
            MessageBox.Show("O valor foi adicionado na posição!");
            return memory;
        } 
        public Element FindElement(int c)
        { 
            int index = 0;
            if (c > num)
            {
                c = num;
                index = c - 2;
            }
            else
            {
                index = c - 2;
            }
            Element current = father;
            Element next = current;
            while (index >= 0)
            {
                current = current.nextValue;
                index--;
            }
            return current;
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

        public string ShowList(Element v)
        {
            while (v.nextValue != null)
            {
                label1.Text += v.value.ToString() + "; ";  
                v = v.nextValue;
                count++;
            }
            label1.Text += v.value.ToString();
            return "Mostrou";
        }
      
        private void generateNum_Click(object sender, EventArgs e)
        {
            //Gerar número
            Random random = new Random();
            if (father.value == 0|| father.value.Equals(null))
            {
                father.value = Convert.ToInt32(random.Next(0, 100));
                label1.Text = father.value.ToString();
            }
            else
            {
                Element a = new Element();
                a.value = Convert.ToInt32(random.Next(0, 100));
                FindLast(father).nextValue = a;
                label1.Text += " " + a.value.ToString() + " ";
            }

            num++;
            comboBox1.Items.Add(num);
            
        }

        private void findElement_Click(object sender, EventArgs e)
        {
            label1.Text = FindElement(Convert.ToInt32(comboBox1.Text)).value.ToString();
        }

        private void findLast_Click(object sender, EventArgs e)
        {
            label1.Text = FindLast(father).value.ToString();
        }

        private void Adicionar(object sender, EventArgs e)
        {
            AddElementAt(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(valueBox.Text));
        }

        private void showList_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            ShowList(father);
        }

    }
}
