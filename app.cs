using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data.Entity;

namespace proekt
{
    /// <summary>
    /// 
    /// </summary>
    internal class app : DbContext
    {
        public DbSet<car> cars { get; set; }

        public app() : base("DefaultConnection") { }

    }
    internal class app2 : DbContext
    {
        public DbSet<service> services { get; set; }

        public app2() : base("DefaultConnection2") { }

    }
    internal class app3 : DbContext
    {
        public DbSet<password> passwords { get; set; }

        public app3() : base("DefaultConnection3") { }

    }
}
