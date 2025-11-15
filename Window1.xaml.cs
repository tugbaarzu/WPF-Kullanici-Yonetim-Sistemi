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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        class nesne
        {
            public double en = 50;
            public double boy = 50;

            public int fx = 0;
            public int fy = 0;

            public double konumx { get; set; }
            public double konumy { get; set; }

           

        }
        nesne eleman = new nesne();
        public Window1()
        {
            InitializeComponent();
            Ekran.DataContext = eleman;
            eleman.konumx = 0;
            eleman.konumy = 0;
        }
        //private void rec1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    int sol;
        //    int ust;
        //    ust = Convert.ToInt32(Canvas.GetTop(rec1));
        //    sol = Convert.ToInt32(Canvas.GetLeft(rec1));

        //    if (e.Key == Key.Left)
        //    {
        //        Canvas.SetLeft(rec1, sol - 20);
             
        //    }
        //    else if (e.Key == Key.Right)
        //    {
        //        Canvas.SetLeft(rec1, sol -20);
        //    }
        //    else if (e.Key == Key.Down)
        //    {
        //        Canvas.SetTop(rec1, ust + -20);
        //    }
        //    else if (e.Key == Key.Up)
        //    {
        //        Canvas.SetTop(rec1, ust - 20);
        //    }

        //}
        private void rec1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                eleman.fy = 0;
                eleman.fx++;
                if (eleman.fx > 4) eleman.fx = 0;
                eleman.konumy -= 5;
                if (eleman.konumy < 0)
                {
                    eleman.konumy = 0;
                }

            }
            if (e.Key == Key.Left)
            {
                eleman.fy = 0;
                eleman.fx++;
                if (eleman.fx > 4) eleman.fx = 0;
                eleman.konumx -= 5;

                if (eleman.konumx < 0)
                {
                    eleman.konumx = 0;
                }
            }
            if (e.Key == Key.Right)
            {
                eleman.fy = 0;
                eleman.fx++;
                if (eleman.fx > 4) eleman.fx = 0;
                eleman.konumx += 5;

                if (eleman.konumx > 230)
                {
                    eleman.konumx = 230;
                }
            }
            if (e.Key == Key.Down)
            {
                eleman.fy = 0;
                eleman.fx++;
                if (eleman.fx > 4) eleman.fx = 0;
                eleman.konumy += 5;

                if (eleman.konumy > 210)
                {
                    eleman.konumy = 210;
                }
            }

            Ekran.DataContext = "";
            Ekran.DataContext = eleman;
        }
    }
}
