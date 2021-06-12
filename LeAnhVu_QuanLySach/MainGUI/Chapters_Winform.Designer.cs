namespace MainGUI
{
    partial class Chapters_Winform
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
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtPhan = new System.Windows.Forms.TextBox();
            this.lblPhan = new System.Windows.Forms.Label();
            this.rtbMucTieuChuong = new System.Windows.Forms.RichTextBox();
            this.lblMucTieuChuong = new System.Windows.Forms.Label();
            this.txtTenChuong = new System.Windows.Forms.TextBox();
            this.lblTenChuong = new System.Windows.Forms.Label();
            this.txtSoThuTuChuong = new System.Windows.Forms.TextBox();
            this.lblSoThuTuChuong = new System.Windows.Forms.Label();
            this.lblChapterInformation = new System.Windows.Forms.Label();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.Location = new System.Drawing.Point(572, 562);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(100, 37);
            this.btnQuayVe.TabIndex = 26;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(408, 562);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 37);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(95, 409);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(53, 13);
            this.lblNoiDung.TabIndex = 23;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // txtPhan
            // 
            this.txtPhan.Location = new System.Drawing.Point(205, 363);
            this.txtPhan.Name = "txtPhan";
            this.txtPhan.Size = new System.Drawing.Size(467, 20);
            this.txtPhan.TabIndex = 22;
            // 
            // lblPhan
            // 
            this.lblPhan.AutoSize = true;
            this.lblPhan.Location = new System.Drawing.Point(95, 363);
            this.lblPhan.Name = "lblPhan";
            this.lblPhan.Size = new System.Drawing.Size(35, 13);
            this.lblPhan.TabIndex = 21;
            this.lblPhan.Text = "Phần:";
            // 
            // rtbMucTieuChuong
            // 
            this.rtbMucTieuChuong.Location = new System.Drawing.Point(205, 220);
            this.rtbMucTieuChuong.Name = "rtbMucTieuChuong";
            this.rtbMucTieuChuong.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rtbMucTieuChuong.Size = new System.Drawing.Size(467, 114);
            this.rtbMucTieuChuong.TabIndex = 20;
            this.rtbMucTieuChuong.Text = "";
            // 
            // lblMucTieuChuong
            // 
            this.lblMucTieuChuong.AutoSize = true;
            this.lblMucTieuChuong.Location = new System.Drawing.Point(95, 217);
            this.lblMucTieuChuong.Name = "lblMucTieuChuong";
            this.lblMucTieuChuong.Size = new System.Drawing.Size(90, 13);
            this.lblMucTieuChuong.TabIndex = 19;
            this.lblMucTieuChuong.Text = "Mục tiêu chương:";
            // 
            // txtTenChuong
            // 
            this.txtTenChuong.Location = new System.Drawing.Point(205, 168);
            this.txtTenChuong.Name = "txtTenChuong";
            this.txtTenChuong.Size = new System.Drawing.Size(467, 20);
            this.txtTenChuong.TabIndex = 18;
            // 
            // lblTenChuong
            // 
            this.lblTenChuong.AutoSize = true;
            this.lblTenChuong.Location = new System.Drawing.Point(95, 168);
            this.lblTenChuong.Name = "lblTenChuong";
            this.lblTenChuong.Size = new System.Drawing.Size(68, 13);
            this.lblTenChuong.TabIndex = 17;
            this.lblTenChuong.Text = "Tên chương:";
            // 
            // txtSoThuTuChuong
            // 
            this.txtSoThuTuChuong.Location = new System.Drawing.Point(205, 124);
            this.txtSoThuTuChuong.Name = "txtSoThuTuChuong";
            this.txtSoThuTuChuong.Size = new System.Drawing.Size(259, 20);
            this.txtSoThuTuChuong.TabIndex = 16;
            // 
            // lblSoThuTuChuong
            // 
            this.lblSoThuTuChuong.AutoSize = true;
            this.lblSoThuTuChuong.Location = new System.Drawing.Point(95, 124);
            this.lblSoThuTuChuong.Name = "lblSoThuTuChuong";
            this.lblSoThuTuChuong.Size = new System.Drawing.Size(92, 13);
            this.lblSoThuTuChuong.TabIndex = 15;
            this.lblSoThuTuChuong.Text = "Số thứ tự chương:";
            // 
            // lblChapterInformation
            // 
            this.lblChapterInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChapterInformation.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblChapterInformation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblChapterInformation.Location = new System.Drawing.Point(23, 19);
            this.lblChapterInformation.Name = "lblChapterInformation";
            this.lblChapterInformation.Size = new System.Drawing.Size(722, 36);
            this.lblChapterInformation.TabIndex = 14;
            this.lblChapterInformation.Text = "CHAPTER INFORMATION";
            this.lblChapterInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Location = new System.Drawing.Point(205, 409);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rtbNoiDung.Size = new System.Drawing.Size(467, 114);
            this.rtbNoiDung.TabIndex = 27;
            this.rtbNoiDung.Text = "";
            // 
            // Chapters_Winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 611);
            this.Controls.Add(this.rtbNoiDung);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.txtPhan);
            this.Controls.Add(this.lblPhan);
            this.Controls.Add(this.rtbMucTieuChuong);
            this.Controls.Add(this.lblMucTieuChuong);
            this.Controls.Add(this.txtTenChuong);
            this.Controls.Add(this.lblTenChuong);
            this.Controls.Add(this.txtSoThuTuChuong);
            this.Controls.Add(this.lblSoThuTuChuong);
            this.Controls.Add(this.lblChapterInformation);
            this.Name = "Chapters_Winform";
            this.Text = "Chapters_Winform";
            this.Load += new System.EventHandler(this.Chapters_Winform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtPhan;
        private System.Windows.Forms.Label lblPhan;
        private System.Windows.Forms.RichTextBox rtbMucTieuChuong;
        private System.Windows.Forms.Label lblMucTieuChuong;
        private System.Windows.Forms.TextBox txtTenChuong;
        private System.Windows.Forms.Label lblTenChuong;
        private System.Windows.Forms.TextBox txtSoThuTuChuong;
        private System.Windows.Forms.Label lblSoThuTuChuong;
        private System.Windows.Forms.Label lblChapterInformation;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
    }
}