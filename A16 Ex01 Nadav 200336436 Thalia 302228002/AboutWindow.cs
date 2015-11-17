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
    public partial class AboutWindow : Form
    {
        User m_LoggedInUser;
        
        public AboutWindow(User i_FacebookUser)
        {
            InitializeComponent();

            m_LoggedInUser = i_FacebookUser;

            showBio();
            showBirthday();

            showEducations();
            showHometown();            
            
        }

        private void showBio()
        {
            string aboutUser = m_LoggedInUser.Bio;
            
            if (!string.IsNullOrEmpty(aboutUser))
            {
                label_UserAbout.Text = aboutUser;
            }
            else
            {
                label_UserAbout.Text = "No bio to show";
            }
        }

        private void showBirthday()
        {
            string userBirthday = m_LoggedInUser.Birthday;

            if (!string.IsNullOrEmpty(userBirthday))
            {
                label_UserBirthday.Text = userBirthday;
            }
            else
            {
                label_UserBirthday.Text = "No birthday to show";
            }
        }

        private void showEducations()
        {
            string educations = string.Empty;

            if (m_LoggedInUser.Educations.Length > 0)
            {
                foreach (Education education in m_LoggedInUser.Educations)
                {
                    string result = string.Format(
    @"{0} at {1}", education.Type, education.School.Name);

                    if (educations != string.Empty)
                    {
                        educations = string.Format(
    @"{0}
{1}", educations, result);
                    }
                    else
                    {
                        educations = result;
                    }
                }
            }
            else
            {
                educations = "No education to show";
            }

            label_UserEducation.Text = educations;
        }

        private void showHometown()
        {
            City userHometown = m_LoggedInUser.Hometown;

            if (userHometown != null)
            {
                label_UserHometown.Text = userHometown.Name;
            }
            else
            {
                label_UserHometown.Text = "No hometown to show";
            }
        }

    }
}
