using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Store
{
    internal class db:DbContext
    {
        public db():base("constr")
        {
        }

        public DbSet<prd> store { get; set; }

    }
}
