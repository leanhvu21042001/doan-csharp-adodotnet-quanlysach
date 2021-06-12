namespace MainGUI
{
    partial class Ebooks_Winform
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
            this.lblBookInformations = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTuaDe = new System.Windows.Forms.TextBox();
            this.lblTuaDe = new System.Windows.Forms.Label();
            this.lblGioiThieu = new System.Windows.Forms.Label();
            this.rtbGioiThieu = new System.Windows.Forms.RichTextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookInformations
            // 
            this.lblBookInformations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookInformations.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblBookInformations.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBookInformations.Location = new System.Drawing.Point(4, 19);
            this.lblBookInformations.Name = "lblBookInformations";
            this.lblBookInformations.Size = new System.Drawing.Size(781, 36);
            this.lblBookInformations.TabIndex = 1;
            this.lblBookInformations.Text = "BOOK INFORMATION";
            this.lblBookInformations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(98, 114);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(57, 15);
            this.lblMaSach.TabIndex = 2;
            this.lblMaSach.Text = "Mã sách:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(208, 114);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(259, 21);
            this.txtMaSach.TabIndex = 3;
            // 
            // txtTuaDe
            // 
            this.txtTuaDe.Location = new System.Drawing.Point(208, 158);
            this.txtTuaDe.Name = "txtTuaDe";
            this.txtTuaDe.Size = new System.Drawing.Size(467, 21);
            this.txtTuaDe.TabIndex = 5;
            // 
            // lblTuaDe
            // 
            this.lblTuaDe.AutoSize = true;
            this.lblTuaDe.Location = new System.Drawing.Point(98, 158);
            this.lblTuaDe.Name = "lblTuaDe";
            this.lblTuaDe.Size = new System.Drawing.Size(48, 15);
            this.lblTuaDe.TabIndex = 4;
            this.lblTuaDe.Text = "Tựa đề:";
            // 
            // lblGioiThieu
            // 
            this.lblGioiThieu.AutoSize = true;
            this.lblGioiThieu.Location = new System.Drawing.Point(98, 207);
            this.lblGioiThieu.Name = "lblGioiThieu";
            this.lblGioiThieu.Size = new System.Drawing.Size(62, 15);
            this.lblGioiThieu.TabIndex = 6;
            this.lblGioiThieu.Text = "Giới thiệu:";
            // 
            // rtbGioiThieu
            // 
            this.rtbGioiThieu.Location = new System.Drawing.Point(208, 210);
            this.rtbGioiThieu.Name = "rtbGioiThieu";
            this.rtbGioiThieu.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rtbGioiThieu.Size = new System.Drawing.Size(467, 114);
            this.rtbGioiThieu.TabIndex = 7;
            this.rtbGioiThieu.Text = "";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(208, 353);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(467, 21);
            this.txtTacGia.TabIndex = 9;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(98, 353);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(50, 15);
            this.lblTacGia.TabIndex = 8;
            this.lblTacGia.Text = "Tác giả:";
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(208, 399);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(467, 21);
            this.txtNhaXuatBan.TabIndex = 11;
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Location = new System.Drawing.Point(98, 399);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(83, 15);
            this.lblNhaXuatBan.TabIndex = 10;
            this.lblNhaXuatBan.Text = "Nhà xuất bản:";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(458, 465);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 37);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.Location = new System.Drawing.Point(575, 465);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(100, 37);
            this.btnQuayVe.TabIndex = 13;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // Ebooks_Winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 524);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtNhaXuatBan);
            this.Controls.Add(this.lblNhaXuatBan);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.rtbGioiThieu);
            this.Controls.Add(this.lblGioiThieu);
            this.Controls.Add(this.txtTuaDe);
            this.Controls.Add(this.lblTuaDe);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.lblMaSach);
            this.Controls.Add(this.lblBookInformations);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Ebooks_Winform";
            this.Text = "Ebooks_Winform";
            this.Load += new System.EventHandler(this.Ebooks_Winform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookInformations;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTuaDe;
        private System.Windows.Forms.Label lblTuaDe;
        private System.Windows.Forms.Label lblGioiThieu;
        private System.Windows.Forms.RichTextBox rtbGioiThieu;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnQuayVe;
    }
}