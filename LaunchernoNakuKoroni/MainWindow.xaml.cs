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
using System.Diagnostics;

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
            Title = Properties.Resources.Title;
        }
        private void LaunchGame(string gameName, string gameParams)
        {
            string path = ConfigurationManager.AppSettings[gameName];
            string path2 = ConfigurationManager.AppSettings[gameParams];
            ///check if the first string is empty and complain if it is
            if (path == "")
            {
                MessageBox.Show(Properties.Resources.CantFindPath, Properties.Resources.CantFindPathTitle);
                return;
            }
            ///check if the path in the first string is correct and complain if it isn't
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show(Properties.Resources.CantFindGame, Properties.Resources.CantFindGameTitle);
                return;
            }
            try
            {
                ///if the second parameter is empty, consider the first string as the game itself
                ///and start it without any parameters
                if (path2 == "")
                {
                    Process.Start(path);
                    return;
                }
                ///check if the path in the second string is correct and complain if it isn't
                if (path2 != "" & !System.IO.File.Exists(path2))
                {
                    MessageBox.Show(Properties.Resources.CantFindGame, Properties.Resources.CantFindGameTitle);
                    return;
                }
                ///start the Locale Emulator and the requested game as its parameter
                Process.Start(path, path2);
                return;
            }
            ///complain at anything weird
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.UnknownError, Properties.Resources.UnknownErrorTitle);
            }
        }
        /// <summary>
        /// Actions for the buttons
        /// </summary>
        private void ButtonHigQ1_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi1", "Higurashi1Param");
        private void ButtonHigQ2_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi2", "Higurashi2Param");
        private void ButtonHigQ3_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi3", "Higurashi3Param");
        private void ButtonHigQ4_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi4", "Higurashi4Param");
        private void ButtonHigA1_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi5", "Higurashi5Param");
        private void ButtonHigA2_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi6", "Higurashi6Param");
        private void ButtonHigA3_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi7", "Higurashi7Param");
        private void ButtonHigA4_Click(object sender, RoutedEventArgs e) => LaunchGame("Higurashi8", "Higurashi8Param");
        private void ButtonHigRei_Click(object sender, RoutedEventArgs e) => LaunchGame("HigurashiRei", "HigurashiReiParam");
        private void ButtonHigHou_Click(object sender, RoutedEventArgs e) => LaunchGame("HigurashiHou", "HigurashiHouParam");
        private void ButtonHigCon_Click(object sender, RoutedEventArgs e) => LaunchGame("HigurashiConsole", "HigurashiConsoleParam");
        private void ButtonUmiQ_Click(object sender, RoutedEventArgs e) => LaunchGame("UminekoQuestion", "UminekoQuestionParam");
        private void ButtonUmiC_Click(object sender, RoutedEventArgs e) => LaunchGame("UminekoSaku", "UminekoSakuParam");
        private void ButtonUmiT_Click(object sender, RoutedEventArgs e) => LaunchGame("UminakoTsubasa", "UminakoTsubasaParam");
        private void ButtonUmiH_Click(object sender, RoutedEventArgs e) => LaunchGame("UminekoHane", "UminekoHaneParam");
        private void ButtonUmiS_Click(object sender, RoutedEventArgs e) => LaunchGame("UminekoSaku", "UminekoSakuParam");
        private void ButtonUmi07T_Click(object sender, RoutedEventArgs e) => LaunchGame("07thTheatre", "07thTheatreParam");
        private void ButtonCic1_Click(object sender, RoutedEventArgs e) => LaunchGame("Ciconia1", "Ciconia1Param");
        private void ButtonCic2_Click(object sender, RoutedEventArgs e) => LaunchGame("Ciconia2", "Ciconia2Param");
        private void ButtonCic3_Click(object sender, RoutedEventArgs e) => LaunchGame("Ciconia3", "Ciconia3Param");
        private void ButtonCic4_Click(object sender, RoutedEventArgs e) => LaunchGame("Ciconia4", "Ciconia4Param");
    }
}
