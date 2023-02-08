using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;


namespace KufelBartlomiej
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Tasks> tasks;

        public MainPage()
        {
            InitializeComponent();
            tasks = new ObservableCollection<Tasks>()
            {
                new Tasks(){ Name = "Spotkanie biznesowe", IsImportant=true},
                new Tasks(){ Name = "Nauka do pana B.", IsImportant=false}
            };

            taskListView.ItemsSource = tasks;
        }

        private void taskListView_Refreshing(object sender, EventArgs e)
        {
            taskListView.ItemsSource = tasks;
            taskListView.EndRefresh();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string name = taskNameEntry.Text;
            taskNameEntry.Text = "";

            bool isImportant = importantSwitch.IsToggled;
            importantSwitch.IsToggled= false;

            tasks.Add(new Tasks() { Name=name, IsImportant=isImportant});
            taskListView.ItemsSource = tasks;
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var menu = (MenuItem)sender;
            var task = (Tasks)menu.CommandParameter;

            var delete = await DisplayAlert($"Usuwanie zadania: {task.Name}", "Czy napewno chcesz usunąć zadanie", "Tak", "Nie");
            if (!delete) return;

            var confirm = tasks.Remove(task);

            string msg = "";
            if (confirm)
                msg = "Pomyślnie usunięto zadanie";
            else
                msg = "Wystąpił błąd";

            await DisplayAlert("Wiadomość", msg, "OK");

            taskListView.ItemsSource = tasks;
        }
    }
}
