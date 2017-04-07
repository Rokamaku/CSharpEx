using System;
using System.Data.OleDb;


namespace DataAccess
{
    public class DBConnection
    {
        protected OleDbConnection conn;

        private const string CONNECTIONSTRING = @"Provider=SQLOLEDB; Data Source = PARAKODA\SQLEXPRESS; Initial Catalog = StudentManagement;
                        Integrated Security = SSPI; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True;
                        ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        public DBConnection()
        {
            try
            {
                conn = new OleDbConnection(CONNECTIONSTRING);
            } catch (Exception)
            {
                Console.WriteLine("Can not connect to database");
            }
        }
    }
}
