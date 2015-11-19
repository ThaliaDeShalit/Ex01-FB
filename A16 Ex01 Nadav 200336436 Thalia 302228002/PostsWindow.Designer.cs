namespace A16_Ex01_Nadav_200336436_Thalia_302228002
{
    public partial class PostsWindow
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
            this.pictureBoxPostPicture = new System.Windows.Forms.PictureBox();
            this.buttonLike = new System.Windows.Forms.Button();
            this.textBoxPostText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPostPicture
            // 
            this.pictureBoxPostPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPostPicture.Location = new System.Drawing.Point(29, 96);
            this.pictureBoxPostPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPostPicture.Name = "pictureBoxPostPicture";
            this.pictureBoxPostPicture.Size = new System.Drawing.Size(108, 91);
            this.pictureBoxPostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPostPicture.TabIndex = 1;
            this.pictureBoxPostPicture.TabStop = false;
            // 
            // buttonLike
            // 
            this.buttonLike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(105)))), ((int)(((byte)(162)))));
            this.buttonLike.FlatAppearance.BorderSize = 0;
            this.buttonLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLike.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLike.ForeColor = System.Drawing.Color.White;
            this.buttonLike.Location = new System.Drawing.Point(102, 195);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(56, 19);
            this.buttonLike.TabIndex = 2;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = false;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // textBoxPostText
            // 
            this.textBoxPostText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPostText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.textBoxPostText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPostText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPostText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.textBoxPostText.Location = new System.Drawing.Point(12, 13);
            this.textBoxPostText.Multiline = true;
            this.textBoxPostText.Name = "textBoxPostText";
            this.textBoxPostText.ReadOnly = true;
            this.textBoxPostText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPostText.Size = new System.Drawing.Size(145, 69);
            this.textBoxPostText.TabIndex = 3;
            this.textBoxPostText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PostsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(169, 225);
            this.Controls.Add(this.textBoxPostText);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.pictureBoxPostPicture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PostsWindow";
            this.Text = "Post";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPostPicture;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.TextBox textBoxPostText;
    }
}