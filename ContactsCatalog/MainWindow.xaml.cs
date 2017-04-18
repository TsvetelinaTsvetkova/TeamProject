using ContactsCatalog.Data;
using ContactsCatalog.Models;
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

namespace ContactsCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

            var context = new ContactsCatalogContext();

            var first = new Contact
            {
                Name = "Ivan",
                Address = "Vasil Levski 5",
                ContactInformation = "School"
            };

            var second = new Contact
            {
                Name = "Petur",
                Address = "Vasil Levski 10",
                ContactInformation = "Work"
            };

            var third = new Contact
            {
                Name = "Milena",
                Address = "Ivan Vazov 10",
                ContactInformation = "Family"
            };

            context.Contacts.Add(first);
            context.Contacts.Add(second);
            context.Contacts.Add(third);
            context.SaveChanges();
            context.Contacts.Count();
        }
    }
}
