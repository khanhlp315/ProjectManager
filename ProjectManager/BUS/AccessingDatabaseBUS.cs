using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class AccessingDatabaseBUS
    {
        private static bool isConnected = false;
        public static async Task<bool> CreateConnection(string connectionstring)
        {
            if (isConnected) return true;
            if (!isConnected)
            {
                connectionstring = "Initial Catalog=QuanLyDuAn;Data Source=.;Integrated Security = True";
                isConnected = await CreateConnectionAsync(connectionstring);
                if(!isConnected)
                {
                    connectionstring = "Initial Catalog=QuanLyDuAn" + "Data Source =.\\SQLEXPRESS;Integrated Security = True";
                    isConnected = await CreateConnectionAsync(connectionstring);
                }
            }
            return isConnected;
        }
        public static async Task<bool> CreateConnectionAsync(string connectionstring)
        {
            var result = DALConnection.CreateConnection(connectionstring);
            return result;
        }
        public static async Task CloseConnection()
        {
            if(isConnected)
            {
                var t = Task.Run(() => DALConnection.CloseConnection());
                t.Wait();
            }
        }

    }
}
