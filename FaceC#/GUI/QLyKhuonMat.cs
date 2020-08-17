using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace GUI
{
    public partial class QLyKhuonMat : Form
    {
        public QLyKhuonMat()
        {
            InitializeComponent();
            LoadDSSV();
        }
        private void LoadDSSV()
        {
            SinhVienDTO sv = new SinhVienDTO();
            dgvDS.DataSource = SinhVienBUS.LayDSTheoHinh(sv);
        }
    }
}
