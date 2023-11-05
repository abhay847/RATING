using RATING.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RATING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void STAR5_Click(object sender, EventArgs e)
        {
            STAR5.Image = Resources.yellow_star;
            STAR4.Image = Resources.yellow_star;
            STAR3.Image = Resources.yellow_star;
            STAR2.Image = Resources.yellow_star;
            STAR1.Image = Resources.yellow_star;

        }

        private void STAR4_Click(object sender, EventArgs e)
        {
            STAR5.Image = Resources.white_star;

            STAR4.Image = Resources.yellow_star;
            STAR3.Image = Resources.yellow_star;
            STAR2.Image = Resources.yellow_star;
            STAR1.Image = Resources.yellow_star;
        }

        private void STAR3_Click(object sender, EventArgs e)
        {
            STAR5.Image = Resources.white_star;
            STAR4.Image = Resources.white_star;
            STAR3.Image = Resources.yellow_star;
            STAR2.Image = Resources.yellow_star;
            STAR1.Image = Resources.yellow_star;
        }

        private void STAR2_Click(object sender, EventArgs e)
        {
            STAR5.Image = Resources.white_star;
            STAR4.Image = Resources.white_star;
            STAR3.Image = Resources.white_star;
            STAR2.Image = Resources.yellow_star;
            STAR1.Image = Resources.yellow_star;
        }

        private void STAR1_Click(object sender, EventArgs e)
        {
            STAR5.Image = Resources.white_star;
            STAR4.Image = Resources.white_star;
            STAR3.Image = Resources.white_star;
            STAR2.Image = Resources.white_star;
            STAR1.Image = Resources.yellow_star;
        }

        private void STAR5_DoubleClick(object sender, EventArgs e)
        {
            STAR5.Image = Resources.white_star;
            STAR4.Image = Resources.white_star;
            STAR3.Image = Resources.white_star;
            STAR2.Image = Resources.white_star;
            STAR1.Image = Resources.white_star;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "Add a comment...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                    }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Add a comment...";
                textBox1.ForeColor = Color.Silver;
            }
        }
    }
}
