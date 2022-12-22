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
    public partial class Uslugi : Form
    {
        app2 DB1;
        /// <summary>
        /// 
        /// </summary>
        public Uslugi()
        {
            InitializeComponent();
            DB1 = new app2();
           
        }

        /// <summary>
        /// Вывод БД services в DGV1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void услуги_Load(object sender, EventArgs e)
        {
            List<service> services = DB1.services.ToList();
            dataGridView1.DataSource = services;
           // dataGridView1.DataSource = DB1.services.ToList();
           
        }

      
       /// <summary>
       /// При нажатии кнопки данное окно закрывается и открывается следующее
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            GuestMain newForm = new GuestMain();
            newForm.Show();
            this.Close();
        }
    }
}
