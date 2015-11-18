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
            this.label_PostText.Location = new System.Drawing.Point(105, 25);
            this.label_PostText.Name = "label_PostText";
            this.label_PostText.Size = new System.Drawing.Size(63, 17);
            this.label_PostText.TabIndex = 0;
            this.label_PostText.Text = "PostText";
            // 
            // pictureBox_PostPicture
            // 
            this.pictureBox_PostPicture.Location = new System.Drawing.Point(42, 66);
            this.pictureBox_PostPicture.Name = "pictureBox_PostPicture";
            this.pictureBox_PostPicture.Size = new System.Drawing.Size(201, 117);
            this.pictureBox_PostPicture.TabIndex = 1;
            this.pictureBox_PostPicture.TabStop = false;
            // 
            // button_Like
            // 
            this.button_Like.Location = new System.Drawing.Point(105, 206);
            this.button_Like.Name = "button_Like";
            this.button_Like.Size = new System.Drawing.Size(75, 23);
            this.button_Like.TabIndex = 2;
            this.button_Like.Text = "Like";
            this.button_Like.UseVisualStyleBackColor = true;
            this.button_Like.Click += new System.EventHandler(this.button_Like_Click);
            // 
            // PostsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button_Like);
            this.Controls.Add(this.pictureBox_PostPicture);
            this.Controls.Add(this.label_PostText);
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