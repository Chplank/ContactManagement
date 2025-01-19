using ContactManagement.ViewModels.Pages;
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

namespace ContactManagement.Views.Pages;
/// <summary>
/// Interaction logic for ContactPage.xaml
/// </summary>
public partial class ContactPage : Page
{
    public ContactPage(ContactViewModel contactViewModel)
    {
        ContactViewModel = contactViewModel;
        DataContext = contactViewModel;

        InitializeComponent();
    }

    public ContactViewModel ContactViewModel { get; set; }
}
