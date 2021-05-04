using FirstAzure.Controllers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAzure
{
    public class PeopleDb : DbContext
    {
        public PeopleDb(DbContextOptions<PeopleDb> options) : base(options) 
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
