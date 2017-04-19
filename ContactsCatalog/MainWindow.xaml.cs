using ContactsCatalog.Data;
using ContactsCatalog.Data.ContactsCatalogStore;
using ContactsCatalog.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ContactsCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

        ContactsCatalogStore store = new ContactsCatalogStore();

        public MainWindow()
        {
            InitializeComponent();

            LoadContacts();
        }

        private void SaveChangesClick_Click(object sender,
           RoutedEventArgs e)
        {
            this.store.SaveChanges();
        }

        public void LoadContacts()
        {
            DataContext = new ObservableCollection<Contact>(store.GetAllContacts());
        }

        private void AddNewContact_Click(object sender,
           RoutedEventArgs e)
        {
            ((ObservableCollection<Contact>)DataContext).Add(this.store.AddNewContact());
        }
    }
}
