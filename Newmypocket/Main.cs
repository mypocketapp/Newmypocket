using System;
using System.Windows.Forms;

namespace Newmypocket
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Shows the Heading buttons Form
        private void btnButton_Click(object sender, EventArgs e)
        {
            frmButton frm = new frmButton();

            frm.Show();
        }

        // Shows the Site infomation Form
        private void btnSite_Click(object sender, EventArgs e)
        {
            frmSite frm = new frmSite();

            frm.Show();
        }

        // Shows the Product infomation Form
        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();

            frm.Show();
        }

        // Shows which product in each store
        private void btnInStore_Click(object sender, EventArgs e)
        {
            frmProductStore frm = new frmProductStore();

            frm.Show();
        }

        // Shows the form to display the output of the buttons headings and stores under each heading
        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();

            frm.Show();
        }

        // button that closes the app
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
