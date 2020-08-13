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
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Main()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChild.Visible = false;
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
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelName.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
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
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            lblTittle.Text = "DANH SÁCH SINH VIÊN";
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLyLop(), sender);
            lblTittle.Text = "DANH SÁCH LỚP";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
            
        }
        private void Reset()
        {
            DisableButton();
            lblTittle.Text = "ỨNG DỤNG ĐIỂM DANH KHUÔN MẶT";
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelName.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChild.Visible = false;
        }

    }
}
