using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Newmypocket
{
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;user=root;database=mypocket;port=3306;password=green2Apple#";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            try
            {

                MySqlCommand cmd = new MySqlCommand("select Heading_id,Heading_Name, Heading_Order,Group_Class from button_headings order by Heading_Order", conn);


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string connStr2 = "server=127.0.0.1;user=root;database=mypocket;port=3306;password=green2Apple#";
                    MySqlConnection conn2 = new MySqlConnection(connStr2);
                    conn2.Open();
                    txtOutput.Text += $"{reader.GetString("Heading_Name")} ";
                    string StoreId = $"{reader.GetString("Group_Class")}";
                    txtOutput.Text += "\r\n";
                    try
                    {
                        MySqlCommand cmd2 = new MySqlCommand("select Site_Url, FullName FROM siteinfo  where StoreId = " + StoreId + " and showsite = 0", conn2);
                        MySqlDataReader reader1 = cmd2.ExecuteReader();
                        //txtOutput.Text += "\t";

                        bool hasRecords = false;

                        while (reader1.Read())
                        {
                            hasRecords = true;
                            txtOutput.Text += "\t";
                            txtOutput.Text += $"{reader1.GetString("FullName")}";
                            txtOutput.Text += "\r\n";
                        }

                        if (!hasRecords)
                        {
                            txtOutput.Text += "\t";
                            txtOutput.Text += "No Records";
                            txtOutput.Text += "\r\n";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Getting Records" + ex.ToString());
                    }


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Getting Records" + ex.ToString());
            }

            btnReturn.Focus();
        }
    }
}
