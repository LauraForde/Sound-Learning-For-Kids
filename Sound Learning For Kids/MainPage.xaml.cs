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
using Windows.Storage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Sound_Learning_For_Kids
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public void btn_click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Animals), null);

        }
       /* ApplicationDataContainer setting = ApplicationData.Current.LocalSettings;
        StorageFolder folder = ApplicationData.Current.LocalFolder;
        
        string name;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            name.Text = TextBox.
        }*/
    }
}
