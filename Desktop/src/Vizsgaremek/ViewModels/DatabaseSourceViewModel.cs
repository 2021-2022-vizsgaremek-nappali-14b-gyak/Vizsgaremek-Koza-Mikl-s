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

        private string selectedDatabaseSources;
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


        public DatabaseSourceViewModel()
        {
            repodatabaseSources = new DatabaseSources();
            displayedDatabaseSources = new ObservableCollection<string>(repodatabaseSources.GetAllDatabaseSources());
            SelectedDatabaseSources = "localhost";
        }

        public ObservableCollection<string> DisplayedDatabaseSources
        {
            get => displayedDatabaseSources;
            
        }

        public string SelectedDatabaseSources
        {
            get => selectedDatabaseSources;
            set 
            {
                selectedDatabaseSources = value;
                displayedDatabaseSource = DisplayedDatabaseSource;
                dbSource = DbSource;
                OnDatabaseSourceChange();
            }

        }

        public DbSource DbSource
        {
            get
            {
                //TDD fejlesztés
                //return DbSource.NONE;
                if (selectedDatabaseSources == "localhost")
                    return DbSource.LOCALHOST;
                
                else if (selectedDatabaseSources == "devops")
                    return DbSource.DEVOPS;
                return DbSource.NONE;
                

            }
        }




        

        
    }
}
