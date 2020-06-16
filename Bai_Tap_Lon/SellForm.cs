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
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
        }

        private void DashBoard_BTN_Click(object sender, EventArgs e)
        {
            DashBoardForm dashBoard = new DashBoardForm();
            dashBoard.Show();
        }

        private void Transfer_BTN_Click(object sender, EventArgs e)
        {
            TransferForm transfer = new TransferForm();
            transfer.Show();
        }

        private void Customer_BTN_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
        }

        private void Employee_BTN_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
        }

        private void Report_BTN_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.Show();
        }

       
    }
}
