namespace MainGUI
{
    partial class MainGUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Danh sách các cuốn sách");
            this.lblTitleEbooksManager = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trvEbooks = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlShowDetailEbooks = new System.Windows.Forms.Panel();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblGioiThieu = new System.Windows.Forms.Label();
            this.lblTieuDeSach = new System.Windows.Forms.Label();
            this.lblMaSoSach = new System.Windows.Forms.Label();
            this.lvEbooks = new System.Windows.Forms.ListView();
            this.pnlShowDetailsChapter = new System.Windows.Forms.Panel();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblMucTieu = new System.Windows.Forms.Label();
            this.lblChuongObjective = new System.Windows.Forms.Label();
            this.lblChuong = new System.Windows.Forms.Label();
            this.cmstSub0 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themSachMoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaTatCaSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstSub1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaThôngTinSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSáchĐangChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thêmChươngMớiChoSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSub2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaThôngTinChươngSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaChươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlShowDetailEbooks.SuspendLayout();
            this.pnlShowDetailsChapter.SuspendLayout();
            this.cmstSub0.SuspendLayout();
            this.cmstSub1.SuspendLayout();
            this.cmsSub2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleEbooksManager
            // 
            this.lblTitleEbooksManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitleEbooksManager.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitleEbooksManager.Location = new System.Drawing.Point(14, 25);
            this.lblTitleEbooksManager.Name = "lblTitleEbooksManager";
            this.lblTitleEbooksManager.Size = new System.Drawing.Size(862, 39);
            this.lblTitleEbooksManager.TabIndex = 0;
            this.lblTitleEbooksManager.Text = "EBOOKS MANAGER";
            this.lblTitleEbooksManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trvEbooks);
            this.panel1.Location = new System.Drawing.Point(14, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 380);
            this.panel1.TabIndex = 1;
            // 
            // trvEbooks
            // 
            this.trvEbooks.Location = new System.Drawing.Point(3, 4);
            this.trvEbooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trvEbooks.Name = "trvEbooks";
            treeNode1.Name = "DanhSachCacCuonSachNode0";
            treeNode1.Text = "Danh sách các cuốn sách";
            this.trvEbooks.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.trvEbooks.Size = new System.Drawing.Size(247, 372);
            this.trvEbooks.TabIndex = 0;
            this.trvEbooks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvEbooks_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlShowDetailEbooks);
            this.panel2.Controls.Add(this.lvEbooks);
            this.panel2.Location = new System.Drawing.Point(275, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 380);
            this.panel2.TabIndex = 2;
            // 
            // pnlShowDetailEbooks
            // 
            this.pnlShowDetailEbooks.Controls.Add(this.lblNhaXuatBan);
            this.pnlShowDetailEbooks.Controls.Add(this.lblTacGia);
            this.pnlShowDetailEbooks.Controls.Add(this.lblGioiThieu);
            this.pnlShowDetailEbooks.Controls.Add(this.lblTieuDeSach);
            this.pnlShowDetailEbooks.Controls.Add(this.lblMaSoSach);
            this.pnlShowDetailEbooks.Location = new System.Drawing.Point(3, 4);
            this.pnlShowDetailEbooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlShowDetailEbooks.Name = "pnlShowDetailEbooks";
            this.pnlShowDetailEbooks.Size = new System.Drawing.Size(593, 372);
            this.pnlShowDetailEbooks.TabIndex = 2;
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNhaXuatBan.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.lblNhaXuatBan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNhaXuatBan.Location = new System.Drawing.Point(16, 312);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(510, 32);
            this.lblNhaXuatBan.TabIndex = 11;
            this.lblNhaXuatBan.Text = " ";
            this.lblNhaXuatBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTacGia
            // 
            this.lblTacGia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTacGia.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.lblTacGia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTacGia.Location = new System.Drawing.Point(16, 250);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(510, 32);
            this.lblTacGia.TabIndex = 10;
            this.lblTacGia.Text = " ";
            this.lblTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGioiThieu
            // 
            this.lblGioiThieu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGioiThieu.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.lblGioiThieu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGioiThieu.Location = new System.Drawing.Point(15, 186);
            this.lblGioiThieu.Name = "lblGioiThieu";
            this.lblGioiThieu.Size = new System.Drawing.Size(510, 32);
            this.lblGioiThieu.TabIndex = 9;
            this.lblGioiThieu.Text = " ";
            this.lblGioiThieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTieuDeSach
            // 
            this.lblTieuDeSach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTieuDeSach.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lblTieuDeSach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTieuDeSach.Location = new System.Drawing.Point(15, 106);
            this.lblTieuDeSach.Name = "lblTieuDeSach";
            this.lblTieuDeSach.Size = new System.Drawing.Size(510, 50);
            this.lblTieuDeSach.TabIndex = 8;
            this.lblTieuDeSach.Text = " ";
            this.lblTieuDeSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaSoSach
            // 
            this.lblMaSoSach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMaSoSach.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lblMaSoSach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaSoSach.Location = new System.Drawing.Point(15, 22);
            this.lblMaSoSach.Name = "lblMaSoSach";
            this.lblMaSoSach.Size = new System.Drawing.Size(511, 50);
            this.lblMaSoSach.TabIndex = 7;
            this.lblMaSoSach.Text = " ";
            this.lblMaSoSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvEbooks
            // 
            this.lvEbooks.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEbooks.HideSelection = false;
            this.lvEbooks.Location = new System.Drawing.Point(3, 4);
            this.lvEbooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvEbooks.Name = "lvEbooks";
            this.lvEbooks.Size = new System.Drawing.Size(593, 372);
            this.lvEbooks.TabIndex = 1;
            this.lvEbooks.UseCompatibleStateImageBehavior = false;
            this.lvEbooks.View = System.Windows.Forms.View.Details;
            // 
            // pnlShowDetailsChapter
            // 
            this.pnlShowDetailsChapter.Controls.Add(this.lblNoiDung);
            this.pnlShowDetailsChapter.Controls.Add(this.lblMucTieu);
            this.pnlShowDetailsChapter.Controls.Add(this.lblChuongObjective);
            this.pnlShowDetailsChapter.Controls.Add(this.lblChuong);
            this.pnlShowDetailsChapter.Location = new System.Drawing.Point(281, 90);
            this.pnlShowDetailsChapter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlShowDetailsChapter.Name = "pnlShowDetailsChapter";
            this.pnlShowDetailsChapter.Size = new System.Drawing.Size(587, 366);
            this.pnlShowDetailsChapter.TabIndex = 12;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNoiDung.Location = new System.Drawing.Point(12, 229);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(556, 122);
            this.lblNoiDung.TabIndex = 3;
            // 
            // lblMucTieu
            // 
            this.lblMucTieu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMucTieu.Location = new System.Drawing.Point(11, 170);
            this.lblMucTieu.Name = "lblMucTieu";
            this.lblMucTieu.Size = new System.Drawing.Size(556, 36);
            this.lblMucTieu.TabIndex = 2;
            this.lblMucTieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChuongObjective
            // 
            this.lblChuongObjective.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuongObjective.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChuongObjective.Location = new System.Drawing.Point(11, 102);
            this.lblChuongObjective.Name = "lblChuongObjective";
            this.lblChuongObjective.Size = new System.Drawing.Size(556, 36);
            this.lblChuongObjective.TabIndex = 1;
            this.lblChuongObjective.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChuong
            // 
            this.lblChuong.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChuong.Location = new System.Drawing.Point(11, 20);
            this.lblChuong.Name = "lblChuong";
            this.lblChuong.Size = new System.Drawing.Size(556, 36);
            this.lblChuong.TabIndex = 0;
            this.lblChuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmstSub0
            // 
            this.cmstSub0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themSachMoiToolStripMenuItem,
            this.xoaTatCaSachToolStripMenuItem});
            this.cmstSub0.Name = "cmstSub0";
            this.cmstSub0.Size = new System.Drawing.Size(156, 48);
            // 
            // themSachMoiToolStripMenuItem
            // 
            this.themSachMoiToolStripMenuItem.Name = "themSachMoiToolStripMenuItem";
            this.themSachMoiToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.themSachMoiToolStripMenuItem.Text = "Thêm sách mới";
            this.themSachMoiToolStripMenuItem.Click += new System.EventHandler(this.themSachMoiToolStripMenuItem_Click);
            // 
            // xoaTatCaSachToolStripMenuItem
            // 
            this.xoaTatCaSachToolStripMenuItem.Name = "xoaTatCaSachToolStripMenuItem";
            this.xoaTatCaSachToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.xoaTatCaSachToolStripMenuItem.Text = "Xóa tất cả sách";
            this.xoaTatCaSachToolStripMenuItem.Click += new System.EventHandler(this.xoaTatCaSachToolStripMenuItem_Click);
            // 
            // cmstSub1
            // 
            this.cmstSub1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaThôngTinSáchToolStripMenuItem,
            this.xóaSáchĐangChọnToolStripMenuItem,
            this.toolStripSeparator1,
            this.thêmChươngMớiChoSáchToolStripMenuItem});
            this.cmstSub1.Name = "cmstSub1";
            this.cmstSub1.Size = new System.Drawing.Size(235, 76);
            // 
            // sửaThôngTinSáchToolStripMenuItem
            // 
            this.sửaThôngTinSáchToolStripMenuItem.Name = "sửaThôngTinSáchToolStripMenuItem";
            this.sửaThôngTinSáchToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.sửaThôngTinSáchToolStripMenuItem.Text = "1. Sửa thông tin sách";
            this.sửaThôngTinSáchToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinSáchToolStripMenuItem_Click);
            // 
            // xóaSáchĐangChọnToolStripMenuItem
            // 
            this.xóaSáchĐangChọnToolStripMenuItem.Name = "xóaSáchĐangChọnToolStripMenuItem";
            this.xóaSáchĐangChọnToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.xóaSáchĐangChọnToolStripMenuItem.Text = "2. Xóa sách đang chọn";
            this.xóaSáchĐangChọnToolStripMenuItem.Click += new System.EventHandler(this.xóaSáchĐangChọnToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // thêmChươngMớiChoSáchToolStripMenuItem
            // 
            this.thêmChươngMớiChoSáchToolStripMenuItem.Name = "thêmChươngMớiChoSáchToolStripMenuItem";
            this.thêmChươngMớiChoSáchToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.thêmChươngMớiChoSáchToolStripMenuItem.Text = "3. Thêm chương mới cho sách";
            this.thêmChươngMớiChoSáchToolStripMenuItem.Click += new System.EventHandler(this.thêmChươngMớiChoSáchToolStripMenuItem_Click);
            // 
            // cmsSub2
            // 
            this.cmsSub2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaThôngTinChươngSáchToolStripMenuItem,
            this.xóaChươngToolStripMenuItem});
            this.cmsSub2.Name = "cmsSub2";
            this.cmsSub2.Size = new System.Drawing.Size(229, 48);
            // 
            // sửaThôngTinChươngSáchToolStripMenuItem
            // 
            this.sửaThôngTinChươngSáchToolStripMenuItem.Name = "sửaThôngTinChươngSáchToolStripMenuItem";
            this.sửaThôngTinChươngSáchToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.sửaThôngTinChươngSáchToolStripMenuItem.Text = "1. Sửa thông tin chương sách";
            this.sửaThôngTinChươngSáchToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinChươngSáchToolStripMenuItem_Click);
            // 
            // xóaChươngToolStripMenuItem
            // 
            this.xóaChươngToolStripMenuItem.Name = "xóaChươngToolStripMenuItem";
            this.xóaChươngToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.xóaChươngToolStripMenuItem.Text = "2. Xóa chương";
            this.xóaChươngToolStripMenuItem.Click += new System.EventHandler(this.xóaChươngToolStripMenuItem_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 485);
            this.Controls.Add(this.pnlShowDetailsChapter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitleEbooksManager);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlShowDetailEbooks.ResumeLayout(false);
            this.pnlShowDetailsChapter.ResumeLayout(false);
            this.cmstSub0.ResumeLayout(false);
            this.cmstSub1.ResumeLayout(false);
            this.cmsSub2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleEbooksManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView trvEbooks;
        private System.Windows.Forms.ListView lvEbooks;
        private System.Windows.Forms.Panel pnlShowDetailEbooks;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblGioiThieu;
        private System.Windows.Forms.Label lblTieuDeSach;
        private System.Windows.Forms.Label lblMaSoSach;
        private System.Windows.Forms.Panel pnlShowDetailsChapter;
        private System.Windows.Forms.Label lblChuong;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblMucTieu;
        private System.Windows.Forms.Label lblChuongObjective;
        private System.Windows.Forms.ContextMenuStrip cmstSub0;
        private System.Windows.Forms.ToolStripMenuItem themSachMoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaTatCaSachToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmstSub1;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSáchĐangChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thêmChươngMớiChoSáchToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsSub2;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinChươngSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaChươngToolStripMenuItem;
    }
}

