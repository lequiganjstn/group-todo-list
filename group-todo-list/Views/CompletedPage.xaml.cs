using group_todo_list.Views;

namespace group_todo_list.Views;

public partial class CompletedPage : ContentPage
{
    public CompletedPage()
    {
        InitializeComponent();

        // Dummy data just to see the design
        CompletedListView.ItemsSource = new List<string>
        {
            "Completed Task 1",
            "Completed Task 2",
            "Completed Task 3",
            "Completed Task 4",
            "Completed Task 5"
        };
    }
}