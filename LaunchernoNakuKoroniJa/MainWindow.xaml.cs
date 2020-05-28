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


namespace LaunchernoNakuKoroniJa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = Properties.Resources.Title;
        }
        private void LaunchGame(string gameName)
        {
            string path = ConfigurationManager.AppSettings[gameName];
            if (path == null)
            {
                MessageBox.Show(Properties.Resources.CantFindPath, Properties.Resources.CantFindPathTitle);
                return;
            }

            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show(Properties.Resources.CantFindGame, Properties.Resources.CantFindGameTitle);
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.UnknownError, Properties.Resources.UnknownErrorTitle);
            }
        }

        private void ButtonHigQ1_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi1");
        private void ButtonHigQ2_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi2");
        private void ButtonHigQ3_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi3");
        private void ButtonHigQ4_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi4");
        private void ButtonHigA1_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi5");
        private void ButtonHigA2_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi6");
        private void ButtonHigA3_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi7");
        private void ButtonHigA4_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi8");
        private void ButtonHigRei_Click(object sender, RoutedEventArgs e) => LaunchGame("HigurashiRei");
        private void ButtonHigHou_Click(object sender, RoutedEventArgs e) => LaunchGame("HigurashiHou");
        private void ButtonHigCon_Click(object sender, RoutedEventArgs e) => LaunchGame("HigurashiConsole");
        private void ButtonUmiQ_Click(object sender, RoutedEventArgs e) => LaunchGame("UminekoQuestion");
        private void ButtonUmiC_Click(object sender, RoutedEventArgs e) => LaunchGame("UminekoSaku");
        private void ButtonUmiT_Click(object sender, RoutedEventArgs e) => LaunchGame("UminakoTsubasa");
        private void ButtonUmiH_Click(object sender, RoutedEventArgs e) => LaunchGame("UminekoHane");
        private void ButtonUmiS_Click(object sender, RoutedEventArgs e) => LaunchGame("UminekoSaku");
        private void ButtonUmi07T_Click(object sender, RoutedEventArgs e) => LaunchGame("07thTheatre");
        private void ButtonCic1_Click(object sender, RoutedEventArgs e) => LaunchGame("Ciconia1");
        private void ButtonCic2_Click(object sender, RoutedEventArgs e) => LaunchGame("Ciconia2");
        private void ButtonCic3_Click(object sender, RoutedEventArgs e) => LaunchGame("Ciconia3");
        private void ButtonCic4_Click(object sender, RoutedEventArgs e) => LaunchGame("Ciconia4");
    }
}
