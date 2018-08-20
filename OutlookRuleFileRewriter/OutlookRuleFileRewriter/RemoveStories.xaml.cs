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
    /// Interaction logic for RemoveStories.xaml
    /// </summary>
    public partial class RemoveStories : Page
    {
        public RemoveStories()
        {
            InitializeComponent();
            DataContext = new ViewModels.RemoveStories(stories);
        }

        string[] stories = new string[] { "XP-7102", "XP-6345", "XP-3479"};

        private void PopulateStoriesListBox()
        {
            stories.Select(s => storiesListBox.Items.Add(s));            
        }

        private void Remove_Stories_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
