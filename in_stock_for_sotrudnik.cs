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
    public partial class in_stock_for_sotrudnik : Form
    {
        app DB;
        /// <summary>
        /// 
        /// </summary>
        public in_stock_for_sotrudnik()
        {
            DB = new app();
            InitializeComponent();
        }

        /// <summary>
        /// Вывод машин в DGV1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void in_stock_for_sotrudnik_Load(object sender, EventArgs e)
        {
            List<car> cars = DB.cars.ToList();
            dataGridView1.DataSource = cars;
          
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            SoturdnikMain frm = new SoturdnikMain();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void add_Click(object sender, EventArgs e)
        {
            AddCar addCar=new AddCar();
            addCar.Show();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteCar car =new DeleteCar(); 
            car.Show();
            

        }

        private void update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=DB.cars.ToList();
        }
    }
}
