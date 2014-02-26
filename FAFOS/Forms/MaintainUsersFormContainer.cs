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
    public partial class MaintainUsersFormContainer : Form
    {
        Form currentPage;
        int _idOfUser, _ProPicID;

        public MaintainUsersFormContainer(int idOfUser, int ProPicID)
        {
            InitializeComponent();

            _idOfUser = idOfUser;
            _ProPicID = ProPicID;

            loadMaintainUsersForm();
        }

        private void loadMaintainUsersForm()
        {
            currentPage.Close();
            MaintainUsersForm embeddedForm = new MaintainUsersForm(_idOfUser, _ProPicID);
            currentPage = embeddedForm;
            embeddedForm.TopLevel = false;
            containerPanel.Controls.Add(embeddedForm);
            embeddedForm.Show();
        }
    }
}
