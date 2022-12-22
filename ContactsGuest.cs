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
    /// автогенерируемый класс
    /// </summary>
    public partial class ContactsGuest : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactsGuest()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GuestMain newForm = new GuestMain();
            newForm.Show();
            this.Close();
        }

    }
}
