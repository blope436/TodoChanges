using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace finalProject.Models
{
   public class InventoryItems
   {
      [Key]
      public int InventoryId { get; set; }

      public string InventoryNumber { get; set; }

      public string InventoryName { get; set; }

      public string InventoryPrice { get; set; }

      public string InventoryQuantity { get; set; }

      public int ProductId { get; set; }

      public Products Product { get; set; }

   }
   

}
