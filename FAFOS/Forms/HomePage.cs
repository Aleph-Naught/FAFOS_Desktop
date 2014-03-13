using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAFOS.Forms
{
    public partial class HomePage : Form
    {

        List<Bitmap> piclist = new List<Bitmap>();

        String userid;

        Users user = new Users();

        public HomePage()
        {
            userid = "";
            InitializeComponent();
        }

        public HomePage(String id)
        {
            userid = id;
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            try
            {
                piclist = MUser.LoadImages();
            }
            catch (Exception)
            {

                piclist.Add(FAFOS.Properties.Resources.DefaultProPic);
                MUser.SaveImages(piclist);
            }

            this.profilePic.BackgroundImage = piclist[MUser.GetPicID(userid.ToString())];// FAFOS.Properties.Resources.Shades;
            this.profilePic.BackgroundImageLayout = ImageLayout.Stretch;


            lblUserInfo.Text = user.getName(Convert.ToInt32(userid));
        }
    }
}
