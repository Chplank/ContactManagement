using ContactManagement.Core.Models;
using ContactManagement.ViewModels.Windows;
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
using System.Windows.Shapes;

namespace ContactManagement.Views.Windows
{
    /// <summary>
    /// Interaction logic for EditContact.xaml
    /// </summary>
    public partial class EditContact : Window
    {
        public EditContact()
        {
            InitializeComponent();
        }
        public Contact Contact
        {
            get => (this.DataContext as EditContactViewModel)!.Contact;
            set => (this.DataContext as EditContactViewModel)!.Contact = value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
