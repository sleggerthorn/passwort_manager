using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTyper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SendKeys.SendWait("%{Tab}");
            if (cbExtraKey.Checked == true)
            {
                System.Windows.Forms.SendKeys.SendWait("{A}");
                if (cbUser.Checked == true)
                {
                    System.Windows.Forms.SendKeys.SendWait(tbUser.Text);
                    System.Windows.Forms.SendKeys.SendWait("{TAB}");
                    System.Windows.Forms.SendKeys.SendWait(tbPassword.Text);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");

                }
                else
                {
                    System.Windows.Forms.SendKeys.SendWait(tbPassword.Text);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                }
            }
            else
            {
                if (cbUser.Checked == true)
                {
                    System.Windows.Forms.SendKeys.SendWait(tbUser.Text);
                    System.Windows.Forms.SendKeys.SendWait("{TAB}");
                    System.Windows.Forms.SendKeys.SendWait(tbPassword.Text);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");

                }
                else
                {
                    System.Windows.Forms.SendKeys.SendWait(tbPassword.Text);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                }
            }
        }
        private void cbUser_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
