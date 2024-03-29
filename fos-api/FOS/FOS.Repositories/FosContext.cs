﻿using FOS.Repositories.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.Repositories
{
    public class FosContext : DbContext
    {
        public FosContext()
            : base("FosContext")
        {

        }

        public FosContext(string connStringOrName)
            : base(connStringOrName)
        {

        }

        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
