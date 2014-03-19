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

        public event EventHandler recordPurchaseClicked;
        public event EventHandler payInvoiceClicked;
        public event EventHandler addClientCLicked;
        public event EventHandler addContractClicked;
        public event EventHandler createQuoteClicked;
        public event EventHandler createSalesClicked;
        public event EventHandler revenueReportClicked;
        public event EventHandler royaltyReportClicked;

        public event EventHandler userSettingsClicked;
        public event EventHandler logoutClicked;

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

        private void button5_Click(object sender, EventArgs e)
        {
            if (addClientCLicked != null)
                addClientCLicked(sender, e);
        }

        private void recordPurchaseBtn_Click(object sender, EventArgs e)
        {
            if (recordPurchaseClicked != null)
                recordPurchaseClicked(sender, e);
        }

        private void payInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (payInvoiceClicked != null)
                payInvoiceClicked(sender, e);
        }

        private void addContractBtn_Click(object sender, EventArgs e)
        {
            if (addContractClicked != null)
                addContractClicked(sender, e);
        }

        private void creatQuoteBtn_Click(object sender, EventArgs e)
        {
            if (createQuoteClicked != null)
                createQuoteClicked(sender, e);
        }

        private void createSalesOrderBtn_Click(object sender, EventArgs e)
        {
            if (createSalesClicked != null)
                createSalesClicked(sender, e);
        }

        private void revenueReport_Click(object sender, EventArgs e)
        {
            if (revenueReportClicked != null)
                revenueReportClicked(sender, e);
        }

        private void royaltyReportBtn_Click(object sender, EventArgs e)
        {
            if (royaltyReportClicked != null)
                royaltyReportClicked(sender, e);
        }

        private void userSettingsBtn_Click(object sender, EventArgs e)
        {
            if (userSettingsClicked != null)
                userSettingsClicked(sender, e);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (logoutClicked != null)
                logoutClicked(sender, e);
        }




    }
}
