using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Lon.DTO
{
    public class DashBoard
    {
        public DashBoard(string productCode, string productName, string typeCode, string typeName, string weight, string produceCountry, double quantity, double importPrice, double exportPrice, DateTime waranty, string note)
        {
            this.Mabinh = productCode;
            this.Tenbinh = productName;
            this.Maloai = typeCode;
            this.Tenloai = typeName;
            this.Makhoiluong = weight;
            this.ManuocSX = produceCountry;
            this.Soluong = quantity;
            this.Dongianhap = importPrice;
            this.Ngaybaohanh = waranty;
            this.Ghichu = note;
        }
        

        public DashBoard(DataRow row)
        {
            this.Mabinh = row["Mabinh"].ToString();
            this.Tenbinh = row["Tenbinh"].ToString();
            this.Maloai = row["Maloai"].ToString();
            this.Tenloai = row["Tenloai"].ToString();
            this.Makhoiluong = row["Makhoiluong"].ToString();
            this.ManuocSX = row["ManuocSX"].ToString();
            this.Soluong = (double)row["Soluong"];
            this.Dongianhap = (double)row["Dongianhap"];
            this.Dongiaban = (double)row["Dongiaban"];
            this.Ngaybaohanh = (DateTime)row["Thoigianbaohang"];
            this.Ghichu = row["Ghichu"].ToString();
        }
         
        public string Mabinh { get; set; }
        public string Tenbinh { get; set; }
        public string Maloai { get; set; }
        public string Tenloai { get; set; }
        public string Makhoiluong { get; set; }
        public string ManuocSX { get; set; }
        public double Soluong { get; set; }
        public double Dongianhap { get; set; }
        public double Dongiaban { get; set; }
        public DateTime Ngaybaohanh { get; set; }
        public string Ghichu { get; set; }

    }
}
