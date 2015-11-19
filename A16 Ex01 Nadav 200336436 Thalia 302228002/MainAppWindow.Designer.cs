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
            this.button_GetLastPost = new System.Windows.Forms.Button();
            this.button_GetRandomPost = new System.Windows.Forms.Button();
            this.button_ImFeelingLucky = new System.Windows.Forms.Button();
            this.button_GenerateMap = new System.Windows.Forms.Button();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label_CurrentLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_CoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.button_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.button_Login.Location = new System.Drawing.Point(586, 20);
            this.button_Login.Margin = new System.Windows.Forms.Padding(2);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(94, 24);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // picture_CoverPhoto
            // 
            this.picture_CoverPhoto.Location = new System.Drawing.Point(9, 10);
            this.picture_CoverPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.picture_CoverPhoto.MinimumSize = new System.Drawing.Size(682, 116);
            this.picture_CoverPhoto.Name = "picture_CoverPhoto";
            this.picture_CoverPhoto.Size = new System.Drawing.Size(682, 116);
            this.picture_CoverPhoto.TabIndex = 1;
            this.picture_CoverPhoto.TabStop = false;
            // 
            // picture_ProfilePicture
            // 
            this.picture_ProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_ProfilePicture.Location = new System.Drawing.Point(20, 63);
            this.picture_ProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.picture_ProfilePicture.Name = "picture_ProfilePicture";
            this.picture_ProfilePicture.Size = new System.Drawing.Size(90, 98);
            this.picture_ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_ProfilePicture.TabIndex = 2;
            this.picture_ProfilePicture.TabStop = false;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.label_UserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_UserName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.label_UserName.Location = new System.Drawing.Point(114, 135);
            this.label_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(121, 25);
            this.label_UserName.TabIndex = 3;
            this.label_UserName.Text = "UserName";
            this.label_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_About
            // 
            this.button_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.button_About.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.button_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_About.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.button_About.Location = new System.Drawing.Point(586, 94);
            this.button_About.Margin = new System.Windows.Forms.Padding(2);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(94, 24);
            this.button_About.TabIndex = 4;
            this.button_About.Text = "About";
            this.button_About.UseVisualStyleBackColor = false;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // label_PostStatus
            // 
            this.label_PostStatus.AutoSize = true;
            this.label_PostStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_PostStatus.Location = new System.Drawing.Point(169, 176);
            this.label_PostStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PostStatus.Name = "label_PostStatus";
            this.label_PostStatus.Size = new System.Drawing.Size(66, 13);
            this.label_PostStatus.TabIndex = 5;
            this.label_PostStatus.Text = "Post Status:";
            this.label_PostStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_PostStatus
            // 
            this.textBox_PostStatus.Location = new System.Drawing.Point(239, 173);
            this.textBox_PostStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PostStatus.Name = "textBox_PostStatus";
            this.textBox_PostStatus.Size = new System.Drawing.Size(262, 20);
            this.textBox_PostStatus.TabIndex = 6;
            // 
            // button_Post
            // 
            this.button_Post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.button_Post.FlatAppearance.BorderSize = 0;
            this.button_Post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Post.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Post.ForeColor = System.Drawing.Color.White;
            this.button_Post.Location = new System.Drawing.Point(505, 172);
            this.button_Post.Margin = new System.Windows.Forms.Padding(2);
            this.button_Post.Name = "button_Post";
            this.button_Post.Size = new System.Drawing.Size(56, 20);
            this.button_Post.TabIndex = 7;
            this.button_Post.Text = "Post";
            this.button_Post.UseVisualStyleBackColor = false;
            this.button_Post.Click += new System.EventHandler(this.button_Post_Click);
            // 
            // listBox_LikedPages
            // 
            this.listBox_LikedPages.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_LikedPages.FormattingEnabled = true;
            this.listBox_LikedPages.Location = new System.Drawing.Point(74, 203);
            this.listBox_LikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_LikedPages.Name = "listBox_LikedPages";
            this.listBox_LikedPages.Size = new System.Drawing.Size(128, 147);
            this.listBox_LikedPages.TabIndex = 8;
            this.listBox_LikedPages.SelectedIndexChanged += new System.EventHandler(this.listBox_LikedPages_SelectedIndexChanged);
            // 
            // listBox_Events
            // 
            this.listBox_Events.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_Events.FormattingEnabled = true;
            this.listBox_Events.Location = new System.Drawing.Point(406, 203);
            this.listBox_Events.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Events.Name = "listBox_Events";
            this.listBox_Events.Size = new System.Drawing.Size(128, 147);
            this.listBox_Events.TabIndex = 9;
            this.listBox_Events.SelectedIndexChanged += new System.EventHandler(this.listBox_Events_SelectedIndexChanged);
            // 
            // button_GetLastPost
            // 
            this.button_GetLastPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.button_GetLastPost.FlatAppearance.BorderSize = 0;
            this.button_GetLastPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetLastPost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_GetLastPost.ForeColor = System.Drawing.Color.White;
            this.button_GetLastPost.Location = new System.Drawing.Point(227, 223);
            this.button_GetLastPost.Margin = new System.Windows.Forms.Padding(2);
            this.button_GetLastPost.Name = "button_GetLastPost";
            this.button_GetLastPost.Size = new System.Drawing.Size(117, 24);
            this.button_GetLastPost.TabIndex = 13;
            this.button_GetLastPost.Text = "Get Last Post";
            this.button_GetLastPost.UseVisualStyleBackColor = false;
            this.button_GetLastPost.Click += new System.EventHandler(this.button_GetLastPost_Click);
            // 
            // button_GetRandomPost
            // 
            this.button_GetRandomPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.button_GetRandomPost.FlatAppearance.BorderSize = 0;
            this.button_GetRandomPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetRandomPost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_GetRandomPost.ForeColor = System.Drawing.Color.White;
            this.button_GetRandomPost.Location = new System.Drawing.Point(227, 253);
            this.button_GetRandomPost.Margin = new System.Windows.Forms.Padding(2);
            this.button_GetRandomPost.Name = "button_GetRandomPost";
            this.button_GetRandomPost.Size = new System.Drawing.Size(117, 24);
            this.button_GetRandomPost.TabIndex = 14;
            this.button_GetRandomPost.Text = "Get Random Post";
            this.button_GetRandomPost.UseVisualStyleBackColor = false;
            this.button_GetRandomPost.Click += new System.EventHandler(this.button_GetRandomPost_Click);
            // 
            // button_ImFeelingLucky
            // 
            this.button_ImFeelingLucky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.button_ImFeelingLucky.FlatAppearance.BorderSize = 0;
            this.button_ImFeelingLucky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ImFeelingLucky.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_ImFeelingLucky.ForeColor = System.Drawing.Color.White;
            this.button_ImFeelingLucky.Location = new System.Drawing.Point(227, 284);
            this.button_ImFeelingLucky.Margin = new System.Windows.Forms.Padding(2);
            this.button_ImFeelingLucky.Name = "button_ImFeelingLucky";
            this.button_ImFeelingLucky.Size = new System.Drawing.Size(117, 24);
            this.button_ImFeelingLucky.TabIndex = 15;
            this.button_ImFeelingLucky.Text = "I\'m Feeling Lucky";
            this.button_ImFeelingLucky.UseVisualStyleBackColor = false;
            this.button_ImFeelingLucky.Click += new System.EventHandler(this.button_ImFeelingLucky_Click);
            // 
            // button_GenerateMap
            // 
            this.button_GenerateMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.button_GenerateMap.FlatAppearance.BorderSize = 0;
            this.button_GenerateMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GenerateMap.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_GenerateMap.ForeColor = System.Drawing.Color.White;
            this.button_GenerateMap.Location = new System.Drawing.Point(565, 284);
            this.button_GenerateMap.Margin = new System.Windows.Forms.Padding(2);
            this.button_GenerateMap.Name = "button_GenerateMap";
            this.button_GenerateMap.Size = new System.Drawing.Size(98, 49);
            this.button_GenerateMap.TabIndex = 17;
            this.button_GenerateMap.Text = "Tell Me When To Leave For The Event";
            this.button_GenerateMap.UseVisualStyleBackColor = false;
            this.button_GenerateMap.Click += new System.EventHandler(this.button_GenerateMap_Click);
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(565, 223);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(98, 20);
            this.textBox_Address.TabIndex = 18;
            // 
            // label_CurrentLocation
            // 
            this.label_CurrentLocation.AutoSize = true;
            this.label_CurrentLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_CurrentLocation.Location = new System.Drawing.Point(538, 203);
            this.label_CurrentLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CurrentLocation.Name = "label_CurrentLocation";
            this.label_CurrentLocation.Size = new System.Drawing.Size(145, 13);
            this.label_CurrentLocation.TabIndex = 19;
            this.label_CurrentLocation.Text = "Enter Your Current Location:";
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(704, 398);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.label_CurrentLocation);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.button_GenerateMap);
            this.Controls.Add(this.button_ImFeelingLucky);
            this.Controls.Add(this.button_GetRandomPost);
            this.Controls.Add(this.button_GetLastPost);
            this.Controls.Add(this.listBox_Events);
            this.Controls.Add(this.listBox_LikedPages);
            this.Controls.Add(this.button_Post);
            this.Controls.Add(this.textBox_PostStatus);
            this.Controls.Add(this.label_PostStatus);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.picture_ProfilePicture);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.picture_CoverPhoto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainAppWindow";
            this.Text = "MainAppWindow";
            ((System.ComponentModel.ISupportInitialize)(this.picture_CoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ProfilePicture)).EndInit();
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
        private System.Windows.Forms.Button button_GetLastPost;
        private System.Windows.Forms.Button button_GetRandomPost;
        private System.Windows.Forms.Button button_ImFeelingLucky;
        private Button button_GenerateMap;
        private TextBox textBox_Address;
        private Label label_CurrentLocation;


    }
}