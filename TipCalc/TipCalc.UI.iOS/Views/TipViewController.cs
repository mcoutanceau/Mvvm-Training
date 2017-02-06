using UIKit;
using Foundation;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using TipCalc.Core.ViewModels;

namespace TipCalc.UI.iOS.Views
{
    [Register("TipViewController")]
    public partial class TipViewController : MvxViewController<Core.ViewModels.TipViewModel>
    {
        public TipViewController()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.White;
            this.TabBarItem.Title = "TipCalc UI iOS";

            var tipView = new TipView();
            this.View.AddSubview(tipView);
            tipView.TranslatesAutoresizingMaskIntoConstraints = false;

            //TODO: Voir quel est la bonne pratique pour placer la vue correctement et qu'elle ne soit pas ...
            //... en dessous de la barre de titre.
            const float _topOffset = 67f;
            this.View.AddConstraint(NSLayoutConstraint.Create(tipView, NSLayoutAttribute.Top   , NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Top   , 1, _topOffset));
            this.View.AddConstraint(NSLayoutConstraint.Create(tipView, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Bottom, 1, 0));
            this.View.AddConstraint(NSLayoutConstraint.Create(tipView, NSLayoutAttribute.Width , NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Width , 1, 0));
            this.View.AddConstraint(NSLayoutConstraint.Create(tipView, NSLayoutAttribute.Height, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Height, 1, 0));

            // Perform any additional setup after loading the view
            this.CreateBinding(tipView._tipLabel).To<TipViewModel>(vm => vm.Tip).Apply();
            this.CreateBinding(tipView._subTotalText).To<TipViewModel>(vm => vm.SubTotal).Apply();
            this.CreateBinding(tipView._generositySlider).To<TipViewModel>(vm => vm.Generosity).Apply();
        }
    }
}