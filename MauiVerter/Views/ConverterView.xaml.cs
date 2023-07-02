using MauiVerter.ViewModels;
using System.Runtime.InteropServices;

namespace MauiVerter.Views;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var context = (ConverterViewModel)BindingContext;
		context.Convert();
    }

   
}