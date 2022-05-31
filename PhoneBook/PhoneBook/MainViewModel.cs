using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PhoneBook;

namespace PhoneBook
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
        public ObservableCollection<Contact> Contacts
        {
            get => contacts;
            set => contacts = value;
        }

        private Contact selectedContact;
        public Contact SelectedContact
        {
            get => selectedContact;
            set
            {
                selectedContact = value;
                if (selectedContact != null)
                    FillForm(selectedContact);
                else
                    ResetProperties();
                CheckDeleteButtonAvailablity();
                OnPropertyChanged();
            }
        }

        private string lastname;
        private string firstname;
        private string email;
        private string phoneNumber;
        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
                CheckSaveButtonAvailablity();
                OnPropertyChanged();
            }
        }
        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
                CheckSaveButtonAvailablity();
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                CheckSaveButtonAvailablity();
                OnPropertyChanged();
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                CheckSaveButtonAvailablity();
                OnPropertyChanged();
            }
        }

        private bool saveButtonEnabled;
        private bool deleteButtonEnabled;
        public bool SaveButtonEnabled
        {
            get { return saveButtonEnabled; }
            private set
            {
                saveButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool DeleteButtonEnabled
        {
            get { return deleteButtonEnabled; }
            private set
            {
                deleteButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public MainViewModel()
        {
            SaveCommand = new ActionCommand(SaveCommandAction);
            DeleteCommand = new ActionCommand(DeleteCommandAction);
        }

        private void SaveCommandAction()
        {
            if (SelectedContact == null)
            {
                Contacts.Add(new Contact(Lastname, Firstname, Email, PhoneNumber));
                ResetProperties();
            }
            else
            {
                SelectedContact.Lastname = Lastname;
                SelectedContact.Firstname = Firstname;
                SelectedContact.Email = Email;
                SelectedContact.PhoneNumber = PhoneNumber;

                SelectedContact = null;
            }
        }
        private void DeleteCommandAction()
        {
            Contacts.Remove(SelectedContact);
        }

        private void CheckSaveButtonAvailablity()
        {
            SaveButtonEnabled = (Lastname != null && Lastname != "") && (Firstname != null && Firstname != "") && ((Email != null && Email != "") || (PhoneNumber != null && PhoneNumber != ""));
        }
        private void CheckDeleteButtonAvailablity()
        {
            DeleteButtonEnabled = SelectedContact != null;
        }

        private void FillForm(Contact selectedContact)
        {
            Lastname = selectedContact.Lastname;
            Firstname = selectedContact.Firstname;
            Email = selectedContact.Email;
            PhoneNumber = selectedContact.PhoneNumber;
        }

        private void ResetProperties()
        {
            Lastname = null;
            Firstname = null;
            Email = null;
            PhoneNumber = null;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
