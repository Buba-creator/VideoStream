using System;
using System.Windows.Input;
using VideoStream.ViewModels;

namespace VideoStream.Commands
{
    public class Minimize:ICommand
    {
        MainPageViewModel MainPageVM;
        public Minimize(MainPageViewModel mainPageVM)
        {
            MainPageVM = mainPageVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MainPageVM.PlayerYTranslation = 0;
            MainPageVM.IsPlaying = false;
            MainPageVM.IsMaximized = false;
            if (MainPageVM.tabSelect == Models.TabSelect.first)
            {
                MainPageVM.IsFirstShowing = true;
            }
            else if (MainPageVM.tabSelect == Models.TabSelect.second)
            {
                MainPageVM.IsSecondShowing = true;
            }                      
        }
    }
}
