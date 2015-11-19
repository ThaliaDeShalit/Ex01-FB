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
            this.label1 = new System.Windows.Forms.Label();
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
            this.buttonLogin.Location = new System.Drawing.Point(781, 25);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(125, 30);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // pictureCoverPhoto
            // 
            this.pictureCoverPhoto.Location = new System.Drawing.Point(12, 12);
            this.pictureCoverPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureCoverPhoto.MinimumSize = new System.Drawing.Size(909, 143);
            this.pictureCoverPhoto.Name = "pictureCoverPhoto";
            this.pictureCoverPhoto.Size = new System.Drawing.Size(909, 143);
            this.pictureCoverPhoto.TabIndex = 1;
            this.pictureCoverPhoto.TabStop = false;
            // 
            // pictureProfilePicture
            // 
            this.pictureProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureProfilePicture.Location = new System.Drawing.Point(27, 54);
            this.pictureProfilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureProfilePicture.Name = "pictureProfilePicture";
            this.pictureProfilePicture.Size = new System.Drawing.Size(120, 121);
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
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(183, 114);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(156, 33);
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
            this.buttonAbout.Location = new System.Drawing.Point(781, 116);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(125, 30);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.button_About_Click);
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Location = new System.Drawing.Point(185, 182);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(84, 17);
            this.labelPostStatus.TabIndex = 5;
            this.labelPostStatus.Text = "Post Status:";
            this.labelPostStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(276, 178);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(348, 22);
            this.textBoxPostStatus.TabIndex = 6;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.buttonPost.FlatAppearance.BorderSize = 0;
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.Location = new System.Drawing.Point(636, 178);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 25);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.button_Post_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(99, 250);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(169, 180);
            this.listBoxLikedPages.TabIndex = 8;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(541, 250);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(169, 180);
            this.listBoxEvents.TabIndex = 9;
            // 
            // buttonGetLastPost
            // 
            this.buttonGetLastPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.buttonGetLastPost.FlatAppearance.BorderSize = 0;
            this.buttonGetLastPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetLastPost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGetLastPost.ForeColor = System.Drawing.Color.White;
            this.buttonGetLastPost.Location = new System.Drawing.Point(303, 274);
            this.buttonGetLastPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGetLastPost.Name = "buttonGetLastPost";
            this.buttonGetLastPost.Size = new System.Drawing.Size(156, 30);
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
            this.buttonGetRandomPost.Location = new System.Drawing.Point(303, 311);
            this.buttonGetRandomPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGetRandomPost.Name = "buttonGetRandomPost";
            this.buttonGetRandomPost.Size = new System.Drawing.Size(156, 30);
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
            this.buttonImFeelingLucky.Location = new System.Drawing.Point(303, 350);
            this.buttonImFeelingLucky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImFeelingLucky.Name = "buttonImFeelingLucky";
            this.buttonImFeelingLucky.Size = new System.Drawing.Size(156, 30);
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
            this.buttonGenerateMap.Location = new System.Drawing.Point(753, 350);
            this.buttonGenerateMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenerateMap.Name = "buttonGenerateMap";
            this.buttonGenerateMap.Size = new System.Drawing.Size(131, 60);
            this.buttonGenerateMap.TabIndex = 17;
            this.buttonGenerateMap.Text = "Tell Me When To Leave For The Event";
            this.buttonGenerateMap.UseVisualStyleBackColor = false;
            this.buttonGenerateMap.Click += new System.EventHandler(this.button_GenerateMap_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(753, 283);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(129, 22);
            this.textBoxAddress.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter Your Current Location:";
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(939, 490);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainAppWindow";
            this.Text = "MainAppWindow";
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
        private Label label1;


    }
}