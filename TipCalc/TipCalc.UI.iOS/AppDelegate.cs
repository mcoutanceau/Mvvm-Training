using Foundation;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using UIKit;

namespace TipCalc.UI.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate //Allows 
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            //MvxIosViewPresenter is the class that will determine how Views are shown - for this sample, we choose a 'standard' one
            var presenter = new MvxIosViewPresenter(this, Window);

            //Calls Mvx Setups.
            var setup = new TipCalc.UI.iOS.Setup(this, presenter);
            setup.Initialize();

            var startup = Mvx.Resolve<IMvxAppStart>(); //Returns TipCalc.Core.App, as defined by TipCalc.UI.iOS.CreateApp();
            startup.Start();

            this.Window.MakeKeyAndVisible();
            return true;
        }
    }
}