using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;

namespace TipCalc.Core
{
    /// <summary>
    /// This class is responsible for providing :
    ///     - registration of which interfaces and implementations the app uses
    ///     - registration of which ViewModel the App will show when it starts
    ///     - control of how ViewModels are located - although most applications normally just use the default implementation of this supplied by the base MvxApplication class.
    /// </summary>
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculation, Calculation>();//Whenever any code requests an ICalculation reference, then the framework should create a new instance of Calculation.
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());//whenever any code requests an IMvxAppStart reference, then the framework should return that same appStart instance.
        }
    }
}