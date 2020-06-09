using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Lon.DAO
{
    public class ImportBillDAO
    {
        public static ImportBillDAO instance = new ImportBillDAO();
        private ImportBillDAO()
        {

        }

        public DataTable GetListImport()
        {
            string query = "SELECT Chi_tiet_hoa_don_nhap.SoHDN, MaNV, NgayNhap, MaNCC, Tongtien, Mabinh, Soluong, Dongia, Giamgia, Thanhtien FROM dbo.Hoa_don_nhap, dbo.Chi_tiet_hoa_don_nhap WHERE dbo.Hoa_don_nhap.SoHDN = dbo.Chi_tiet_hoa_don_nhap.SoHDN";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query, new object[] { });
            return data;
        }

        public DataTable GetListImportByProductCode(string productCode)
        {
            string query = " SELECT* FROM dbo.Hoa_don_nhap, dbo.Chi_tiet_hoa_don_nhap WHERE dbo.Hoa_don_nhap.SoHDN = dbo.Chi_tiet_hoa_don_nhap.SoHDN AND Mabinh = '"+ productCode +"'";
            DataTable data = DataProvider.instance.ExcuteQuery(query, new object[] { });

            return data;
        }

        public DataTable GetListImportBySupplier(string supplierCode)
        {
            string query = "SELECT * FROM dbo.Hoa_don_nhap, dbo.Chi_tiet_hoa_don_nhap WHERE dbo.Hoa_don_nhap.SoHDN = dbo.Chi_tiet_hoa_don_nhap.SoHDN AND MaNCC = '" + supplierCode + "' ";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query, new object[] { });
            return data;
        }

        public DataTable GetListImportByDate(DateTime date)
        {
            
            string query = "SELECT * FROM dbo.Hoa_don_nhap, dbo.Chi_tiet_hoa_don_nhap WHERE dbo.Hoa_don_nhap.SoHDN = dbo.Chi_tiet_hoa_don_nhap.SoHDN AND NgayNhap= ' "+ date + "'";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query, new object[] { });
            return data;
        }
    }
}
