
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAFOS.Forms
{
    public partial class Main : Form
    {
        //Members--------------------------------------------------------
        Users user;
        int userid;

        Login loginform = new Login();

        Form currentPage;

        MaintainUsersForm userSettings;
        SyncView android;

        WorkOrder[] orders;
        ContractService[] services;


        //Functions------------------------------------------------------
        public Main()
        {
            InitializeComponent();

            loginform.LoggedIn += loginform_LoggedIn;

            user = new Users();

        }

        void closeSettings(object sender, EventArgs e)
        {
            userSettings = null;
        }

        void closeAndroid(object sender, EventArgs e)
        {
            android = null;
        }


        void loginform_LoggedIn(object sender, EventArgs e)
        {

            this.Show();

            userid = loginform.userid;
            loginform.Close();


            HomePage embeddedForm = new HomePage(userid.ToString());


            embeddedForm.recordPurchaseClicked += recordPurchaseToolStripMenuItem_Click;
            embeddedForm.payInvoiceClicked += paymentToolStripMenuItem_Click;
            embeddedForm.addClientCLicked += addClientToolStripMenuItem_Click;
            embeddedForm.addContractClicked += addContractToolStripMenuItem_Click;

            embeddedForm.createQuoteClicked += createQuoteToolStripMenuItem_Click;
            embeddedForm.revenueReportClicked += revenueReportsToolStripMenuItem_Click;
            embeddedForm.createSalesClicked += createSalesOrderToolStripMenuItem_Click;
            embeddedForm.royaltyReportClicked += royaltyFeeToolStripMenuItem_Click;


            embeddedForm.userSettingsClicked += userSettingsToolStripMenuItem_Click;
            embeddedForm.logoutClicked += logoutToolStripMenuItem_Click;


            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();

            this.userLabel.Text = "Logged in as " + user.getName(userid);

            Notifications();

        }

        public void Notifications()
        {

            DataTable dt2 = new ClientContract().getServices(userid.ToString());
            serviceNotification.Text = "";

            for (int i = 0; i < dt2.Rows.Count; i++)
            {


                if (Convert.ToDateTime(dt2.Rows[i][2]) == DateTime.Today)
                {
                    String service = dt2.Rows[i][0].ToString();
                    serviceNotification.Text += service + " needs to be completed today at ";
                    serviceNotification.Text += dt2.Rows[i][4].ToString() + ", " + dt2.Rows[i][5].ToString() + "\n\n";
                }
            }
            if (serviceNotification.Text == "")
                serviceNotification.Text = "None";




            DataTable dt = new Payment().getNotPaid(userid);
            paymentNotification.Text = "";

            for (int i = 2; i < dt.Rows.Count; i++)
            {

                String date = Convert.ToDateTime(dt.Rows[i][2]).ToString().ToString();
                String today1 = DateTime.Today.ToString();

                if (Convert.ToDateTime(dt.Rows[i][2]) == DateTime.Today)
                {
                    String name = new Client().getName(new ClientContract().getClient(new SalesOrder().getSAddress(new Invoice().getSalesOrderID(dt.Rows[i][0].ToString()).ToString())));
                    paymentNotification.Text += "" + name + " has an outstanding balance of ";

                    DataTable payments = new Payment().getAmount(dt.Rows[i][0].ToString());
                    double total = 0;
                    for (int j = 0; j < payments.Rows.Count; j++)
                    {
                        total += Convert.ToDouble(payments.Rows[j][2]);

                    }
                    paymentNotification.Text += "$" + String.Format("{0:0.00}", Math.Round(Convert.ToDouble(dt.Rows[i][3].ToString()) - total, 2))
                        + " on invoice #" + dt.Rows[i][0].ToString() + "\n\n";
                }
            }
            if (paymentNotification.Text == "")
                paymentNotification.Text = "None";
        }


        private void MainPrototype_Load(object sender, EventArgs e)
        { 
            loginform.ShowDialog();
        }

        private void dayItineraryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            InspectionForm embeddedForm = new InspectionForm(userid.ToString());
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            InventoryForm embeddedForm = new InventoryForm(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }

        private void recordPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();
            PurchaseRecord embeddedForm = new PurchaseRecord(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();
            PaymentForm embeddedForm = new PaymentForm(userid, this);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }

        private void createQuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            QuoteController qc = new QuoteController(userid.ToString());

            currentPage.Close();
            QuoteForm embeddedForm = qc.quote(1);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
          
        }

        private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (userSettings != null)
            {
                userSettings.BringToFront();
            }
            else
            {
                userSettings = new MaintainUsersForm(userid, MUser.GetPicID(userid.ToString()));
                userSettings.Show();
                userSettings.settingsClosed += closeSettings;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();
            this.Hide();
            loginform = new Login();
            loginform.LoggedIn += loginform_LoggedIn;
            loginform.ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            InvoiceForm embeddedForm = new InvoiceForm(userid, this);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            HomePage embeddedForm = new HomePage(userid.ToString());

            embeddedForm.recordPurchaseClicked += recordPurchaseToolStripMenuItem_Click;
            embeddedForm.payInvoiceClicked += paymentToolStripMenuItem_Click;
            embeddedForm.addClientCLicked += addClientToolStripMenuItem_Click;
            embeddedForm.addContractClicked += addContractToolStripMenuItem_Click;

            embeddedForm.createQuoteClicked += createQuoteToolStripMenuItem_Click;
            embeddedForm.revenueReportClicked += revenueReportsToolStripMenuItem_Click;
            embeddedForm.createSalesClicked += createSalesOrderToolStripMenuItem_Click;
            embeddedForm.royaltyReportClicked += royaltyFeeToolStripMenuItem_Click;

            embeddedForm.userSettingsClicked += userSettingsToolStripMenuItem_Click;
            embeddedForm.logoutClicked += logoutToolStripMenuItem_Click;

            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            MaintainClientController control = new MaintainClientController(this);
            AddEditClientForm embeddedForm = control.New_client_button_Click(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }


        private void royaltyFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            RoyaltyFeeCollection embeddedForm = new RoyaltyFeeCollection(userid.ToString());
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }

        private void financialStatementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            Statements embeddedForm = new Statements(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }
 
        private void editQuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            QuoteController qc = new QuoteController(userid.ToString());
            // type 2 = edit
            QuoteForm embeddedForm = qc.quote(2);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }

        private void createSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            SalesOrderController control = new SalesOrderController(userid.ToString());
            // type 1 = create
            Sales_Order embeddedForm = control.salesOrder(1);
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill;

            currentPage = embeddedForm;
            embeddedForm.Show();
        }

        private void editSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            SalesOrderController control = new SalesOrderController(userid.ToString());
            // type 3 = edit
            Sales_Order embeddedForm = control.salesOrder(3);
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill;

            currentPage = embeddedForm;
            embeddedForm.Show();
        }

        private void convertToSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesOrderController control = new SalesOrderController(userid.ToString());

            currentPage.Close();

            // type 2 = convert
            Sales_Order embeddedForm = control.salesOrder(2);
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill;

            currentPage = embeddedForm;
            embeddedForm.Show();
        }
 

        private void revenueReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            ReportsController cont = new ReportsController(userid.ToString());
            Reports embeddedForm = new Reports(cont, userid.ToString(), 0);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }
 


        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            MaintainClientController control = new MaintainClientController(this);
            AddEditClientForm embeddedForm = control.Edit_Client_Button_Click(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }

        private void addContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            MaintainClientController control = new MaintainClientController(this);
            AddEditContractForm embeddedForm = control.Add_contract_Button_Click(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }

        private void editContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();

            MaintainClientController control = new MaintainClientController(this);
            AddEditContractForm embeddedForm = control.Edit_contract_Button_Click(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }

        private void syncAndroid_Click(object sender, EventArgs e)
        {
            if (android != null)
            {
                android.BringToFront();
            }
            else
            {
                android = new SyncView(userid);
                android.Show();
               android.androidClosed += closeAndroid;
            }
        }

        private void dayItineraryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            currentPage.Close();

            MapsForm embeddedForm = new MapsForm(userid, orders, services);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);

            embeddedForm.Dock = DockStyle.Fill; //This is required for scaling

            embeddedForm.Show();
        }
 
    }
}

