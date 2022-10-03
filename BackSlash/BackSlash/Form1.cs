using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackSlash
{
    public partial class Form1 : Form
    {
        int _h;

        public Form1()
        {
            InitializeComponent();

            _h = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            yes.Visible = false;
            no.Visible = false;
            question.Visible = false;
            load.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, 0, 0, _h, 1000);
        }

        private void load_Tick(object sender, EventArgs e)
        {
            _h += 10;
            Invalidate();
        }
    }
}
