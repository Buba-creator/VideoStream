using System;
using System.Windows.Input;
using VideoStream.ViewModels;

namespace VideoStream.Commands
{
    public class Tab1Selector :ICommand
    {
        MainPageViewModel MainPageVM;
        public Tab1Selector(MainPageViewModel mainPageVM)
        {
            this.MainPageVM = mainPageVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MainPageVM.IsFirstShowing = true;
            MainPageVM.IsSecondShowing = false;
        }
    }
}
