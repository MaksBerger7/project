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
    /// <summary>
    /// 
    /// </summary>
    public partial class GuestMain : Form
    {
        /// <summary>
        /// Основная экранная форма для гостя
        /// Здесь функионал кнопок ограничен выводом следующих жкранов и закрытием текущего
        /// </summary>
        public GuestMain()
        {
            InitializeComponent();
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ContactsGuest newForm = new ContactsGuest();
            newForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            in_stock in_Stock=new in_stock();
            in_Stock.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uslugi услуги=new Uslugi();
            услуги.Show();
            this.Close ();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Close();
        }


    }
}
