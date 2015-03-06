// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the Setup type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XamarinFormsMvvm.iOS
{
    using Cirrious.MvvmCross.Touch.Platform;
    using Cirrious.MvvmCross.Touch.Views.Presenters;
    using Cirrious.MvvmCross.ViewModels;

	using XamarinFormsMvvm.Core.Services;
    using XamarinFormsMvvm.Forms.Services;
    using XamarinFormsMvvm.iOS.Presenters;

    /// <summary>
    ///    Defines the Setup type.
    /// </summary>
    public class Setup : MvxTouchSetup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Setup"/> class.
        /// </summary>
        /// <param name="applicationDelegate">The application delegate.</param>
        /// <param name="presenter">The presenter.</param>
        public Setup(
			MvxApplicationDelegate applicationDelegate, 
			IMvxTouchViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

		/// <summary>
        /// Creates the presenter.
        /// </summary>
        /// <returns></returns>
        protected override IMvxTouchViewPresenter CreatePresenter()
        {
            return new MvxFormsTouchViewPresenter(
                new ViewModelService(), 
                new PageService(), 
                this.ApplicationDelegate,
                this.Window);
        }

        /// <summary>
        /// Creates the app.
        /// </summary>
        /// <returns>An instance of IMvxApplication</returns>
        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}