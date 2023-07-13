using System.Windows;
using UsingTask.Library;
using UsingTask.Shared;

namespace UsingTask.UI;

public partial class MainWindow : Window
{
    PersonReader reader = new PersonReader();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void FetchWithTaskButton_Click(object sender, RoutedEventArgs e)
    {
        ClearListBox();
    }

    private async void FetchWithAwaitButton_Click(object sender, RoutedEventArgs e)
    {
        ClearListBox();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ClearListBox()
    {
        PersonListBox.Items.Clear();
    }
}
