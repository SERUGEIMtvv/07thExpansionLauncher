using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.Threading;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Resources;


namespace LaunchernoNakuKoroni
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LaunchGame(string gameName)
        {
            string path = ConfigurationManager.AppSettings[gameName];
            if (path == null)
            {
                MessageBox.Show($"Error: Can't find [{gameName}]'s path in App Settings!\nPlease make sure it is defined in the config file.", "Game not in app settings");
                return;
            }

            if (!System.IO.File.Exists(path)
            {
                MessageBox.Show($"Error: Game [{gameName}] couldn't be found at [{path}].\nPlease check the path is correct in the config file.", "Game path incorrect");
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: Can't start game [{gameName}] at [{path}] due to unknown error:\n\n{e.ToString()}", "Can't start game");
            }
        }

        private void ButtonHigQ1_Click(object sender, RoutedEventArgs e) => LaunchGame("HigQ1_exe");
        private void ButtonHigQ2_Click(object sender, RoutedEventArgs e) => LaunchGame("HigQ2_exe");
        private void ButtonHigQ3_Click(object sender, RoutedEventArgs e) => LaunchGame("HigQ3_exe");
        private void ButtonHigQ4_Click(object sender, RoutedEventArgs e) => LaunchGame("HigQ4_exe");
        private void ButtonHigA1_Click(object sender, RoutedEventArgs e) => LaunchGame("HigA1_exe");
        private void ButtonHigA2_Click(object sender, RoutedEventArgs e) => LaunchGame("HigA2_exe");
        private void ButtonHigA3_Click(object sender, RoutedEventArgs e) => LaunchGame("HigA3_exe");
        private void ButtonHigA4_Click(object sender, RoutedEventArgs e) => LaunchGame("HigA4_exe");
        private void ButtonHigRei_Click(object sender, RoutedEventArgs e) => LaunchGame("HigRei_exe");
        private void ButtonHigHou_Click(object sender, RoutedEventArgs e) => LaunchGame("HigHou_exe");
        private void ButtonHigCon_Click(object sender, RoutedEventArgs e) => LaunchGame("HigCon_exe");
        private void ButtonUmiQ_Click(object sender, RoutedEventArgs e) => LaunchGame("UmiQ_exe");
        private void ButtonUmiA_Click(object sender, RoutedEventArgs e) => LaunchGame("UmiA_exe");
        private void ButtonUmiT_Click(object sender, RoutedEventArgs e) => LaunchGame("UmiT_exe");
        private void ButtonUmiH_Click(object sender, RoutedEventArgs e) => LaunchGame("UmiH_exe");
        private void ButtonUmiS_Click(object sender, RoutedEventArgs e) => LaunchGame("UmiS_exe");
        private void ButtonCic1_Click(object sender, RoutedEventArgs e) => LaunchGame("Cic1_exe");
        private void ButtonCic2_Click(object sender, RoutedEventArgs e) => LaunchGame("Cic2_exe");
        private void ButtonCic3_Click(object sender, RoutedEventArgs e) => LaunchGame("Cic3_exe");
        private void ButtonCic4_Click(object sender, RoutedEventArgs e) => LaunchGame("Cic4_exe");
        private void ButtonUmi07T_Click(object sender, RoutedEventArgs e) => LaunchGame("Umi07T_exe");

    }
}
