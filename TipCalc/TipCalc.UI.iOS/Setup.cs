using MvvmCross.iOS.Platform;
using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.ViewModels;
using TipCalc.Core;
using MvvmCross.iOS.Views.Presenters;

namespace TipCalc.UI.iOS
{
    /// <summary>
    /// Performs the initialisation of the MvvmCross framework and your application, including:
    /// - the Inversion of Control(IoC) system
    /// - the MvvmCross data-binding
    /// - your App and its collection of ViewModels
    /// - your UI project and its collection of Views
    /// </summary>
    internal class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate appDelegate, IMvxIosViewPresenter presenter)
            : base(appDelegate, presenter)
        {

        }
        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}
