using System;
using System.Windows;

namespace SwimmingCompetitionManager
{
    public partial class AthleteRegistrationWindow : Window
    {
        public AthleteRegistrationWindow()
        {
            InitializeComponent();
            dpDOB.SelectedDateChanged += DpDOB_SelectedDateChanged;
        }

        private void DpDOB_SelectedDateChanged(object sender, RoutedEventArgs e)
        {
            if (dpDOB.SelectedDate.HasValue)
            {
                var dob = dpDOB.SelectedDate.Value;
                var today = DateTime.Today;
                int years = today.Year - dob.Year;
                int months = today.Month - dob.Month;

                if (today.Day < dob.Day)
                    months--;

                if (months < 0)
                {
                    years--;
                    months += 12;
                }

                txtAgeYears.Text = years.ToString();
                txtAgeMonths.Text = months.ToString();
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            // Add database saving logic here
            MessageBox.Show("Registration Successful!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            cmbGender.SelectedIndex = -1;
            dpDOB.SelectedDate = null;
            txtAgeYears.Clear();
            txtAgeMonths.Clear();
            txtUID.Clear();
            txtWhatsApp.Clear();
            txtEmail.Clear();
            txtClubID.Clear();
            txtCategoryID.Clear();
        }
    }
}
