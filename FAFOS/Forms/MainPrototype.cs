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
    public partial class MainPrototype : Form
    {
        public MainPrototype()
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = "Logged in as _____";

            View embeddedForm = new View();
            embeddedForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(embeddedForm);
            embeddedForm.Show();

        }
 

    }
}
