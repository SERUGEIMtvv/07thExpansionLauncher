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

        private void ButtonHigQ1_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigQ1_exe"));
        private void ButtonHigQ2_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigQ2_exe"));
        private void ButtonHigQ3_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigQ3_exe"));
        private void ButtonHigQ4_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigQ4_exe"));
        private void ButtonHigA1_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigA1_exe"));
        private void ButtonHigA2_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigA2_exe"));
        private void ButtonHigA3_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigA3_exe"));
        private void ButtonHigA4_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigA4_exe"));
        private void ButtonHigRei_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigRei_exe"));
        private void ButtonHigHou_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigHou_exe"));
        private void ButtonHigCon_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("HigCon_exe"));
        private void ButtonUmiQ_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("UmiQ_exe"));
        private void ButtonUmiA_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("UmiA_exe"));
        private void ButtonUmiT_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("UmiT_exe"));
        private void ButtonUmiH_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("UmiH_exe"));
        private void ButtonUmiS_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("UmiS_exe"));
        private void ButtonCic1_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("Cic1_exe"));
        private void ButtonCic2_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("Cic2_exe"));
        private void ButtonCic3_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("Cic3_exe"));
        private void ButtonCic4_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("Cic4_exe"));
        private void ButtonUmi07T_Click(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start(ConfigurationManager.AppSettings.Get("Umi07T_exe"));

    }
}
