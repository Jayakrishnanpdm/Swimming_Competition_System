using System;
using System.Windows;
using System.Windows.Controls;

namespace AquaChampPro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeStatusBar();
        }

        private void InitializeStatusBar()
        {
            // Initialize status bar with default values
            // These will be updated from your database/business logic
            AthleteCountText.Text = "0";
            EventCountText.Text = "0";
            ActiveCompetitionText.Text = "None";
        }

        // Event handlers for dashboard cards
        private void RegistrationCard_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Athlete Registration module
            // Example: Open AthleteRegistrationWindow or navigate to UserControl
            MessageBox.Show("Opening Athlete Registration module...", "AquaChamp Pro",
                MessageBoxButton.OK, MessageBoxImage.Information);

            // TODO: Implement navigation logic
            // NavigationService.Navigate(new AthleteRegistrationPage());
            // or
            // var registrationWindow = new AthleteRegistrationWindow();
            // registrationWindow.Show();
        }

        private void EventsCard_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Event Management module
            MessageBox.Show("Opening Event Management module...", "AquaChamp Pro",
                MessageBoxButton.OK, MessageBoxImage.Information);

            // TODO: Implement navigation logic
        }

        private void SchedulingCard_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Event Scheduling module
            MessageBox.Show("Opening Event Scheduling module...", "AquaChamp Pro",
                MessageBoxButton.OK, MessageBoxImage.Information);

            // TODO: Implement navigation logic
        }

        private void TimingCard_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Time Recording module
            MessageBox.Show("Opening Time Recording module...", "AquaChamp Pro",
                MessageBoxButton.OK, MessageBoxImage.Information);

            // TODO: Implement navigation logic
        }

        private void RankingsCard_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Rankings & Results module
            MessageBox.Show("Opening Rankings & Results module...", "AquaChamp Pro",
                MessageBoxButton.OK, MessageBoxImage.Information);

            // TODO: Implement navigation logic
        }

        private void ReportsCard_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Reports & Awards module
            MessageBox.Show("Opening Reports & Awards module...", "AquaChamp Pro",
                MessageBoxButton.OK, MessageBoxImage.Information);

            // TODO: Implement navigation logic
        }

        // Method to update status bar (call this from your ViewModel or business logic)
        public void UpdateStatusBar(int athleteCount, int eventCount, string activeCompetition)
        {
            AthleteCountText.Text = athleteCount.ToString();
            EventCountText.Text = eventCount.ToString();
            ActiveCompetitionText.Text = activeCompetition ?? "None";
        }

        // Window events
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialize any startup logic here
            // Load data from database, check connections, etc.
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Handle window closing
            // Save any pending changes, close database connections, etc.
        }
    }
}