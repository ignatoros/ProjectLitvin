using ProjectLitvin.ClassFolder;
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

namespace ProjectLitvin.PageFolder.GuestPage
{
    /// <summary>
    /// Логика взаимодействия для EmployeeGuestPage.xaml
    /// </summary>
    public partial class EmployeeGuestPage : Page
    {
        DGClass dGClass;
        public EmployeeGuestPage()
        {
            InitializeComponent();
            dGClass = new DGClass(ListUserDG);
        }
        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dGClass.LoadDG("Select IdEmployee,EmployeeName,EmployeeLastName From dbo.Employee " +
                $"Where EmployeeName Like '%{SearchTb.Text}%'");
        }

        private void AddIm_Click(object sender, RoutedEventArgs e)
        {
            StartWindow.OpenPage(new ServiceFolder.ServiceAdminPage());
        }

        private void BackIm_Click(object sender, RoutedEventArgs e)
        {
            StartWindow.OpenPage(new EmployeeGuestPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dGClass.LoadDG("Select IdEmployee,EmployeeName,EmployeeLastName From dbo.Employee");
        }
    }
}
