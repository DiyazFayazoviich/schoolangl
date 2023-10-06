﻿using schoolangl.Components;
using System;
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

namespace schoolangl.Pages
{

    public partial class ServiceListPage : Page
    {
        public ServiceListPage()
        {
            InitializeComponent();
            var serviceslist = App.db.Service.ToList();
            foreach (var service in serviceslist)
            {
                ServiceWp.Children.Add(new ServiceUserControl(service));
            }
        }
    }
}