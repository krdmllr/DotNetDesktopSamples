using System;
using Microsoft.Maui.Controls;

namespace MauiBlazor
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			App.State.CounterChanged += (s, e) => UpdateCounter();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			App.State.IncrementCounter();
		}

		private void UpdateCounter()
        {
			CounterLabel.Text = $"Current count: {App.State.Counter}";
		}
	}
}
