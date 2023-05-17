using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlyoutDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public AppFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new AppFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class AppFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AppFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public AppFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<AppFlyoutPageFlyoutMenuItem>(new[]
                {
                    new AppFlyoutPageFlyoutMenuItem { Id = 0, Title = "Strona główna", TargetType= typeof(MainPage), Icon="home.png" },
                    new AppFlyoutPageFlyoutMenuItem { Id = 1, Title = "Gallery", TargetType= typeof(GalleryPage), Icon="gallery.jpg" },
                    new AppFlyoutPageFlyoutMenuItem { Id = 2, Title = "O mnie", TargetType= typeof(AboutPage), Icon="about.png" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}