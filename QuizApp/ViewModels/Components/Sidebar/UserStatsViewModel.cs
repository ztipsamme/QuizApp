using CommunityToolkit.Mvvm.ComponentModel;
using QuizApp.Models;

namespace QuizApp.ViewModels.Components.Sidebar;

public partial class UserStatsViewModel: ViewModelBase
{
    [ObservableProperty] private int xp;
    [ObservableProperty] private int matches;
    [ObservableProperty] private int wins;
    [ObservableProperty] private int friends;

    public UserStatsViewModel(User user)
    {
        Xp = user.Xp;
        Matches = user.Matches;
        Wins = user.Wins;
        Friends = user.Friends;
    }
}