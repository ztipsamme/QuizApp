using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizApp.Models;
using QuizApp.ViewModels.Pages;

namespace QuizApp.ViewModels.Components.Sidebar;

public partial class NavigationViewModel : ViewModelBase
{
    private readonly MainWindowViewModel _mainWindow;

    public NavigationViewModel(MainWindowViewModel mainWindow, User user)
    {
        _mainWindow = mainWindow;

        NavItems = new()
        {
            new NavItemTemplate("Hem", typeof(HomePageViewModel),
                SelectItem),
            new NavItemTemplate("Spela Quiz", typeof(PlayQuizPageViewModel),
                SelectItem),
            new NavItemTemplate("Mina Quiz", typeof(MyQuizzesPageViewModel),
                SelectItem)
        };
    }

    public ObservableCollection<NavItemTemplate> NavItems { get; }


    [ObservableProperty] private NavItemTemplate _selectedListItem;

    [RelayCommand]
    private void SelectItem(NavItemTemplate item)
    {
        var instance = Activator.CreateInstance(item.ModelType);
        if (instance is ViewModelBase vm)
        {
            _mainWindow.CurrentPage = vm;
        }
    }
}

public class NavItemTemplate
{
    public string Text { get; }
    public Type ModelType { get; }
    public ICommand SelectCommand { get; }

    public NavItemTemplate(string text, Type modelType,
        Action<NavItemTemplate> onSelect)
    {
        Text = text;
        ModelType = modelType;
        SelectCommand = new RelayCommand(() => onSelect(this));
    }
}