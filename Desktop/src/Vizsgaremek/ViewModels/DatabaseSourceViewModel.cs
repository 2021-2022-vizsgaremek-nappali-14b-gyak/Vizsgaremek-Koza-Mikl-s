using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;
using Vizsgaremek.Repositories;

namespace Vizsgaremek.ViewModels
{
    public class DatabaseSourceViewModel
    {

       private ObservableCollection<string> displayedDatabaseSources;

        private string selectedDatabaseSource;
        DatabaseSources repodatabaseSources;
        private string displayedDatabaseSource;
        private DbSource dbSource;

        public string DisplayedDatabaseSource
        {
            get
            {
                switch (dbSource)
                {
                    case DbSource.DEVOPS:
                        return "devops adatforrás";
                        
                    case DbSource.LOCALHOST:
                        return "localhost adatforrás.";
                    case DbSource.NONE:
                        return "beépített teszt adatok";
                    default:
                        return "";
                }
            }
        }

        // Esemény kiváltása (raise)
        protected void OnDatabaseSourceChange()
        {
            // Argumentumba belepakoljuk az üzenetet
            DatabaseSourceEventArg dsea = new DatabaseSourceEventArg(DisplayedDatabaseSource);
            // Ha van esemény akkor meghívjük a feliratkozott osztályokat;
            if (ChangeDatabaseSource != null)
                ChangeDatabaseSource.Invoke(this, dsea);
        }


        public event EventHandler ChangeDatabaseSource;

        class DatabaseSourceEventArg : EventArgs
        {
            private string databaseSource;

            public DatabaseSourceEventArg(string databaseSource)
            {
                this.DatabaseSource = databaseSource;
            }

            public string DatabaseSource { get => databaseSource; set => databaseSource = value; }
        }



        public DatabaseSourceViewModel()
        {
            repodatabaseSources = new DatabaseSources();
            displayedDatabaseSources = 
                new ObservableCollection<string>(repodatabaseSources.GetAllDatabaseSources());
            SelectedDatabaseSources = "localhost";
        }

        public ObservableCollection<string> DisplayedDatabaseSources
        {
            get => displayedDatabaseSources;
            
        }

        public string SelectedDatabaseSources
        {
            get => selectedDatabaseSource;
            set 
            {
                selectedDatabaseSource = value;
                dbSource = DbSource;
                displayedDatabaseSource = DisplayedDatabaseSource;
                OnDatabaseSourceChange();
            }

        }

        public DbSource DbSource
        {
            get
            {
                //TDD fejlesztés
                //return DbSource.NONE;
                if (selectedDatabaseSource == "localhost")
                    return DbSource.LOCALHOST;
                
                else if (selectedDatabaseSource == "devops")
                    return DbSource.DEVOPS;
                return DbSource.NONE;
                

            }
        }




        

        
    }
}
