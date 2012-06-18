using System.Collections.Generic;

namespace Silverblade5.Web.Interfaces
{
    public interface IMainMenuService
    {
        IList<IMenuItem> GetMainMenu();
    }
}