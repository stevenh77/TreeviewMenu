using System;
using GalaSoft.MvvmLight.Messaging;

namespace Silverblade5.Messages
{
    public class NavigationMessage : MessageBase
    {
        public Uri NavigateTo { get; set; }
    }
}
