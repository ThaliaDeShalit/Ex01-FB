namespace A16_Ex01_Nadav_200336436_Thalia_302228002
{
    partial class PostsWindow
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
            this.label_PostText = new System.Windows.Forms.Label();
            this.pictureBox_PostPicture = new System.Windows.Forms.PictureBox();
            this.button_Like = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PostPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label_PostText
            // 
            this.label_PostText.AutoSize = true;
            this.label_PostText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_PostText.Location = new System.Drawing.Point(29, 20);
            this.label_PostText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PostText.MaximumSize = new System.Drawing.Size(100, 0);
            this.label_PostText.Name = "label_PostText";
            this.label_PostText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_PostText.Size = new System.Drawing.Size(50, 13);
            this.label_PostText.TabIndex = 0;
            this.label_PostText.Text = "PostText";
            // 
            // pictureBox_PostPicture
            // 
            this.pictureBox_PostPicture.Location = new System.Drawing.Point(32, 54);
            this.pictureBox_PostPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_PostPicture.Name = "pictureBox_PostPicture";
            this.pictureBox_PostPicture.Size = new System.Drawing.Size(151, 151);
            this.pictureBox_PostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_PostPicture.TabIndex = 1;
            this.pictureBox_PostPicture.TabStop = false;
            // 
            // button_Like
            // 
            this.button_Like.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.button_Like.FlatAppearance.BorderSize = 0;
            this.button_Like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Like.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Like.ForeColor = System.Drawing.Color.White;
            this.button_Like.Location = new System.Drawing.Point(72, 209);
            this.button_Like.Margin = new System.Windows.Forms.Padding(2);
            this.button_Like.Name = "button_Like";
            this.button_Like.Size = new System.Drawing.Size(56, 19);
            this.button_Like.TabIndex = 2;
            this.button_Like.Text = "Like";
            this.button_Like.UseVisualStyleBackColor = false;
            this.button_Like.Click += new System.EventHandler(this.button_Like_Click);
            // 
            // PostsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(212, 236);
            this.Controls.Add(this.button_Like);
            this.Controls.Add(this.pictureBox_PostPicture);
            this.Controls.Add(this.label_PostText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PostsWindow";
            this.Text = "PostsWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PostPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PostText;
        private System.Windows.Forms.PictureBox pictureBox_PostPicture;
        private System.Windows.Forms.Button button_Like;
    }
}