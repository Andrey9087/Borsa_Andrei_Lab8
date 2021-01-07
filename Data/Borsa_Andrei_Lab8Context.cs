using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Borsa_Andrei_Lab8.Models;

namespace Borsa_Andrei_Lab8.Data
{
    public class Borsa_Andrei_Lab8Context : DbContext
    {
        public Borsa_Andrei_Lab8Context (DbContextOptions<Borsa_Andrei_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Borsa_Andrei_Lab8.Models.Book> Book { get; set; }
    }
}
