namespace Silverblade5.Views.Home
{
    using System.Windows.Controls;
    using System.Windows.Navigation;

    /// <summary>
    /// <see cref="Page"/> class to present information about the current application.
    /// </summary>
    public partial class SearchView : Page
    {
        /// <summary>
        /// Creates a new instance of the <see cref="SearchView"/> class.
        /// </summary>
        public SearchView()
        {
            InitializeComponent();

            this.Title = ApplicationStrings.HomeSearchPageTitle;
        }

        /// <summary>
        /// Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}