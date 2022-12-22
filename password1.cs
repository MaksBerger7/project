using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;

using System.Data.SQLite;

namespace proekt
{/// <summary>
/// 
/// </summary>

    
    public partial class password1 : Form
    {
        app3 db;
        /// <summary>
        /// Ввод информации в textbox будет осуществлятся через *
        /// </summary>
        public password1()
        {
            db= new app3();
            InitializeComponent();
            pass.PasswordChar = '*';
            log.PasswordChar = '*';

        }
        /// <summary>
        /// SQL Подключение к БД
        /// Если пароль и логин совпадют с БД, то данная строка будет в переменной dt
        /// Так как строка одна, то вход успешный и открывается следующее окно
        /// Если ввод неверный то нужно перепроверить правильность информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SQLiteConnection connection1 = new SQLiteConnection("DataSource=passwords.db");
            string text1 = "Select*from passwords Where пароль = '" + pass.Text.Trim() + "'and логин='" + log.Text.Trim() + "'";
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(text1, connection1);
            adapter1.Fill(dt);


            if (dt.Rows.Count == 1)
            {

                SoturdnikMain newForm = new SoturdnikMain();
                newForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы ввели неверный логин или пароль");
            }
            //p => p.марка == textBox1.Text;
            //var parametrs = db.passwords.Where(p => p.пароль == pass.Text).ToList() ;

            //foreach (var item in parametrs)
            //{
            //    int b = 0;
            //    if (parametrs)
            //    {

            //        SoturdnikMain newForm = new SoturdnikMain();
            //        newForm.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Вы ввели неверный логин или пароль");
            //    }
            //}




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start newForm = new Start();
            newForm.Show();
            this.Hide();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
