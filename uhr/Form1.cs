using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uhr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorDialog1.FullOpen = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void цветЦиферблатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            foreach (clock timeclock in Controls.OfType<clock>())
                timeclock.ClockColor = colorDialog1.Color;
        }
        private void цветЧасовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            foreach (clock timeclock in Controls.OfType<clock>())
                timeclock.hColor = colorDialog1.Color;
        }
        private void цветМинутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            foreach (clock timeclock in Controls.OfType<clock>())
                timeclock.mColor = colorDialog1.Color;
        }
        private void цветСекундToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            foreach (clock timeclock in Controls.OfType<clock>())
                timeclock.sColor = colorDialog1.Color;
        }
        private void сброситьЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (clock timeclock in Controls.OfType<clock>())
            {
                timeclock.ClockColor = Color.Black;
                timeclock.hColor = Color.Black;
                timeclock.mColor = Color.Black;
                timeclock.sColor = Color.Black;
            }
        }
    }
}
