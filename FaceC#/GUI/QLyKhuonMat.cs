using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace GUI
{
    public partial class QLyKhuonMat : Form
    {
        private Capture quayVideo = null;
        string masv = null,lop=null,ten=null;
        int SoKhuonMat = 12;
        //string path = null;
        //string[] files = null;
        int chonHinh = 0,dem=1;
        Mat frame = new Mat();
        private Image<Bgr, Byte> currentFrame = null;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        private bool addface = false;
        List<string> pictureList = new List<string>();
        Bitmap bm = null;

        public QLyKhuonMat()
        {
            InitializeComponent();
            ChonLop();
            LoadDSSV();
            btnCapNhat.Enabled = false;
        }
        private void LoadDSSV()
        {
            SinhVienDTO sv = new SinhVienDTO();
            dgvDS.DataSource = SinhVienBUS.LayDSTheoHinh(sv);
        }

        private void QLyKhuonMat_Load(object sender, EventArgs e)
        {
            

        }
        protected void ChonLop()
        {
            SinhVienDTO sv = new SinhVienDTO();
            LopHocDTO lh = new LopHocDTO();
            cboTim.DataSource = SinhVienBUS.LayDSLopHoc(sv);
            cboTim.DisplayMember = "Ma_Lop";
            cboTim.ValueMember = "Ma_Lop";

            

        }
        private void btnBatCam_Click(object sender, EventArgs e)
        {
            if (quayVideo == null)
            {
                quayVideo = new Capture();
                quayVideo.ImageGrabbed += StartFrame;// tao ham lam viec voi camera
                quayVideo.FlipHorizontal = !quayVideo.FlipHorizontal;
                quayVideo.Start();
                btnCapNhat.Enabled = true;

            }
            else
            {
                quayVideo.Dispose();
            }
        }

        private void StartFrame(object sender, EventArgs e)
        {
            quayVideo.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(320, 240, Inter.Cubic);

            Mat grayImage = new Mat();
            CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(grayImage, grayImage);//cân bằng độ sáng
            System.Drawing.Rectangle[] faces = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 10, new Size(20, 20));


            if (faces.Length > 0)
            {
                foreach (var face in faces)
                {
                    // vẽ hình vuông vào mặt
                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                    //add khuôn mặt : resualtFace
                    Image<Gray, Byte> resualtFace = currentFrame.Convert<Gray, Byte>();
                    resualtFace.ROI = face;
                    //picBox2.SizeMode = PictureBoxSizeMode.StretchImage;// Chỉnh size cho imagebox;
                    //picBox2.Image = resualtFace.Bitmap;
                    if (addface)
                    {


                        string path = Directory.GetCurrentDirectory() + @"\TrainedImages";//Tạo thư mục Trained trong debug
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);

                        Task.Factory.StartNew(() =>
                        {


                            //var i = Image.FromFile(path + @"\" + masv + "_" + lop + "_" + chonHinh + ".bmp");
                            //bm = new Bitmap(i);
                          
                                string[] files = Directory.GetFiles(path, masv + "_" + lop + "_" + chonHinh + ".bmp", SearchOption.AllDirectories);
                                foreach (var file in files)
                                {
                                    //File.Delete(file);
                                    resualtFace.Resize(100, 100, Inter.Cubic).Save(path + @"\" + masv + "_" + lop + "_" + chonHinh + ".bmp");
                                    bm = new Bitmap(resualtFace.Bitmap);
                            
                                }
                                
                            switch (chonHinh)
                                {
                                    case 1:
                                        
                                        pic1.Image = bm;
                                        pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case 2:
                                       
                                        pic2.Image = bm;
                                        pic2.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case 3:
                                        pic3.Image = bm;
                                        pic3.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case 4:
                                        pic4.Image = bm;
                                        pic4.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case 5:
                                        pic5.Image = bm;
                                        pic5.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case 6:
                                        pic6.Image = bm;
                                        pic6.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case 7:
                                        pic7.Image = bm;
                                        pic7.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case 8:
                                        pic8.Image = bm;
                                        pic8.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case 9:
                                        pic9.Image = bm;
                                        pic9.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case 10:
                                        pic10.Image = bm;
                                        pic10.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case 11:
                                        pic11.Image = bm;
                                        pic11.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;

                                    case 12:
                                        pic12.Image = bm;
                                        pic12.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                }
                        });
                    }

                    addface = false;
                }
            }
            picCamera.Image = currentFrame.Bitmap;
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // ko cho phep nhap dau .
            else if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') == -1))
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.Ma_SV = txtTim.Text.ToString();
            sv.Ma_Lop = cboTim.Text;
            if (txtTim.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm");
            }
            else
            {
                if (SinhVienBUS.TimKiemMaSV(sv.Ma_SV) != null)
                {
                    dgvDS.DataSource = SinhVienBUS.TimKiemMaSVCoHinh(sv.Ma_SV);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại");
                }
            }
        }

        private void cboTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.Ma_Lop = cboTim.Text.ToString();
            dgvDS.DataSource = SinhVienBUS.LayDSSVLopCoHinh(sv.Ma_Lop);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            chonHinh = 1;

            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic1.Image = null;
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
              
                Debug.WriteLine(chonHinh);

                pic2.Enabled = false;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = false;
                pic10.Enabled = false;
                pic11.Enabled = false;
                pic12.Enabled = false;
            }

        }

        private void pic2_Click(object sender, EventArgs e)
        {
            chonHinh = 2;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic2.Image = null;

                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = false;
                pic10.Enabled = false;
                pic11.Enabled = false;
                pic12.Enabled = false;
            }
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            if (quayVideo != null)
            {
                quayVideo.Dispose();
                btnCapNhat.Enabled = false;
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            
            chonHinh = 3;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic3.Image = null;
                pic3.SizeMode = PictureBoxSizeMode.StretchImage;
                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = false;
                pic10.Enabled = false;
                pic11.Enabled = false;
                pic12.Enabled = false;
            }
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            chonHinh = 4;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic4.Image = null;
                pic4.SizeMode = PictureBoxSizeMode.StretchImage;
                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = false;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = false;
                pic10.Enabled = false;
                pic11.Enabled = false;
                pic12.Enabled = false;
            }
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            chonHinh = 5;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic5.Image = null;
                pic5.SizeMode = PictureBoxSizeMode.StretchImage;
                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = false;
                pic10.Enabled = false;
                pic11.Enabled = false;
                pic12.Enabled = false;
            }
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            chonHinh = 6;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic6.Image = null;
                pic6.SizeMode = PictureBoxSizeMode.StretchImage;
                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = false;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = false;
                pic10.Enabled = false;
                pic11.Enabled = false;
                pic12.Enabled = false;
            }
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            chonHinh = 7;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic7.Image = null;
                pic7.SizeMode = PictureBoxSizeMode.StretchImage;
                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = false;
                pic10.Enabled = false;
                pic11.Enabled = false;
                pic12.Enabled = false;
            }
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            chonHinh = 8;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic8.Image = null;
                pic8.SizeMode = PictureBoxSizeMode.StretchImage;
                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = false;
                pic9.Enabled = false;
                pic10.Enabled = false;
                pic11.Enabled = false;
                pic12.Enabled = false;
            }
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            chonHinh = 9;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic9.Image = null;
                pic9.SizeMode = PictureBoxSizeMode.StretchImage;
                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic10.Enabled = false;
                pic11.Enabled = false;
                pic12.Enabled = false;
            }
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            chonHinh = 10;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic10.Image = null;
                pic10.SizeMode = PictureBoxSizeMode.StretchImage;
                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = false;
                pic11.Enabled = false;
                pic12.Enabled = false;
            }
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            chonHinh = 11;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic11.Image = null;
                pic11.SizeMode = PictureBoxSizeMode.StretchImage;
                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = false;
                pic10.Enabled = false;
                pic12.Enabled = false;
            }
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            chonHinh = 12;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                pic12.Image = null;
                pic12.SizeMode = PictureBoxSizeMode.StretchImage;
                Debug.WriteLine(chonHinh);
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = false;
                pic10.Enabled = false;
                pic11.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {   
           addface = true;
            pic1.Enabled = true;
            pic2.Enabled = true;
            pic3.Enabled = true;
            pic4.Enabled = true;
            pic5.Enabled = true;
            pic6.Enabled = true;
            pic7.Enabled = true;
            pic8.Enabled = true;
            pic9.Enabled = true;
            pic10.Enabled = true;
            pic11.Enabled = true;
            pic12.Enabled = true;
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDS.ReadOnly = true;
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvDS.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dgvDS.CurrentRow.Selected = true;
                masv = dgvDS.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                lop = dgvDS.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

                for (int i = 1; i <= SoKhuonMat; i++)
                {
                    string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                    string[] files = Directory.GetFiles(path, masv + "_" + lop + "_" + i + ".bmp", SearchOption.AllDirectories);
                    foreach (var file in files)
                    {
                        pictureList.Add(file);
                    }
                }
                
                    pic1.Image = Image.FromFile(pictureList[0]);
                    pic2.Image = Image.FromFile(pictureList[1]);
                    pic3.Image = Image.FromFile(pictureList[2]);
                    pic4.Image = Image.FromFile(pictureList[3]);
                    pic5.Image = Image.FromFile(pictureList[4]);
                    pic6.Image = Image.FromFile(pictureList[5]);
                    pic7.Image = Image.FromFile(pictureList[6]);
                    pic8.Image = Image.FromFile(pictureList[7]);
                    pic9.Image = Image.FromFile(pictureList[8]);
                    pic10.Image = Image.FromFile(pictureList[9]);
                    pic11.Image = Image.FromFile(pictureList[10]);
                    pic12.Image = Image.FromFile(pictureList[11]);
                    pictureList.Clear();
                

                pic1.Enabled = true;
                pic2.Enabled = true;
                pic3.Enabled = true;
                pic4.Enabled = true;
                pic5.Enabled = true;
                pic6.Enabled = true;
                pic7.Enabled = true;
                pic8.Enabled = true;
                pic9.Enabled = true;
                pic10.Enabled = true;
                pic11.Enabled = true;
                pic12.Enabled = true;
            }

            


            //Debug.WriteLine(pictureList[i] + " test " +pictureList.Count);


        }
    }
}
