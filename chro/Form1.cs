using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DateTime début= DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Marche")
            {
                début = DateTime.Now;
                label1.Text = "00:00:00";
                timer1.Enabled = true;
                button1.Text = "Arrét";
                return;
            }
            if (button1.Text == "Arrét")
            {
                timer1.Enabled = false;
                button1.Text = "Marche";
                return;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maintenant = DateTime.Now;
            TimeSpan durée = maintenant - début;
            label1.Text = durée.Hours.ToString("d2") + ":" + durée.Minutes.ToString("d2") + ":"  + durée.Seconds.ToString("d2");
        }
    }
}
