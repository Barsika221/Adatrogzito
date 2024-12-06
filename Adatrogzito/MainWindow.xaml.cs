using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Adatrogzito
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HozzaadClick(object sender, RoutedEventArgs e)
        {
            string nev = TextBoxName.Text;
            string kor = TextBoxAge.Text;
            string email = TextBoxEmail.Text;
            string telefon = TextBoxPhoneNumber.Text;
            string cim = TextBoxAddress.Text;
            string nem = ComboBoxGender.Text;
            string megjegyzes = TextBoxComment.Text;

            if (nev.Length < 3)
            {
                MessageBox.Show("A név legalább 3 karakter hosszú kell legyen!");
                return;
            }
            if (!int.TryParse(kor, out int korInt) && korInt <= 0)
            {
                MessageBox.Show("A kor csak szám lehet!");
                return;
            }
            if (email.Length == 0 && !email.Contains("@"))
            {
                MessageBox.Show("Az email nem megfelelő formátumú!");
                return;
            }
            if (telefon.Length < 8 && !int.TryParse(telefon, out int telefonInt))
            {
                MessageBox.Show("A telefonszám legalább 8 karakter hosszú kell legyen!");
                return;
            }
            if (cim.Length == 0)
            {
                MessageBox.Show("A cím nem lehet üres!");
                return;
            }
            if (nem.Length == 0)
            {
                MessageBox.Show("A nem nem lehet üres!");
                return;
            }
            else
            {
                if (File.Exists("adatok.txt"))
                {
                    using (StreamWriter sw = File.AppendText("adatok.txt"))
                    {
                        sw.WriteLine(nev + "," + kor + "," + email + "," + telefon + "," + cim + "," + nem + "," + megjegyzes);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText("adatok.txt"))
                    {
                        sw.WriteLine(nev + "," + kor + "," + email + "," + telefon + "," + cim + "," + nem + "," + megjegyzes);
                    }
                }
            }
            MessageBox.Show("Sikeres hozzáadás!");
        }

        private void ListaoldalClick(object sender, RoutedEventArgs e)
        {
            UserList userList = new UserList();
            userList.Show();
            this.Close();
        }
    }
}