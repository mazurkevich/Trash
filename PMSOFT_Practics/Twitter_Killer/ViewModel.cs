using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RestSharp;

namespace Twitter_Killer
{
    class ViewModel : ViewModelBase
    {
        private string _login;
        private string _password;
        private IUser _user;

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
           
        }
    }
}
