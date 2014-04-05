using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FAFOS.Forms;
using System.Data.SqlClient;

namespace FAFOS.Forms.Operations
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (supplierName.Text != "")
            {
                Random rnd = new Random();
                

                bool success = false;


                while(!success)
                {
                    int myRandomNo = rnd.Next(1000, 9999); // creates a 4 digit random no.

                    try
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.FAFOS);
                        con.Open();

                        SqlCommand command = new SqlCommand("INSERT INTO Supplier (supplier_id, name) VALUES (@id, @name)", con);
                        command.Parameters.AddWithValue("@id", myRandomNo.ToString());
                        command.Parameters.AddWithValue("@name", supplierName.Text);

                        command.ExecuteNonQuery();
                        con.Close();

                        success = true;

                    }
                    catch (Exception f)
                    {
                        //MessageBox.Show(f.ToString());
                        success = false;
                    }

                    
                }

                

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
