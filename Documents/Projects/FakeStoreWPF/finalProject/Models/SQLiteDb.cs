using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject.Models
{
   class SQLiteDb : DbContext
   {
      public DbSet<InventoryItems> InventoryItem { get; set; }

      public DbSet<Products> Product { get; set; }

      public DbSet<Orders> Order { get; set; }


      protected override void OnConfiguring(DbContextOptionsBuilder options)
      {
         options.UseSqlite(@"Data Source=store.sqlite");
         base.OnConfiguring(options);

      }


}
}
