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
            this.labelPostText = new System.Windows.Forms.Label();
            this.pictureBoxPostPicture = new System.Windows.Forms.PictureBox();
            this.buttonLike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPostText
            // 
            this.labelPostText.AutoSize = true;
            this.labelPostText.Location = new System.Drawing.Point(105, 25);
            this.labelPostText.Name = "labelPostText";
            this.labelPostText.Size = new System.Drawing.Size(63, 17);
            this.labelPostText.TabIndex = 0;
            this.labelPostText.Text = "PostText";
            // 
            // pictureBoxPostPicture
            // 
            this.pictureBoxPostPicture.Location = new System.Drawing.Point(42, 66);
            this.pictureBoxPostPicture.Name = "pictureBoxPostPicture";
            this.pictureBoxPostPicture.Size = new System.Drawing.Size(201, 117);
            this.pictureBoxPostPicture.TabIndex = 1;
            this.pictureBoxPostPicture.TabStop = false;
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(105, 206);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(75, 23);
            this.buttonLike.TabIndex = 2;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.button_Like_Click);
            // 
            // PostsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.pictureBoxPostPicture);
            this.Controls.Add(this.labelPostText);
            this.Name = "PostsWindow";
            this.Text = "PostsWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPostText;
        private System.Windows.Forms.PictureBox pictureBoxPostPicture;
        private System.Windows.Forms.Button buttonLike;
    }
}