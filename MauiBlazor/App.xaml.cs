using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiBlazor
{
	public partial class App : Application
	{
		internal static AppState State {  get; set; } = new AppState();

		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}
	}
}
