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

        private void btnButton_Click(object sender, EventArgs e)
        {
            frmButton frm = new frmButton();

            frm.Show();
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            frmSite frm = new frmSite();

            frm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();

            frm.Show();
        }

        private void btnInStore_Click(object sender, EventArgs e)
        {
            frmProductStore frm = new frmProductStore();

            frm.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();

            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
