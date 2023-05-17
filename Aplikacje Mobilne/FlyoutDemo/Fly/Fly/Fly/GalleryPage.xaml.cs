using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlyoutDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    class Photo
    {
        public string Filename { get; set; }
        public string Title { get; set; }
    }

    public partial class GalleryPage : ContentPage
    {
        private List<Photo> photos;
        int index;

        public GalleryPage()
        {
            InitializeComponent();
            photos = new List<Photo>()
            {
                new Photo() {Filename = "home.png", Title = "Domek"},
                new Photo() {Filename = "gallery.jpg", Title = "Galeria"},
                new Photo() {Filename = "about.png", Title = "Ikonka o mnie"},
            };
            photosCarouselView.ItemsSource = photos;
        }

        private void previousButton_Clicked(object sender, EventArgs e)
        {
            index--;
            if(index < 0)
            {
                index = photos.Count- 1;
            }
            photosCarouselView.Position = index;
        }

        private void nextButton_Clicked(object sender, EventArgs e)
        {
            index++;
            if (index > photos.Count -1)
            {
                index = 0;
            }
            photosCarouselView.Position = index;
        }
    }
}