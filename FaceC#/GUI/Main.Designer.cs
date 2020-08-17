namespace GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelName = new System.Windows.Forms.Panel();
            this.lblDesign = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCloseChild = new System.Windows.Forms.Button();
            this.btnMi = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.panelDeskop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHinh = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnDSSV = new System.Windows.Forms.Button();
            this.btnDiemDanh = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDeskop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnThoat);
            this.panelMenu.Controls.Add(this.btnHinh);
            this.panelMenu.Controls.Add(this.btnLop);
            this.panelMenu.Controls.Add(this.btnDSSV);
            this.panelMenu.Controls.Add(this.btnDiemDanh);
            this.panelMenu.Controls.Add(this.panelName);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(416, 865);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.panelName.Controls.Add(this.lblDesign);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(416, 102);
            this.panelName.TabIndex = 2;
            this.panelName.Paint += new System.Windows.Forms.PaintEventHandler(this.panelName_Paint);
            // 
            // lblDesign
            // 
            this.lblDesign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesign.AutoSize = true;
            this.lblDesign.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.ForeColor = System.Drawing.Color.White;
            this.lblDesign.Location = new System.Drawing.Point(137, 30);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(119, 37);
            this.lblDesign.TabIndex = 1;
            this.lblDesign.Text = "MENU";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.panelTitle.Controls.Add(this.btnCloseChild);
            this.panelTitle.Controls.Add(this.btnMi);
            this.panelTitle.Controls.Add(this.lblTittle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(416, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1043, 102);
            this.panelTitle.TabIndex = 2;
            // 
            // btnCloseChild
            // 
            this.btnCloseChild.FlatAppearance.BorderSize = 0;
            this.btnCloseChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChild.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChild.ForeColor = System.Drawing.Color.White;
            this.btnCloseChild.Location = new System.Drawing.Point(964, 33);
            this.btnCloseChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseChild.Name = "btnCloseChild";
            this.btnCloseChild.Size = new System.Drawing.Size(51, 38);
            this.btnCloseChild.TabIndex = 4;
            this.btnCloseChild.Text = "X";
            this.btnCloseChild.UseVisualStyleBackColor = true;
            this.btnCloseChild.Click += new System.EventHandler(this.btnCloseChild_Click);
            // 
            // btnMi
            // 
            this.btnMi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMi.FlatAppearance.BorderSize = 0;
            this.btnMi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMi.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMi.ForeColor = System.Drawing.Color.White;
            this.btnMi.Location = new System.Drawing.Point(908, 33);
            this.btnMi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMi.Name = "btnMi";
            this.btnMi.Size = new System.Drawing.Size(51, 38);
            this.btnMi.TabIndex = 3;
            this.btnMi.Text = "-";
            this.btnMi.UseVisualStyleBackColor = true;
            this.btnMi.Click += new System.EventHandler(this.btnMi_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(316, 31);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(401, 37);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "ỨNG DỤNG ĐIỂM DANH";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelDeskop
            // 
            this.panelDeskop.BackColor = System.Drawing.Color.White;
            this.panelDeskop.Controls.Add(this.pictureBox1);
            this.panelDeskop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskop.Location = new System.Drawing.Point(416, 102);
            this.panelDeskop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDeskop.Name = "panelDeskop";
            this.panelDeskop.Size = new System.Drawing.Size(1043, 763);
            this.panelDeskop.TabIndex = 3;
            this.panelDeskop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDeskop_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo33;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1043, 763);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::GUI.Properties.Resources.icons8_open_door_100;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(0, 642);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnThoat.Size = new System.Drawing.Size(416, 135);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnHinh
            // 
            this.btnHinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHinh.FlatAppearance.BorderSize = 0;
            this.btnHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinh.ForeColor = System.Drawing.Color.Black;
            this.btnHinh.Image = global::GUI.Properties.Resources.icons8_picture_in_picture_100;
            this.btnHinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHinh.Location = new System.Drawing.Point(0, 507);
            this.btnHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHinh.Name = "btnHinh";
            this.btnHinh.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHinh.Size = new System.Drawing.Size(416, 135);
            this.btnHinh.TabIndex = 6;
            this.btnHinh.Text = "Quản Lý Hình Ảnh";
            this.btnHinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHinh.UseVisualStyleBackColor = true;
            this.btnHinh.Click += new System.EventHandler(this.btnHinh_Click);
            this.btnHinh.Paint += new System.Windows.Forms.PaintEventHandler(this.btnThoat_Paint);
            // 
            // btnLop
            // 
            this.btnLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLop.FlatAppearance.BorderSize = 0;
            this.btnLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.ForeColor = System.Drawing.Color.Black;
            this.btnLop.Image = global::GUI.Properties.Resources.icons8_class_100;
            this.btnLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLop.Location = new System.Drawing.Point(0, 372);
            this.btnLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLop.Name = "btnLop";
            this.btnLop.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLop.Size = new System.Drawing.Size(416, 135);
            this.btnLop.TabIndex = 5;
            this.btnLop.Text = " Quản Lý Lớp Học";
            this.btnLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            this.btnLop.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLop_Paint);
            // 
            // btnDSSV
            // 
            this.btnDSSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDSSV.FlatAppearance.BorderSize = 0;
            this.btnDSSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSSV.ForeColor = System.Drawing.Color.Black;
            this.btnDSSV.Image = global::GUI.Properties.Resources.icons8_student_registration_100;
            this.btnDSSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSSV.Location = new System.Drawing.Point(0, 237);
            this.btnDSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDSSV.Name = "btnDSSV";
            this.btnDSSV.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDSSV.Size = new System.Drawing.Size(416, 135);
            this.btnDSSV.TabIndex = 4;
            this.btnDSSV.Text = "Quản Lý Sinh Viên";
            this.btnDSSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSSV.UseVisualStyleBackColor = true;
            this.btnDSSV.Click += new System.EventHandler(this.btnDSSV_Click);
            this.btnDSSV.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDSSV_Paint);
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemDanh.FlatAppearance.BorderSize = 0;
            this.btnDiemDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemDanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemDanh.ForeColor = System.Drawing.Color.Black;
            this.btnDiemDanh.Image = global::GUI.Properties.Resources.icons8_face_id_100__1_;
            this.btnDiemDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemDanh.Location = new System.Drawing.Point(0, 102);
            this.btnDiemDanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDiemDanh.Size = new System.Drawing.Size(416, 135);
            this.btnDiemDanh.TabIndex = 3;
            this.btnDiemDanh.Text = " Điểm Danh";
            this.btnDiemDanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemDanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiemDanh.UseVisualStyleBackColor = true;
            this.btnDiemDanh.Click += new System.EventHandler(this.btnDiemDanh_Click);
            this.btnDiemDanh.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDiemDanh_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 865);
            this.Controls.Add(this.panelDeskop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDeskop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnDSSV;
        private System.Windows.Forms.Button btnDiemDanh;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel panelDeskop;
        private System.Windows.Forms.Button btnCloseChild;
        private System.Windows.Forms.Button btnMi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHinh;
        private System.Windows.Forms.Button btnThoat;
    }
}

