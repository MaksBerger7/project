using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace proekt
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SoturdnikMain : Form
    {
        app DB;
        /// <summary>
        /// 
        /// </summary>
        public SoturdnikMain()
        {
            
            InitializeComponent();
            DB = new app();//Выделение памяти
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCar newForm = new AddCar();
            newForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteCar newForm = new DeleteCar();
            newForm.Show();
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Start newForm = new Start();
            newForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            in_stock_for_sotrudnik in_Stock = new in_stock_for_sotrudnik();
            in_Stock.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            diagramma diagara = new diagramma();
            diagara.Show();
            this.Hide();
        }
    }
}
