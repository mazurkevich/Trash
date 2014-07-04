using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Twitter_Killer
{
    class ViewModel : ViewModelBase
    {
        private string _login;
        private string _password;

        public ICommand LoginCommand { get; private set; }

        public string Login
        {
            get { return _login; }
            set { Set(ref _login, value); }
        }

        public string Password
        {
            get { return _password; }
            set { Set(ref _password, value); }
        }

        public ViewModel()
        {
            LoginCommand = new RelayCommand(OnLogin);
        }

        private void OnLogin()
        {
            Login = "Lol";
            Password = "azazaz";
        }
    }
}
