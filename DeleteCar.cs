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
    public partial class DeleteCar : Form
    {
        
        app db;
        /// <summary>
        /// 
        /// </summary>
        public DeleteCar()
        {
            InitializeComponent();
            db = new app();
        }
        /// <summary>
        /// переменная int типа int равна надписи в textbox
        /// через linq запрос удаляется id если такой есть в бд
        /// если такого id нет, то выскакивает сообщение об ошибке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                int id = Convert.ToInt32(textBox1.Text);
                db.cars.Remove(db.cars.Where(o => o.id == id).FirstOrDefault());
                db.SaveChanges();
                this.Close();

            }
            catch (Exception )
            {

                MessageBox.Show("Такого id нету в базе данных ");
                textBox1.Clear();
                
            }
            
        
        }

        /// <summary>
        /// при нажатии кнопки отмены, окно закрывается и открывается предшевствующие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Отмена_Click(object sender, EventArgs e)
        {
            //in_stock_for_sotrudnik in_= new in_stock_for_sotrudnik();
            
            //in_.Show();
            this.Close();
             
        }
    }
}
