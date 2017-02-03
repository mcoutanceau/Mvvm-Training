using System;
using System.Drawing;
using CoreFoundation;
using UIKit;
using Foundation;
using MvvmCross.iOS.Views;

namespace TipCalc.UI.iOS.Views
{
    [Register("TipView")]
    public class TipView : UIView
    {
        private UILabel     _subTotalLabel;
        private UITextField _subTotalText;

        private UILabel     _generosityLabel;
        private UISlider    _generositySlider;

        private UILabel     _tipLabel;

        public TipView()
        {
            Initialize();
        }

        public TipView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            this.BackgroundColor = UIColor.Orange;

            _subTotalLabel    = new UILabel()  { Text = "Subtotal", BackgroundColor = UIColor.Yellow };
            _subTotalText     = new UITextField();

            _generosityLabel  = new UILabel()  { Text = "Generosity" };
            _generositySlider = new UISlider();

            _tipLabel         = new UILabel();

            const float defaultHeight = 30f;

            this.AddSubviews(_subTotalLabel, _subTotalText, _generosityLabel, _generositySlider, _tipLabel);
            _subTotalLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            this.AddConstraint(NSLayoutConstraint.Create(_subTotalLabel, NSLayoutAttribute.Height   , NSLayoutRelation.Equal, 0f, defaultHeight));
            this.AddConstraint(NSLayoutConstraint.Create(_subTotalLabel, NSLayoutAttribute.CenterX  , NSLayoutRelation.Equal, this, NSLayoutAttribute.CenterX, 1, 0));
            this.AddConstraint(NSLayoutConstraint.Create(_subTotalLabel, NSLayoutAttribute.Width    , NSLayoutRelation.Equal, this, NSLayoutAttribute.Width  , 1, 0));
        }
    }

    [Register("TipViewController")]
    public class TipViewController : MvxViewController<Core.ViewModels.TipViewModel>
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
            this.View.BackgroundColor = UIColor.Red;

            var tipView = new TipView();
            this.View.AddSubview(tipView);
            tipView.TranslatesAutoresizingMaskIntoConstraints = false;
            this.View.AddConstraint(NSLayoutConstraint.Create(tipView, NSLayoutAttribute.CenterY, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.CenterY, 1, 0));
            this.View.AddConstraint(NSLayoutConstraint.Create(tipView, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.CenterX, 1, 0));
            this.View.AddConstraint(NSLayoutConstraint.Create(tipView, NSLayoutAttribute.Width  , NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Width  , 1, 0));
            this.View.AddConstraint(NSLayoutConstraint.Create(tipView, NSLayoutAttribute.Height , NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Width  , 1, 0));
            // Perform any additional setup after loading the view
        }
    }
}