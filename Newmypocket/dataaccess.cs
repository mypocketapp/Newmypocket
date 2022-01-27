using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

public static class dataaccess
{
    static string connStr = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;

    static dataaccess()
    {
        //
    }


    //public static void ExecuteNonQuery(MySqlCommand cmd)
    //{
    //    DataSet dsData = new DataSet();

    //    try
    //    {
    //        using (MySqlConnection connection = new MySqlConnection(connStr))
    //        {
    //            cmd.Connection = connection;
    //            cmd.Connection.Open();
    //            cmd.ExecuteNonQuery();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.ToString());
    //    }
    //    finally
    //    {

    //    }
    //}

    public static string ExecuteScalar(DbCommand command)
    {
        MySqlConnection connection = new MySqlConnection(connStr);
        string value = "";

        command.Connection = connection;

        try
        {
            connection.Open();
            value = Convert.ToString(command.ExecuteScalar());
            if (value == "")
            {
                value = "No Match";
            }
            return value;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return value;
    }

    public static string ExecuteReader(DbCommand command)
    {
        MySqlConnection connection = new MySqlConnection(connStr);
        string value = "";

        command.Connection = connection;

        try
        {
            connection.Open();
            value = command.ExecuteReader().ToString();
            return value;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return value;
    }

    public static DataTable ExecuteSelectComandTable(MySqlCommand command)
    {
        MySqlConnection connection = new MySqlConnection(connStr);
        DataTable table = new DataTable();
        command.Connection = connection;
        {
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            table = new DataTable();
            table.Load(reader);
            reader.Close();
            command.Connection.Close();
            return table;
        }
    }

    public static int ExecuteNonQuery(DbCommand command)
    {
        // the number of affected rows
        int affectedRows = -1;
        MySqlConnection connection = new MySqlConnection(connStr);
        // exexcute the command making sure the connection gets closed
        command.Connection = connection;
       
        try
        {
            // open the connection
            connection.Open();
            // execute the command and get the number of affected rows
            affectedRows = command.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            MessageBox.Show("Error" + ex.ToString());
        }
        finally
        {
            command.Connection.Close();
        }
        return affectedRows;
    }
}