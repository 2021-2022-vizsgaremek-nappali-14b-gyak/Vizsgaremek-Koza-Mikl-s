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

using Vizsgaremek.Views.Pages;
using Vizsgaremek.ViewModels;
using Vizsgaremek.Views.Navigation;

namespace Vizsgaremek.Views.Pages
{
    /// <summary>
    /// Interaction logic for DatabaseSourcePage.xaml
    /// </summary>
    public partial class DatabaseSourcePage : UserControl
    {
        DatabaseSourceViewModel databaseSourceViewModel;

        public DatabaseSourcePage()
        {
            databaseSourceViewModel = new DatabaseSourceViewModel();
            InitializeComponent();
            this.DataContext = databaseSourceViewModel;
        }
       
        private void Image_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            Navigate.Navigation(welcomePage);
        }
    }
}
