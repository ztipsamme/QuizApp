using CommunityToolkit.Mvvm.ComponentModel;
using QuizApp.Models;

namespace QuizApp.ViewModels.Components.Sidebar
{
    public partial class UserProfileViewModel : ViewModelBase
    {
        [ObservableProperty] private string name;
        [ObservableProperty] private string tagline;

        public UserProfileViewModel(User user)
        {
            Name = user.DisplayName;
            Tagline = user.Tagline;
        }
    }
}