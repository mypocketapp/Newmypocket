using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Newmypocket
{
    public partial class SiteAdd : Form
    {
        // All of the below have to be true to add new record
        public bool WordPressOk = false;
        public bool StoreIdOk = false;
        public bool FullNameOk = false;
        public bool AfiliateOk = true;
        public bool URLOk = false;
        public bool ShowOk = false;
        public SiteAdd()
        {
            InitializeComponent();
        }

        // recives values from frmsite and checks button number
        private void SiteAdd_Load(object sender, EventArgs e)
        {
            lblId.Text = frmSite.NextSite.ToString();
            string buttonNo = frmSite.PassButton.ToString();
            txtStoreId.Text = buttonNo;
            CheckButton(buttonNo);
            btnAdd.Enabled = false;
        }

        // checks store id when txtstoreId is changed
        private void txtStoreId_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStoreId.Text))
            {
                //
            }
            else
            {
                string buttonNo = txtStoreId.Text.ToString();
                CheckButton(buttonNo);
            }
        }

        // checks siteSiteId when txtSiteId is changed
        private void txtSiteId_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSiteId.Text))
            {
                //
            }
            else
            {
                CheckWord();
            }
        }

        // checks if name is already used
        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFullName.Text))
            {
                //
            }
            else
            {
                CheckFullName();
            }
        }

        // checks if URL is already used
        private void txtSiteURL_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSiteURL.Text))
            {
                //
            }
            else
            {
                CheckURL();
            }
        }

        // checks if value is 0 or 1
        private void txtShow_TextChanged(object sender, EventArgs e)
        {
            if (txtShow.Text == "0" || txtShow.Text == "1")
            {
                ShowOk = true;
            }
            else
            {
                MessageBox.Show("Value needs to be a 0 or 1");
                ShowOk = false;
            }
            CheckBtn();
        }

        // check if the button number is vaild
        public void CheckButton(string ButtonIN)
        {

            string ButtonReturn = StoredProc.GetButtonHeading(ButtonIN);
            //txtStoreId.Text = buttonNo;
            if (ButtonReturn == "No Match")
            {
                lblName.BackColor = System.Drawing.Color.Red;
                lblName.Text = ButtonReturn;
                StoreIdOk = false;
            }
            else
            {
                lblName.BackColor = System.Drawing.Color.Green;
                lblName.Text = ButtonReturn;
                StoreIdOk = true;
            }
            CheckBtn();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Idin = lblId.Text;
            string SiteIdIn = txtSiteId.Text;
            string StoreId = txtStoreId.Text;
            string FullName = txtFullName.Text;
            string AffiateIn = txtAffilate.Text;
            string SiteURL = txtSiteURL.Text;
            string ShowSiteIn = txtShow.Text;

            bool result = StoredProc.AddNewSite(Idin, SiteIdIn, StoreId, FullName, AffiateIn, SiteURL, ShowSiteIn);

            if (result == true)
            {
                MessageBox.Show("Your site is added");

            }
            else
            {
                MessageBox.Show("Error Adding you site");
            }
        }

        // closes this form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // makes sure the Wordpress site number not already used
        public void CheckWord()
        {
            string site = txtSiteId.Text;
            string ButtonReturn = StoredProc.CheckWordPressSite(site);

            if (ButtonReturn == "No Match")
            {
                lblWord.BackColor = System.Drawing.Color.Green;
                lblWord.Text = ButtonReturn;
                WordPressOk = true;
            }
            else
            {
                lblWord.BackColor = System.Drawing.Color.Red;
                lblWord.Text = ButtonReturn;
                WordPressOk = false;
            }
            CheckBtn();
        }

        public void CheckFullName()
        {
            string FullName = txtFullName.Text;
            string ButtonReturn = StoredProc.CheckFullName(FullName);

            if (ButtonReturn == "No Match")
            {
                lblCheckName.BackColor = System.Drawing.Color.Green;
                lblCheckName.Text = ButtonReturn;
                FullNameOk = true;
            }
            else
            {
                lblCheckName.BackColor = System.Drawing.Color.Red;
                lblCheckName.Text = ButtonReturn;
                FullNameOk = false;
            }
            CheckBtn();
        }

        public void CheckURL()
        {
            string URL = txtSiteURL.Text;
            string ButtonReturn = StoredProc.URLName(URL);

            if (ButtonReturn == "No Match")
            {
                lblURlCheck.BackColor = System.Drawing.Color.Green;
                lblURlCheck.Text = ButtonReturn;
                URLOk = true;
            }
            else
            {
                lblURlCheck.BackColor = System.Drawing.Color.Red;
                lblURlCheck.Text = ButtonReturn;
                URLOk = false;
            }
            CheckBtn();
        }
        // check if the btnAdd should be enabled
        public void CheckBtn()
        {
            if (WordPressOk == true && StoreIdOk == true && FullNameOk == true && AfiliateOk == true && URLOk == true && ShowOk == true )
            {
                btnAdd.Enabled = true;
            }
        }

        // checks for numbers only on txtSiteId
        private void txtSiteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

      

        // checks for numbers only on txtStoreId
        private void txtStoreId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAffilate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

       
    }
}
