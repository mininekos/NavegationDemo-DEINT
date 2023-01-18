using NavegationDemo_DEINT.MVVM.Views;

namespace NavegationDemo_DEINT;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage( new PaginaInicial());
	}
}
