using MauiVerter.ViewModels;

namespace MauiVerter.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var gridElemend = (Grid)sender;

        var labelText = ((Label)gridElemend.Children.LastOrDefault()).Text;

        var ConverterView = new ConverterView()
        {
            BindingContext = new ConverterViewModel(labelText)
        };

        Navigation.PushAsync(ConverterView);
    }
}