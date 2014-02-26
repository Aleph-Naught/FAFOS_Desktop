﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAFOS.Forms
{
    public partial class Main : Form
    {
        //Members--------------------------------------------------------
        int userid;

        Login loginform = new Login();

        Form currentPage;

        //Functions------------------------------------------------------
        public Main()
        {
            InitializeComponent();

            loginform.LoggedIn += loginform_LoggedIn;

            this.toolStripStatusLabel1.Text = "Logged in as _____";

        }

        void loginform_LoggedIn(object sender, EventArgs e)
        {

            userid = loginform.userid;
            loginform.Close();

            InvoiceForm embeddedForm = new InvoiceForm(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);
            embeddedForm.Show();

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
                    serviceNotification.Text += "\n" + service + " needs to be completed by today at ";
                    serviceNotification.Text += dt2.Rows[i][4].ToString() + ", " + dt2.Rows[i][5].ToString() + "\n";
                }
            }
            if (serviceNotification.Text == "")
                serviceNotification.Text = "None";




            DataTable dt = new Payment().getNotPaid(userid);
            paymentNotification.Text = "";
            for (int i = 2; i < dt.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dt.Rows[i][2]) == DateTime.Today)
                {
                    String name = new Client().getName(new ClientContract().getClient(new SalesOrder().getSAddress(new Invoice().getSalesOrderID(dt.Rows[i][0].ToString()).ToString())));
                    paymentNotification.Text += "\n" + name + " has an outstanding balance of ";

                    DataTable payments = new Payment().getAmount(dt.Rows[i][0].ToString());
                    double total = 0;
                    for (int j = 0; j < payments.Rows.Count; j++)
                    {
                        total += Convert.ToDouble(payments.Rows[j][2]);

                    }
                    paymentNotification.Text += "$" + String.Format("{0:0.00}", Math.Round(Convert.ToDouble(dt.Rows[i][3].ToString()) - total, 2))
                        + " on invoice #" + dt.Rows[i][0].ToString() + "\n";
                }
            }
            if (paymentNotification.Text == "")
                paymentNotification.Text = "None";
        }

        private void syncHQ_Click(object sender, EventArgs e)
        {
            //TODO: None of the sync buttons work
        }

        private void MainPrototype_Load(object sender, EventArgs e)
        {
            loginform.ShowDialog();
        }

        private void dayItineraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();
            //TODO: Implement this
        }

        private void inspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();
            InspectionForm embeddedForm = new InspectionForm(userid.ToString());
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);
            embeddedForm.Show();

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();
            InventoryForm embeddedForm = new InventoryForm(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);
            embeddedForm.Show();
        }

        private void recordPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();
            PurchaseRecord embeddedForm = new PurchaseRecord(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);
            embeddedForm.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPage.Close();
            PaymentForm embeddedForm = new PaymentForm(userid);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);
            embeddedForm.Show();
        }

        private void createQuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: figure this out
        }
 

    }
}