using QuizApp.Models;
using QuizApp.ViewModels;

namespace QuizApp.ViewModels.Components.Sidebar
{
    public partial class SidebarLeftViewModel : ViewModelBase
    {
        public NavigationViewModel Navigation { get; }


        public SidebarLeftViewModel(MainWindowViewModel mainWindow, User user)
        {
            Navigation = new NavigationViewModel(mainWindow, user);
        }
    }
}