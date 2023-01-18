namespace NavegationDemo_DEINT.MVVM.Views;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();
	}

    private void btnPag2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Pagina2(txtNombre.Text));
		//Navigation.PushModalAsync(new Pagina2());
    }
}