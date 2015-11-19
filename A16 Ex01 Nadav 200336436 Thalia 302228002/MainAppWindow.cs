using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace A16_Ex01_Nadav_200336436_Thalia_302228002
{
    public partial class MainAppWindow : Form
    {
        private User m_LoggedInUser;
        private Random m_RandomNumberGenerater;

        public MainAppWindow()
        {
            InitializeComponent();

            m_RandomNumberGenerater = new Random();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            LoginResult result = FacebookService.Login(
                "173969972948571",
                "public_profile",
                "user_about_me",
                "user_birthday",
                "user_likes",
                "user_photos",
                "user_work_history",
                "user_events",
                "user_hometown",
                "publish_actions",
                "user_education_history");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            FacebookService.s_CollectionLimit = 99;
            pictureCoverPhoto.Load(m_LoggedInUser.Cover.SourceURL);
            pictureProfilePicture.Load(m_LoggedInUser.PictureNormalURL);
            labelUserName.Text = m_LoggedInUser.Name;

            fetchLikedPages();
            fetchEvents();
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                listBoxLikedPages.Items.Add(page);
            }

            if (m_LoggedInUser.LikedPages.Count == 0)
            {
                MessageBox.Show("User has no liked pages");
            }
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";

            foreach (Event userEvent in m_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(userEvent);
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("User has no events");
            }
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow(m_LoggedInUser);
            aboutWindow.ShowDialog();
        }

        private void button_Post_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(textBoxPostStatus.Text);
            MessageBox.Show("Posted! id: " + postedStatus.Id);
        }

        private void button_GetLastPost_Click(object sender, EventArgs e)
        {
            if (checkIfPageWasSelected())
            {
                getPostFromSelectedPage(0, listBoxLikedPages.SelectedItem as Page);
            }
        }

        private bool checkIfPageWasSelected()
        {
            bool wasPageSelected = false;

            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("User has no liked pages");
            }
            else if (listBoxLikedPages.SelectedItems.Count == 1)
            {
                wasPageSelected = true;
            }
            else if (listBoxLikedPages.SelectedItems.Count > 1)
            {
                MessageBox.Show("Too many pages were selected");
            }
            else
            {
                MessageBox.Show("Please select a page");
            }

            return wasPageSelected;
        }

        private void button_GetRandomPost_Click(object sender, EventArgs e)
        {
            if (checkIfPageWasSelected())
            {
                Page selectedPage = listBoxLikedPages.SelectedItem as Page;
                int postIndex = m_RandomNumberGenerater.Next(0, selectedPage.Posts.Count);
                getPostFromSelectedPage(postIndex, selectedPage);
            }
        }

        private void getPostFromSelectedPage(int i_Index, Page i_SelectedPage)
        {
            PostsWindow postsWindow = new PostsWindow(m_LoggedInUser, i_SelectedPage.Posts[i_Index]);
            postsWindow.ShowDialog();
        }

        private void button_ImFeelingLucky_Click(object sender, EventArgs e)
        {
            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("User has no liked pages");
            }
            else
            {
                int numOfPage = m_RandomNumberGenerater.Next(0, listBoxLikedPages.Items.Count);
                Page randomPage = listBoxLikedPages.Items[numOfPage] as Page;
                int postIndex = m_RandomNumberGenerater.Next(0, randomPage.Posts.Count);
                getPostFromSelectedPage(postIndex, randomPage);
            }
        }

        private void button_GenerateMap_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                string destination = selectedEvent.Place.Name;
                if (!string.IsNullOrEmpty(destination))
                {
                    string origin = textBoxAddress.Text;
                    if (!string.IsNullOrEmpty(origin))
                    {
                        DateTime eventStartTime = (DateTime)selectedEvent.StartTime;

                        if (eventStartTime != null)
                        {
                            DateTime? timeToLeaveForEvent = whenToLeaveForEvent(origin, destination, eventStartTime);

                            if (timeToLeaveForEvent != null)
                            {
                                MessageBox.Show(string.Format(@"You need to leave at {0} to get to the event on time", ((DateTime)timeToLeaveForEvent).ToLongTimeString()));
                            }
                            else
                            {
                                MessageBox.Show("something went wrong");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Event has no start time");
                        }
                    }
                    else
                    {
                        MessageBox.Show("you must enter an address");
                    }
                }
                else
                {
                    MessageBox.Show("Event has no location");
                }
            }
            else
            {
                MessageBox.Show("please select a single event");
            }
        }

        private DateTime? whenToLeaveForEvent(string i_Origin, string i_Destination, DateTime i_TimeToArrive)
        {
            DateTime? timeToLeave = null;
            
            string url = string.Format(@"https://maps.googleapis.com/maps/api/distancematrix/json?origins={0}&destinations={1}&key={2}", i_Origin, i_Destination, "AIzaSyDhZ61DrCNA7GBaPJvrDCJ5XWh5I1psBl8");

            JObject parsedJson;

            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(url);
                parsedJson = Newtonsoft.Json.Linq.JObject.Parse(json);
            }
            
            //In case the json was not parsed correctly

            try
            {
                int travelDurationInSeconds;
                string duration = parsedJson["rows"][0]["elements"][0]["duration"]["value"].ToString();
                bool temporaryBoolForParsingPurposes = int.TryParse(duration, out travelDurationInSeconds);
                timeToLeave = i_TimeToArrive.AddSeconds(-travelDurationInSeconds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return timeToLeave;
        }
    }
}
