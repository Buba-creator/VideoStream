using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VideoStream.Services;
using VideoStream.Views;
using System.IO;

namespace VideoStream
{
    public partial class App : Application
    {
        static SqlDatabase database;

        public App ()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }


		public static SqlDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new SqlDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "VideoSQLite.db3"));
				}
				return database;
			}
		}

		protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}
