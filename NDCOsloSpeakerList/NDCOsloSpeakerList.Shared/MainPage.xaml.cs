using NDCOsloSpeakerList.Shared;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


namespace NDCOsloSpeakerList
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SpeakerList_ItemClick(object sender, ItemClickEventArgs e)
        {
            var speaker = e.ClickedItem as Speaker;
            this.Frame.Navigate(typeof(SpeakerDetails), speaker);
        }
    }
}
