using VERTER_MAUI.MVVM.ViewModels;

namespace VERTER_MAUI;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
		//BindingContext = new ConverterViewModel();
	}

    private void Picker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
		var viewModel = (ConverterViewModel)BindingContext;
		viewModel.Convert();
    }
}
