using ProjectLitvin.ClassFolder;
using ProjectLitvin.PageFolder.SellFolder;
using ProjectLitvin.WindowFolder;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace ProjectLitvin.PageFolder.ServiceFolder
{
    /// <summary>
    /// Логика взаимодействия для EditServicePage.xaml
    /// </summary>
    public partial class EditServicePage : Page
    {
        DGClass dGClass;
        public EditServicePage()
        {
            InitializeComponent();
            dGClass = new DGClass(ListUserDG);
        }

        private void AddIm_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BackIm_Click(object sender, RoutedEventArgs e)
        {
            StartWindow.OpenPage(new ServiceAdminPage());
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dGClass.LoadDG("Select * From dbo.WarehouseView " +
                $"Where ProductName Like '%{SearchTb.Text}%'");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dGClass.LoadDG("Select * From dbo.WarehouseView");
        }

        private void AddTypeIm_Click(object sender, RoutedEventArgs e)
        {
            StartWindow.OpenPage(new AddServicePage());
        }

        private void CustomerCh_Click(object sender, RoutedEventArgs e)
        {
            StartWindow.OpenPage(new CustomerPage());
        }
    }
}
