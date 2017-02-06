using Foundation;
using System.Drawing;
using UIKit;

namespace TipCalc.UI.iOS.Views
{
    public partial class TipViewController
    {
        [Register("TipView")]
        private class TipView : UIView
        {
            public UILabel     _subTotalLabel;
            public UITextField _subTotalText;
            public UILabel     _generosityLabel;
            public UISlider    _generositySlider;
            public UILabel     _tipLabel;

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
                _subTotalLabel    = new UILabel()  { Text = "Subtotal" };
                _subTotalText     = new UITextField();

                _generosityLabel  = new UILabel()  { Text = "Generosity" };
                _generositySlider = new UISlider() { MinValue = 0, MaxValue = 100 };

                _tipLabel         = new UILabel();

                const float defaultHeight = 30f;

                this.AddSubviews(_subTotalLabel, _subTotalText, _generosityLabel, _generositySlider, _tipLabel);
                _subTotalLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            
                this.AddConstraint(NSLayoutConstraint.Create(_subTotalLabel, NSLayoutAttribute.Top    , NSLayoutRelation.Equal, this, NSLayoutAttribute.Top    , 1, 0));
                this.AddConstraint(NSLayoutConstraint.Create(_subTotalLabel, NSLayoutAttribute.Height , NSLayoutRelation.Equal, 0f, defaultHeight));
                this.AddConstraint(NSLayoutConstraint.Create(_subTotalLabel, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, this, NSLayoutAttribute.CenterX, 1, 0));
                this.AddConstraint(NSLayoutConstraint.Create(_subTotalLabel, NSLayoutAttribute.Width  , NSLayoutRelation.Equal, this, NSLayoutAttribute.Width  , 1, 0));

                _subTotalText.TranslatesAutoresizingMaskIntoConstraints = false;
                this.AddConstraint(NSLayoutConstraint.Create(_subTotalText, NSLayoutAttribute.Top    , NSLayoutRelation.Equal, _subTotalLabel, NSLayoutAttribute.Bottom, 1, 0));
                this.AddConstraint(NSLayoutConstraint.Create(_subTotalText, NSLayoutAttribute.Height , NSLayoutRelation.Equal, 0f, defaultHeight));
                this.AddConstraint(NSLayoutConstraint.Create(_subTotalText, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, this, NSLayoutAttribute.CenterX, 1, 0));
                this.AddConstraint(NSLayoutConstraint.Create(_subTotalText, NSLayoutAttribute.Width  , NSLayoutRelation.Equal, this, NSLayoutAttribute.Width  , 1, 0));

                _generosityLabel.TranslatesAutoresizingMaskIntoConstraints = false;
                this.AddConstraint(NSLayoutConstraint.Create(_generosityLabel, NSLayoutAttribute.Top    , NSLayoutRelation.Equal, _subTotalText, NSLayoutAttribute.Bottom, 1, 0));
                this.AddConstraint(NSLayoutConstraint.Create(_generosityLabel, NSLayoutAttribute.Height , NSLayoutRelation.Equal, 0f, defaultHeight));
                this.AddConstraint(NSLayoutConstraint.Create(_generosityLabel, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, this, NSLayoutAttribute.CenterX, 1, 0));
                this.AddConstraint(NSLayoutConstraint.Create(_generosityLabel, NSLayoutAttribute.Width  , NSLayoutRelation.Equal, this, NSLayoutAttribute.Width  , 1, 0));

                _generositySlider.TranslatesAutoresizingMaskIntoConstraints = false;
                this.AddConstraint(NSLayoutConstraint.Create(_generositySlider, NSLayoutAttribute.Top    , NSLayoutRelation.Equal, _generosityLabel, NSLayoutAttribute.Bottom, 1, 0));
                this.AddConstraint(NSLayoutConstraint.Create(_generositySlider, NSLayoutAttribute.Height , NSLayoutRelation.Equal, 0f, defaultHeight));
                this.AddConstraint(NSLayoutConstraint.Create(_generositySlider, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, this, NSLayoutAttribute.CenterX, 1, 0));
                this.AddConstraint(NSLayoutConstraint.Create(_generositySlider, NSLayoutAttribute.Width  , NSLayoutRelation.Equal, this, NSLayoutAttribute.Width  , 1, 0));

                _tipLabel.TranslatesAutoresizingMaskIntoConstraints = false;
                this.AddConstraint(NSLayoutConstraint.Create(_tipLabel, NSLayoutAttribute.Top    , NSLayoutRelation.Equal, _generositySlider, NSLayoutAttribute.Bottom, 1, 0));
                this.AddConstraint(NSLayoutConstraint.Create(_tipLabel, NSLayoutAttribute.Height , NSLayoutRelation.Equal, 0f, defaultHeight));
                this.AddConstraint(NSLayoutConstraint.Create(_tipLabel, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, this, NSLayoutAttribute.CenterX, 1, 0));
                this.AddConstraint(NSLayoutConstraint.Create(_tipLabel, NSLayoutAttribute.Width  , NSLayoutRelation.Equal, this, NSLayoutAttribute.Width  , 1, 0));
            }
        }
    }
}
