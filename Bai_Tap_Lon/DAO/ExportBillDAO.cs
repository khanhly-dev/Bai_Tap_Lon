using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Lon.DAO
{
    public class ExportBillDAO
    {
        public static ExportBillDAO instance = new ExportBillDAO();
        private ExportBillDAO()
        {

        }

        public DataTable GetListExportBill()
        {
            string query = "SELECT * FROM dbo.Hoa_don_ban, dbo.Chi_tiet_hoa_don_ban WHERE Chi_tiet_hoa_don_ban.SoHDB=dbo.Hoa_don_ban.SoHDB";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query, new object[] { });
            return data;
        }
        
    }
}
