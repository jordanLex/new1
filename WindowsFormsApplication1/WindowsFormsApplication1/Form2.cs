using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public string q = "";
        Form1 parent;
        public Form2(Form1 mainform)
        {
            InitializeComponent();
            parent = mainform;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            q = listBox1.Items[listBox1.SelectedIndex].ToString();
            parent.goback(q);
            this.Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            System.IO.StreamReader streamReader = new System.IO.StreamReader("name.txt");

            while (!streamReader.EndOfStream)
            {
                listBox1.Items.Add(streamReader.ReadLine());
            }
        }

    }
}
