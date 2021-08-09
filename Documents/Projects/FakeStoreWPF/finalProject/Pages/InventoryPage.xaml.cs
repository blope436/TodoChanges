using finalProject.Models;
using Microsoft.Data.Sqlite;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;



namespace finalProject.Pages
{
   /// <summary>
   /// Interaction logic for InventoryPage.xaml
   /// </summary>
   public partial class InventoryPage : Page
   {
      public int count = 0;
      public string quantity;
      public string price;
      public InventoryPage()
      {
         InitializeComponent();
         syncDB2();
         productLabel2.Foreground = Brushes.DarkRed;
         inventoryText.Foreground = Brushes.Blue;
         inventoryText2.Foreground = Brushes.Blue;
         inventoryText22.Foreground = Brushes.Blue;
         inventoryText33.Foreground = Brushes.Blue;
         InvN.Foreground = Brushes.DarkCyan;

      }
      private void syncDB2()
      {
         using var dbContext = new SQLiteDb();
         var inventory2 = dbContext.InventoryItem.ToList<InventoryItems>();
         //dislay the names to be deleted in the combo box
         if (inventory2 is not null)
         {
            Inventory2CB.ItemsSource = inventory2.Select(i => i.InventoryName);
         }
      }

      private void backButton2_Click(object sender, RoutedEventArgs e)
      {
         this.NavigationService.Navigate(new Main());
      }
      private void Enter_Click(object sender, RoutedEventArgs e)
      {

         //if the inventory number is not empty then this statement will run
         if (inventoryNumber.Text != "" && inventoryName.Text != "" && inventoryPrice.Text != "" && inventoryQuantity.Text != "")
         {
            count++;
            //save items entered by user in the database
            using var dbContext = new SQLiteDb();
           dbContext.Product.Add(new() { ProductName = inventoryName.Text, });
           dbContext.SaveChanges();

           dbContext.InventoryItem.Add(new() { InventoryNumber = inventoryNumber.Text, InventoryName = inventoryName.Text, InventoryPrice = inventoryPrice.Text, InventoryQuantity = inventoryQuantity.Text, ProductId = count });

           dbContext.SaveChanges();
         
            inventoryNumber.Text = "";
            inventoryName.Text = "";
            inventoryPrice.Text = "";
            inventoryQuantity.Text = "";

         }
         else 
         {
            MessageBox.Show("All of the items in the Inventory page must be filled.");
         }
         


      }

      private void Cancel_Click(object sender, RoutedEventArgs e)
      {
         inventoryNumber.Clear();
         inventoryName.Clear();
         inventoryPrice.Clear();
         inventoryQuantity.Clear();
         Inventory2CB.Text = "";
         InventoryLB.Items.Clear();
      }
      Products product = new();
      public int count2 = 0;
      private void Delete_Click(object sender, RoutedEventArgs e)
      {
         //delete selected items
         if (Inventory2CB.Text != "")
         {
               count2++;
               product.ProductId = count2;
               using var dbContext = new SQLiteDb();
               MessageBox.Show($"{Inventory2CB.Text} has been deleted");
               dbContext.InventoryItem.Remove(new() { InventoryId = product.ProductId});
               dbContext.Product.Remove(new() { ProductId = product.ProductId });
               dbContext.SaveChanges();
               Inventory2CB.Text = "";

         }
         
        
      }

      private void Read_Click(object sender, RoutedEventArgs e)
      {
         //display the names from the inventory when the read button is clicked on
         SqliteConnection connection = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem"
                  , connection
            );

         try
         {
            connection.Open();
            SqliteDataReader datareader = command.ExecuteReader();
            while (datareader.Read())
            {
               
               InventoryLB.Items.Add("Inventory Item Name:");
               InventoryLB.Items.Add(datareader["InventoryName"].ToString());

            }
            datareader.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection.Close();
         }

         
        
      }
   }
}
