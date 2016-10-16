using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace LaunchersAndChoosersDemo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void FirstListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((e.AddedItems[0] as ListBoxItem).Name)
            {
                case "iEmailComposeTask":
                    EmailComposeTask ect = new EmailComposeTask();
                    ect.To = "some.email@address.com";
                    ect.Subject = "Some subject";
                    ect.Body = "email content here";
                    ect.Show();
                    break;
                case "iMarketplaceDetailTask":
                    MarketplaceDetailTask mdt = new MarketplaceDetailTask();
                    mdt.ContentType = MarketplaceContentType.Applications;
                    mdt.Show();
                    break;
                case "iMarketplaceHubTask":
                    MarketplaceHubTask mht = new MarketplaceHubTask();
                    mht.ContentType = MarketplaceContentType.Applications;
                    mht.Show();
                    break;
                case "iMarketplaceReviewTask":
                    MarketplaceReviewTask mrt = new MarketplaceReviewTask();
                    mrt.Show();
                    break;
                case "iMarketplaceSearchTask":
                    MarketplaceSearchTask mst = new MarketplaceSearchTask();
                    mst.ContentType = MarketplaceContentType.Music;
                    mst.SearchTerms = "Radiohead";
                    mst.Show();
                    break;
                case "iMediaPlayerLauncher":
                    MediaPlayerLauncher mpl = new MediaPlayerLauncher();
                    mpl.Media = new Uri("", UriKind.Relative);
                    mpl.Location = MediaLocationType.Data;
                    mpl.Controls = MediaPlaybackControls.Pause | 
                                   MediaPlaybackControls.Stop | 
                                   MediaPlaybackControls.Rewind;
                    mpl.Show();
                    break;
                case "iPhoneCallTask":
                    PhoneCallTask pct = new PhoneCallTask();
                    pct.DisplayName = "My contact";
                    pct.PhoneNumber = "55512345678";
                    pct.Show();
                    break;
                case "iSearchTask":
                    SearchTask st = new SearchTask();
                    st.SearchQuery = "Facebook";
                    st.Show();
                    break;
                case "iSmsComposeTask":
                    SmsComposeTask sct = new SmsComposeTask();
                    sct.To = "My contact";
                    sct.Body = "sms content";
                    sct.Show();
                    break;
                case "iWebBrowserTask":
                    WebBrowserTask wbt = new WebBrowserTask();
                    wbt.URL = "http://www.apress.com";
                    wbt.Show();
                    break;
            }
        }

        private void SecondListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((e.AddedItems[0] as ListBoxItem).Name)
            {
                case "iCameraCaptureTask":
                    MessageBox.Show("See recipe 7-1 for CameraCaptureTask chooser explanation.");
                    break;
                case "iPhotoChooserTask":
                    MessageBox.Show("See recipe 7-2 for PhotoChooserTask chooser explanation.");
                    break;
                case "iEmailAddressChooserTask":
                    EmailAddressChooserTask eact = new EmailAddressChooserTask();
                    eact.Completed += new EventHandler<EmailResult>(EmailAddressChooserTask_Completed);
                    eact.Show();
                    break;
                case "iPhoneNumberChooserTask":
                    PhoneNumberChooserTask pnct = new PhoneNumberChooserTask();
                    pnct.Completed += new EventHandler<PhoneNumberResult>(PhoneNumberChooserTask_Completed);
                    pnct.Show();
                    break;
                case "iSaveEmailAddressTask":
                    SaveEmailAddressTask seat = new SaveEmailAddressTask();
                    seat.Completed += new EventHandler<TaskEventArgs>(SaveEmailAddressTask_Completed);
                    seat.Email = "some.email@address.com";
                    seat.Show();
                    break;
                case "iSavePhoneNumberTask":
                    SavePhoneNumberTask spnt = new SavePhoneNumberTask();
                    spnt.PhoneNumber = "55512345678";
                    spnt.Completed += new EventHandler<TaskEventArgs>(SavePhoneNumberTask_Completed);
                    spnt.Show();
                    break;
            }
        }

        void SavePhoneNumberTask_Completed(object sender, TaskEventArgs e)
        {
            if (e.TaskResult == TaskResult.OK)
                MessageBox.Show("Phone numeber saved correctly");
            else if (e.TaskResult == TaskResult.Cancel)
                MessageBox.Show("Save operation cancelled");
        }

        void SaveEmailAddressTask_Completed(object sender, TaskEventArgs e)
        {
            if (e.TaskResult == TaskResult.OK)
                MessageBox.Show("Email saved correctly");
            else if (e.TaskResult == TaskResult.Cancel)
                MessageBox.Show("Save operation cancelled");
        }

        void PhoneNumberChooserTask_Completed(object sender, PhoneNumberResult e)
        {
            if (e.TaskResult == TaskResult.OK)
                MessageBox.Show(e.PhoneNumber);
        }

        void EmailAddressChooserTask_Completed(object sender, EmailResult e)
        {
            if (e.TaskResult == TaskResult.OK)
                MessageBox.Show(e.Email);
        }

    }
}