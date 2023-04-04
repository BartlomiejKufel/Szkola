using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Log
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grades : ContentPage
    {
        public Grades()
        {
            InitializeComponent();
            GradesList.ItemsSource = SubcjectList.Subjects;
        }
    }
}