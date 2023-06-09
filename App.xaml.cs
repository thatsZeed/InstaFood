using InstaFood.Database;
using InstaFood.Views;

namespace InstaFood;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}

	public static LoginDatabase database;

	public static LoginDatabase Database
	{
		get
		{
			if (database == null)
			{
				database = new LoginDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)));
			}
			return database;
		}
	}
}
