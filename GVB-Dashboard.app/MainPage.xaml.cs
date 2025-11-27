using Microsoft.Maui.Controls;
using System;

namespace GVB_Dashboard.app;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Standaard meteen de eerste afbeelding tonen (als er items in de picker staan)
        if (Kaart.Items.Count > 0)
        {
            Kaart.SelectedIndex = 0;
            UpdateLeftImage();
        }
    }

    // === MENU HANDLERS ===

    private void OnDashboardTapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Navigation", "Dashboard clicked", "OK");
    }

    private void OnReportsToggled(object sender, TappedEventArgs e)
    {
        if (ReportsDropdown == null || ReportsArrow == null)
            return;

        ReportsDropdown.IsVisible = !ReportsDropdown.IsVisible;
        ReportsArrow.Text = ReportsDropdown.IsVisible ? "▲" : "▼";
    }

    private void OnSalesReportTapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Navigation", "Sales Report clicked", "OK");
    }

    private void OnAnalyticsTapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Navigation", "Analytics clicked", "OK");
    }

    private void OnExportsTapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Navigation", "Exports clicked", "OK");
    }

    private void OnSettingsToggled(object sender, TappedEventArgs e)
    {
        if (SettingsDropdown == null || SettingsArrow == null)
            return;

        SettingsDropdown.IsVisible = !SettingsDropdown.IsVisible;
        SettingsArrow.Text = SettingsDropdown.IsVisible ? "▲" : "▼";
    }

    private void OnProfileTapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Navigation", "Profile clicked", "OK");
    }

    private void OnPreferencesTapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Navigation", "Preferences clicked", "OK");
    }

    private void OnHelpTapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Navigation", "Help clicked", "OK");
    }

    // === FOTO-SELECTIE VOOR LINKER KAART ===

    private void OnLeftPhotoSelected(object sender, EventArgs e)
    {
        UpdateLeftImage();
    }

    private void UpdateLeftImage()
    {
        if (Kaart.SelectedIndex < 0)
            return;

        var selectedText = Kaart.Items[Kaart.SelectedIndex];

        // hier koppel je namen uit de dropdown aan bestanden in Resources/Images
        string fileName = selectedText switch
        {
            "Alle Metro lijnen" => "kaart_gvb.png",
            "Metro lijn 50" => "kaartm50_gvb.png",
            "Metro lijn 51" => "kaartm51_gvb.png",
            "Metro lijn 52" => "kaartm52_gvb.png",
            "Metro lijn 53" => "kaartm53_gvb.png",
            "Metro lijn 54" => "kaartm54_gvb.png",
            _ => null
        };

        if (!string.IsNullOrWhiteSpace(fileName))
        {
            LeftSelectedImage.Source = ImageSource.FromFile(fileName);
        }
        else
        {
            LeftSelectedImage.Source = null;
        }
    }
}
