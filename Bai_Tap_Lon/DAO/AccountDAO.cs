using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Lon.DAO
{
    public class AccountDAO
    {
        // Constructer + design pattern singleton
        public static AccountDAO instance = new AccountDAO();
        private AccountDAO()
        {

        }

        public bool Login(string userName, string password)
        {
            string query = "USP_Login @userName , @password";

            DataTable result = DataProvider.instance.ExcuteQuery(query, new object[] { userName, password });

            return result.Rows.Count > 0;
        }

    }
}
