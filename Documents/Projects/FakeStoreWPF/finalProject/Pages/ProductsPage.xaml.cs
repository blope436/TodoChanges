using finalProject.Models;
using Microsoft.Data.Sqlite;
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

namespace finalProject.Pages
{
   /// <summary>
   /// Interaction logic for ProductsPage.xaml
   /// </summary>
   public partial class ProductsPage : Page
   {
      //total will be used to calculate the total of each item depending on quantity
      double total = 0;
      //allTotal will be used to caluclate the total for all of the items in the cart
      double allTotal = 0;
      //updateQuantity will be used to remove the items that were purchased from the database
      int updateQuantity = 0;
      //all of the inventory variables will hold the prices for each different items in database
      public string inventory1;
      public string inventory2;
      public string inventory3;
      public string inventory4;
      public string inventory5;
      public string inventory6;
      public string inventory7;
      public string inventory8;
      public string inventory9;
      public string inventory10;
      public string inventory11;
      public string inventory12;
      public string inventory13;
      public string inventory14;
      public string inventory15;
      public string inventory16;
      public string inventory17;
      public string inventory18;
      public string inventory19;
      public string inventory20;
      public string inventory21;
      public string inventory22;
      public string inventory23;
      public string inventory24;
      public string inventory25;
      public string inventory26;
      public string inventory27;
      public string inventory28;
      public string inventory29;
      //all of the product variables will hold the names for each different items in database
      public string product1;
      public string product2;
      public string product3;
      public string product4;
      public string product5;
      public string product6;
      public string product7;
      public string product8;
      public string product9;
      public string product10;
      public string product11;
      public string product12;
      public string product13;
      public string product14;
      public string product15;
      public string product16;
      public string product17;
      public string product18;
      public string product19;
      public string product20;
      public string product21;
      public string product22;
      public string product23;
      public string product24;
      public string product25;
      public string product26;
      public string product27;
      public string product28;
      public string product29;
      //all of the invquant variables will hold the quantities for each different item in database
      public string invquant1;
      public string invquant2;
      public string invquant3;
      public string invquant4;
      public string invquant5;
      public string invquant6;
      public string invquant7;
      public string invquant8;
      public string invquant9;
      public string invquant10;
      public string invquant11;
      public string invquant12;
      public string invquant13;
      public string invquant14;
      public string invquant15;
      public string invquant16;
      public string invquant17;
      public string invquant18;
      public string invquant19;
      public string invquant20;
      public string invquant21;
      public string invquant22;
      public string invquant23;
      public string invquant24;
      public string invquant25;
      public string invquant26;
      public string invquant27;
      public string invquant28;
      public string invquant29;

      public ProductsPage()
      {
         InitializeComponent();
         syncDB();
         productLabel.Foreground = Brushes.DarkRed;
         products.Foreground = Brushes.Blue;
         purchase2.Foreground = Brushes.Blue;
         purchase.Foreground = Brushes.Blue;
         quantityLabel.Foreground = Brushes.Blue;
         quantityLabel2.Foreground = Brushes.Blue;
         cartLabel.Foreground = Brushes.DarkCyan;
      }

      private void syncDB()
      {
         //get the names from the database and display them in the inventory combo box
         using var dbContext = new SQLiteDb();
         var inventory = dbContext.InventoryItem.ToList<InventoryItems>();
         if (inventory is not null)
         {
            InventoryCB.ItemsSource = inventory.Select(i => i.InventoryName);
         }
      }

      private void backButton1_Click(object sender, RoutedEventArgs e)
      {
         //when back button is entered go back to main menu
         this.NavigationService.Navigate(new Main());
      }

      private void add_Click(object sender, RoutedEventArgs e)
      {
         InventoryPage item = new();
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection90 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command90 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 1"
                  , connection90
            );

         try
         {
            connection90.Open();
            SqliteDataReader datareader90 = command90.ExecuteReader();
            while (datareader90.Read())
            {
               invquant1 = datareader90["InventoryQuantity"].ToString();


            }
            datareader90.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection90.Close();
         }
         SqliteConnection connection91 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command91 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 2"
                  , connection91
            );

         try
         {
            connection91.Open();
            SqliteDataReader datareader91 = command91.ExecuteReader();
            while (datareader91.Read())
            {
               invquant3 = datareader91["InventoryQuantity"].ToString();

            }
            datareader91.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection91.Close();
         }
         SqliteConnection connection92 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command92 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 4"
                  , connection92
            );

         try
         {
            connection92.Open();
            SqliteDataReader datareader92 = command92.ExecuteReader();
            while (datareader92.Read())
            {
               invquant4 = datareader92["InventoryQuantity"].ToString();


            }
            datareader92.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection92.Close();
         }
         SqliteConnection connection93 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command93 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 5"
                  , connection93
            );

         try
         {
            connection93.Open();
            SqliteDataReader datareader93 = command93.ExecuteReader();
            while (datareader93.Read())
            {
               invquant5 = datareader93["InventoryQuantity"].ToString();

            }
            datareader93.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection91.Close();
         }
         SqliteConnection connection94 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command94 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 6"
                  , connection94
            );

         try
         {
            connection94.Open();
            SqliteDataReader datareader94 = command94.ExecuteReader();
            while (datareader94.Read())
            {
               invquant6 = datareader94["InventoryQuantity"].ToString();


            }
            datareader94.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection94.Close();
         }
         SqliteConnection connection95 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command95 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 7"
                  , connection95
            );

         try
         {
            connection95.Open();
            SqliteDataReader datareader95 = command95.ExecuteReader();
            while (datareader95.Read())
            {
               invquant7 = datareader95["InventoryQuantity"].ToString();

            }
            datareader95.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection95.Close();
         }
         SqliteConnection connection96 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command96 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 8"
                  , connection96
            );

         try
         {
            connection96.Open();
            SqliteDataReader datareader96 = command96.ExecuteReader();
            while (datareader96.Read())
            {
               invquant8 = datareader96["InventoryQuantity"].ToString();


            }
            datareader96.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection96.Close();
         }
         SqliteConnection connection97 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command97 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 9"
                  , connection97
            );

         try
         {
            connection97.Open();
            SqliteDataReader datareader97 = command97.ExecuteReader();
            while (datareader97.Read())
            {
               invquant9 = datareader97["InventoryQuantity"].ToString();

            }
            datareader97.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection97.Close();
         }
         SqliteConnection connection98 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command98 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 10"
                  , connection98
            );

         try
         {
            connection98.Open();
            SqliteDataReader datareader98 = command98.ExecuteReader();
            while (datareader98.Read())
            {
               invquant10 = datareader98["InventoryQuantity"].ToString();


            }
            datareader98.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection98.Close();
         }
         SqliteConnection connection99 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command99 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 11"
                  , connection99
            );

         try
         {
            connection99.Open();
            SqliteDataReader datareader99 = command99.ExecuteReader();
            while (datareader99.Read())
            {
               invquant11 = datareader99["InventoryQuantity"].ToString();

            }
            datareader99.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection99.Close();
         }
         SqliteConnection connection100 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command100 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 12"
                  , connection100
            );

         try
         {
            connection100.Open();
            SqliteDataReader datareader100 = command100.ExecuteReader();
            while (datareader100.Read())
            {
               invquant12 = datareader100["InventoryQuantity"].ToString();


            }
            datareader100.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection100.Close();
         }
         SqliteConnection connection101 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command101 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 13"
                  , connection101
            );

         try
         {
            connection101.Open();
            SqliteDataReader datareader101 = command101.ExecuteReader();
            while (datareader101.Read())
            {
               invquant13 = datareader101["InventoryQuantity"].ToString();

            }
            datareader101.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection101.Close();
         }
         SqliteConnection connection102 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command102 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 14"
                  , connection102
            );

         try
         {
            connection102.Open();
            SqliteDataReader datareader102 = command102.ExecuteReader();
            while (datareader102.Read())
            {
               invquant14 = datareader102["InventoryQuantity"].ToString();


            }
            datareader102.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection102.Close();
         }
         SqliteConnection connection103 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command103 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 15"
                  , connection103
            );

         try
         {
            connection103.Open();
            SqliteDataReader datareader103 = command103.ExecuteReader();
            while (datareader103.Read())
            {
               invquant15 = datareader103["InventoryQuantity"].ToString();

            }
            datareader103.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection103.Close();
         }
         SqliteConnection connection104 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command104 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 16"
                  , connection104
            );

         try
         {
            connection104.Open();
            SqliteDataReader datareader104 = command104.ExecuteReader();
            while (datareader104.Read())
            {
               invquant16 = datareader104["InventoryQuantity"].ToString();


            }
            datareader104.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection104.Close();
         }
         SqliteConnection connection105 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command105 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 17"
                  , connection105
            );

         try
         {
            connection105.Open();
            SqliteDataReader datareader105 = command105.ExecuteReader();
            while (datareader105.Read())
            {
               invquant17 = datareader105["InventoryQuantity"].ToString();

            }
            datareader105.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection105.Close();
         }
         SqliteConnection connection106 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command106 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 18"
                  , connection106
            );

         try
         {
            connection106.Open();
            SqliteDataReader datareader106 = command106.ExecuteReader();
            while (datareader106.Read())
            {
               invquant18 = datareader106["InventoryQuantity"].ToString();


            }
            datareader106.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection106.Close();
         }
         SqliteConnection connection107 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command107 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 19"
                  , connection107
            );

         try
         {
            connection107.Open();
            SqliteDataReader datareader107 = command107.ExecuteReader();
            while (datareader107.Read())
            {
               invquant19 = datareader107["InventoryQuantity"].ToString();

            }
            datareader107.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection107.Close();
         }
         SqliteConnection connection108 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command108 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 20"
                  , connection108
            );

         try
         {
            connection108.Open();
            SqliteDataReader datareader108 = command108.ExecuteReader();
            while (datareader108.Read())
            {
               invquant20 = datareader108["InventoryQuantity"].ToString();


            }
            datareader108.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection108.Close();
         }
         SqliteConnection connection109 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command109 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 21"
                  , connection109
            );

         try
         {
            connection109.Open();
            SqliteDataReader datareader109 = command109.ExecuteReader();
            while (datareader109.Read())
            {
               invquant21 = datareader109["InventoryQuantity"].ToString();

            }
            datareader109.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection109.Close();
         }
         SqliteConnection connection110 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command110 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 22"
                  , connection110
            );

         try
         {
            connection110.Open();
            SqliteDataReader datareader110 = command110.ExecuteReader();
            while (datareader110.Read())
            {
               invquant22 = datareader110["InventoryQuantity"].ToString();


            }
            datareader110.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection110.Close();
         }
         SqliteConnection connection111 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command111 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 23"
                  , connection111
            );

         try
         {
            connection111.Open();
            SqliteDataReader datareader111 = command111.ExecuteReader();
            while (datareader111.Read())
            {
               invquant23 = datareader111["InventoryQuantity"].ToString();

            }
            datareader111.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection111.Close();
         }
         SqliteConnection connection112 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command112 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 24"
                  , connection112
            );

         try
         {
            connection112.Open();
            SqliteDataReader datareader112 = command112.ExecuteReader();
            while (datareader112.Read())
            {
               invquant24 = datareader112["InventoryQuantity"].ToString();


            }
            datareader112.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection112.Close();
         }
         SqliteConnection connection113 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command113 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 25"
                  , connection113
            );

         try
         {
            connection113.Open();
            SqliteDataReader datareader113 = command113.ExecuteReader();
            while (datareader113.Read())
            {
               invquant25 = datareader113["InventoryQuantity"].ToString();

            }
            datareader113.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection113.Close();
         }
         SqliteConnection connection114 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command114 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 26"
                  , connection114
            );

         try
         {
            connection114.Open();
            SqliteDataReader datareader114 = command114.ExecuteReader();
            while (datareader114.Read())
            {
               invquant26 = datareader114["InventoryQuantity"].ToString();


            }
            datareader114.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection114.Close();
         }
         SqliteConnection connection115 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command115 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 27"
                  , connection115
            );

         try
         {
            connection115.Open();
            SqliteDataReader datareader115 = command115.ExecuteReader();
            while (datareader115.Read())
            {
               invquant27 = datareader115["InventoryQuantity"].ToString();

            }
            datareader115.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection115.Close();
         }
         SqliteConnection connection116 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command116 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 28"
                  , connection116
            );

         try
         {
            connection116.Open();
            SqliteDataReader datareader116 = command116.ExecuteReader();
            while (datareader116.Read())
            {
               invquant28 = datareader116["InventoryQuantity"].ToString();


            }
            datareader116.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection116.Close();
         }
         SqliteConnection connection117 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command117 = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem Where InventoryId == 29"
                  , connection117
            );

         try
         {
            connection117.Open();
            SqliteDataReader datareader117 = command117.ExecuteReader();
            while (datareader117.Read())
            {
               invquant29 = datareader117["InventoryQuantity"].ToString();

            }
            datareader117.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection117.Close();
         }
         
         
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection20 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command20 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 1"
                  , connection20
            );

         try
         {
            connection20.Open();
            SqliteDataReader datareader20 = command20.ExecuteReader();
            while (datareader20.Read())
            {
               inventory1 = datareader20["InventoryPrice"].ToString();
               
               
            }
            datareader20.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection20.Close();
         }
         SqliteConnection connection21 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command21 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 2"
                  , connection21
            );

         try
         {
            connection21.Open();
            SqliteDataReader datareader21 = command21.ExecuteReader();
            while (datareader21.Read())
            {
               inventory2 = datareader21["InventoryPrice"].ToString();
               
            }
            datareader21.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection21.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection22 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command22 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 3"
                  , connection22
            );

         try
         {

            connection22.Open();
            SqliteDataReader datareader22 = command22.ExecuteReader();
            while (datareader22.Read())
            {
               inventory3 = datareader22["InventoryPrice"].ToString();
              

            }
            datareader22.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection22.Close();
         }


         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection23 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command23 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 4"
                  , connection23
            );

         try
         {
            connection23.Open();
            SqliteDataReader datareader23 = command23.ExecuteReader();
            while (datareader23.Read())
            {
               inventory4 = datareader23["InventoryPrice"].ToString();
              

            }
            datareader23.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection23.Close();
         }

         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection24 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command24 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 5"
                  , connection24
            );

         try
         {

            connection24.Open();
            SqliteDataReader datareader24 = command24.ExecuteReader();
            while (datareader24.Read())
            {
               inventory5 = datareader24["InventoryPrice"].ToString();
               

            }
            datareader24.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection24.Close();
         }

         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection25 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command25 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 6"
                  , connection25
            );

         try
         {
            connection25.Open();
            SqliteDataReader datareader25 = command25.ExecuteReader();
            while (datareader25.Read())
            {
               inventory6 = datareader25["InventoryPrice"].ToString();
               

            }
            datareader25.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection25.Close();
         }
         SqliteConnection connection26 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command26 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 7"
                  , connection26
            );

         try
         {

            connection26.Open();
            SqliteDataReader datareader26 = command26.ExecuteReader();
            while (datareader26.Read())
            {
               inventory7 = datareader26["InventoryPrice"].ToString();
              

            }
            datareader26.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection26.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection27 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command27 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 8"
                  , connection27
            );

         try
         {
            connection27.Open();
            SqliteDataReader datareader27 = command27.ExecuteReader();
            while (datareader27.Read())
            {
               inventory8 = datareader27["InventoryPrice"].ToString();
               

            }
            datareader27.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection27.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection28 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command28 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 9"
                  , connection28
            );

         try
         {

            connection28.Open();
            SqliteDataReader datareader28 = command28.ExecuteReader();
            while (datareader28.Read())
            {
               inventory9 = datareader28["InventoryPrice"].ToString();
               

            }
            datareader28.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection28.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection29 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command29 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 10"
                  , connection29
            );

         try
         {
            connection29.Open();
            SqliteDataReader datareader29 = command29.ExecuteReader();
            while (datareader29.Read())
            {
               inventory10 = datareader29["InventoryPrice"].ToString();
               

            }
            datareader29.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection29.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection30 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command30 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 11"
                  , connection30
            );

         try
         {

            connection30.Open();
            SqliteDataReader datareader30 = command30.ExecuteReader();
            while (datareader30.Read())
            {
               inventory11 = datareader30["InventoryPrice"].ToString();
              

            }
            datareader30.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection30.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection31 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command31 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 12"
                  , connection31
            );

         try
         {
            connection31.Open();
            SqliteDataReader datareader31 = command31.ExecuteReader();
            while (datareader31.Read())
            {
               inventory12 = datareader31["InventoryPrice"].ToString();
             

            }
            datareader31.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection31.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection33 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command33 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 13"
                  , connection33
            );

         try
         {
            connection33.Open();
            SqliteDataReader datareader33 = command33.ExecuteReader();
            while (datareader33.Read())
            {
               inventory13 = datareader33["InventoryPrice"].ToString();
             

            }
            datareader33.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection33.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection34 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command34 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 14"
                  , connection34
            );

         try
         {

            connection34.Open();
            SqliteDataReader datareader34 = command34.ExecuteReader();
            while (datareader34.Read())
            {
               inventory14 = datareader34["InventoryPrice"].ToString();
              

            }
            datareader34.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection34.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection35 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command35 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 15"
                  , connection35
            );

         try
         {
            connection35.Open();
            SqliteDataReader datareader35 = command35.ExecuteReader();
            while (datareader35.Read())
            {
               inventory15 = datareader35["InventoryPrice"].ToString();
               

            }
            datareader35.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection35.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection36 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command36 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 16"
                  , connection36
            );

         try
         {

            connection36.Open();
            SqliteDataReader datareader36 = command36.ExecuteReader();
            while (datareader36.Read())
            {
               inventory16 = datareader36["InventoryPrice"].ToString();
              

            }
            datareader36.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection36.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection37 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command37 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 17"
                  , connection37
            );

         try
         {
            connection37.Open();
            SqliteDataReader datareader37 = command37.ExecuteReader();
            while (datareader37.Read())
            {
               inventory17 = datareader37["InventoryPrice"].ToString();
              

            }
            datareader37.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection37.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection38 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command38 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 18"
                  , connection38
            );

         try
         {

            connection38.Open();
            SqliteDataReader datareader38 = command38.ExecuteReader();
            while (datareader38.Read())
            {
               inventory18 = datareader38["InventoryPrice"].ToString();
              

            }
            datareader38.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection38.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection39 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command39 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 19"
                  , connection39
            );

         try
         {
            connection39.Open();
            SqliteDataReader datareader39 = command39.ExecuteReader();
            while (datareader39.Read())
            {
               inventory19 = datareader39["InventoryPrice"].ToString();
               

            }
            datareader39.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection39.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection40 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command40 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 20"
                  , connection40
            );

         try
         {

            connection40.Open();
            SqliteDataReader datareader40 = command40.ExecuteReader();
            while (datareader40.Read())
            {
               inventory20 = datareader40["InventoryPrice"].ToString();
              

            }
            datareader40.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection40.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection41 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command41 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 21"
                  , connection41
            );

         try
         {
            connection41.Open();
            SqliteDataReader datareader41 = command41.ExecuteReader();
            while (datareader41.Read())
            {
               inventory21 = datareader41["InventoryPrice"].ToString();
              

            }
            datareader41.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection41.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection42 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command42 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 22"
                  , connection42
            );

         try
         {

            connection42.Open();
            SqliteDataReader datareader42 = command42.ExecuteReader();
            while (datareader42.Read())
            {
               inventory22 = datareader42["InventoryPrice"].ToString();
               

            }
            datareader42.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection42.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection43 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command43 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 23"
                  , connection43
            );

         try
         {
            connection43.Open();
            SqliteDataReader datareader43 = command43.ExecuteReader();
            while (datareader43.Read())
            {
               inventory23 = datareader43["InventoryPrice"].ToString();
               

            }
            datareader43.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection43.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection44 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command44 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 24"
                  , connection44
            );

         try
         {

            connection44.Open();
            SqliteDataReader datareader44 = command44.ExecuteReader();
            while (datareader44.Read())
            {
               inventory24 = datareader44["InventoryPrice"].ToString();
              

            }
            datareader44.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection44.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection45 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command45 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 25"
                  , connection45
            );

         try
         {
            connection45.Open();
            SqliteDataReader datareader45 = command45.ExecuteReader();
            while (datareader45.Read())
            {
               inventory25 = datareader45["InventoryPrice"].ToString();
              

            }
            datareader45.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection45.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection46 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command46 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 26"
                  , connection46
            );

         try
         {

            connection46.Open();
            SqliteDataReader datareader46 = command46.ExecuteReader();
            while (datareader46.Read())
            {
               inventory26 = datareader46["InventoryPrice"].ToString();
               

            }
            datareader46.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection46.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection47 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command47 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 27"
                  , connection47
            );

         try
         {
            connection47.Open();
            SqliteDataReader datareader47 = command47.ExecuteReader();
            while (datareader47.Read())
            {
               inventory27 = datareader47["InventoryPrice"].ToString();
               

            }
            datareader47.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection47.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection48 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command48 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 28"
                  , connection48
            );

         try
         {

            connection48.Open();
            SqliteDataReader datareader48 = command48.ExecuteReader();
            while (datareader48.Read())
            {
               inventory28 = datareader48["InventoryPrice"].ToString();
              

            }
            datareader48.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection48.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection49 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command49 = new SqliteCommand
            (
                  "SELECT InventoryPrice From InventoryItem Where InventoryId == 29"
                  , connection49
            );

         try
         {
            connection49.Open();
            SqliteDataReader datareader49 = command49.ExecuteReader();
            while (datareader49.Read())
            {
               inventory29 = datareader49["InventoryPrice"].ToString();
              

            }
            datareader49.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection49.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //EnD--------------------------------------------------------------------------------------------------
         SqliteConnection connection60 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command60 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 1"
                  , connection60
            );

         try
         {
            connection60.Open();
            SqliteDataReader datareader60 = command60.ExecuteReader();
            while (datareader60.Read())
            {
               product1 = datareader60["InventoryName"].ToString();

            }
            datareader60.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection60.Close();
         }

         SqliteConnection connection61 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command61 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 2"
                  , connection61
            );

         try
         {
            connection61.Open();
            SqliteDataReader datareader61 = command61.ExecuteReader();
            while (datareader61.Read())
            {
               product2 = datareader61["InventoryName"].ToString();
               
            }
            datareader61.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection61.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection62 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command62 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 3"
                  , connection62
            );

         try
         {

            connection62.Open();
            SqliteDataReader datareader62 = command62.ExecuteReader();
            while (datareader62.Read())
            {
               product3 = datareader62["InventoryName"].ToString();
               

            }
            datareader62.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection62.Close();
         }


         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection63 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command63 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 4"
                  , connection63
            );

         try
         {
            connection63.Open();
            SqliteDataReader datareader63 = command63.ExecuteReader();
            while (datareader63.Read())
            {
               product4 = datareader63["InventoryName"].ToString();
              

            }
            datareader63.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection63.Close();
         }

         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection64 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command64 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 5"
                  , connection64
            );

         try
         {

            connection64.Open();
            SqliteDataReader datareader64 = command64.ExecuteReader();
            while (datareader64.Read())
            {
               product5 = datareader64["InventoryName"].ToString();
             

            }
            datareader64.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection64.Close();
         }

         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection65 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command65 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 6"
                  , connection65
            );

         try
         {
            connection65.Open();
            SqliteDataReader datareader65 = command65.ExecuteReader();
            while (datareader65.Read())
            {
               product6 = datareader65["InventoryName"].ToString();
               

            }
            datareader65.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection65.Close();
         }
         SqliteConnection connection66 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command66 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 7"
                  , connection66
            );

         try
         {

            connection66.Open();
            SqliteDataReader datareader66 = command66.ExecuteReader();
            while (datareader66.Read())
            {
               product7 = datareader66["InventoryName"].ToString();
              

            }
            datareader66.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection66.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection67 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command67 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 8"
                  , connection67
            );

         try
         {
            connection67.Open();
            SqliteDataReader datareader67 = command67.ExecuteReader();
            while (datareader67.Read())
            {
               product8 = datareader67["InventoryName"].ToString();
               

            }
            datareader67.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection67.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection68 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command68 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 9"
                  , connection68
            );

         try
         {

            connection68.Open();
            SqliteDataReader datareader68 = command68.ExecuteReader();
            while (datareader68.Read())
            {
               product9 = datareader68["InventoryName"].ToString();
               

            }
            datareader68.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection68.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection69 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command69 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 10"
                  , connection69
            );

         try
         {
            connection69.Open();
            SqliteDataReader datareader69 = command69.ExecuteReader();
            while (datareader69.Read())
            {
               product10 = datareader69["InventoryName"].ToString();
              

            }
            datareader69.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection69.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection70 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command70 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 11"
                  , connection70
            );

         try
         {

            connection70.Open();
            SqliteDataReader datareader70 = command70.ExecuteReader();
            while (datareader70.Read())
            {
               product11 = datareader70["InventoryName"].ToString();
               

            }
            datareader70.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection70.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection71 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command71 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 12"
                  , connection71
            );

         try
         {
            connection71.Open();
            SqliteDataReader datareader71 = command71.ExecuteReader();
            while (datareader71.Read())
            {
               product12 = datareader71["InventoryName"].ToString();
               

            }
            datareader71.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection71.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection73 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command73 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 13"
                  , connection73
            );

         try
         {
            connection33.Open();
            SqliteDataReader datareader73 = command33.ExecuteReader();
            while (datareader73.Read())
            {
               product13 = datareader73["InventoryName"].ToString();
              

            }
            datareader73.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection73.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection74 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command74 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 14"
                  , connection74
            );

         try
         {

            connection74.Open();
            SqliteDataReader datareader74 = command74.ExecuteReader();
            while (datareader74.Read())
            {
               product14 = datareader74["InventoryName"].ToString();
               

            }
            datareader74.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection74.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection75 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command75 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 15"
                  , connection75
            );

         try
         {
            connection75.Open();
            SqliteDataReader datareader75 = command75.ExecuteReader();
            while (datareader75.Read())
            {
               product15 = datareader75["InventoryName"].ToString();
               

            }
            datareader75.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection75.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection76 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command76 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 16"
                  , connection76
            );

         try
         {

            connection76.Open();
            SqliteDataReader datareader76 = command76.ExecuteReader();
            while (datareader76.Read())
            {
               product16 = datareader76["InventoryName"].ToString();
               

            }
            datareader76.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection76.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection77 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command77 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 17"
                  , connection77
            );

         try
         {
            connection77.Open();
            SqliteDataReader datareader77 = command77.ExecuteReader();
            while (datareader77.Read())
            {
               product17 = datareader77["InventoryName"].ToString();
              

            }
            datareader77.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection77.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection78 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command78 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 18"
                  , connection78
            );

         try
         {

            connection78.Open();
            SqliteDataReader datareader78 = command78.ExecuteReader();
            while (datareader78.Read())
            {
               product18 = datareader78["InventoryName"].ToString();
              

            }
            datareader78.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection78.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection79 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command79 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 19"
                  , connection79
            );

         try
         {
            connection79.Open();
            SqliteDataReader datareader79 = command79.ExecuteReader();
            while (datareader79.Read())
            {
               product19 = datareader79["InventoryName"].ToString();
               

            }
            datareader79.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection79.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection80 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command80 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 20"
                  , connection80
            );

         try
         {

            connection80.Open();
            SqliteDataReader datareader80 = command80.ExecuteReader();
            while (datareader80.Read())
            {
               product20 = datareader80["InventoryName"].ToString();
               

            }
            datareader80.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection80.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection81 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command81 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 21"
                  , connection81
            );

         try
         {
            connection81.Open();
            SqliteDataReader datareader81 = command81.ExecuteReader();
            while (datareader81.Read())
            {
               product21 = datareader81["InventoryName"].ToString();
               

            }
            datareader81.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection81.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection82 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command82 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 22"
                  , connection82
            );

         try
         {

            connection82.Open();
            SqliteDataReader datareader82 = command82.ExecuteReader();
            while (datareader82.Read())
            {
               product22 = datareader82["InventoryName"].ToString();
               

            }
            datareader82.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection82.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection83 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command83 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 23"
                  , connection83
            );

         try
         {
            connection83.Open();
            SqliteDataReader datareader83 = command83.ExecuteReader();
            while (datareader83.Read())
            {
               product23 = datareader83["InventoryName"].ToString();
               

            }
            datareader83.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection83.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection84 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command84 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 24"
                  , connection84
            );

         try
         {

            connection84.Open();
            SqliteDataReader datareader84 = command84.ExecuteReader();
            while (datareader84.Read())
            {
               product24 = datareader84["InventoryName"].ToString();
               

            }
            datareader84.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection84.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection85 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command85 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 25"
                  , connection85
            );

         try
         {
            connection85.Open();
            SqliteDataReader datareader85 = command85.ExecuteReader();
            while (datareader85.Read())
            {
               product25 = datareader85["InventoryName"].ToString();
               

            }
            datareader85.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection85.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection86 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command86 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 26"
                  , connection86
            );

         try
         {

            connection86.Open();
            SqliteDataReader datareader86 = command86.ExecuteReader();
            while (datareader86.Read())
            {
               product26 = datareader86["InventoryName"].ToString();
               

            }
            datareader86.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection86.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection87 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command87 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 27"
                  , connection87
            );

         try
         {
            connection87.Open();
            SqliteDataReader datareader87 = command87.ExecuteReader();
            while (datareader87.Read())
            {
               product27 = datareader87["InventoryName"].ToString();
               

            }
            datareader87.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection87.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection88 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command88 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 28"
                  , connection88
            );

         try
         {

            connection88.Open();
            SqliteDataReader datareader88 = command88.ExecuteReader();
            while (datareader88.Read())
            {
               product28 = datareader88["InventoryName"].ToString();
              

            }
            datareader88.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection88.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         SqliteConnection connection89 = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command89 = new SqliteCommand
            (
                  "SELECT InventoryName From InventoryItem Where InventoryId == 29"
                  , connection89
            );

         try
         {
            connection89.Open();
            SqliteDataReader datareader89 = command89.ExecuteReader();
            while (datareader89.Read())
            {
               product29 = datareader89["InventoryName"].ToString();

               


            }
            datareader89.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection89.Close();
         }
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------
         //-----------------------------------------------------------------------------------------------------      
         if (InventoryCB.Text == "" && quantity.Text == "")
         {
            MessageBox.Show("No items to add");
         }
        
         SqliteConnection connection = new SqliteConnection("Data Source=store.sqlite");
         SqliteCommand command = new SqliteCommand
            (
                  "SELECT InventoryQuantity From InventoryItem"
                  , connection
            );

         try
         {
            connection.Open();
            SqliteDataReader datareader2 = command.ExecuteReader();
            while (datareader2.Read())
            {
               item.quantity = datareader2["InventoryQuantity"].ToString();

               

               if (InventoryCB.Text != "" && quantity.Text != "" && int.Parse(quantity.Text) > int.Parse(item.quantity.ToString()))
               {


                  MessageBox.Show($"Item not added not enough inventory to complete order. Quantity available:{item.quantity.ToString()}");

               }

            }
            datareader2.Close();
         }
         catch (SqliteException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            connection.Close();
         }

         //-----------------------------------------------------------------------------------------------------

         SqliteConnection connection2 = new SqliteConnection("Data Source=store.sqlite");
            SqliteCommand command2 = new SqliteCommand
               (
                     "SELECT InventoryPrice From InventoryItem"
                     , connection2
               );


            try
            {
               connection2.Open();
               SqliteDataReader datareader3 = command2.ExecuteReader();
            
            while (datareader3.Read())
               {
               
               item.price = datareader3["InventoryPrice"].ToString();
               //update the quantity in the database
               if (product1 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory1;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 1, InventoryNumber = item.inventoryNumber.Text, InventoryName = product1, InventoryPrice = inventory1, InventoryQuantity = updateQuantity.ToString(), ProductId = 1 });
                  dbContext.SaveChanges();


               }
               if (product2 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory2;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 2, InventoryNumber = item.inventoryNumber.Text, InventoryName = product2, InventoryPrice = inventory2, InventoryQuantity = updateQuantity.ToString(), ProductId = 2 });
                  dbContext.SaveChanges();


               }
               if (product3 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory3;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 3, InventoryNumber = item.inventoryNumber.Text, InventoryName = product3, InventoryPrice = inventory3, InventoryQuantity = updateQuantity.ToString(), ProductId = 3 });
                  dbContext.SaveChanges();

               }

               if (product4 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory4;
                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 4, InventoryNumber = item.inventoryNumber.Text, InventoryName = product4, InventoryPrice = inventory4, InventoryQuantity = updateQuantity.ToString(), ProductId = 4 });
                  dbContext.SaveChanges();

               }
               if (product5 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory5;
                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 5, InventoryNumber = item.inventoryNumber.Text, InventoryName = product5, InventoryPrice = inventory5, InventoryQuantity = updateQuantity.ToString(), ProductId = 5 });
                  dbContext.SaveChanges();

               }
               if (product6 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory6;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 6, InventoryNumber = item.inventoryNumber.Text, InventoryName = product6, InventoryPrice = inventory6, InventoryQuantity = updateQuantity.ToString(), ProductId = 6 });
                  dbContext.SaveChanges();
               }
               if (product7 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory7;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 7, InventoryNumber = item.inventoryNumber.Text, InventoryName = product7, InventoryPrice = inventory7, InventoryQuantity = updateQuantity.ToString(), ProductId = 7 });
                  dbContext.SaveChanges();
               }

               if (product8 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory8;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 8, InventoryNumber = item.inventoryNumber.Text, InventoryName = product8, InventoryPrice = inventory8, InventoryQuantity = updateQuantity.ToString(), ProductId = 8 });
                  dbContext.SaveChanges();
               }
               if (product9 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory9;
                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 9, InventoryNumber = item.inventoryNumber.Text, InventoryName = product9, InventoryPrice = inventory9, InventoryQuantity = updateQuantity.ToString(), ProductId = 9 });
                  dbContext.SaveChanges();

               }
               if (product10 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory10;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 10, InventoryNumber = item.inventoryNumber.Text, InventoryName = product10, InventoryPrice = inventory10, InventoryQuantity = updateQuantity.ToString(), ProductId = 10 });
                  dbContext.SaveChanges();
               }
               if (product11 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory11;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 11, InventoryNumber = item.inventoryNumber.Text, InventoryName = product11, InventoryPrice = inventory11, InventoryQuantity = updateQuantity.ToString(), ProductId = 11 });
                  dbContext.SaveChanges();
               }

               if (product12 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory12;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 12, InventoryNumber = item.inventoryNumber.Text, InventoryName = product12, InventoryPrice = inventory12, InventoryQuantity = updateQuantity.ToString(), ProductId = 12 });
                  dbContext.SaveChanges();
               }
               if (product13 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory13;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 13, InventoryNumber = item.inventoryNumber.Text, InventoryName = product13, InventoryPrice = inventory13, InventoryQuantity = updateQuantity.ToString(), ProductId = 13 });
                  dbContext.SaveChanges();
               }
               if (product14 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory14;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 14, InventoryNumber = item.inventoryNumber.Text, InventoryName = product14, InventoryPrice = inventory14, InventoryQuantity = updateQuantity.ToString(), ProductId = 14 });
                  dbContext.SaveChanges();
               }
               if (product15 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory15;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 15, InventoryNumber = item.inventoryNumber.Text, InventoryName = product15, InventoryPrice = inventory15, InventoryQuantity = updateQuantity.ToString(), ProductId = 15 });
                  dbContext.SaveChanges();
               }

               if (product16 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory16;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 16, InventoryNumber = item.inventoryNumber.Text, InventoryName = product16, InventoryPrice = inventory16, InventoryQuantity = updateQuantity.ToString(), ProductId = 16 });
                  dbContext.SaveChanges();
               }
               if (product17 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory17;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 17, InventoryNumber = item.inventoryNumber.Text, InventoryName = product17, InventoryPrice = inventory17, InventoryQuantity = updateQuantity.ToString(), ProductId = 17 });
                  dbContext.SaveChanges();
               }
               if (product18 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory18;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 18, InventoryNumber = item.inventoryNumber.Text, InventoryName = product18, InventoryPrice = inventory18, InventoryQuantity = updateQuantity.ToString(), ProductId = 18 });
                  dbContext.SaveChanges();
               }
               if (product19 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory19;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 19, InventoryNumber = item.inventoryNumber.Text, InventoryName = product19, InventoryPrice = inventory19, InventoryQuantity = updateQuantity.ToString(), ProductId = 19 });
                  dbContext.SaveChanges();
               }

               if (product20 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory20;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 20, InventoryNumber = item.inventoryNumber.Text, InventoryName = product20, InventoryPrice = inventory20, InventoryQuantity = updateQuantity.ToString(), ProductId = 20 });
                  dbContext.SaveChanges();
               }
               if (product21 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory21;
                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 21, InventoryNumber = item.inventoryNumber.Text, InventoryName = product21, InventoryPrice = inventory21, InventoryQuantity = updateQuantity.ToString(), ProductId = 21 });
                  dbContext.SaveChanges();

               }
               if (product22 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory22;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 22, InventoryNumber = item.inventoryNumber.Text, InventoryName = product22, InventoryPrice = inventory22, InventoryQuantity = updateQuantity.ToString(), ProductId = 22 });
                  dbContext.SaveChanges();
               }
               if (product23 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory23;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 23, InventoryNumber = item.inventoryNumber.Text, InventoryName = product23, InventoryPrice = inventory23, InventoryQuantity = updateQuantity.ToString(), ProductId = 23 });
                  dbContext.SaveChanges();
               }
               if (product24 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory24;
                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 24, InventoryNumber = item.inventoryNumber.Text, InventoryName = product24, InventoryPrice = inventory24, InventoryQuantity = updateQuantity.ToString(), ProductId = 24 });
                  dbContext.SaveChanges();

               }
               if (product25 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory25;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 25, InventoryNumber = item.inventoryNumber.Text, InventoryName = product25, InventoryPrice = inventory25, InventoryQuantity = updateQuantity.ToString(), ProductId = 25 });
                  dbContext.SaveChanges();
               }
               if (product26 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory26;
                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 26, InventoryNumber = item.inventoryNumber.Text, InventoryName = product26, InventoryPrice = inventory26, InventoryQuantity = updateQuantity.ToString(), ProductId = 26 });
                  dbContext.SaveChanges();

               }
               if (product27 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory27;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 27, InventoryNumber = item.inventoryNumber.Text, InventoryName = product27, InventoryPrice = inventory27, InventoryQuantity = updateQuantity.ToString(), ProductId = 27 });
                  dbContext.SaveChanges();
               }
               if (product28 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory28;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 28, InventoryNumber = item.inventoryNumber.Text, InventoryName = product28, InventoryPrice = inventory28, InventoryQuantity = updateQuantity.ToString(), ProductId = 28 });
                  dbContext.SaveChanges();
               }
               if (product29 == InventoryCB.Text && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
               {
                  item.price = inventory29;

                  updateQuantity = int.Parse(invquant1) - int.Parse(quantity.Text);
                  using var dbContext = new SQLiteDb();
                  dbContext.InventoryItem.Update(new() { InventoryId = 29, InventoryNumber = item.inventoryNumber.Text, InventoryName = product29, InventoryPrice = inventory29, InventoryQuantity = updateQuantity.ToString(), ProductId = 29 });
                  dbContext.SaveChanges();
               }
               //caluclate the total for one item
               total = double.Parse(item.price.ToString()) * int.Parse(quantity.Text);
               //calculate all of the total
               allTotal += total; 

               if ( InventoryCB.Text != "" && quantity.Text != "" && CartLB.Items.IndexOf(InventoryCB.SelectedItem.ToString()) == -1 && int.Parse(quantity.Text) < int.Parse(item.quantity.ToString()))
                  {

                     InventoryItems items = new();
                  //display the cart in the list box
                     CartLB.Items.Add("Product:");
                     CartLB.Items.Add(InventoryCB.Text);
                     CartLB.Items.Add("Quantity:");
                     CartLB.Items.Add(quantity.Text);
                     CartLB.Items.Add("Price (For 1 item):");

                     CartLB.Items.Add($"${ item.price.ToString()}");
                     CartLB.Items.Add("Total:");
                     CartLB.Items.Add($"${total.ToString()}");
                     
                     CartLB.Items.Add("Total of order:");
                     CartLB.Items.Add($"${allTotal.ToString()}");
               }


               }
            
            datareader3.Close();
            }
            catch (SqliteException ex)
            {
               MessageBox.Show(ex.Message);
            }
            finally
            {
               connection2.Close();
            }
         

      }

      private void cancel2_Click(object sender, RoutedEventArgs e)
      {
         InventoryCB.Text = "";
         quantity.Text = "";
         
      }

      private void Checkout_Click(object sender, RoutedEventArgs e)
      {
         InventoryPage item2 = new();
         if (CartLB.Items.IsEmpty)
         {
            MessageBox.Show("No items in the cart");
         }
         else
         {
            using var dbContext = new SQLiteDb();
            MessageBox.Show($"order has been saved to database");
            //the list will be used in a foreach to save all of the contents of the listbox and display them in a message box
            List<String> list = new();
            string string1 = null;
            foreach (var item in CartLB.Items)
            {
               list.Add(item.ToString());
               string1 += item + "\r\n";
            }
            
            dbContext.Order.Add(new() { OrderName = string1, orderQuantity = string1, orderTotal = string1 });
            dbContext.SaveChanges();
            
            MessageBox.Show($"Items Purchased:\n{string1}\nPurchase Complete!");
            InventoryCB.Text = "";
            quantity.Text = "";
            CartLB.Items.Clear();
            
         }
         

      }

      private void Clear_Click(object sender, RoutedEventArgs e)
      {
         if (CartLB.Items.IsEmpty)
         {
            MessageBox.Show("No items in the cart to clear");
         }
         else
         {
            CartLB.Items.Clear();
         }
      }
   }
}
