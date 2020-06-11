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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace NDCOsloSpeakerList.Shared
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpeakerDetails : Page
    {
        public SpeakerDetails()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var speaker = e.Parameter as Speaker;

            var speakerImage = new BitmapImage(new Uri("ms-appx:///" + speaker.SpeakerImage, UriKind.Absolute));

            SpeakerName.Text = speaker.SpeakerName;
            SpeakerImage.Source = speakerImage;
            SessionTitle.Text = speaker.SessionTitle;
            SessionSummary.Text = speaker.SessionSummary;
        }

        private void SpeakerPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

    }
}
