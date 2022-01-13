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

       private ObservableCollection<string> displayedDatabaseSources;

        private string selectedDatabaseSources;
        DatabaseSources repodatabaseSources;

        public DatabaseSourceViewModel()
        {
            repodatabaseSources = new DatabaseSources();
            displayedDatabaseSources = new ObservableCollection<string>(repodatabaseSources.GetAllDatabaseSources());

        }

        public ObservableCollection<string> DisplayedDatabaseSources
        {
            get => displayedDatabaseSources;
            
        }

        public string SelectedDatabaseSources
        {
            get => selectedDatabaseSources;
            set => selectedDatabaseSources = value;
        }




        

        
    }
}
