using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstCrud.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) 
        {
         
        }
        public DbSet<Student> tbl_Student { get; set; }

        //public DbSet<LoginModel> tbl_Login { get; set; }
        




























































    }
}
