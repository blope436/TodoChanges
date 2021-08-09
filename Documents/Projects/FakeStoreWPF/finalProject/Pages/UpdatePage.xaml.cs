using finalProject.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace finalProject.Pages
{
   /// <summary>
   /// Interaction logic for UpdatePage.xaml
   /// </summary>
   public partial class UpdatePage : Page
   {
      public UpdatePage()
      {
         InitializeComponent();
         productLabel30.Foreground = Brushes.DarkRed;
         productLabel40.Foreground = Brushes.Blue;
      }

      private void update_Click(object sender, RoutedEventArgs e)
      {
         if (inventoryNumber30.Text != "")
         {
            using var dbContext = new SQLiteDb();
            dbContext.InventoryItem.Update(new() { InventoryId = int.Parse(inventoryNumber30.Text), InventoryNumber = inventoryNumber31.Text, InventoryName = inventoryName32.Text, InventoryPrice = inventoryPrice33.Text, InventoryQuantity = inventoryQuantity34.Text, ProductId = int.Parse(inventoryNumber30.Text) });
            dbContext.SaveChanges();
            MessageBox.Show("Database has been updated!");
            inventoryNumber30.Text = "";
            inventoryNumber31.Text = "";
            inventoryName32.Text = "";
            inventoryPrice33.Text = "";
            inventoryQuantity34.Text = "";
            inventoryNumber30.Text = "";
         }
        
      }

      private void backButton20_Click(object sender, RoutedEventArgs e)
      {
         this.NavigationService.Navigate(new Main());
      }

      private void showInventory_Click(object sender, RoutedEventArgs e)
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
              
                  InventoryLB2.Items.Add("Inventory Item Name:");
                  InventoryLB2.Items.Add(datareader["InventoryName"].ToString());
               

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

      private void Cancel2_Click(object sender, RoutedEventArgs e)
      {
         inventoryNumber30.Clear();
         inventoryNumber31.Clear();
         inventoryName32.Clear();
         inventoryPrice33.Clear();
         inventoryQuantity34.Clear();
        
      }
   }
}
