using System;
using System.Windows.Input;
using VideoStream.Models;
using VideoStream.ViewModels;

namespace VideoStream.Commands
{
    public class Maximize:ICommand
    {
        public MainPageViewModel MainPageVM { get; set; }
        public Maximize(MainPageViewModel mainPage)
        {
            this.MainPageVM = mainPage;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MainPageVM.PlayerYTranslation = -365;
            MainPageVM.IsPlaying = true;
            MainPageVM.IsMaximized = true;
            if (MainPageVM.IsSecondShowing == true)
            {             
                MainPageVM.tabSelect = TabSelect.second;
            }
            else if (MainPageVM.IsFirstShowing==true){               
                MainPageVM.tabSelect = TabSelect.first;
            }
            MainPageVM.IsSecondShowing = false;
            MainPageVM.IsFirstShowing = false;
        }
    }
}
