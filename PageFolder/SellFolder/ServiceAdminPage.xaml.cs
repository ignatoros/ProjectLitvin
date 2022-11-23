using ProjectLitvin.ClassFolder;
using ProjectLitvin.PageFolder.EmployeeFolder;
using ProjectLitvin.WindowFolder;
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

namespace ProjectLitvin.PageFolder.ServiceFolder
{
    /// <summary>
    /// Логика взаимодействия для ServiceAdminPage.xaml
    /// </summary>
    public partial class ServiceAdminPage : Page
    {
        DGClass dGClass;
        public ServiceAdminPage()
        {
            InitializeComponent();
            dGClass = new DGClass(ListUserDG);
        }

        private void AddIm_Click(object sender, RoutedEventArgs e)
        {
            StartWindow.OpenPage(new AddServicePage());
        }

        private void BackIm_Click(object sender, RoutedEventArgs e)
        {
            StartWindow.OpenPage(new AuthorizationPage());
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dGClass.LoadDG("Select * From dbo.SaleView " +
                $"Where ProductName Like '%{SearchTb.Text}%'");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dGClass.LoadDG("Select * From dbo.SaleView");
        }

        private void AddTypeIm_Click(object sender, RoutedEventArgs e)
        {
            StartWindow.OpenPage(new EditServicePage());
        }
    }
}
