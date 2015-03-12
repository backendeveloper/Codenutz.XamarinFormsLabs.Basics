﻿using Codenutz.XFLabs.Basics.View;
using Codenutz.XFLabs.Basics.ViewModel;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using XLabs.Platform.Device;

namespace Codenutz.XFLabs.Basics
{
	public class App : Application
	{
		public App()
		{
			RegisterViews();
			MainPage = new NavigationPage((Page)ViewFactory.CreatePage<MainViewModel, MainView>());
		}

		private void RegisterViews()
		{
			ViewFactory.Register<MainView, MainViewModel>();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
