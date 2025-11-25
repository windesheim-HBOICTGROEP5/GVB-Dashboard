namespace GVB_Dashboard.app
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        // Dashboard
        private void OnDashboardTapped(object sender, EventArgs e)
        {
            DisplayAlert("Navigation", "Dashboard clicked", "OK");
        }

        // Reports Dropdown
        private void OnReportsToggled(object sender, EventArgs e)
        {
            ToggleDropdown(ReportsDropdown, ReportsArrow, ReportsHeader);
        }

        private void OnSalesReportTapped(object sender, EventArgs e)
        {
            DisplayAlert("Navigation", "Sales Report clicked", "OK");
        }

        private void OnAnalyticsTapped(object sender, EventArgs e)
        {
            DisplayAlert("Navigation", "Analytics clicked", "OK");
        }

        private void OnExportsTapped(object sender, EventArgs e)
        {
            DisplayAlert("Navigation", "Exports clicked", "OK");
        }

        // Settings Dropdown
        private void OnSettingsToggled(object sender, EventArgs e)
        {
            ToggleDropdown(SettingsDropdown, SettingsArrow, SettingsHeader);
        }

        private void OnProfileTapped(object sender, EventArgs e)
        {
            DisplayAlert("Navigation", "Profile clicked", "OK");
        }

        private void OnPreferencesTapped(object sender, EventArgs e)
        {
            DisplayAlert("Navigation", "Preferences clicked", "OK");
        }

        // Help
        private void OnHelpTapped(object sender, EventArgs e)
        {
            DisplayAlert("Navigation", "Help clicked", "OK");
        }

        // Helper methode voor de animatie
        private async void ToggleDropdown(VerticalStackLayout dropdown, Label arrow, Border header)
        {
            if (dropdown.IsVisible)
            {
                // Close dropdown
                await arrow.RotateTo(0, 200);
                dropdown.IsVisible = false;
                header.BackgroundColor = Colors.Transparent;
            }
            else
            {
                // Open dropdown
                await arrow.RotateTo(180, 200);
                dropdown.IsVisible = true;
                header.BackgroundColor = Color.FromArgb("#0081BA");
            }
        }
    }

}
