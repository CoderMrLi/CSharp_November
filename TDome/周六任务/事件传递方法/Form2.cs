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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public delegate void TestDelegate();
        //event 事件
        public event TestDelegate Print;

        private void button1_Click(object sender, EventArgs e)
        {
            //先判断不为空 再运行
            if(Print != null)
            {
                Print();
                //Print.Invoke();
            }
        }
    }
}
