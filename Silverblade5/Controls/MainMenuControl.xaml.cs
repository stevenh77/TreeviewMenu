using System;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Messaging;
using Silverblade5.Messages;

namespace Silverblade5.Controls
{
    public partial class MainMenuControl : UserControl
    {
        public MainMenuControl()
        {
            InitializeComponent();
        }

        private void TreeviewMenu_ItemClicked(object sender, EventArgs e)
        {
            // get uri from the selected
            var uri = ((Models.MenuItem)((LazyTreeViewItem)sender).Header).Uri;

            // exit if the TreeViewItem did not contain a Uri
            if (uri == null)
            {
                return;
            }

            // we have a uri, lets send the message 
            // and let the MainPage.xaml.cs update the content pane
            Messenger.Default.Send(new NavigationMessage() {NavigateTo = uri});
        }
    }
}
