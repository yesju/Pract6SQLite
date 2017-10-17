using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace Pract6SQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SQLiteAsyncConnection database;
            string db;

            db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<TESHDatos>().Wait();

            var elemento = new TESHDatos
            {
                Id = "13090337",
                Dato1 = "Yesica",
                Dato2 = "Castro",
                Dato3 = "Irack",
                Dato4 = "53161370",
                Dato5 = "ISC",
                Dato6 = "Noveno",
                Dato7 = "castroyess@hotmail.com",
                Dato8 = "yesju"
            };
            database.InsertAsync(elemento);
        }
    }
}
