using OutlookRuleFileRewriter.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace OutlookRuleFileRewriter.ViewModels
{
  public class RemoveStories
  {
    public ObservableCollection<UserStory> UserStories { get; set; }

    public RemoveStories()
    {
      UserStories = new ObservableCollection<UserStory>();
    }

    public RemoveStories(string[] stories)
    {
      UserStories = new ObservableCollection<UserStory>();
      foreach(string storyNumber in stories)
      {
        UserStories.Add(new UserStory { StoryNumber = storyNumber });
      }
    }
  }
}
