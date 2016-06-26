using System.Windows;
using Word.WpfAppl.View;
using Word.WpfAppl.ViewModel;
using Words.Model;
using Words.Model.IO;
using Words.Model.Strategy;
using Words.Model.StrategyContracts;

namespace Word.WpfAppl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            

            var view = new MainWindow
            {
                Width = 800,
                Height = 400,
            };

            var viewModel = new MainViewModel();
            view.DataContext = viewModel;

            view.Show();
        }
    }
}
