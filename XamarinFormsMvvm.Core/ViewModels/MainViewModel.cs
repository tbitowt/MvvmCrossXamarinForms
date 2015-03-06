// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the MainViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace XamarinFormsMvvm.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string sampleText = "Hello from the Ninja Coder!";

        private string sampleText2 = "Hello2";

        public MainViewModel()
        {
            
        }

        public string SampleText
        {
            get { return this.sampleText; }
            set { this.SetProperty(ref this.sampleText, value); }
        }

        public string SampleText2
        {
            get { return this.sampleText2; }
            set { this.SetProperty(ref this.sampleText2, value); }
        }

        private MvxCommand _resetCommand;
        public ICommand ResetCommand
        {
            get
            {
                _resetCommand = _resetCommand ?? new MvxCommand(() => Reset());
                return _resetCommand;
            }
        }

        private void Reset()
        {
            
        }
    }
}
