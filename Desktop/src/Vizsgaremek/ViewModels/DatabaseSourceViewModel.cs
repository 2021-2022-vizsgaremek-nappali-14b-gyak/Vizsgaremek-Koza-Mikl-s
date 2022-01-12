using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Repositories;

namespace Vizsgaremek.ViewModels
{
    class DatabaseSourceViewModel
    {

       private ObservableCollection<string> displayedDatabaseSource;

        private string selectedDatabaseSource;
        DatabaseSources repodatabaseSources;

        public DatabaseSourceViewModel()
        {
            repodatabaseSources = new DatabaseSources();
            displayedDatabaseSource = new ObservableCollection<string>(repodatabaseSources.GetAllDatabaseSources());

        }

        public ObservableCollection<string> DisplayedDatabaseSource
        {
            get => displayedDatabaseSource;
            
        }

        public string SelectedDatabaseSource
        {
            get => selectedDatabaseSource;
            set => selectedDatabaseSource = value;
        }


        

        
    }
}
