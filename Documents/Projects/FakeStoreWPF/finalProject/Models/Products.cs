using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject.Models
{
   public class Products
   {
      [Key]
      public int ProductId { get; set; }

      public string ProductName { get; set; }


      public List<InventoryItems> InventoryItem { get; set; } = new();


   }
}
