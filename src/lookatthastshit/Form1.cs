using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Ebat;
using static Ebat.Class2;
namespace lookatthastshit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            write(@"datfile\random.data", textBox1.Text, @"datfile\", "random.data");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            create(@"datfile\", "random.data");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            read(@"datfile\random.data");

            textBox2.Text = ebatdurak;
            ebatdurak = "";
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            clear(@"datfile\random.data");
            textBox2.Text = "";
            textBox1.Text = "";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button4.Text = "Copied!";
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            button4.Text = "Copy";
            timer2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("helpfunc.dll"))
            {
                MessageBox.Show("Can't Find helpfunc.dll!");
                Application.Exit();
            }
            this.AcceptButton = button1;
            download();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
