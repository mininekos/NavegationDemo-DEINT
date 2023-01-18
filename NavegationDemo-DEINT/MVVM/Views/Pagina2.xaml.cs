namespace NavegationDemo_DEINT.MVVM.Views;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
	}
    public Pagina2(string s)
    {
        InitializeComponent();
        txtEntrada.Text = s;
    }

    private void btnPagIni_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
        //Navigation.PopModalAsync();
    }

    private void btnPagFnl_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaFinal());

        //Son dos pilas distintas por lo que no puedo continuar con la otra
        //Navigation.PushModalAsync(new PaginaFinal());
    }
}