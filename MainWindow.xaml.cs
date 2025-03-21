using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls;

namespace Delta_Silence_Launcher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Normal;
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        
        private void FullScreenButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                FullScreenButton.Content = "⛶"; 
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                FullScreenButton.Content = "❐"; 
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        private void HideAllGrids()
        {
            HomeGrid.Visibility = Visibility.Hidden;
            SOIGrid.Visibility = Visibility.Hidden;
            SOIVRGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Hidden;
            SupportGrid.Visibility = Visibility.Hidden;
            AboutUsGrid.Visibility = Visibility.Hidden;
        }

        private void ResetButtonStyles()
        {
            HomeButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E88E5"));
            HomeButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

            SOIButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E88E5"));
            SOIButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

            SOIVRButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E88E5"));
            SOIVRButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

            SettingsButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E88E5"));
            SettingsButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

            SupportButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E88E5"));
            SupportButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

            AboutUsButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E88E5"));
            AboutUsButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            HideAllGrids();
            HomeGrid.Visibility = Visibility.Visible;

            ResetButtonStyles();
            HomeButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            HomeButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        }

        private void SOI_Click(object sender, RoutedEventArgs e)
        {
            HideAllGrids();
            SOIGrid.Visibility = Visibility.Visible;

            ResetButtonStyles();
            SOIButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            SOIButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        }

        private void SOIVR_Click(object sender, RoutedEventArgs e)
        {
            HideAllGrids();
            SOIVRGrid.Visibility = Visibility.Visible;

            ResetButtonStyles();
            SOIVRButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            SOIVRButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            HideAllGrids();
            SettingsGrid.Visibility = Visibility.Visible;

            ResetButtonStyles();
            SettingsButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            SettingsButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        }

        private void Support_Click(object sender, RoutedEventArgs e)
        {
            HideAllGrids();
            SupportGrid.Visibility = Visibility.Visible;

            ResetButtonStyles();
            SupportButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            SupportButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        }

        private void AboutUs_Click(object sender, RoutedEventArgs e)
        {
            HideAllGrids();
            AboutUsGrid.Visibility = Visibility.Visible;

            ResetButtonStyles();
            AboutUsButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            AboutUsButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Coming Soon...", "Delta Silence Launcher",
                            MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
