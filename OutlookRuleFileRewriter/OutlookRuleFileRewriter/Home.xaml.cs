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

namespace OutlookRuleFileRewriter
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Add_Stories_Click(object sender, RoutedEventArgs e)
        {
            AddStories addStories = new AddStories();
            this.NavigationService.Navigate(addStories);
        }


        private void Remove_Stories_Click(object sender, RoutedEventArgs e)
        {
            RemoveStories removeStories = new RemoveStories();
            this.NavigationService.Navigate(removeStories);
        }
    }
}
