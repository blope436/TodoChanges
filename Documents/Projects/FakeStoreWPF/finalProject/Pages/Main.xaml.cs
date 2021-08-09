using finalProject.Models;
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
   /// Interaction logic for Main.xaml
   /// </summary>
   public partial class Main : Page
   {
      public Main()
      {
         InitializeComponent();
      }

     

      private void productsButton_Click(object sender, RoutedEventArgs e)
      {
         this.NavigationService.Navigate(new ProductsPage());
      }

      private void inventoryButton_Click(object sender, RoutedEventArgs e)
      {
         this.NavigationService.Navigate(new InventoryPage());
      }

      private void updateButton_Click(object sender, RoutedEventArgs e)
      {
         this.NavigationService.Navigate(new UpdatePage());
      }
   }
}
