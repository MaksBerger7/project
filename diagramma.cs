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
    
    public partial class diagramma : Form
    {
        app DB;
        public diagramma()
        {
            DB = new app();
            InitializeComponent();
        }

        private void diagara_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("Процентное соотношение машин") ;
            var parametrs = DB.cars.GroupBy(x => x.марка).Select(x => new { a = x.Key,b = x.Count()});
            foreach (var item in parametrs)
            {
                  chart1.Series["Series1"].Points.AddXY(item.a, item.b);
            }
            chart2.Titles.Add("Процентное соотношение видов кузовов");
            //string text1 = "Select COUNT(*) AS id,марка from cars GROUP BY(марка) " ;
            // [1,1,1,2,2,2,3,3,3] - изначально так
            //[1,2,3] - гурппирокка по груп бай, count - кол во повторений, key - само занченение
            var parametr= DB.cars.GroupBy(x => x.вид).Select(x => new { a = x.Key, b = x.Count() });
            foreach (var item in parametr)
            {
                chart2.Series["Series1"].Points.AddXY(item.a, item.b);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoturdnikMain soturdnikMain = new SoturdnikMain();
            soturdnikMain.Show();
            this.Close();
        }
    }
}
