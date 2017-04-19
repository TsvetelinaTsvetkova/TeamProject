using ContactsCatalog.Data;
using ContactsCatalog.Data.ContactsCatalogStore;
using ContactsCatalog.Models;
using Microsoft.Win32;
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

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            OpenFileDialog dlg = new OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox and Image
            if (result == true)
            {
                // Open document
                image.Source = new BitmapImage(new Uri(dlg.FileName));
                string filename = dlg.FileName;
                ProfilePicturePathBox.Text = filename.ToString();

                Contact selectedContact = this.ContactsList.SelectedItem as Contact;

                selectedContact.ProfilePicturePath = ProfilePicturePathBox.Text;
            }
        }
    }
}
