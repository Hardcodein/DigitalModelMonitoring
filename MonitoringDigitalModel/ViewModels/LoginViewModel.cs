



using MonitoringDigitalModel.Models;
using MonitoringDigitalModel.Views;
using System.Runtime.InteropServices;

namespace MonitoringDigitalModel.ViewModels;
public partial class LoginViewModel
{
    public LoginViewModel()
    {
        
    }
    private User user = new User();
    private RelayCommand<User> _autentificationCommand;
    public ICommand AutentificationCommand => _autentificationCommand ?? new RelayCommand<User>(Autentification);
 
    public async  void Autentification(User user)
    {
        DbProvider dbProvider = new DbProvider();
        int? id = await dbProvider.GetDb(user.Login, user.Password);

        if (id == null)
        {
            MessageBox.Show("Нет такого пользователя");
        }
        MainViewModel mainViewModel = new MainViewModel();
        MainView mainView = new MainView();
        mainView.DataContext = mainViewModel;
        mainView.Show();
    }
}
