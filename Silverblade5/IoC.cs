using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Silverblade5.Interfaces;
using Silverblade5.ViewModels;
using Silverblade5.Web.Interfaces;
using Silverblade5.Web.Services;

namespace Silverblade5
{
    public class IoC
    {
        static IoC()
        {
            if (ViewModelBase.IsInDesignModeStatic)
            {
                
            }
            else
            {
               
            }

            SimpleIoc.Default.Register<IMainMenuService, MainMenuService>();
            SimpleIoc.Default.Register<IMainMenuViewModel, MainMenuViewModel>();

            var service = SimpleIoc.Default.GetInstance<IMainMenuService>(); 
            var vm = SimpleIoc.Default.GetInstance<IMainMenuViewModel>();

        }

        public IMainMenuViewModel MainMenuViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<IMainMenuViewModel>();
            }
        }

        public IMainMenuService MainMenuService
        {
            get
            {
                return SimpleIoc.Default.GetInstance<IMainMenuService>();
            }
        }
        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}