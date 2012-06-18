
using System;
using System.Collections.Generic;
using Silverblade5.Models;
using Silverblade5.Web.Interfaces;

namespace Silverblade5.Web.Services
{
    public class MainMenuService : IMainMenuService
    {
        public IList<IMenuItem> GetMainMenu()
        {
            var menu = new List<IMenuItem>(5);

            //HOME
            var home = new MenuItem("1", "Home", null, null);
            var home1 = new MenuItem("1.1", "Search", new Uri("/Silverblade5;component/Assets/Images/Menu/Find_16x16.png", UriKind.RelativeOrAbsolute), new Uri("/Home/SearchView", UriKind.Relative));
            var home2 = new MenuItem("1.2", "Tasks", new Uri("/Silverblade5;component/Assets/Images/Menu/mail-icon.png", UriKind.Relative), new Uri("Views/Clients/Portfolios.xaml", UriKind.Relative));
            var home3 = new MenuItem("1.3", "Maintenance", new Uri("/Silverblade5;component/Assets/Images/Menu/logo.png", UriKind.Relative), new Uri("Views/Clients/Assets.xaml", UriKind.Relative));
            home.Add(home1, home2, home3);

            //CLIENTS
            var clients = new MenuItem("1", "Clients", null, null);
            var clients1 = new MenuItem("1.1", "Details", new Uri("/Silverblade5;component/Assets/Images/Menu/client-icon.png", UriKind.Relative), new Uri("/Clients/DetailsView", UriKind.Relative));
            var clients2 = new MenuItem("1.2", "Portfolios", new Uri("/Silverblade5;component/Assets/Images/Menu/report2-icon.png", UriKind.Relative), new Uri("Views/Clients/Portfolios.xaml", UriKind.Relative));
            var clients3 = new MenuItem("1.3", "Assets", new Uri("/Silverblade5;component/Assets/Images/Menu/coins-icon.png", UriKind.Relative), new Uri("Views/Clients/Assets.xaml", UriKind.Relative));
            clients.Add(clients1, clients2, clients3);


            //REPORTS
            var reports = new MenuItem("2", "Reports", null, null);
            var reports1 = new MenuItem("2.1", "View", new Uri("/Silverblade5;component/Assets/Images/Menu/chart-icon.png", UriKind.Relative), new Uri("Views/Reports/Details.xaml", UriKind.Relative));
            var reports2 = new MenuItem("2.2", "Export", new Uri("/Silverblade5;component/Assets/Images/Menu/export-icon.png", UriKind.Relative), new Uri("Views/Reports/Portfolios.xaml", UriKind.Relative));
            var reports3 = new MenuItem("2.3", "Analyse", new Uri("/Silverblade5;component/Assets/Images/Menu/calculator-icon.png", UriKind.Relative), new Uri("Views/Reports/Assets.xaml", UriKind.Relative));
            reports.Add(reports1, reports2, reports3);

            //REALTIME
            var realtime = new MenuItem("3", "Real Time", null, null);
            var realtime1 = new MenuItem("3.1", "Sockets", new Uri("/Silverblade5;component/Assets/Images/Menu/socket-icon.png", UriKind.Relative), new Uri("Views/Realtime/Details.xaml", UriKind.Relative));
            var realtime2 = new MenuItem("3.2", "Cloud", new Uri("/Silverblade5;component/Assets/Images/Menu/world-icon.png", UriKind.Relative), new Uri("Views/Realtime/Portfolios.xaml", UriKind.Relative));
            var realtime3 = new MenuItem("3.3", "Integration", new Uri("/Silverblade5;component/Assets/Images/Menu/transaction-icon.png", UriKind.Relative), new Uri("Views/Realtime/Assets.xaml", UriKind.Relative));
            realtime.Add(realtime1, realtime2, realtime3);

            //PLUGINS
            var plugins = new MenuItem("4", "Plugins", null, null);
            var plugins1 = new MenuItem("4.1", "DOS", new Uri("/Silverblade5;component/Assets/Images/Menu/dos-icon.png", UriKind.Relative), new Uri("Views/Plugins/Details.xaml", UriKind.Relative));
            var plugins2 = new MenuItem("4.2", ".NET", new Uri("/Silverblade5;component/Assets/Images/Menu/dotnet-icon.png", UriKind.Relative), new Uri("Views/Plugins/Portfolios.xaml", UriKind.Relative));
            var plugins3 = new MenuItem("4.3", "Cloud", new Uri("/Silverblade5;component/Assets/Images/Menu/report1-icon.png", UriKind.Relative), new Uri("Views/Plugins/Assets.xaml", UriKind.Relative));
            plugins.Add(plugins1, plugins2, plugins3);

            menu.AddRange( new List<IMenuItem>(5) {home, clients, reports, realtime, plugins} );
            
            return menu;
        }
    }
}