using ContactManagement.Core.Models;
using ContactManagement.Views.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ContactManagement.ViewModels.Pages;

public partial class ContactViewModel : ObservableObject
{
    //public event PropertyChangedEventHandler? PropertyChanged;

    [ObservableProperty]
    private ObservableCollection<Contact> contacts = new();

    [RelayCommand]
    public void CreateContact()
    {
        Console.Write("Test");
        var view = new EditContact();
        if (view.ShowDialog() == true)
        {
            contacts.Add(view.Contact);
        }
    }

    [RelayCommand]
    public void ClearForm()
    {

    }

    [RelayCommand]
    public void EditContact(Contact contact)
    {

    }

    [RelayCommand]
    public void DeleteContact(int id)
    {
        Contact contact = (Contact)Contacts.Select(c => c.Id == id);

        Contacts.Remove(contact);
    }
}
