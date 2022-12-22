using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace proekt
{
    /// <summary>
    /// 
    /// </summary>
    public partial class in_stock : Form
    {
        app DB;
       
        /// <summary>
        /// 
        /// </summary>

        public in_stock()
        {
           
            DB = new app();//Выделение памяти
            InitializeComponent();
        }

      
        /// <summary>
        /// При загрузке формы выводится datagridview с таблицей машин
        /// созадется list класса car в который передается база данных cars и возвращается значения list
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void in_stock_Load(object sender, EventArgs e)
        {
           
            List<car>cars=DB.cars.ToList();
            dataGridView2.DataSource = cars;
            //dataGridView2.DataSource = DB.cars.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuestMain newForm = new GuestMain();
            newForm.Show();
            this.Close();
        }
        /// <summary>
        /// linq запрос, в DGV2 передаются данные удовлетворяющему условию
        /// условие: если навзвание марки введеной в textbox совпадает с названием в БД, то эти машины выводятся
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                dataGridView2.DataSource = DB.cars.Where(p => p.марка == textBox1.Text.Substring(0)).ToList();
            
           
            
        }

        /// <summary>
        ///  linq запрос, в DGV2 передаются данные удовлетворяющему условию
        ///  условие: если вид, выбранный в combobx, имеется в БД, то выводится в DGV2 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DB.cars.Where(p => p.вид == comboBox1.SelectedItem.ToString()).ToList();


            if (comboBox1.SelectedIndex==4)
           dataGridView2.DataSource=DB.cars.ToList();

        }
    }
}
