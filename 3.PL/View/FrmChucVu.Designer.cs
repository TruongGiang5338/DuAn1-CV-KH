namespace _3.PL.View
{
    partial class FrmChucVu
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
            this.gbx_ChucVu = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgrid_ChucVu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.rbtn_NghiViec = new System.Windows.Forms.RadioButton();
            this.rbtn_LamViec = new System.Windows.Forms.RadioButton();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.gbx_ChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_ChucVu
            // 
            this.gbx_ChucVu.Controls.Add(this.label2);
            this.gbx_ChucVu.Controls.Add(this.btn_TimKiem);
            this.gbx_ChucVu.Controls.Add(this.label1);
            this.gbx_ChucVu.Controls.Add(this.txt_TimKiem);
            this.gbx_ChucVu.Controls.Add(this.tb_ten);
            this.gbx_ChucVu.Controls.Add(this.tb_ma);
            this.gbx_ChucVu.Controls.Add(this.lbl_TimKiem);
            this.gbx_ChucVu.Controls.Add(this.rbtn_NghiViec);
            this.gbx_ChucVu.Controls.Add(this.btn_Xoa);
            this.gbx_ChucVu.Controls.Add(this.rbtn_LamViec);
            this.gbx_ChucVu.Controls.Add(this.btn_Sua);
            this.gbx_ChucVu.Controls.Add(this.lbl_TrangThai);
            this.gbx_ChucVu.Controls.Add(this.btn_Them);
            this.gbx_ChucVu.Controls.Add(this.dgrid_ChucVu);
            this.gbx_ChucVu.Location = new System.Drawing.Point(59, 43);
            this.gbx_ChucVu.Name = "gbx_ChucVu";
            this.gbx_ChucVu.Size = new System.Drawing.Size(751, 550);
            this.gbx_ChucVu.TabIndex = 0;
            this.gbx_ChucVu.TabStop = false;
            this.gbx_ChucVu.Text = "ChucVu";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(370, 340);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(94, 29);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(226, 337);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(125, 27);
            this.txt_TimKiem.TabIndex = 5;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(91, 340);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(130, 20);
            this.lbl_TimKiem.TabIndex = 4;
            this.lbl_TimKiem.Text = "Tìm kiếm theo ID :";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(498, 379);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(145, 29);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(291, 379);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(145, 29);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sua";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(75, 379);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(145, 29);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgrid_ChucVu
            // 
            this.dgrid_ChucVu.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgrid_ChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChucVu.Location = new System.Drawing.Point(24, 26);
            this.dgrid_ChucVu.Name = "dgrid_ChucVu";
            this.dgrid_ChucVu.RowHeadersWidth = 51;
            this.dgrid_ChucVu.RowTemplate.Height = 29;
            this.dgrid_ChucVu.Size = new System.Drawing.Size(696, 285);
            this.dgrid_ChucVu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã";
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(350, 439);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(114, 27);
            this.tb_ten.TabIndex = 18;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(141, 439);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(114, 27);
            this.tb_ma.TabIndex = 17;
            // 
            // rbtn_NghiViec
            // 
            this.rbtn_NghiViec.AutoSize = true;
            this.rbtn_NghiViec.Location = new System.Drawing.Point(272, 495);
            this.rbtn_NghiViec.Name = "rbtn_NghiViec";
            this.rbtn_NghiViec.Size = new System.Drawing.Size(92, 24);
            this.rbtn_NghiViec.TabIndex = 16;
            this.rbtn_NghiViec.TabStop = true;
            this.rbtn_NghiViec.Text = "Nghỉ việc";
            this.rbtn_NghiViec.UseVisualStyleBackColor = true;
            // 
            // rbtn_LamViec
            // 
            this.rbtn_LamViec.AutoSize = true;
            this.rbtn_LamViec.Location = new System.Drawing.Point(160, 495);
            this.rbtn_LamViec.Name = "rbtn_LamViec";
            this.rbtn_LamViec.Size = new System.Drawing.Size(88, 24);
            this.rbtn_LamViec.TabIndex = 15;
            this.rbtn_LamViec.TabStop = true;
            this.rbtn_LamViec.Text = "Làm việc";
            this.rbtn_LamViec.UseVisualStyleBackColor = true;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Location = new System.Drawing.Point(70, 498);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(81, 20);
            this.lbl_TrangThai.TabIndex = 14;
            this.lbl_TrangThai.Text = "Trạng Thái:";
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 635);
            this.Controls.Add(this.gbx_ChucVu);
            this.Name = "FrmChucVu";
            this.Text = "FrmChucVu";
            this.gbx_ChucVu.ResumeLayout(false);
            this.gbx_ChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_ChucVu;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgrid_ChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.RadioButton rbtn_NghiViec;
        private System.Windows.Forms.RadioButton rbtn_LamViec;
        private System.Windows.Forms.Label lbl_TrangThai;
    }
}