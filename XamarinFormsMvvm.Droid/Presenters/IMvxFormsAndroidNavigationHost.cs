// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the IMvxFormsAndroidNavigationHost type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XamarinFormsMvvm.Droid.Presenters
{
    /// <summary>
    /// Defines the IMvxFormsAndroidNavigationHost type.
    /// </summary>
    public interface IMvxFormsAndroidNavigationHost
    {
        /// <summary>
        /// Sets the navigation provider.
        /// </summary>
        IMvxFormsAndroidNavigationProvider NavigationProvider { set; }
    }
}