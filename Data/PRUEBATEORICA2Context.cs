using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRUEBATEORICA2.Models;

namespace PRUEBATEORICA2.Data
{
    public class PRUEBATEORICA2Context : DbContext
    {
        public PRUEBATEORICA2Context (DbContextOptions<PRUEBATEORICA2Context> options)
            : base(options)
        {
        }

        public DbSet<PRUEBATEORICA2.Models.Employee> Employee { get; set; }
    }
}
