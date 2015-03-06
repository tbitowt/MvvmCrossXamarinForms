// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the App type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Cirrious.CrossCore;

namespace XamarinFormsMvvm.Core
{
    using Cirrious.CrossCore.IoC;
    using Cirrious.MvvmCross.ViewModels;
    using XamarinFormsMvvm.Core.ViewModels;

    /// <summary>
    /// Define the App type.
    /// </summary>
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<IMvxCommandHelper, MvxStrongCommandHelper>();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public override void Initialize()
        {
            this.CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();


            //// Start the app with the Main View Model.
            this.RegisterAppStart<MainViewModel>();
        }
    }
}