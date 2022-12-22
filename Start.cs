using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt
{
    public partial class Start : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Start()
        {
            InitializeComponent();
            pictureBox1.Width = pictureBox1.Width ;
            pictureBox1.Height = pictureBox1.Height ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            password1 newForm = new password1();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuestMain newForm = new GuestMain();
            newForm.Show();
            this.Hide();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
