using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    /// <summary>
    /// Создание класса password с полями и методами
    /// </summary>
    internal class password
    {
        public int id { get; set; }
        public string пароль { get; set; }
        public string логин { get; set; }

        public string имя_работника { get; set; }
        public string фамилия_работника { get; set; }

        public password() { }
        public password(string пароль, string логин, string имя_работника, string фамилия_работника)
        {
            this.пароль = пароль;
            this.логин = логин;
            this.имя_работника = имя_работника;
            this.фамилия_работника = фамилия_работника;

        }

    }
}
