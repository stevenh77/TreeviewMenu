using System.Collections.Generic;
using Silverblade5.Web.Interfaces;

namespace Silverblade5.Interfaces
{
    public interface IMainMenuViewModel
    {
        IList<IMenuItem> Model { get; }
    }
}