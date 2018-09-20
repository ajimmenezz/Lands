namespace Lands.ViewModels
{
    class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login {
            get; set;
        }
        #endregion

        #region Contructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
