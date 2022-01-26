﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Vizsgaremek;

using Vizsgaremek.Views.Navigation;
using Vizsgaremek.Views.Pages;
using Vizsgaremek.ViewModels;

namespace Vizsgaremek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainWindowViewModel mainWindowViewModel;
        DatabaseSourceViewModel databaseSourceViewModel;



        public MainWindow()
        {
            mainWindowViewModel = new MainWindowViewModel();
            databaseSourceViewModel = new DatabaseSourceViewModel();
            InitializeComponent();

            this.DataContext = mainWindowViewModel;
            mainWindowViewModel.SelectedSource = databaseSourceViewModel.DisplayedDatabaseSource;


            databaseSourceViewModel.ChangeDatabaseSource += DatabaseSourceViewModel_ChangeDatabaseSource1; ;

           





            this.DataContext = mainWindowViewModel;
            Navigate.mainWindow = this;
            WelcomePage welcomePage = new WelcomePage();
            Navigate.Navigation(welcomePage);
        }

        private void DatabaseSourceViewModel_ChangeDatabaseSource1(object sender, EventArgs e)
        {
            DatabaseSourceEventArg dsea = (DatabaseSourceEventArg)e;
            mainWindowViewModel.SelectedSource = dsea.DatabaseSource;
        }

       

       

        /// <summary>
        /// ListView elemen bal egér gomb fel lett engedve
        /// </summary>
        /// <param name="sender">ListView amin megnyomtuk a bal egér gombot</param>
        /// <param name="e"></param>
        private void ListView_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ListView lvMenu = sender as ListView;
            ListViewItem lvMenuItem = lvMenu.SelectedItem as ListViewItem;
            //ListViewItem lvMenuItem = (ListViewItem) lvMenu.SelectedItem;

            if (lvMenuItem != null)
            {
                // x:Name tulajdonságot vizsgáljuk
                switch (lvMenuItem.Name)
                {
                    case "lviExit":
                        Close();
                        break;
                    case "lviProgramVersion":
                        ProgramVersion programVersion = new ProgramVersion();
                        Navigate.Navigation(programVersion);
                        break;

                    case "lviDatabaseSourceSelection":
                        DatabaseSourcePage databaseSourcePage = new DatabaseSourcePage(databaseSourceViewModel);
                        Navigate.Navigation(databaseSourcePage);
                        break;
                }
                
            }
        }


    }
}
