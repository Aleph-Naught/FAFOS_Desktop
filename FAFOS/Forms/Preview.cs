using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAFOS
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
            
        }
        public Preview(String file)
        {
            InitializeComponent();
            try
            {
                webBrowser1.Navigate(file);
            }
            catch (Exception e)
            {
                MessageBox.Show("The PDF could not load, please try again later");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
