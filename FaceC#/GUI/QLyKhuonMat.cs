using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        int chonHinh = 0;
        Mat frame = new Mat();
        private Image<Bgr, Byte> currentFrame = null;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        private bool addface = false;
        List<string> pictureList = new List<string>();


        public QLyKhuonMat()
        {
            InitializeComponent();
            ChonLop();
            LoadDSSV();
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
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                resualtFace.Resize(100, 100, Inter.Cubic).Save(path + @"\" + masv + "_" + lop + "_" + chonHinh + ".bmp");
                                //if(chonHinh!=0)
                                //{
                                //    Bitmap hinhAnh = new Bitmap(resualtFace.Bitmap);
                                //    switch (chonHinh)
                                //    {
                                //        case 1:
                                           
                                //            pic1.Image = hinhAnh;
                                //            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                                //            break;
                                //        case 2:
                                //            pic2.Image = hinhAnh;

                                //            pic2.SizeMode = PictureBoxSizeMode.StretchImage;break;
                                //        default:
                                //            pic3.Image = hinhAnh;

                                //            pic3.SizeMode = PictureBoxSizeMode.StretchImage;break;
                                //    }
                                //}

                            }));

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
            Debug.WriteLine(chonHinh);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            chonHinh = 2;
            Debug.WriteLine(chonHinh);

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            addface = true;
            
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvDS.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dgvDS.CurrentRow.Selected = true;
                masv = dgvDS.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                ten = dgvDS.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                lop = dgvDS.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
               

                    

                    //Debug.WriteLine(pictureList[i] + " test " +pictureList.Count);
                    
                    //pic1.Image = Image.FromFile(pictureList[1]);
                    //pic2.Image = Image.FromFile(pictureList[2]);
                    //pic3.Image = Image.FromFile(pictureList[3]);
                    //pic4.Image = Image.FromFile(pictureList[4]);
                    //pic5.Image = Image.FromFile(pictureList[5]);
                    //pic6.Image = Image.FromFile(pictureList[6]);
                    //pic7.Image = Image.FromFile(pictureList[7]);
                    //pic8.Image = Image.FromFile(pictureList[8]);
                    //pic9.Image = Image.FromFile(pictureList[9]);
                    //pic10.Image = Image.FromFile(pictureList[10]);
                    //pic11.Image = Image.FromFile(pictureList[11]);
                    //pic12.Image = Image.FromFile(pictureList[12]);
                

            }


           

        }
    }
}
