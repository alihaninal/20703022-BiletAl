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
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            combobox_cinsiyet.Items.Add("Kadın");
            combobox_cinsiyet.Items.Add("Erkek");

            combobox_koltuk.Items.Add("1");
            combobox_koltuk.Items.Add("2");
            combobox_koltuk.Items.Add("3");
            combobox_koltuk.Items.Add("4");
            combobox_koltuk.Items.Add("5");
            combobox_koltuk.Items.Add("6");
            combobox_koltuk.Items.Add("7");
            combobox_koltuk.Items.Add("8");
            combobox_koltuk.Items.Add("9");
            combobox_koltuk.Items.Add("10");
            combobox_koltuk.Items.Add("11");
            combobox_koltuk.Items.Add("12");
            combobox_koltuk.Items.Add("13");
            combobox_koltuk.Items.Add("14");
            combobox_koltuk.Items.Add("15");


           
            
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Satın_Al_Click(object sender, RoutedEventArgs e)
        {

            
            if(ad_txt.Text  == "")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
                return;

            }
            if (txt_soyad.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
                return;
            }
            if (combobox_cinsiyet.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
                return;
            }
            if (combobox_koltuk.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
                return;
            }
            if (txt_tc.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
                return;
            }


            string koltuk = combobox_koltuk.Text;


            string koltuk1 = bir.Text;
            if (koltuk == koltuk1)
            {
                bir.Background = Brushes.Red;
            }

            string koltuk2 = iki.Text;
            if (koltuk == koltuk2)
            {
                iki.Background = Brushes.Red;
            }

            string koltuk3 = uc.Text;
            if (koltuk == koltuk3)
            {
                uc.Background = Brushes.Red;
            }

            string koltuk4 = dort.Text;
            if (koltuk == koltuk4)
            {
                dort.Background = Brushes.Red;
            }

            string koltuk5 = bes.Text;
            if (koltuk == koltuk5)
            {
                bes.Background = Brushes.Red;
            }
            string koltuk6 = altı.Text;
            if (koltuk == koltuk6)
            {
                altı.Background = Brushes.Red;
            }

            string koltuk7 = yedi.Text;
            if (koltuk == koltuk7)
            {
                yedi.Background = Brushes.Red;
            }

            string koltuk8 = sekiz.Text;
            if (koltuk == koltuk8)
            {
                sekiz.Background = Brushes.Red;
            }

            string koltuk9 = dokuz.Text;
            if (koltuk == koltuk9)
            {
                dokuz.Background = Brushes.Red;
            }

            string koltuk10 = on.Text;
            if (koltuk == koltuk10)
            {
                on.Background = Brushes.Red;
            }
            string koltuk11 = onbir.Text;
            if (koltuk == koltuk11)
            {
                onbir.Background = Brushes.Red;
            }

            string koltuk12 = oniki.Text;
            if (koltuk == koltuk12)
            {
                oniki.Background = Brushes.Red;
            }

            string koltuk13 = onuc.Text;
            if (koltuk == koltuk13)
            {
                onuc.Background = Brushes.Red;
            }

            string koltuk14 = ondort.Text;
            if (koltuk == koltuk14)
            {
                ondort.Background = Brushes.Red;
            }

            string koltuk15 = onbes.Text;
            if (koltuk == koltuk15)
            {
                onbes.Background = Brushes.Red;
            }
        }

        private void Temizle_Click(object sender, RoutedEventArgs e)
        {
            ad_txt.Clear();
            txt_soyad.Clear();
            txt_tc.Clear();
            combobox_cinsiyet.Items.Clear();
            combobox_koltuk.Items.Clear();
        }

        private void Rakamgirisi(object sender, TextCompositionEventArgs e) 
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        
    }
}
