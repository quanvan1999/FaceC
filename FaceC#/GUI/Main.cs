using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        private Button currentButton;
      
        private Form activeForm;
        public Main()
        {
            InitializeComponent();
            btnCloseChild.Visible = true;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(4000);// đặt thời gian chạy xong
            t.Abort();
        }
        public void SplashStart()
        {

            Application.Run(new ManHinhKhoiDong());// gọi form Welcome 
        }
        
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCloseChild.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDeskop.Controls.Add(childForm);
            this.panelDeskop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new DiemDanh(), sender);
            lblTittle.Text = "ĐIỂM DANH";
            
        }

        private void btnDSSV_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new DSSV(), sender);
            lblTittle.Text = "QUẢN LÝ SINH VIÊN";
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLyLop(), sender);
            lblTittle.Text = "DANH SÁCH LỚP";
        }

       
        

       

        private void btnMi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            
        }
        private void Reset()
        {
            DisableButton();
            lblTittle.Text = "ỨNG DỤNG ĐIỂM DANH";  
            currentButton = null;
            btnCloseChild.Visible = true;
            activeForm = null;
            
        }

       
        //Border cho button
      
    

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,panelMenu.ClientRectangle,
                       Color.Black, 1, ButtonBorderStyle.None, // left
                       Color.Black, 1, ButtonBorderStyle.None, // top
                       Color.Black,2, ButtonBorderStyle.Solid, // right
                       Color.Black, 1, ButtonBorderStyle.None);// bottom
        }
      
        private void Main_Load(object sender, EventArgs e)
        {
            

        }

        private void panelDeskop_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btnThoat_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnHinh.ClientRectangle,
                       Color.Black, 1, ButtonBorderStyle.None, // left
                       Color.Black, 1, ButtonBorderStyle.None, // top
                       Color.Black, 2, ButtonBorderStyle.Solid, // right
                       Color.Black, 2, ButtonBorderStyle.Solid);// bottom
        }

        private void btnLop_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnLop.ClientRectangle,
                       Color.Black, 1, ButtonBorderStyle.None, // left
                       Color.Black, 1, ButtonBorderStyle.None, // top
                       Color.Black, 2, ButtonBorderStyle.Solid, // right
                       Color.Black, 2, ButtonBorderStyle.Solid);// bottom
        }

        private void btnDSSV_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnDSSV.ClientRectangle,
                       Color.Black, 1, ButtonBorderStyle.None, // left
                       Color.Black, 1, ButtonBorderStyle.None, // top
                       Color.Black, 2, ButtonBorderStyle.Solid, // right
                       Color.Black, 2, ButtonBorderStyle.Solid);// bottom
        }

        private void btnDiemDanh_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnDiemDanh.ClientRectangle,
                       Color.Black, 1, ButtonBorderStyle.None, // left
                       Color.Black, 1, ButtonBorderStyle.None, // top
                       Color.Black, 2, ButtonBorderStyle.Solid, // right
                       Color.Black, 2, ButtonBorderStyle.Solid);// bottom
        }

        private void panelName_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelName.ClientRectangle,
                      Color.Black, 1, ButtonBorderStyle.None, // left
                      Color.Black, 1, ButtonBorderStyle.None, // top
                      Color.Blue, 2, ButtonBorderStyle.None, // right
                      Color.Black, 1, ButtonBorderStyle.None);// bottom
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLyKhuonMat(), sender);
            lblTittle.Text = "QUẢN LÝ HÌNH ẢNH";
        }
    }
}
