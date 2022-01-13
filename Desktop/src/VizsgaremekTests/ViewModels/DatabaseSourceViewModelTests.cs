using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vizsgaremek.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels.Tests
{
    [TestClass()]
    public class DatabaseSourceViewModelTests
    {
        [TestMethod()]
        public void DatabaseSourceViewModelTestLocalhost()
        {
            DatabaseSourceViewModel databaseSourceViewModel = new DatabaseSourceViewModel();
            // Felhasználó "rákattintott a localhostra
            databaseSourceViewModel.SelectedDatabaseSources = "localhost";
            DbSource expectedDbSource = DbSource.LOCALHOST;

            DbSource actualDbSource = databaseSourceViewModel.DbSource;

            Assert.AreEqual(expectedDbSource, actualDbSource, "A kiválasztott adatbázis a 'localhost', de nem váltott át DbSource.LOCALHOST-ra");

        }


        [TestMethod()]
        public void DatabaseSourceViewModelTestNONE()
        {
            DatabaseSourceViewModel databaseSourceViewModel = new DatabaseSourceViewModel();
            // Felhasználó "rákattintott a localhostra
            databaseSourceViewModel.SelectedDatabaseSources = "none";
            DbSource expectedDbSource = DbSource.NONE;

            DbSource actualDbSource = databaseSourceViewModel.DbSource;

            Assert.AreEqual(expectedDbSource, actualDbSource, "A kiválasztott adatbázis a 'NONE', de nem váltott át DbSource.NONE-ra");

        }

        [TestMethod()]
        public void DatabaseSourceViewModelTestDEVOPS()
        {
            DatabaseSourceViewModel databaseSourceViewModel = new DatabaseSourceViewModel();
            // Felhasználó "rákattintott a localhostra
            databaseSourceViewModel.SelectedDatabaseSources = "devops";
            DbSource expectedDbSource = DbSource.DEVOPS;

            DbSource actualDbSource = databaseSourceViewModel.DbSource;

            Assert.AreEqual(expectedDbSource, actualDbSource, "A kiválasztott adatbázis a 'devops', de nem váltott át DbSource.DEVOPS-ra");

        }


    }
}