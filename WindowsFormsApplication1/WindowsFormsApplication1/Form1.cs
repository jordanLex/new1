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
    public partial class Form1 : Form
    {
        int i = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "return");
            if (e.KeyCode==Keys.Enter)
            {
                System.IO.StreamWriter sw;
                System.IO.FileInfo fi = new System.IO.FileInfo("name.txt");
                sw = fi.AppendText();
                sw.WriteLine(textBox1.Text);
                sw.Close();
                tabs.SelectedTab.Text = textBox1.Text;
                ((WebBrowser)tabs.SelectedTab.Controls[0]).Navigate(@"http://www." + textBox1.Text);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            tabs.TabPages.Add("Новая вкладка ");
            tabs.SelectTab(i - 1);
            browser.Name = "browser";
            
            tabs.SelectedTab.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            
            i++;
        }
    }
}
