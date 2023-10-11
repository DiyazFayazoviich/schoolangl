using schoolangl.Components;
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
    /// <summary>
    /// Логика взаимодействия для ServiceListPage.xaml
    /// </summary>
    public partial class ServiceListPage : Page
    {
        public ServiceListPage()
        {
            InitializeComponent();
            if (App.isAdmin == false)
            {
                AddBtn.Visibility = Visibility.Hidden;
            }
            var serviceslist = App.db.Service.ToList();
            foreach (var service in serviceslist)
            {
                ServiceWp.Children.Add(new ServiceUserControl(service));
            }

        }
        private void ReFresh()
        {
            IEnumerable<Service> serviceSortlist = App.db.Service;
            if(SortCb.SelectedIndex == 1)
            {
                serviceSortlist = serviceSortlist.OrderBy(x => x.CostDiscount);
            }
            else if (SortCb.SelectedIndex == 2)
            {
                serviceSortlist = serviceSortlist.OrderByDescending(x => x.CostDiscount);
            }
            ServiceWp.Children.Clear();    
            foreach (var service in serviceSortlist)
            {
                ServiceWp.Children.Add(new ServiceUserControl(service));
            }
        }
        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ReFresh();
        }
    }
}
