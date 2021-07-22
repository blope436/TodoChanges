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

namespace WPFForm
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
         //This will change the color of text and font size
         calender.Foreground = Brushes.OrangeRed;
         calender.FontSize = 25;
         //modify the login button
         loginButton.FontSize = 25;
         loginButton.Background = Brushes.LightSteelBlue;
         loginButton.Foreground = Brushes.Chocolate;
         //modify the cancel button
         cancelButton.FontSize = 25;
         cancelButton.Background = Brushes.LightSteelBlue;
         cancelButton.Foreground = Brushes.Chocolate;
         //modify the top text and text that tells user to fill the form
         text.FontSize = 30;
         text.Foreground = Brushes.LightSkyBlue;
         text.TextDecorations = TextDecorations.Underline;
         access.FontSize = 30;
         access.Foreground = Brushes.Red;
         //modify elements of the textbox
         textBox.FontSize = 15;
         textBox.Background = Brushes.LightYellow;
         textBox.Foreground = Brushes.Red;
         atext.FontSize = 25;
         atext.Foreground = Brushes.Aqua;
         //modify the radio buttons
         radio.FontSize = 22;
         radio.Foreground = Brushes.DarkRed;

         radios.FontSize = 22;
         radios.Foreground = Brushes.IndianRed;
         //modify the password box
         password.FontSize = 25;
         password.Foreground = Brushes.Aqua;
         pass.Background = Brushes.LightYellow;

      }

      private void loginButton_Click(object sender, RoutedEventArgs e)
      {
         //Print message when the login button is clicked on, and clear when ok is entered
         MessageBox.Show($"{textBox.Text} Is the username that was entered.\nForm Submitted!");
         textBox.Clear();
         pass.Clear();
         //uncheck the radio buttons when the form is submitted
         radio1.IsChecked=false;
         radio2.IsChecked = false;

         radiobutton.IsChecked = false;
         radiobutton2.IsChecked = false;


      }

      private void cancelButton_Click(object sender, RoutedEventArgs e)
      {
         //clear information when the cancel button is entered
         textBox.Clear();
         pass.Clear();
         radio1.IsChecked = false;
         radio2.IsChecked = false;

         radiobutton.IsChecked = false;
         radiobutton2.IsChecked = false;

      }

      


   }
}
