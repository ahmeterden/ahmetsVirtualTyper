using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace ahmetsVirtualTyper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_begin_Click(object sender, EventArgs e)
        {
            timer1.Interval = Int32.Parse(tbDelay.Text) * 1000;
            timer1.Enabled = true;
        }
		                     
        private void timer1_Tick(object sender, EventArgs e)
        {
            InputSimulator myKb = new InputSimulator();
            myKb.Keyboard.TextEntry(tbPaste.Text);

			//old approach, before RDP typing

            //foreach (char myChar in tbPaste.Text)
            //{
            //    string tempStr;

            //    if(myChar == '+' || myChar == '^' || myChar == '%' || myChar == '~' || myChar == '(' || myChar == ')' || myChar == '{' || myChar == '}')
            //    {
            //        tempStr = "{" + myChar.ToString() + "}";
            //    }
            //    else
            //    {
            //        tempStr = myChar.ToString();
            //    }

            //    SendKeys.Send(tempStr);
            //    Thread.Sleep(1000/Int32.Parse(tbDelay.Text));
            //}

            timer1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }
    }
}
