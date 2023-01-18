namespace NavegationDemo_DEINT.MVVM.Views;

public partial class PaginaFinal : ContentPage
{
	public PaginaFinal()
	{
		InitializeComponent();
	}

    private void btnPagIni_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    private void btnPag2_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
        //Navigation.PopModalAsync();
    }

    protected override bool OnBackButtonPressed()
    {
        return base.OnBackButtonPressed();
    }

}