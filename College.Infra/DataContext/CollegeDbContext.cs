using College.Infra.Table;
using CollegeDetails.Infra.Table;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetails.Infra.DataContext
{
    public class CollegeDbContext:DbContext
    {
        public CollegeDbContext(DbContextOptions<CollegeDbContext>options): base(options) 
        {
        }
        public DbSet<CollegeTable> College { get; set; }
        public DbSet<FeesTable> Fees { get; set; }
        
    }

}
