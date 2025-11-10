using ScheduleAppDemo .Core;
using ScheduleAppDemo .MVVM .View;
using System;
using System .Windows;
using System .Collections .Generic;
using System .ComponentModel;
using System .IO .Packaging;
using System .Linq;
using System .Reflection .Emit;
using System .Runtime .CompilerServices;
using System .Text;
using System .Threading .Tasks;

namespace ScheduleAppDemo .MVVM .ViewModel
{

    class MainViewModel : ObservableObject
    {
        public RelayCommand CloseAppCommand { get; set; }
        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand NewsViewCommand { get; set; }

        public LoginViewModel LoginView { get; set; }
        public MainScheduleView DiscoveryVM { get; set; }
        public NewsViewModel NewsVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel ( )
        {
          
            LoginView = new LoginViewModel(this);
            DiscoveryVM = new MainScheduleView();
            NewsVM = new NewsViewModel();

            CurrentView = LoginView; 

            LoginViewCommand = new RelayCommand(o =>
            {
                CurrentView = LoginView;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });

            NewsViewCommand = new RelayCommand(o =>
            {
                CurrentView = NewsVM;
            });
            CloseAppCommand = new RelayCommand(o =>
            {
                Application .Current .Shutdown();
            });
        }
    
        public void ShowNewsView ( )
        {
            CurrentView = NewsVM;
        }
    }
}
