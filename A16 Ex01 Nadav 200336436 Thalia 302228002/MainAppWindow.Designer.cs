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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonGetLastPost = new System.Windows.Forms.Button();
            this.buttonGetRandomPost = new System.Windows.Forms.Button();
            this.buttonImFeelingLucky = new System.Windows.Forms.Button();
            this.buttonGenerateMap = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelCurrentLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.buttonLogin.Location = new System.Drawing.Point(586, 20);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 24);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // pictureCoverPhoto
            // 
            this.pictureCoverPhoto.Location = new System.Drawing.Point(9, 10);
            this.pictureCoverPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureCoverPhoto.MinimumSize = new System.Drawing.Size(682, 116);
            this.pictureCoverPhoto.Name = "pictureCoverPhoto";
            this.pictureCoverPhoto.Size = new System.Drawing.Size(682, 116);
            this.pictureCoverPhoto.TabIndex = 1;
            this.pictureCoverPhoto.TabStop = false;
            // 
            // pictureProfilePicture
            // 
            this.pictureProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureProfilePicture.Location = new System.Drawing.Point(23, 73);
            this.pictureProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureProfilePicture.Name = "pictureProfilePicture";
            this.pictureProfilePicture.Size = new System.Drawing.Size(68, 80);
            this.pictureProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureProfilePicture.TabIndex = 2;
            this.pictureProfilePicture.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.labelUserName.Location = new System.Drawing.Point(95, 128);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(121, 25);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "UserName";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.buttonAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.buttonAbout.Location = new System.Drawing.Point(586, 93);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(94, 24);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.button_About_Click);
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostStatus.Location = new System.Drawing.Point(150, 167);
            this.labelPostStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(66, 13);
            this.labelPostStatus.TabIndex = 5;
            this.labelPostStatus.Text = "Post Status:";
            this.labelPostStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(220, 167);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(198, 20);
            this.textBoxPostStatus.TabIndex = 6;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.buttonPost.FlatAppearance.BorderSize = 0;
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.Location = new System.Drawing.Point(431, 167);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(42, 20);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.button_Post_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(15, 207);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(122, 173);
            this.listBoxLikedPages.TabIndex = 8;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(392, 204);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(130, 173);
            this.listBoxEvents.TabIndex = 9;
            // 
            // buttonGetLastPost
            // 
            this.buttonGetLastPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.buttonGetLastPost.FlatAppearance.BorderSize = 0;
            this.buttonGetLastPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetLastPost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGetLastPost.ForeColor = System.Drawing.Color.White;
            this.buttonGetLastPost.Location = new System.Drawing.Point(153, 207);
            this.buttonGetLastPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetLastPost.Name = "buttonGetLastPost";
            this.buttonGetLastPost.Size = new System.Drawing.Size(116, 20);
            this.buttonGetLastPost.TabIndex = 13;
            this.buttonGetLastPost.Text = "Get Last Post";
            this.buttonGetLastPost.UseVisualStyleBackColor = false;
            this.buttonGetLastPost.Click += new System.EventHandler(this.button_GetLastPost_Click);
            // 
            // buttonGetRandomPost
            // 
            this.buttonGetRandomPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.buttonGetRandomPost.FlatAppearance.BorderSize = 0;
            this.buttonGetRandomPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetRandomPost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGetRandomPost.ForeColor = System.Drawing.Color.White;
            this.buttonGetRandomPost.Location = new System.Drawing.Point(153, 244);
            this.buttonGetRandomPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetRandomPost.Name = "buttonGetRandomPost";
            this.buttonGetRandomPost.Size = new System.Drawing.Size(116, 20);
            this.buttonGetRandomPost.TabIndex = 14;
            this.buttonGetRandomPost.Text = "Get Random Post";
            this.buttonGetRandomPost.UseVisualStyleBackColor = false;
            this.buttonGetRandomPost.Click += new System.EventHandler(this.button_GetRandomPost_Click);
            // 
            // buttonImFeelingLucky
            // 
            this.buttonImFeelingLucky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.buttonImFeelingLucky.FlatAppearance.BorderSize = 0;
            this.buttonImFeelingLucky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImFeelingLucky.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonImFeelingLucky.ForeColor = System.Drawing.Color.White;
            this.buttonImFeelingLucky.Location = new System.Drawing.Point(153, 277);
            this.buttonImFeelingLucky.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImFeelingLucky.Name = "buttonImFeelingLucky";
            this.buttonImFeelingLucky.Size = new System.Drawing.Size(116, 21);
            this.buttonImFeelingLucky.TabIndex = 15;
            this.buttonImFeelingLucky.Text = "I\'m Feeling Lucky";
            this.buttonImFeelingLucky.UseVisualStyleBackColor = false;
            this.buttonImFeelingLucky.Click += new System.EventHandler(this.button_ImFeelingLucky_Click);
            // 
            // buttonGenerateMap
            // 
            this.buttonGenerateMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.buttonGenerateMap.FlatAppearance.BorderSize = 0;
            this.buttonGenerateMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateMap.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGenerateMap.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateMap.Location = new System.Drawing.Point(538, 266);
            this.buttonGenerateMap.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateMap.Name = "buttonGenerateMap";
            this.buttonGenerateMap.Size = new System.Drawing.Size(142, 42);
            this.buttonGenerateMap.TabIndex = 17;
            this.buttonGenerateMap.Text = "Tell Me When To Leave For The Event";
            this.buttonGenerateMap.UseVisualStyleBackColor = false;
            this.buttonGenerateMap.Click += new System.EventHandler(this.button_GenerateMap_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(538, 230);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(142, 20);
            this.textBoxAddress.TabIndex = 18;
            // 
            // labelCurrentLocation
            // 
            this.labelCurrentLocation.AutoSize = true;
            this.labelCurrentLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCurrentLocation.Location = new System.Drawing.Point(535, 204);
            this.labelCurrentLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentLocation.Name = "labelCurrentLocation";
            this.labelCurrentLocation.Size = new System.Drawing.Size(145, 13);
            this.labelCurrentLocation.TabIndex = 19;
            this.labelCurrentLocation.Text = "Enter Your Current Location:";
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(704, 398);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelCurrentLocation);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonGenerateMap);
            this.Controls.Add(this.buttonImFeelingLucky);
            this.Controls.Add(this.buttonGetRandomPost);
            this.Controls.Add(this.buttonGetLastPost);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.pictureProfilePicture);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureCoverPhoto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainAppWindow";
            this.Text = "Facebook 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureCoverPhoto;
        private System.Windows.Forms.PictureBox pictureProfilePicture;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonGetLastPost;
        private System.Windows.Forms.Button buttonGetRandomPost;
        private System.Windows.Forms.Button buttonImFeelingLucky;
        private Button buttonGenerateMap;
        private TextBox textBoxAddress;
        private Label labelCurrentLocation;
    }
}