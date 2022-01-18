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
        public bool WordPressOk = false;
        public bool StoreIdOk = false;
        public bool FullNameOk = true;
        public bool AfiliateOk = true;
        public bool URLOk = true;
        public bool ShowOk = true;
        public SiteAdd()
        {
            InitializeComponent();
        }

        private void SiteAdd_Load(object sender, EventArgs e)
        {
            lblId.Text = frmSite.NextSite.ToString();
            string buttonNo = frmSite.PassButton.ToString();
            txtStoreId.Text = buttonNo;
            CheckButton(buttonNo);
            btnAdd.Enabled = false;
        }
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

        private void txtStoreId_TextChanged(object sender, EventArgs e)
        {
            string buttonNo = txtStoreId.Text.ToString();
            CheckButton(buttonNo);
        }

        private void txtSiteId_TextChanged(object sender, EventArgs e)
        {
            CheckWord();
        }

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

        public void CheckBtn()
        {
            if (WordPressOk == true && StoreIdOk == true && FullNameOk == true && AfiliateOk == true && URLOk == true && ShowOk == true )
            {
                btnAdd.Enabled = true;
            }
        }
    }
}
