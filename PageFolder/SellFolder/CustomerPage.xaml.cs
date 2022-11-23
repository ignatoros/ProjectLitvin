using ProjectLitvin.ClassFolder;
using ProjectLitvin.PageFolder.ServiceFolder;
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

namespace ProjectLitvin.PageFolder.SellFolder
{
    /// <summary>
    /// Логика взаимодействия для CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        DGClass dGClass;
        public CustomerPage()
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
            StartWindow.OpenPage(new ServiceAdminPage());
}

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dGClass.LoadDG("Select * From dbo.Customer " +
                $"Where CustomerName Like '%{SearchTb.Text}%'");
}

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dGClass.LoadDG("Select * From dbo.Customer");
        }

        private void AddTypeIm_Click(object sender, RoutedEventArgs e)
        {
            StartWindow.OpenPage(new AddServicePage());
        }

        private void CustomerCh_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
