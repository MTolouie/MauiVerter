using MauiVerter.Views;

namespace MauiVerter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MenuView();
	}
}
