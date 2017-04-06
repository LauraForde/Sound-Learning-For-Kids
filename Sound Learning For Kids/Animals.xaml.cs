using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sound_Learning_For_Kids
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Animals : Page
    {
        public Animals()
        {
            this.InitializeComponent();
        }

        public void btn_click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }
        public void lion_click(object sender, RoutedEventArgs e)
        {
            lion.Play();
        }
        public void cat_click(object sender, RoutedEventArgs e)
        {
            cat.Play();
        }
        public void dog_click(object sender, RoutedEventArgs e)
        {
            dog.Play();
        }
        public void pig_click(object sender, RoutedEventArgs e)
        {
            pig.Play();
        }
        public void bear_click(object sender, RoutedEventArgs e)
        {
            bear.Play();
        }
        public void bee_click(object sender, RoutedEventArgs e)
        {
            bee.Play();
        }
        public void chicken_click(object sender, RoutedEventArgs e)
        {
            chicken.Play();
        }
        public void cow_click(object sender, RoutedEventArgs e)
        {
            cow.Play();
        }
        public void duck_click(object sender, RoutedEventArgs e)
        {
            duck.Play();
        }
        public void elephant_click(object sender, RoutedEventArgs e)
        {
            elephant.Play();
        }
        public void frog_click(object sender, RoutedEventArgs e)
        {
            frog.Play();
        }
        public void geese_click(object sender, RoutedEventArgs e)
        {
            geese.Play();
        }
        public void gorilla_click(object sender, RoutedEventArgs e)
        {
            gorilla.Play();
        }
        public void horse_click(object sender, RoutedEventArgs e)
        {
            horse.Play();
        }
        public void kook_click(object sender, RoutedEventArgs e)
        {
            kook.Play();
        }
        public void owl_click(object sender, RoutedEventArgs e)
        {
            owl.Play();
        }
        public void sheep_click(object sender, RoutedEventArgs e)
        {
            sheep.Play();
        }
        public void turkey_click(object sender, RoutedEventArgs e)
        {
            turkey.Play();
        }
    }
}
