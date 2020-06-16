using Bai_Tap_Lon.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Lon.DAO
{
    public class DashBoardDAO
    {
        public static DashBoardDAO instance = new DashBoardDAO();
        private DashBoardDAO()
        {

        }

        public List<DashBoard> LoadDashBoard()
        {
            List<DashBoard> dashBoardList = new List<DashBoard>();
            string query = "SELECT Mabinh, Tenbinh, DM_Binh_ga.Maloai, Tenloai, Makhoiluong, ManuocSX, Soluong, Dongianhap, Dongiaban, Thoigianbaohang, Ghichu FROM dbo.DM_Binh_ga, dbo.Loai_ga WHERE DM_Binh_ga.Maloai = Loai_ga.Maloai";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query, new object[] { });
            foreach (DataRow item in data.Rows)
            {
                DashBoard dashBoard = new DashBoard(item);
                dashBoardList.Add(dashBoard);
            }
            return dashBoardList;
        } 

        public DataTable GetDashBoard()
        {
            string query = "SELECT Mabinh, Tenbinh, DM_Binh_ga.Maloai, Tenloai, Makhoiluong, ManuocSX, Soluong, Dongianhap, Thoigianbaohang, Ghichu FROM dbo.DM_Binh_ga, dbo.Loai_ga WHERE DM_Binh_ga.Maloai = Loai_ga.Maloai";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query, new object[] { });
            return data;
        }

        public DataTable GetDashBoardByType(string key)
        {
            string query = "SELECT Mabinh, Tenbinh, DM_Binh_ga.Maloai, Tenloai, Makhoiluong, ManuocSX, Soluong, Dongianhap, Thoigianbaohang, Ghichu FROM dbo.DM_Binh_ga, dbo.Loai_ga WHERE DM_Binh_ga.Maloai = Loai_ga.Maloai AND Tenloai='" + key+"'";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query, new object[] { });
            return data;
        }

        public DataTable GetDashBoardByWeight(string key)
        {
            string query = "SELECT Mabinh, Tenbinh, DM_Binh_ga.Maloai, Tenloai, Makhoiluong, ManuocSX, Soluong, Dongianhap, Thoigianbaohang, Ghichu FROM dbo.DM_Binh_ga, dbo.Loai_ga WHERE DM_Binh_ga.Maloai = Loai_ga.Maloai AND Makhoiluong='" + key + "'";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query, new object[] { });
            return data;
        }

        public DataTable GetDashBoardByWaranty(DateTime key)
        {
            string query = "SELECT Mabinh, Tenbinh, DM_Binh_ga.Maloai, Tenloai, Makhoiluong, ManuocSX, Soluong, Dongianhap, Thoigianbaohang, Ghichu FROM dbo.DM_Binh_ga, dbo.Loai_ga WHERE DM_Binh_ga.Maloai = Loai_ga.Maloai AND Thoigianbaohang='" + key + "'";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query, new object[] { });
            return data;
        }
    }
}
