using AppTest.ViewModels.Startup;
using Microsoft.VisualBasic;

namespace AppTest.Views.Startup;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}