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
            this.labelPostText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostText.Location = new System.Drawing.Point(29, 20);
            this.labelPostText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostText.MaximumSize = new System.Drawing.Size(100, 0);
            this.labelPostText.Name = "label_PostText";
            this.labelPostText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPostText.Size = new System.Drawing.Size(50, 13);
            this.labelPostText.TabIndex = 0;
            this.labelPostText.Text = "PostText";
            // 
            // pictureBoxPostPicture
            // 
            this.pictureBoxPostPicture.Location = new System.Drawing.Point(32, 54);
            this.pictureBoxPostPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPostPicture.Name = "pictureBox_PostPicture";
            this.pictureBoxPostPicture.Size = new System.Drawing.Size(151, 151);
            this.pictureBoxPostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPostPicture.TabIndex = 1;
            this.pictureBoxPostPicture.TabStop = false;
            // 
            // buttonLike
            // 
            this.buttonLike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.buttonLike.FlatAppearance.BorderSize = 0;
            this.buttonLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLike.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLike.ForeColor = System.Drawing.Color.White;
            this.buttonLike.Location = new System.Drawing.Point(72, 209);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLike.Name = "button_Like";
            this.buttonLike.Size = new System.Drawing.Size(56, 19);
            this.buttonLike.TabIndex = 2;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = false;
            this.buttonLike.Click += new System.EventHandler(this.button_Like_Click);
            // 
            // PostsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(212, 236);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.pictureBoxPostPicture);
            this.Controls.Add(this.labelPostText);
            this.Margin = new System.Windows.Forms.Padding(2);
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