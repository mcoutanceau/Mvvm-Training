using MvvmCross.Core.ViewModels;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        private readonly ICalculation _calculation;

        public TipViewModel(ICalculation calculation)
        {
            _calculation = calculation;
        }

        public override void Start()
        {
            _subTotal = 100;
            _generosity = 10;
            this.Recalculate();
        }

        private double _subTotal;
        public double SubTotal
        {
            get { return _subTotal; }
            set
            {
                _subTotal = value;
                base.RaisePropertyChanged(() => SubTotal);
                this.Recalculate();
            }
        }

        private int _generosity;
        public int Generosity
        {
            get { return _generosity; }
            set
            {
                _generosity = value;
                base.RaisePropertyChanged(() => Generosity);
                this.Recalculate();
            }
        }

        private double _tip;
        public double Tip
        {
            get { return _tip; }
            set
            {
                _tip = value;
                base.RaisePropertyChanged(() => Tip);
            }
        }

        private void Recalculate()
        {
            this.Tip = _calculation.TipAmount(SubTotal, Generosity);
        }
    }
}