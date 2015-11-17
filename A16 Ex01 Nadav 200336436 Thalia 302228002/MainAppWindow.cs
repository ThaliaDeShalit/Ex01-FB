﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A16_Ex01_Nadav_200336436_Thalia_302228002
{
    public partial class MainAppWindow : Form
    {
        private User m_LoggedInUser;
        private Page m_SelectedPage;
        private Random m_RandomNumberGenerater;
        private bool m_WasImFeelingLuckyPressed = false;
        
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
            picture_CoverPhoto.Load(m_LoggedInUser.Cover.SourceURL);
            picture_ProfilePicture.Load(m_LoggedInUser.PictureLargeURL);
            label_UserName.Text = m_LoggedInUser.Name;

            fetchLikedPages();

            fetchEvents();

            picture_UserPictures.Load(m_LoggedInUser.Pictures.PictureUrl);
        }

        private void fetchLikedPages()
        {
            listBox_LikedPages.Items.Clear();
            listBox_LikedPages.DisplayMember = "Name";

            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                listBox_LikedPages.Items.Add(page);
            }

            if (m_LoggedInUser.LikedPages.Count == 0)
            {
                MessageBox.Show("User has no liked pages");
            }
        }

        private void fetchEvents()
        {
            listBox_Events.Items.Clear();
            listBox_Events.DisplayMember = "Name";

            foreach (Event userEvent in m_LoggedInUser.Events)
            {
                listBox_Events.Items.Add(userEvent);
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
                Status postedStatus = m_LoggedInUser.PostStatus(textBox_PostStatus.Text);
                MessageBox.Show("Posted! id: " + postedStatus.Id);   
        }

        private void button_NextPicture_Click(object sender, EventArgs e)
        {

        }

        private void button_PreviousPicture_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox_LikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_LikedPages.SelectedItems.Count == 1)
            {
                m_SelectedPage = listBox_LikedPages.SelectedItem as Page;
            }
        }

        private void button_GetLastPost_Click(object sender, EventArgs e)
        {
            if (m_WasImFeelingLuckyPressed)
            {
                m_SelectedPage = listBox_LikedPages.SelectedItem as Page;
            }
            getPostFromSelectedPage(0);
        }

        private void button_GetRandomPost_Click(object sender, EventArgs e)
        {
            if (m_WasImFeelingLuckyPressed)
            {
                m_SelectedPage = listBox_LikedPages.SelectedItem as Page;
            }
            getPostFromSelectedPage(m_RandomNumberGenerater.Next(0, m_SelectedPage.Posts.Count));
        }

        private void getPostFromSelectedPage(int i_Index)
        {
            if (m_SelectedPage != null)
            {
                PostsWindow postsWindow = new PostsWindow(m_SelectedPage.Posts[i_Index]);
                postsWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("No page was selected");
            }
        }

        private void button_ImFeelingLucky_Click(object sender, EventArgs e)
        {
            int numOfPage = m_RandomNumberGenerater.Next(0, listBox_LikedPages.Items.Count);
            m_SelectedPage = listBox_LikedPages.Items[numOfPage] as Page;

            getPostFromSelectedPage(m_RandomNumberGenerater.Next(0, m_SelectedPage.Posts.Count));

            m_WasImFeelingLuckyPressed = true;
        }

        private void button_GetWeather_Click(object sender, EventArgs e)
        {
            
        }
    }
}