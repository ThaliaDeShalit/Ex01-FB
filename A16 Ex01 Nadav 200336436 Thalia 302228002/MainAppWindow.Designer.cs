using System;
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
    partial class MainAppWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Login = new System.Windows.Forms.Button();
            this.picture_CoverPhoto = new System.Windows.Forms.PictureBox();
            this.picture_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.button_About = new System.Windows.Forms.Button();
            this.label_PostStatus = new System.Windows.Forms.Label();
            this.textBox_PostStatus = new System.Windows.Forms.TextBox();
            this.button_Post = new System.Windows.Forms.Button();
            this.listBox_LikedPages = new System.Windows.Forms.ListBox();
            this.listBox_Events = new System.Windows.Forms.ListBox();
            this.picture_UserPictures = new System.Windows.Forms.PictureBox();
            this.button_NextPicture = new System.Windows.Forms.Button();
            this.button_PreviousPicture = new System.Windows.Forms.Button();
            this.button_GetLastPost = new System.Windows.Forms.Button();
            this.button_GetRandomPost = new System.Windows.Forms.Button();
            this.button_ImFeelingLucky = new System.Windows.Forms.Button();
            this.label_UserInfo = new System.Windows.Forms.Label();
            this.button_GetWeather = new System.Windows.Forms.Button();
            this.label_WeatherInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_CoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_UserPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(782, 24);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(125, 27);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // picture_CoverPhoto
            // 
            this.picture_CoverPhoto.Location = new System.Drawing.Point(12, 12);
            this.picture_CoverPhoto.MinimumSize = new System.Drawing.Size(910, 143);
            this.picture_CoverPhoto.Name = "picture_CoverPhoto";
            this.picture_CoverPhoto.Size = new System.Drawing.Size(910, 143);
            this.picture_CoverPhoto.TabIndex = 1;
            this.picture_CoverPhoto.TabStop = false;
            // 
            // picture_ProfilePicture
            // 
            this.picture_ProfilePicture.Location = new System.Drawing.Point(29, 24);
            this.picture_ProfilePicture.Name = "picture_ProfilePicture";
            this.picture_ProfilePicture.Size = new System.Drawing.Size(120, 120);
            this.picture_ProfilePicture.TabIndex = 2;
            this.picture_ProfilePicture.TabStop = false;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(168, 75);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(75, 17);
            this.label_UserName.TabIndex = 3;
            this.label_UserName.Text = "UserName";
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(782, 117);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(125, 27);
            this.button_About.TabIndex = 4;
            this.button_About.Text = "About";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);

            // 
            // label_PostStatus
            // 
            this.label_PostStatus.AutoSize = true;
            this.label_PostStatus.Location = new System.Drawing.Point(186, 178);
            this.label_PostStatus.Name = "label_PostStatus";
            this.label_PostStatus.Size = new System.Drawing.Size(84, 17);
            this.label_PostStatus.TabIndex = 5;
            this.label_PostStatus.Text = "Post Status:";
            // 
            // textBox_PostStatus
            // 
            this.textBox_PostStatus.Location = new System.Drawing.Point(276, 178);
            this.textBox_PostStatus.Name = "textBox_PostStatus";
            this.textBox_PostStatus.Size = new System.Drawing.Size(348, 22);
            this.textBox_PostStatus.TabIndex = 6;
            // 
            // button_Post
            // 
            this.button_Post.Location = new System.Drawing.Point(636, 178);
            this.button_Post.Name = "button_Post";
            this.button_Post.Size = new System.Drawing.Size(75, 23);
            this.button_Post.TabIndex = 7;
            this.button_Post.Text = "Post";
            this.button_Post.UseVisualStyleBackColor = true;
            this.button_Post.Click += new System.EventHandler(this.button_Post_Click);
            // 
            // listBox_LikedPages
            // 
            this.listBox_LikedPages.FormattingEnabled = true;
            this.listBox_LikedPages.ItemHeight = 16;
            this.listBox_LikedPages.Location = new System.Drawing.Point(98, 250);
            this.listBox_LikedPages.Name = "listBox_LikedPages";
            this.listBox_LikedPages.Size = new System.Drawing.Size(170, 180);
            this.listBox_LikedPages.TabIndex = 8;
            this.listBox_LikedPages.SelectedIndexChanged += new System.EventHandler(this.listBox_LikedPages_SelectedIndexChanged);

            // 
            // listBox_Events
            // 
            this.listBox_Events.FormattingEnabled = true;
            this.listBox_Events.ItemHeight = 16;
            this.listBox_Events.Location = new System.Drawing.Point(98, 461);
            this.listBox_Events.Name = "listBox_Events";
            this.listBox_Events.Size = new System.Drawing.Size(170, 180);
            this.listBox_Events.TabIndex = 9;
            // 
            // picture_UserPictures
            // 
            this.picture_UserPictures.Location = new System.Drawing.Point(596, 250);
            this.picture_UserPictures.Name = "picture_UserPictures";
            this.picture_UserPictures.Size = new System.Drawing.Size(170, 180);
            this.picture_UserPictures.TabIndex = 10;
            this.picture_UserPictures.TabStop = false;
            // 
            // button_NextPicture
            // 
            this.button_NextPicture.Location = new System.Drawing.Point(772, 322);
            this.button_NextPicture.Name = "button_NextPicture";
            this.button_NextPicture.Size = new System.Drawing.Size(29, 23);
            this.button_NextPicture.TabIndex = 11;
            this.button_NextPicture.Text = ">";
            this.button_NextPicture.UseVisualStyleBackColor = true;
            this.button_NextPicture.Click += new System.EventHandler(this.button_NextPicture_Click);

            // 
            // button_PreviousPicture
            // 
            this.button_PreviousPicture.Location = new System.Drawing.Point(561, 322);
            this.button_PreviousPicture.Name = "button_PreviousPicture";
            this.button_PreviousPicture.Size = new System.Drawing.Size(29, 23);
            this.button_PreviousPicture.TabIndex = 12;
            this.button_PreviousPicture.Text = "<";
            this.button_PreviousPicture.UseVisualStyleBackColor = true;
            this.button_PreviousPicture.Click += new System.EventHandler(this.button_PreviousPicture_Click);

            // 
            // button_GetLastPost
            // 
            this.button_GetLastPost.Location = new System.Drawing.Point(303, 275);
            this.button_GetLastPost.Name = "button_GetLastPost";
            this.button_GetLastPost.Size = new System.Drawing.Size(130, 30);
            this.button_GetLastPost.TabIndex = 13;
            this.button_GetLastPost.Text = "Get Last Post";
            this.button_GetLastPost.UseVisualStyleBackColor = true;
            this.button_GetLastPost.Click += new System.EventHandler(this.button_GetLastPost_Click);

            // 
            // button_GetRandomPost
            // 
            this.button_GetRandomPost.Location = new System.Drawing.Point(303, 311);
            this.button_GetRandomPost.Name = "button_GetRandomPost";
            this.button_GetRandomPost.Size = new System.Drawing.Size(130, 30);
            this.button_GetRandomPost.TabIndex = 14;
            this.button_GetRandomPost.Text = "Get Random Post";
            this.button_GetRandomPost.UseVisualStyleBackColor = true;
            this.button_GetRandomPost.Click += new System.EventHandler(this.button_GetRandomPost_Click);

            // 
            // button_ImFeelingLucky
            // 
            this.button_ImFeelingLucky.Location = new System.Drawing.Point(303, 349);
            this.button_ImFeelingLucky.Name = "button_ImFeelingLucky";
            this.button_ImFeelingLucky.Size = new System.Drawing.Size(130, 30);
            this.button_ImFeelingLucky.TabIndex = 15;
            this.button_ImFeelingLucky.Text = "I\'m Feeling Lucky";
            this.button_ImFeelingLucky.UseVisualStyleBackColor = true;
            this.button_ImFeelingLucky.Click += new System.EventHandler(this.button_ImFeelingLucky_Click);

            // 
            // label_UserInfo
            // 
            this.label_UserInfo.AutoSize = true;
            this.label_UserInfo.Location = new System.Drawing.Point(312, 461);
            this.label_UserInfo.Name = "label_UserInfo";
            this.label_UserInfo.Size = new System.Drawing.Size(0, 17);
            this.label_UserInfo.TabIndex = 16;
            // 
            // button_GetWeather
            // 
            this.button_GetWeather.Location = new System.Drawing.Point(596, 461);
            this.button_GetWeather.Name = "button_GetWeather";
            this.button_GetWeather.Size = new System.Drawing.Size(170, 23);
            this.button_GetWeather.TabIndex = 17;
            this.button_GetWeather.Text = "Get Weather";
            this.button_GetWeather.UseVisualStyleBackColor = true;
            this.button_GetWeather.Click += new System.EventHandler(this.button_GetWeather_Click);

            // 
            // label_WeatherInfo
            // 
            this.label_WeatherInfo.AutoSize = true;
            this.label_WeatherInfo.Location = new System.Drawing.Point(636, 511);
            this.label_WeatherInfo.Name = "label_WeatherInfo";
            this.label_WeatherInfo.Size = new System.Drawing.Size(0, 17);
            this.label_WeatherInfo.TabIndex = 18;
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 653);
            this.Controls.Add(this.label_WeatherInfo);
            this.Controls.Add(this.button_GetWeather);
            this.Controls.Add(this.label_UserInfo);
            this.Controls.Add(this.button_ImFeelingLucky);
            this.Controls.Add(this.button_GetRandomPost);
            this.Controls.Add(this.button_GetLastPost);
            this.Controls.Add(this.button_PreviousPicture);
            this.Controls.Add(this.button_NextPicture);
            this.Controls.Add(this.picture_UserPictures);
            this.Controls.Add(this.listBox_Events);
            this.Controls.Add(this.listBox_LikedPages);
            this.Controls.Add(this.button_Post);
            this.Controls.Add(this.textBox_PostStatus);
            this.Controls.Add(this.label_PostStatus);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.picture_ProfilePicture);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.picture_CoverPhoto);
            this.Name = "MainAppWindow";
            this.Text = "MainAppWindow";
            ((System.ComponentModel.ISupportInitialize)(this.picture_CoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_UserPictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.PictureBox picture_CoverPhoto;
        private System.Windows.Forms.PictureBox picture_ProfilePicture;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.Label label_PostStatus;
        private System.Windows.Forms.TextBox textBox_PostStatus;
        private System.Windows.Forms.Button button_Post;
        private System.Windows.Forms.ListBox listBox_LikedPages;
        private System.Windows.Forms.ListBox listBox_Events;
        private System.Windows.Forms.PictureBox picture_UserPictures;
        private System.Windows.Forms.Button button_NextPicture;
        private System.Windows.Forms.Button button_PreviousPicture;
        private System.Windows.Forms.Button button_GetLastPost;
        private System.Windows.Forms.Button button_GetRandomPost;
        private System.Windows.Forms.Button button_ImFeelingLucky;
        private System.Windows.Forms.Label label_UserInfo;
        private System.Windows.Forms.Button button_GetWeather;
        private System.Windows.Forms.Label label_WeatherInfo;


    }
}