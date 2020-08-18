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
        string masv = null,lop=null;
        int SoKhuonMat = 12;
        string path = null;
        string[] files = null;
        Mat frame = new Mat();
        private Image<Bgr, Byte> currentFrame = null;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        private bool addface = false;
        List<string> picture = new List<string>();
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

        private void QLyKhuonMat_Load(object sender, EventArgs e)
        {
            path = Directory.GetCurrentDirectory() + @"\TrainedImages";
            files = Directory.GetFiles(path, "*.bmp", SearchOption.AllDirectories);

        }

        private void btnBatCam_Click(object sender, EventArgs e)
        {
           
        }
        
        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Bitmap[] bm = new Bitmap[100];
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvDS.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dgvDS.CurrentRow.Selected = true;
                masv = dgvDS.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                lop = dgvDS.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                foreach (var file in files)
                {
                    string mssv = file.Split('\\').Last().Split('_')[0];
                    string lop = file.Split('\\').Last().Split('_')[1];
                    for (int i = 1; i <= SoKhuonMat; i++)
                    {
                        if (masv == mssv)
                        {
                            string[] fileHinh = Directory.GetFiles(path, masv + "_" + lop + "_" + i + "*.bmp", SearchOption.AllDirectories);
                            foreach(var fileHinhs in fileHinh)
                            {
                                bm[i] = new Bitmap(fileHinhs);
                            }
                            
                           
                        }

                    }
                    pic1.Image = bm[1];
                    pic2.Image = bm[2];
                    pic3.Image = bm[3];
                    pic4.Image = bm[4];
                    pic5.Image = bm[5];
                    pic6.Image = bm[6];
                    pic7.Image = bm[7];
                    pic8.Image = bm[8];
                    pic9.Image = bm[9];
                    pic10.Image = bm[10];
                    pic11.Image = bm[11];
                    pic12.Image = bm[12];
                }
            }
                
        }
    }
}
