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
    public partial class PostsWindow : Form
    {
        private Post m_Post;

        public PostsWindow(Post i_Post)
        {
            InitializeComponent();

            m_Post = i_Post;
            showText();
            showImage();
        }

        private void showText()
        {
            string postText = m_Post.Message;

            if (!string.IsNullOrEmpty(postText)) {
label_PostText.Text = postText;
            }
            else
            {
                label_PostText.Text = string.Empty;
            }
            
        }

        private void showImage()
        {
            string postPicture = m_Post.PictureURL;

            if (!string.IsNullOrEmpty(postPicture))
            {
                pictureBox_PostPicture.Load(postPicture);
            }
            else
            {
                pictureBox_PostPicture.Image = pictureBox_PostPicture.ErrorImage;

            }
        }
    }
}
