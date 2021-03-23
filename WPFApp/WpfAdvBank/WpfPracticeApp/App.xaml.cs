using MahApps.Metro.Controls;
using System.Windows;

namespace WpfPracticeApp
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var navWIn = new MetroNavigationWindow();
            navWIn.Title = @"WPF Bikeshop";
            navWIn.Show();
            navWIn.Navigate(new MainMenu());
        }
    }
}
