using Bai_Tap_Lon.DAO;
using Bai_Tap_Lon.DTO;
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
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
            GetListDashBoard();
        }

        public void GetListDashBoard()
        {
            DashBoard_DGV.DataSource = DashBoardDAO.instance.LoadDashBoard();
        }

        public void GetDashBoardByType()
        {
            DashBoard_DGV.DataSource = DashBoardDAO.instance.GetDashBoardByType(ProductSeach_TBX.Text);
        }

        public void GetDashBoardByWeight()
        {
            DashBoard_DGV.DataSource = DashBoardDAO.instance.GetDashBoardByWeight(ProductSeach_TBX.Text);
        }

        public void GetDashBoardByWaranty()
        {
            DateTime date;
            DateTime.TryParse(ProductSeach_TBX.Text, out date);
            DashBoard_DGV.DataSource = DashBoardDAO.instance.GetDashBoardByWaranty(date);
        }

        private void Seasch_BTN_Click(object sender, EventArgs e)
        {
            if(TypeSeach_CBB.Text=="Khối lượng")
            {
                GetDashBoardByWeight();
            }   
            else if(TypeSeach_CBB.Text=="Loại")
            {
                GetDashBoardByType();
            }    
            else
            {
                GetDashBoardByWaranty();
            }                
        }

        private void Add_BTN_Click(object sender, EventArgs e)
        {

        }

        private void Delete_BTN_Click(object sender, EventArgs e)
        {

        }

        private void Edit_BTN_Click(object sender, EventArgs e)
        {

        }
    }
}
