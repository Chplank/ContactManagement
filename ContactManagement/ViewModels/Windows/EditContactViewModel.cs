using ContactManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagement.ViewModels.Windows
{
    public partial class EditContactViewModel : ObservableObject
    {   
        [ObservableProperty]
        private Contact contact = new();
    }
}
