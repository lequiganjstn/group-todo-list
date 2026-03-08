using Microsoft.Extensions.DependencyInjection;
using group_todo_list.Views;
namespace group_todo_list
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new ProfilePage()));
        }
    }
}