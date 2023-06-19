using AppTest.Models;
using AppTest.ViewModels;
using AppTest.Views.Dashboard;

namespace AppTest;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		this.BindingContext = new AppShellViewModel();
	}
}
