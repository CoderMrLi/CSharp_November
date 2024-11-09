using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 事件传递方法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void printHello()
        {
            MessageBox.Show("Hello");
            label1.Text = "Hello";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            //把printHello方法给了Form2
            form2.Print += printHello;
            form2.ShowDialog();
        }
    }
}
