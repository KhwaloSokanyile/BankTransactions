#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bank.Models;

namespace Bank.Data
{
    public class BankContext : DbContext
    {
        public BankContext (DbContextOptions<BankContext> options)
            : base(options)
        {
        }

        public DbSet<Bank.Models.Transactions> Transactions { get; set; }

        public DbSet<Bank.Models.Loans>? Loans { get; set; }
    }
}
