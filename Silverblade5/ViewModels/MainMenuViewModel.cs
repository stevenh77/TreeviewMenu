using System;
using System.Collections.Generic;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Silverblade5.Interfaces;
using Silverblade5.Web.Interfaces;

namespace Silverblade5.ViewModels
{
    public class MainMenuViewModel : IMainMenuViewModel
    {
        public IList<IMenuItem> Model { get; private set; }

        //private ICommand _navigateContent;
        //public ICommand NavigateContent 
        //{ 
        //    get 
        //    {
        //        if (_navigateContent == null)
        //            _navigateContent = new RelayCommand(ExecuteCommand);

        //        return _navigateContent;
        //    }
        //}

        //private void ExecuteCommand()
        //{

        //    // we have a uri, lets send the message and let the MainPage.xaml.cs update the content pane
        //    Messenger.Default.Send(new NotificationMessage<Uri>(this, uri, "Update content pane"));
        //}

        public MainMenuViewModel(IMainMenuService service)
        {
            Model = service.GetMainMenu();
        }
    }
}
