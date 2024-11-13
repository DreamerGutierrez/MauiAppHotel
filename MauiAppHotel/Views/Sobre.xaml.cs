namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
        InitializeComponent();
	}

    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new ContratacaoHospedagem();
    }
}