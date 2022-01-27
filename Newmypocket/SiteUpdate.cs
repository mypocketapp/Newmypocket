using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newmypocket
{
    public partial class SiteUpdate : Form
    {

        bool StoreIdOk = true;
        bool FullNameOk = true;
        bool AffiateOk = true;
        bool URLOk = true;
        bool ShowOk = true;
        string SiteId;
        string ButtonNumber;
        string FullName;
        string Affiate;
        string SiteUrl;
        string SiteShow;
        public SiteUpdate()
        {
            InitializeComponent();
        }

        private void SiteUpdate_Load(object sender, EventArgs e)
        {
            lblId.Text = frmSite.PassValue;
            StoredProc.SiteDetailInfo siteInfo = StoredProc.GetSite(frmSite.PassValue);

            SiteId = siteInfo.SiteId.ToString();
            ButtonNumber = siteInfo.StoreId.ToString();
            FullName = siteInfo.FullName.ToString();
            Affiate = siteInfo.Affiliate.ToString();
            SiteUrl = siteInfo.SiteUrl.ToString();
            SiteShow = siteInfo.ShowSite.ToString();

            txtSiteId.Text = SiteId;
            txtButtonNumber.Text = ButtonNumber;
            txtFullName.Text = FullName;
            txtAffiate.Text = Affiate;
            txtSiteURL.Text = SiteUrl;
            txtShow.Text = SiteShow;

            btnUpdate.Enabled = false;
            
        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtButtonNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtButtonNumber.Text))
            {
                //
            }
            else
            {
                CheckButton(txtButtonNumber.Text);
            }
                       
        }

        // check if the button number is vaild
        public void CheckButton(string ButtonIn)
        {
            StoreIdOk = false;
            btnUpdate.Enabled = false;
            string ButtonReturn = StoredProc.GetButtonHeading(ButtonIn);
            if (ButtonReturn == "No Match")
            {
                txtButtonName.BackColor = System.Drawing.Color.Red;
                txtButtonName.Text = ButtonReturn;
                StoreIdOk = false;
            }
            else
            {
                txtButtonName.BackColor = System.Drawing.Color.Green;
                txtButtonName.Text = ButtonReturn;
                StoreIdOk = true;
            }
            checkBtn();
        }

        public void checkBtn()
        {
            bool updateButton = false;
            bool updateUrl = false;
            bool updateName = false;
            bool updateAffiate = false;
            bool updateShow = false;
            bool showUpdateOk = false;
            bool showUpdate = false;

            if ( txtButtonNumber.Text == ButtonNumber)
            {
                updateButton = false;
            }
            else
            {
                updateButton = true;
            }

            if (txtSiteURL.Text == SiteUrl)
            {
                updateUrl = false;
            }
            else
            {
                updateUrl = true;
            }

            if (txtFullName.Text == FullName)
            {
                updateName = false;
            }
            else
            {
                updateName = true;
            }

            if(txtAffiate.Text == Affiate)
            {
                updateAffiate = false;
            }
            else
            {
                updateAffiate = true;
            }

            if (txtShow.Text == SiteShow)
            {
                updateShow = false;
            }
            else
            {
                updateShow = true;
            }
            if (updateButton == true || updateUrl == true || updateName == true || updateAffiate == true || updateShow == true)
            {
                showUpdateOk = true;
            }
            if (StoreIdOk == true && FullNameOk == true && AffiateOk == true && URLOk == true && ShowOk == true)
            {
                showUpdate = true;
                
            }
            if (showUpdateOk == true && showUpdate == true)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void txtSiteURL_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSiteURL.Text))
            {
                //
            }
            else
            {
               CheckUrl();
                        
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                //
            }
            else
            {
                if (FullName == txtFullName.Text)
                {
                    //
                }
                else
                {
                    CheckFullName();
                }
            }

            checkBtn();
        }

        private void txtAffiate_TextChanged(object sender, EventArgs e)
        {
            checkBtn();
        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {
            ShowOk = false;
            btnUpdate.Enabled = false;
            if (string.IsNullOrEmpty(txtShow.Text))
            {
                //
            }
            else
            {
                if (txtShow.Text == "0" || txtShow.Text == "1")
                {
                    ShowOk = true;
                }
                else
                {
                    MessageBox.Show("Values needs to be a 0 or 1");
                    ShowOk = false;
                }
            }
            checkBtn();
        }

        public void CheckUrl()
        {
            URLOk = false;
            btnUpdate.Enabled = false;
            string URL = txtSiteURL.Text;
            string ButtonReturn = StoredProc.URLName(URL);

            if (ButtonReturn == "No Match" || txtSiteURL.Text == SiteUrl)
            {
                lblUrl.BackColor = System.Drawing.Color.Green;
                lblUrl.Text = ButtonReturn;
                URLOk = true;
            }
            else
            {
                lblUrl.BackColor = System.Drawing.Color.Red;
                lblUrl.Text = ButtonReturn;
                URLOk = false;
            }
            checkBtn();

        }

        public void CheckFullName()
        {
            FullNameOk = false;
            btnUpdate.Enabled = false;
            string FullNameIn = txtFullName.Text;
            string buttonReturn = StoredProc.CheckFullName(FullNameIn);
            if (buttonReturn == "No Match" || txtFullName.Text == FullName)
            {
              lblName.BackColor = System.Drawing.Color.Green;
                lblName.Text = buttonReturn;
                FullNameOk = true;
            }
            else
            {
                lblName.BackColor = System.Drawing.Color.Red;
                lblName.Text = buttonReturn;
                FullNameOk = false;
            }

            checkBtn();
        }

        private void txtAffiate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtButtonName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtShow_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtShow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtButtonNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtButtonNumber.Text))
            {
                //
            }
            else
            {
                string buttonNo = txtButtonNumber.Text.ToString();
                CheckButton(buttonNo);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idOut = lblId.Text;
            string ButtonOut = txtButtonNumber.Text;
            string NameOut = txtFullName.Text;
            string AffiliateOut = txtAffiate.Text;
            string SiteUrlOut = txtSiteURL.Text;
            string ShowOut = txtShow.Text;

            bool result = StoredProc.UpdateSite(idOut, ButtonOut, NameOut, AffiliateOut, SiteUrlOut, ShowOut);

            if (result == true)
            {
                MessageBox.Show("Your Site is Updated");
            }
            else
            {
                MessageBox.Show("Your site was not Updated");
            }
        }
    }
}
