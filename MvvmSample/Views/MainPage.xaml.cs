using MvvmSample.ViewModels;

namespace MvvmSample;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
	
		InitializeComponent();
		this.BindingContext = vm;

	}

	
}

