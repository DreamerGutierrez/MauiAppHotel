namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

	private void OnSobreClicked(object sender, EventArgs e)
	{
        App.Current.MainPage = new Sobre();
    }
}