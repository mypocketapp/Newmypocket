using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
namespace Newmypocket
{
    public partial class frmButton : Form
    {
        MySqlDataAdapter daButton;
        DataSet dsButton;
        public frmButton()
        {
            InitializeComponent();
        }

        // displays Currents button heading when form loads
        private void frmButton_Load(object sender, EventArgs e)
        {
            // This section may change Gets the database connection string
            string connStr = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connStr);

            // gets the records from the button_heading table and puts into a datagrid
            try
            {
                string sql = "select Heading_id, Heading_Name,Heading_Order, Group_Class from button_headings";

                daButton = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daButton);
                dsButton = new DataSet();
                daButton.Fill(dsButton, "button");
                dataGridView1.DataSource = dsButton;
                dataGridView1.DataMember = "button";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // updates the button_heading table. after user makes changes
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int v = daButton.Update(dsButton, "button");
            MessageBox.Show("My sql record updated");
        }

        // closes the form
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
