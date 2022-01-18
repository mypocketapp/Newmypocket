using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Newmypocket
{
    public partial class frmSite : Form
    {
        public static string PassButton = "";
        public static string PassValue = "";
        public static int NextSite = 0;
        public frmSite()
        {
            InitializeComponent();
        }

        private void frmSite_Load(object sender, EventArgs e)
        {
            UpdateId();
        }

        private void btnCheckName_Click(object sender, EventArgs e)
        {
            FindName();
        }

        private void btnCheckUEL_Click(object sender, EventArgs e)
        {
            FindURL();
        }

        private void btnCheckHeading_Click(object sender, EventArgs e)
        {
            FindButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NextSite = Convert.ToInt32(txtNextId.Text) + 1;
            PassButton = txtButtonNo.Text.ToString();
            SiteAdd frm = new SiteAdd();
            frm.Show();
        }

               private void btnup_Click(object sender, EventArgs e)
        {
            PassValue = txtUpdateNo.Text;
          //  frmUpdateSite frm = new frmUpdateSite();
          //  frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateId()
        {
            txtNextId.Text = StoredProc.CountSite();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateId();
        }

        public void FindButton()
        {
            txtButtonName.Text = StoredProc.GetButtonHeading(txtButtonNo.Text);
        }

        public void FindURL()
        {
            txtURLOutput.Text = "";

            if (String.IsNullOrEmpty(txtURLInput.Text))
            {
                MessageBox.Show("You need to enter infomation");
            }
            else
            {
                DataTable table = StoredProc.FindUrl(txtURLInput.Text);

                if (table.Rows.Count != 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        txtURLOutput.Text += Convert.ToString(table.Rows[i]["id"]);
                        txtURLOutput.Text += "\t";
                        txtURLOutput.Text += Convert.ToString(table.Rows[i]["fullname"]);
                        txtURLOutput.Text += "\r\n";
                    }
                }
                else
                {
                    txtURLOutput.Text = "Nothing Found";
                }

            }

        }
        public void FindName()
        {
            txtNameOutput.Text = "";
            DataTable table = StoredProc.FindName(txtCheckName.Text);

            if (table.Rows.Count != 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    txtNameOutput.Text += Convert.ToString(table.Rows[i]["id"]);
                    txtNameOutput.Text += "\t";
                    txtNameOutput.Text += Convert.ToString(table.Rows[i]["fullname"]);
                    txtNameOutput.Text += "\r\n";
                }
            }
            else
            {
                txtNameOutput.Text = "Nothing Found";
            }

        }
    }
}

