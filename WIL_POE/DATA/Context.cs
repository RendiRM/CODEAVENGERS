using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ENTITIES;

namespace DATA
{
    public class CONTEXT : DbContext
    {
       public DbSet <Employee> driver { get; set; }



    }
}
