using System.IO;
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

namespace Adatrogzito
{
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList : Window
    {
        public UserList()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("adatok.txt");
            foreach (string line in lines)
            {
                userListBox.Items.Add(line);
            }
        }

        private void AddPageClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void DataDeleteClick(object sender, MouseButtonEventArgs e)
        {
            string[] lines = File.ReadAllLines("adatok.txt");
            File.WriteAllText("adatok.txt", string.Empty);
            foreach (string line in lines)
            {
                if (userListBox.SelectedItem.ToString() != line)
                {
                    File.AppendAllText("adatok.txt", line + Environment.NewLine);
                }
            }
            userListBox.Items.Clear();
            lines = File.ReadAllLines("adatok.txt");
            foreach (string line in lines)
            {
                userListBox.Items.Add(line);
            }
        }
    }
}
