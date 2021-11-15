using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVP.Vistas;
using MVP.Database;
using System.IO;

namespace MVP
{
    public partial class App : Application
    {
        #region Database
        static DatabaseQuerys database;

        public static DatabaseQuerys Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseQuerys(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBname6.db"));
                }
                return database;
            }
        }
        #endregion



        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Principal());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
