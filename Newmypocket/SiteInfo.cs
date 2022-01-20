using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Newmypocket
{
    public partial class frmSite : Form
    {
        // variables used to send infomation to other forms
        public static string PassButton = "";
        public static string PassValue = "";
        public static int NextSite = 0;

        public frmSite()
        {
            InitializeComponent();
        }

        // Calls UpdateId() when forms opens
        private void frmSite_Load(object sender, EventArgs e)
        {
            UpdateId();
        }
        
        // Calls FindName() when user clicks on btnCheckName.
        private void btnCheckName_Click(object sender, EventArgs e)
        {
            FindName();
        }

        // calls FindUrl() when user clicks on btnCheckUEl
        private void btnCheckUEL_Click(object sender, EventArgs e)
        {
            FindURL();
        }

        // Call findButton when btnCheckHeading clicks on btnCheckHeading
        private void btnCheckHeading_Click(object sender, EventArgs e)
        {
            FindButton();
        }

        // opens the frm SiteAdd passing the value of txtNextId plus one, also the button no if user check a button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NextSite = Convert.ToInt32(txtNextId.Text) + 1;
            if (String.IsNullOrEmpty(txtButtonNo.Text))
            {
                PassButton = "0";
            }
            else
            {
                PassButton = txtButtonNo.Text.ToString();
            }
            PassButton = txtButtonNo.Text.ToString();
            SiteAdd frm = new SiteAdd();
            frm.Show();
        }

        // opens the form siteupade and passes the Value of site to update.
        private void btnup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdateNo.Text))
            {
                PassValue = "0";
            }
            else
            {
                PassValue = txtUpdateNo.Text;
            }
            
            SiteUpdate frm = new SiteUpdate();
            frm.Show();
        }

        // closes this form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Manualy updates the last id number calls UpdateId()
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateId();
        }

        // Calls the stored Procedure Countsite returns the last site id.
        public void UpdateId()
        {
            txtNextId.Text = StoredProc.CountSite();
        }
        public void FindButton()
        {
            txtButtonName.Text = StoredProc.GetButtonHeading(txtButtonNo.Text);
        }

        // checks and return if char in txtURLInput are in site info database
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

        // // checks and return if char in txtCheckName are in site info database
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

