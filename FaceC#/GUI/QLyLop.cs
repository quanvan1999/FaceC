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
    public partial class QLyLop : Form
    {
        int dem = 0, sosinhvien = 0;
        System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");
        public QLyLop()
        {
            InitializeComponent();
        }
       

        private void btnThem_Click(object sender, EventArgs e)
        {
            LopHocDTO lh = new LopHocDTO();
            lh.Ma_Lop = txtLop.Text.ToUpper();
            if (dem == 1)
            {
                txtLop.Enabled = true;
                txtLop.Text = "";
                cbTrangThai.Checked = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                dem = 0;
            }
            else
            {
                if (cbTrangThai.Checked)
                {
                    lh.TrangThai = true;
                }
                else
                {
                    lh.TrangThai = false;
                }
                if (txtLop.Text == "" || r.IsMatch(txtLop.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mã lớp hoặc mã lớp không hợp lệ");
                }
                else if (LopHocBUS.ThemLop(lh))
                {
                    MessageBox.Show("Thêm Lớp Mới Thành Công");
                    LoadDSLOP();
                }
                else
                {
                    MessageBox.Show("Thêm Lớp Mới Thất Bại");
                    txtLop.Text = "";
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LopHocDTO lh = new LopHocDTO();
            lh.Ma_Lop = txtLop.Text;
            if (cbTrangThai.Checked)
            {
                lh.TrangThai = true;
            }
            else
            {
                lh.TrangThai = false;
            }
            if (LopHocBUS.CapNhatLopHoc(lh))
            {
                MessageBox.Show("Cập Nhật Trạng Thái Thành Công");
                LoadDSLOP();
            }
            else
            {
                MessageBox.Show("Cập Nhật Trạng Thái Thất Bại");
                txtLop.Text = "";
            }
        }

        private void QLyLop_Load(object sender, EventArgs e)
        {
            LoadDSLOP();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvDSLOP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvDSLOP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dgvDSLOP.CurrentRow.Selected = true;
                txtLop.Text = dgvDSLOP.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                sosinhvien = Convert.ToInt32(dgvDSLOP.Rows[e.RowIndex].Cells[2].FormattedValue);
                cbTrangThai.Checked = Convert.ToBoolean(dgvDSLOP.Rows[e.RowIndex].Cells[1].FormattedValue);

            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtLop.Enabled = false;
            dem = 1;
        }

        private void txtLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ko cho phep nhap dau .
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
            }
            else if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {

            }

            else
            {
                e.Handled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LopHocDTO lh = new LopHocDTO();
            lh.Ma_Lop = txtLop.Text;
            lh.SoSinhVien = sosinhvien;
            if (LopHocBUS.XoaLopHoc(lh))
            {
                MessageBox.Show("Xóa Lớp Thành Công");
                LoadDSLOP();
            }
            else
            {
                MessageBox.Show("Còn Sinh Viên Trong Lớp " + lh.Ma_Lop);
            }
        }

        public void LoadDSLOP()
        {
            dgvDSLOP.DataSource = LopHocBUS.LayDSLop();
        }

    }
}
