using CommunityToolkit.Mvvm.ComponentModel;
using QuizApp.Models;

namespace QuizApp.ViewModels.Components.Sidebar
{
    public partial class SidebarRightViewModel : ViewModelBase
    {
        public UserProfileViewModel Profile { get; }
        public UserStatsViewModel Stats { get; }

        public SidebarRightViewModel(User user)
        {
            Profile = new UserProfileViewModel(user);
            Stats = new UserStatsViewModel(user);
        }
    }
}