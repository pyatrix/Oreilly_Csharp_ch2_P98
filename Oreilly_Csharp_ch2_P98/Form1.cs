using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter2_program4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int a = 0;
            while (Visible )
            {
                for (int c = 0; c < 253 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    //System.Threading.Thread.Sleep(1);

                }
                for (int c = 253; c >0  && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    //System.Threading.Thread.Sleep(1);
                }


            }
        }
    }
}
