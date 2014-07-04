using System.Windows;

namespace Twitter_Killer
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // initializing client view with data context
            var clientView = new View {DataContext = new ViewModel()};
            clientView.Show();
        }
    }
}
