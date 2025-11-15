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

namespace WpfApplication2
{
   
    public partial class MainWindow : Window
    {
        ServiceReference1.Service1Client baglanti = new ServiceReference1.Service1Client();
        public MainWindow()
        {
            InitializeComponent();
            
         
           
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Kullanici a = new ServiceReference1.Kullanici();
            a.Kullad = kulad.Text;
            a.Sifre=sifre.Text;

            a.Isim="*";
            a.Soyisim="*";
            a.Email="*";

            if (baglanti.YeniKullanici(a) == true)
            {
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Eklenmedi");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (baglanti.SifreKontrol(kulad.Text, sifre.Text) == true)
            {
                MessageBox.Show("Giris Yapıldı");
                Window1 wn1 = new Window1();
                wn1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seni Tanımıyorum....");
            }
        }

       
    }
}
