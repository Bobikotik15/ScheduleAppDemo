using ScheduleAppDemo .Core;
using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System .Threading .Tasks;
using System .Windows;

namespace ScheduleAppDemo .MVVM .ViewModel
{
 
   class LoginViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;

        public RelayCommand LoginCommand { get; set; }

        public LoginViewModel (MainViewModel mainViewModel) // Добавлен конструктор!
        {
            _mainViewModel = mainViewModel;
            LoginCommand = new RelayCommand(Login);
        }

        private void Login (object obj)
        {
            // Placeholder for login logic
            _mainViewModel .ShowNewsView(); // Navigate to NewsView
        }

    }
}
