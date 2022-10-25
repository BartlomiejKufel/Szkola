using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Layout
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<User> users;
        
        public MainPage()
        {
            InitializeComponent();
            users = new ObservableCollection<User>();
            users.Add(new User() 
            { 
                Email="jankowalski@test.com", 
                BirthDate = new DateTime(2000,10,1),
                Gender=Gender.Man, 
                Height=185 
            });

            renderList();
        
        }

        private void renderList()
        {
            listEditor.Text = "";

            foreach (var user in users)
            {
                string userRecord = $"{user.Email}, ur. {user.BirthDate.ToShortDateString()}, ";

                string genderStr="";
                switch (user.Gender)
                {
                    case Gender.Man:genderStr="mężczyzna"; break;
                    case Gender.Woman:genderStr="kobieta";break;
                    case Gender.NotSelected:genderStr=" - ";break;
                }
                userRecord += genderStr;
                userRecord += $", {user.Height} cm\n\n";

                listEditor.Text+=userRecord;
            
            }

        }

        private void addUser_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            DateTime birthDate = birthDatePicker.Date;
            Gender gender = getGender();
            uint height = (uint) heightStepper.Value;

            if (isEmailValid(email))
            {
                User newUser = new User()
                {
                    Email = email,
                    BirthDate = birthDate,
                    Gender = gender,
                    Height = height
                };
                users.Add(newUser);
                renderList();
            }
            else
            {
                DisplayAlert("Błąd", "Popraw dane i spróbuj jeszcze raz.", "OK");
            } 
            




        }

        private bool isEmailValid(string emailToValidate)
        {
            string email=emailToValidate.Trim();
            if(email.Length < 5) return false;

            if (!email.Contains("@") || !email.Contains(".")) return false;

            return true;
        }

        private Gender getGender()
        {
            if (manRadioButton.IsChecked)
            {
                return Gender.Man;
            }
            else if (womanRadioButton.IsChecked)
            {
                return Gender.Woman;
            }
            else
            {
                return Gender.NotSelected;
            }
        }
    }
}
