namespace Silverblade5.Views.Clients
{
    using System.Windows.Controls;
    using System.Windows.Navigation;

    /// <summary>
    /// <see cref="Page"/> class to present information about the current application.
    /// </summary>
    public partial class DetailsView : Page
    {
        /// <summary>
        /// Creates a new instance of the <see cref="DetailsView"/> class.
        /// </summary>
        public DetailsView()
        {
            InitializeComponent();

            this.Title = ApplicationStrings.ClientDetailsPageTitle;
        }

        /// <summary>
        /// Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}