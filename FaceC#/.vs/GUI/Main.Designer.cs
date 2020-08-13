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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMi = new System.Windows.Forms.Button();
            this.panelDeskop = new System.Windows.Forms.Panel();
            this.btnCloseChild = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnDSSV = new System.Windows.Forms.Button();
            this.btnDiemDanh = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnLop);
            this.panelMenu.Controls.Add(this.btnDSSV);
            this.panelMenu.Controls.Add(this.btnDiemDanh);
            this.panelMenu.Controls.Add(this.panelName);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(365, 821);
            this.panelMenu.TabIndex = 0;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelName.Controls.Add(this.lblDesign);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(365, 111);
            this.panelName.TabIndex = 2;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.btnCloseChild);
            this.panelTitle.Controls.Add(this.btnMi);
            this.panelTitle.Controls.Add(this.btnMax);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.lblTittle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(365, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(998, 111);
            this.panelTitle.TabIndex = 2;
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(368, 46);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(288, 26);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "ỨNG DỤNG ĐIỂM DANH";
            // 
            // lblDesign
            // 
            this.lblDesign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesign.AutoSize = true;
            this.lblDesign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.ForeColor = System.Drawing.Color.White;
            this.lblDesign.Location = new System.Drawing.Point(88, 46);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(163, 22);
            this.lblDesign.TabIndex = 1;
            this.lblDesign.Text = "Thiết kế bởi TQ&VC";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(968, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(932, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 35);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "O";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMi
            // 
            this.btnMi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMi.FlatAppearance.BorderSize = 0;
            this.btnMi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMi.ForeColor = System.Drawing.Color.White;
            this.btnMi.Location = new System.Drawing.Point(896, 0);
            this.btnMi.Name = "btnMi";
            this.btnMi.Size = new System.Drawing.Size(30, 35);
            this.btnMi.TabIndex = 3;
            this.btnMi.Text = "O";
            this.btnMi.UseVisualStyleBackColor = true;
            this.btnMi.Click += new System.EventHandler(this.btnMi_Click);
            // 
            // panelDeskop
            // 
            this.panelDeskop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskop.Location = new System.Drawing.Point(365, 111);
            this.panelDeskop.Name = "panelDeskop";
            this.panelDeskop.Size = new System.Drawing.Size(998, 710);
            this.panelDeskop.TabIndex = 3;
            // 
            // btnCloseChild
            // 
            this.btnCloseChild.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChild.FlatAppearance.BorderSize = 0;
            this.btnCloseChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChild.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChild.ForeColor = System.Drawing.Color.White;
            this.btnCloseChild.Image = global::GUI.Properties.Resources.icons8_close_window_50;
            this.btnCloseChild.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChild.Name = "btnCloseChild";
            this.btnCloseChild.Size = new System.Drawing.Size(96, 111);
            this.btnCloseChild.TabIndex = 4;
            this.btnCloseChild.UseVisualStyleBackColor = true;
            this.btnCloseChild.Click += new System.EventHandler(this.btnCloseChild_Click);
            // 
            // btnLop
            // 
            this.btnLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLop.FlatAppearance.BorderSize = 0;
            this.btnLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLop.Image = global::GUI.Properties.Resources.icons8_class_100;
            this.btnLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLop.Location = new System.Drawing.Point(0, 381);
            this.btnLop.Name = "btnLop";
            this.btnLop.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLop.Size = new System.Drawing.Size(365, 135);
            this.btnLop.TabIndex = 5;
            this.btnLop.Text = " Quản Lý Lớp";
            this.btnLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnDSSV
            // 
            this.btnDSSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDSSV.FlatAppearance.BorderSize = 0;
            this.btnDSSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSSV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDSSV.Image = global::GUI.Properties.Resources.icons8_student_registration_100;
            this.btnDSSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSSV.Location = new System.Drawing.Point(0, 246);
            this.btnDSSV.Name = "btnDSSV";
            this.btnDSSV.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDSSV.Size = new System.Drawing.Size(365, 135);
            this.btnDSSV.TabIndex = 4;
            this.btnDSSV.Text = " Danh Sách Sinh Viên";
            this.btnDSSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSSV.UseVisualStyleBackColor = true;
            this.btnDSSV.Click += new System.EventHandler(this.btnDSSV_Click);
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemDanh.FlatAppearance.BorderSize = 0;
            this.btnDiemDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemDanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemDanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDiemDanh.Image = global::GUI.Properties.Resources.icons8_face_id_100__1_;
            this.btnDiemDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemDanh.Location = new System.Drawing.Point(0, 111);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDiemDanh.Size = new System.Drawing.Size(365, 135);
            this.btnDiemDanh.TabIndex = 3;
            this.btnDiemDanh.Text = " Điểm Danh";
            this.btnDiemDanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemDanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiemDanh.UseVisualStyleBackColor = true;
            this.btnDiemDanh.Click += new System.EventHandler(this.btnDiemDanh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 821);
            this.Controls.Add(this.panelDeskop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMi;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Panel panelDeskop;
        private System.Windows.Forms.Button btnCloseChild;
    }
}

