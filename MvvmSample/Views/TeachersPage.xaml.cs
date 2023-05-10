using MvvmSample.Models;
using MvvmSample.ViewModels;

namespace MvvmSample.Views;

public partial class TeachersPage : ContentPage
{
	public TeachersPage(TeachersViewModel tvm)
	{
		InitializeComponent();

		this.BindingContext = tvm;
	}
}