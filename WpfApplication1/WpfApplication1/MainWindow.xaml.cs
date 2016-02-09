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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            my_ellipse.Opacity = 1;
            my_square.Opacity = 1;
            my_rectangle.Opacity = 1;
        }

        private void Slider_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender == circle_slider)
            {
                double val = e.NewValue;
                my_ellipse.Opacity = Math.Max((circle_slider.Maximum - val) / circle_slider.Maximum, .2);
                my_ellipse.Height = (int)val;
                my_ellipse.Width = (int)val;
                
            }
            if (sender == square_slider)
            {
                double val = e.NewValue;
                my_square.Opacity = Math.Max((square_slider.Maximum - val) / square_slider.Maximum, .2);
                my_square.Height = (int)val;
                my_square.Width = (int)val;

            }
            if (sender == johnly_slider)
            {
                double val = e.NewValue;
                my_rectangle.Opacity = Math.Max((johnly_slider.Maximum - val) / johnly_slider.Maximum, .2);
                my_rectangle.Height = (int)val;
                my_rectangle.Width = 2 * (int)val;
            }
            
        }
    }
}
