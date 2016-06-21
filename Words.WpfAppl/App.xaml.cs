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
            var speaker = new SpeakerDummy();
            var listener = new ListenerDummy();

            IStrategyFactory strategyFactory = new StrategyFactory(speaker, listener);
            var strategySelector = new StrategySelector();
            var worldSource = new XmlWorldSource();

            var appl = new Appl(strategyFactory, strategySelector, worldSource);

            var view = new MainWindow
            {
                Width = 800,
                Height = 400,
            };

            var viewModel = new MainViewModel();
            view.DataContext = viewModel;

            view.Show();

            //appl.Run();
        }
    }
}
