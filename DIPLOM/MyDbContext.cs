using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace DIPLOM
{
    class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("DbConnection")
        { }

        

        public DbSet<Dannie> Dannies { get; set; }
    }
}
