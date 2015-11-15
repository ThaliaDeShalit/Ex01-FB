namespace A16_Ex01_Nadav_200336436_Thalia_302228002
{
    partial class AboutWindow
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
            this.label_AboutUser = new System.Windows.Forms.Label();
            this.label_Hometown = new System.Windows.Forms.Label();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_Job = new System.Windows.Forms.Label();
            this.label_Education = new System.Windows.Forms.Label();
            this.label_UserBirthday = new System.Windows.Forms.Label();
            this.label_UserHometown = new System.Windows.Forms.Label();
            this.label_UserEducation = new System.Windows.Forms.Label();
            this.label_UserJob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_AboutUser
            // 
            this.label_AboutUser.AutoSize = true;
            this.label_AboutUser.Location = new System.Drawing.Point(69, 44);
            this.label_AboutUser.Name = "label_AboutUser";
            this.label_AboutUser.Size = new System.Drawing.Size(75, 17);
            this.label_AboutUser.TabIndex = 0;
            this.label_AboutUser.Text = "AboutUser";
            // 
            // label_Hometown
            // 
            this.label_Hometown.AutoSize = true;
            this.label_Hometown.Location = new System.Drawing.Point(36, 170);
            this.label_Hometown.Name = "label_Hometown";
            this.label_Hometown.Size = new System.Drawing.Size(78, 17);
            this.label_Hometown.TabIndex = 1;
            this.label_Hometown.Text = "Hometown:";
            // 
            // label_Birthday
            // 
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Location = new System.Drawing.Point(36, 136);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(64, 17);
            this.label_Birthday.TabIndex = 2;
            this.label_Birthday.Text = "Birthday:";
            // 
            // label_Job
            // 
            this.label_Job.AutoSize = true;
            this.label_Job.Location = new System.Drawing.Point(36, 237);
            this.label_Job.Name = "label_Job";
            this.label_Job.Size = new System.Drawing.Size(35, 17);
            this.label_Job.TabIndex = 3;
            this.label_Job.Text = "Job:";
            this.label_Job.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Education
            // 
            this.label_Education.AutoSize = true;
            this.label_Education.Location = new System.Drawing.Point(36, 204);
            this.label_Education.Name = "label_Education";
            this.label_Education.Size = new System.Drawing.Size(75, 17);
            this.label_Education.TabIndex = 4;
            this.label_Education.Text = "Education:";
            // 
            // label_UserBirthday
            // 
            this.label_UserBirthday.AutoSize = true;
            this.label_UserBirthday.Location = new System.Drawing.Point(130, 136);
            this.label_UserBirthday.Name = "label_UserBirthday";
            this.label_UserBirthday.Size = new System.Drawing.Size(90, 17);
            this.label_UserBirthday.TabIndex = 5;
            this.label_UserBirthday.Text = "UserBirthday";
            // 
            // label_UserHometown
            // 
            this.label_UserHometown.AutoSize = true;
            this.label_UserHometown.Location = new System.Drawing.Point(130, 170);
            this.label_UserHometown.Name = "label_UserHometown";
            this.label_UserHometown.Size = new System.Drawing.Size(104, 17);
            this.label_UserHometown.TabIndex = 6;
            this.label_UserHometown.Text = "UserHometown";
            // 
            // label_UserEducation
            // 
            this.label_UserEducation.AutoSize = true;
            this.label_UserEducation.Location = new System.Drawing.Point(130, 204);
            this.label_UserEducation.Name = "label_UserEducation";
            this.label_UserEducation.Size = new System.Drawing.Size(101, 17);
            this.label_UserEducation.TabIndex = 7;
            this.label_UserEducation.Text = "UserEducation";
            // 
            // label_UserJob
            // 
            this.label_UserJob.AutoSize = true;
            this.label_UserJob.Location = new System.Drawing.Point(130, 237);
            this.label_UserJob.Name = "label_UserJob";
            this.label_UserJob.Size = new System.Drawing.Size(61, 17);
            this.label_UserJob.TabIndex = 8;
            this.label_UserJob.Text = "UserJob";
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 288);
            this.Controls.Add(this.label_UserJob);
            this.Controls.Add(this.label_UserEducation);
            this.Controls.Add(this.label_UserHometown);
            this.Controls.Add(this.label_UserBirthday);
            this.Controls.Add(this.label_Education);
            this.Controls.Add(this.label_Job);
            this.Controls.Add(this.label_Birthday);
            this.Controls.Add(this.label_Hometown);
            this.Controls.Add(this.label_AboutUser);
            this.Name = "AboutWindow";
            this.Text = "AboutWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AboutUser;
        private System.Windows.Forms.Label label_Hometown;
        private System.Windows.Forms.Label label_Birthday;
        private System.Windows.Forms.Label label_Job;
        private System.Windows.Forms.Label label_Education;
        private System.Windows.Forms.Label label_UserBirthday;
        private System.Windows.Forms.Label label_UserHometown;
        private System.Windows.Forms.Label label_UserEducation;
        private System.Windows.Forms.Label label_UserJob;
    }
}