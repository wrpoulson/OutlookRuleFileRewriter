using OutlookRuleFileRewriter.Models;
using System.Collections.ObjectModel;

namespace OutlookRuleFileRewriter.ViewModels
{
  public class AddStories
  {
    public ObservableCollection<UserStory> People { get; set; }

    public AddStories()
    {
      People = new ObservableCollection<UserStory>();
    }
  }
}
