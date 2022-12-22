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
    
    public partial class AddCar : Form
    {
        app DB;
        /// <summary>  
        /// класс AddCarнужен для добавления новой машины в БД
        /// </summary>
        public AddCar()
        {
            InitializeComponent();
            DB = new app();//Выделение памяти
        }
      /// <summary>
      /// При нажатии кнопкк идет добавления машины при правильном вводе
      /// создаются перемнные которые равны тексту в textbox
      /// выскаиквает сообщение при неправильном
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                string модель = Модель.Text;
                string марка = Марка.Text;
                int год_выпуска = Convert.ToInt32(Год_выпуска.Text);
                string вид = Вид.Text;
                string цвет = Цвет.Text;
                int модификации = Convert.ToInt32(Модификации.Text);
                int цена = Convert.ToInt32(Цена.Text);
                car car1 = new car(марка, модель, год_выпуска, вид, цвет, модификации, цена);
                DB.cars.Add(car1);
                DB.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка: " +ex.Message);

            }
           
           


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Отмена_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
