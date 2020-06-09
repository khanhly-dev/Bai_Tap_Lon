using Bai_Tap_Lon.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Lon
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            GetListImport();
            GetListExport();
        }

        public void GetListImport()
        {
            ImportBill_DGV.DataSource = ImportBillDAO.instance.GetListImport();
        }

        public void GetListImportByProductCode()
        {
            ImportBill_DGV.DataSource = ImportBillDAO.instance.GetListImportByProductCode(ImportSeach_TBX.Text);
        }

        public void GetListImportBySupplier()
        {
            ImportBill_DGV.DataSource = ImportBillDAO.instance.GetListImportBySupplier(ImportSeach_TBX.Text);
        }

        public void GetListImportByDate()
        {
            DateTime date;
            DateTime.TryParse(ImportSeach_TBX.Text, out date);
            ImportBill_DGV.DataSource = ImportBillDAO.instance.GetListImportByDate(date);
        }

        private void ImportSeach_BTN_Click(object sender, EventArgs e)
        {
            if(TypeSeach_CBB.Text=="Mã hàng")
            {
                GetListImportByProductCode();
            }    
            else if(TypeSeach_CBB.Text=="Nhà cung cấp")
            {
                GetListImportBySupplier();
            }
            else
            {
                GetListImportByDate();
            }         
        }



        public void GetListExport()
        {
            ExportBill_DGV.DataSource= ExportBillDAO.instance.GetListExportBill();
        }
       
    }
}
