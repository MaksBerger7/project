using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    
    internal class service
    {
        public int id { get; set; }
        public string Вид_услуги { get; set; }

        public int Цена { get; set; }
        public string Время_выполнения { get; set; }

        public service () {}
        public service(int id, string Вид_услуги, int Цена, string Время_выполнения)

        {
            this.id = id;
            this.Вид_услуги = Вид_услуги;
            this.Цена = Цена;
            this.Время_выполнения = Время_выполнения;
        }
    }
}
