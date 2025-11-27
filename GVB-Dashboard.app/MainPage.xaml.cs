using Microsoft.Maui.Controls;

namespace GVB_Dashboard.app;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // === MENU HANDLERS ===

    private void OnDashboardTapped(object sender, TappedEventArgs e)
    {
        // TODO: laad dashboard content
        DisplayAlert("Navigation", "Dashboard clicked", "OK");
    }

    // REPORTS DROPDOWN TOGGLE
    private void OnReportsToggled(object sender, TappedEventArgs e)
    {
        if (ReportsDropdown == null || ReportsArrow == null)
            return;

        ReportsDropdown.IsVisible = !ReportsDropdown.IsVisible;
        ReportsArrow.Text = ReportsDropdown.IsVisible ? "▲" : "▼";
    }

    private void OnSalesReportTapped(object sender, TappedEventArgs e)
    {
        // TODO: vervang door echte logica
        DisplayAlert("Navigation", "Sales Report clicked", "OK");
    }

    private void OnAnalyticsTapped(object sender, TappedEventArgs e)
    {
        // TODO: vervang door echte logica
        DisplayAlert("Navigation", "Analytics clicked", "OK");
    }

    private void OnExportsTapped(object sender, TappedEventArgs e)
    {
        // TODO: vervang door echte logica
        DisplayAlert("Navigation", "Exports clicked", "OK");
    }

    // SETTINGS DROPDOWN TOGGLE
    private void OnSettingsToggled(object sender, TappedEventArgs e)
    {
        if (SettingsDropdown == null || SettingsArrow == null)
            return;

        SettingsDropdown.IsVisible = !SettingsDropdown.IsVisible;
        SettingsArrow.Text = SettingsDropdown.IsVisible ? "▲" : "▼";
    }

    private void OnProfileTapped(object sender, TappedEventArgs e)
    {
        // TODO: vervang door echte logica
        DisplayAlert("Navigation", "Profile clicked", "OK");
    }

    private void OnPreferencesTapped(object sender, TappedEventArgs e)
    {
        // TODO: vervang door echte logica
        DisplayAlert("Navigation", "Preferences clicked", "OK");
    }

    private void OnHelpTapped(object sender, TappedEventArgs e)
    {
        // TODO: vervang door echte logica
        DisplayAlert("Navigation", "Help clicked", "OK");
    }
}

