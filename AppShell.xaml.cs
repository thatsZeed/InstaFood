using InstaFood.Views;
using InstaFood.Views.Account;

namespace InstaFood;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("login", typeof(LoginPage));
		Routing.RegisterRoute("main", typeof(MainPage));
		Routing.RegisterRoute("signup", typeof(SignUpPage));
		//Routing.RegisterRoute("account", typeof(AccountPage));
		Routing.RegisterRoute("cookbook", typeof(CookbookPage));
		Routing.RegisterRoute("search", typeof(SearchPage));
		Routing.RegisterRoute("resetpassword", typeof(ResetPasswordPage));
	}
}
