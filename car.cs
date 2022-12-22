using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    internal class car
    {
        public int id { get; set; }
        public string марка { get; set; }
        public string модель { get; set; }
        public int год_выпуска { get; set; }
        public string вид { get; set; }
        public string цвет { get; set; }
        public int модификации { get; set; }
        public int цена { get; set; }

        public car() { }

        public car( string марка, string модель, int год_выпуска, string вид, string цвет, int модификации, int цена)
        {
            
            this.марка = марка;
            this.модель = модель;
            this.год_выпуска = год_выпуска;
            this.вид = вид;
            this.цвет = цвет;
            this.модификации = модификации;
            this.цена = цена;
        }
    }

}
