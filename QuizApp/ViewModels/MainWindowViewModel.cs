using CommunityToolkit.Mvvm.ComponentModel;
using QuizApp.Models;
using QuizApp.ViewModels.Components.Sidebar;
using QuizApp.ViewModels.Pages;

namespace QuizApp.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ViewModelBase _currentPage = new HomePageViewModel();
        public SidebarLeftViewModel SidebarLeft { get; }
        public SidebarRightViewModel SidebarRight { get; }

        public MainWindowViewModel()
        {
            // Mock login
            var mockUser = new User("anna123", "Anna Andersson", "En motiverande text");
            SidebarRight = new SidebarRightViewModel(mockUser);
            
            SidebarLeft = new SidebarLeftViewModel(this, mockUser);

        }
    }
}