using MySql.Data.MySqlClient;
using System;
using System.Data;
    
namespace Newmypocket
{
    class StoredProc
    {

       

        public class SiteDetailInfo
        {
            private int id;
            private int siteid;
            private int storeid;
            private string sitename;
            private string fullname;
            private int affiliate;
            private string site_url;
            private string showsite;


            public int Id
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }
            public int SiteId
            {
                get
                {
                    return siteid;
                }
                set
                {
                    siteid = value;
                }
            }
            public int StoreId
            {
                get
                {
                    return storeid;
                }
                set
                {
                    storeid = value;
                }
            }

            public string SiteName
            {
                get
                {
                    return sitename;
                }
                set
                {
                    sitename = value;
                }
            }

            public string FullName
            {
                get
                {
                    return fullname;
                }
                set
                {
                    fullname = value;
                }
            }
            public int Affiliate
            {
                get
                {
                    return affiliate;
                }
                set
                {
                    affiliate = value;
                }
            }

            public string SiteUrl
            {
                get
                {
                    return site_url;
                }
                set
                {
                    site_url = value;
                }
            }
            public string ShowSite
            {
                get
                {
                    return showsite;
                }
                set
                {
                    showsite = value;
                }
            }


            public SiteDetailInfo(DataRow siterow)
            {
                SiteId = Int32.Parse(siterow["SiteId"].ToString());
                StoreId = Int32.Parse(siterow["StoreId"].ToString());
                FullName = siterow["FullName"].ToString();
                Affiliate =  Int32.Parse(siterow["Affiliate"].ToString());
                SiteUrl = siterow["Site_URL"].ToString();
                ShowSite = siterow["ShowSite"].ToString();
            }
        }

        public static SiteDetailInfo GetSite(string SiteId)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "SiteINfo";
            comm.Parameters.Add("@InSiteNo", MySqlDbType.Int32).Value = SiteId;

            DataTable table = dataaccess.ExecuteSelectComandTable(comm);
            DataRow SiteRow = table.Rows[0];
            SiteDetailInfo siteInfo = new SiteDetailInfo(SiteRow);
            return siteInfo;
        }

        public static string GetButtonHeading(string ButtonId)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "checkButton";
            comm.Parameters.Add("@inButton", MySqlDbType.Int32).Value = ButtonId;

            string output = Convert.ToString(dataaccess.ExecuteScalar
                (comm));
            return output;
        }

        public static string CountSite()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "GetSiteCount";

            string output = Convert.ToString(dataaccess.ExecuteScalar(comm));

            return output;

        }

        public static DataTable FindUrl(string URL)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "URLCheck";
            comm.Parameters.Add("@url", MySqlDbType.String).Value = URL;

            DataTable table = dataaccess.ExecuteSelectComandTable(comm);

            return table;
        }

        public static DataTable FindName(string name)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "NameCheck";
            comm.Parameters.Add("@name", MySqlDbType.String).Value = name;

            DataTable table = dataaccess.ExecuteSelectComandTable(comm);

            return table;
        }

        // Add new Site
        public static bool AddNewSite(string IdIn, string SiteIdIn, String StoreId, string FullNameIn, string AffiliateIn, string SiteUrlIn, String ShowSiteIn)

        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "AddSite";
            comm.Parameters.Add("@IdIn", MySqlDbType.Int32).Value = IdIn;
            comm.Parameters.Add("@SiteIdIn", MySqlDbType.Int32).Value = SiteIdIn;
            comm.Parameters.Add("@StoreId", MySqlDbType.Int32).Value = StoreId;
            comm.Parameters.Add("@FullNameIn", MySqlDbType.String).Value = FullNameIn;
            comm.Parameters.Add("@AffiliateIn", MySqlDbType.Int32).Value = AffiliateIn;
            comm.Parameters.Add("@SiteURLIn", MySqlDbType.String).Value = SiteUrlIn;
            comm.Parameters.Add("@ShowSiteIn", MySqlDbType.String).Value = ShowSiteIn;

            int result = -1;

            try
            {
                result = dataaccess.ExecuteNonQuery(comm);

            }
            catch
            {
                //
            }

            return (result != -1);
        }

        public static bool UpdateSite(string IdIn, string StoreIdIn, string FullNameIn, string AffiliateIn, string SiteUrlIn, String ShowSiteIn)

        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "UpdateSite";
            comm.Parameters.Add("@IdIn", MySqlDbType.Int32).Value = IdIn;
            comm.Parameters.Add("@StoreId", MySqlDbType.Int32).Value = StoreIdIn;
            comm.Parameters.Add("@FullNameIn", MySqlDbType.String).Value = FullNameIn;
            comm.Parameters.Add("@AffiliateIn", MySqlDbType.Int32).Value = AffiliateIn;
            comm.Parameters.Add("@SiteURLIn", MySqlDbType.String).Value = SiteUrlIn;
            comm.Parameters.Add("@ShowSiteIn", MySqlDbType.String).Value = ShowSiteIn;

            int result = -1;

            try
            {
                result = dataaccess.ExecuteNonQuery(comm);

            }
            catch
            {
                //
            }

            return (result != -1);
        }

        public static string CheckWordPressSite(string SiteId)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "CheckSite";
            comm.Parameters.Add("@SiteIdIn", MySqlDbType.Int32).Value = SiteId;

            string output = Convert.ToString(dataaccess.ExecuteScalar(comm));
            return output;
        }

        public static string CheckFullName(string Name)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "FindName";
            comm.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
            string output = Convert.ToString(dataaccess.ExecuteScalar(comm));
            return output;
        }

        public static string URLName(string Name)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "FindURL";
            comm.Parameters.Add("@URL", MySqlDbType.VarChar).Value = Name;
            string output = Convert.ToString(dataaccess.ExecuteScalar(comm));
            return output;
        }
    }

   
}
