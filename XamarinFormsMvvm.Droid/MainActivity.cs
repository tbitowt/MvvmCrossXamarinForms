// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the MainActivity type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using XamarinFormsMvvm.Forms;

namespace XamarinFormsMvvm.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;
    using Xamarin.Forms.Platform.Android;

		
    /// <summary>
    /// Defines the MainActivity type.
    /// </summary>
    [Activity(Label = "", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        /// <summary>
        /// Called when [create].
        /// </summary>
        /// <param name="bundle">The bundle.</param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);

            var app = new App();
            this.LoadApplication(app);
        }
    }
}
