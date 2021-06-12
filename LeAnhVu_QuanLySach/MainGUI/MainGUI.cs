using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace MainGUI
{
    public partial class MainGUI : Form
    {
        BUS_Ebooks bBook = new BUS_Ebooks();
        BUS_Chapter bChapter = new BUS_Chapter();

        public MainGUI()
        {
            InitializeComponent();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            DataTable dataEbooks = bBook.layToanBoEbooks();
            DataTable dataChapter = bChapter.layToanBoChapter();
            // them sach
            foreach (DataRow eb in dataEbooks.Rows)
            {
                trvEbooks.Nodes[0].Nodes.Add(eb[1].ToString());
            }
            // them chuong cho sach
            for (int i = 0; i < trvEbooks.Nodes[0].Nodes.Count; i++)
            {
                foreach (DataRow ct in dataChapter.Rows)
                {
                    if (dataEbooks.Rows[i][0].ToString().Equals(ct[1].ToString()))
                    {
                        trvEbooks.Nodes[0].Nodes[i].Nodes.Add($"Chapter {ct[0].ToString()}: {ct[2].ToString()} ");
                    }
                }
            }
            // them Context menu Strip
            trvEbooks.Nodes[0].ContextMenuStrip = cmstSub0;
            foreach (TreeNode ebook in trvEbooks.Nodes[0].Nodes)
            {
                ebook.ContextMenuStrip = cmstSub1;
                foreach (TreeNode chp in ebook.Nodes)
                {
                    chp.ContextMenuStrip = cmsSub2;
                }
            }
        }

        private void trvEbooks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lvEbooks.Columns.Clear();
            lvEbooks.Items.Clear();

            DataTable dataEbooks = bBook.layToanBoEbooks();
            DataTable dataChapter = bChapter.layToanBoChapter();

            if (trvEbooks.SelectedNode.Level == 0)
            {
                pnlShowDetailEbooks.Hide();
                pnlShowDetailsChapter.Hide();
                lvEbooks.Columns.Add("Mã số sách");
                lvEbooks.Columns.Add("Tên sách");
                lvEbooks.Columns.Add("Giới thiệu");
                lvEbooks.Columns.Add("Tác giả");
                lvEbooks.Columns.Add("Nhà xuất bản");
                foreach (DataRow eb in dataEbooks.Rows)
                {
                    string[] arr =
                    {
                        eb[0].ToString(),
                        eb[1].ToString(),
                        eb[2].ToString(),
                        eb[3].ToString(),
                        eb[4].ToString()
                    };
                    lvEbooks.Items.Add(new ListViewItem(arr));
                }
            } else if (trvEbooks.SelectedNode.Level == 1)
            {
                lvEbooks.Hide();
                pnlShowDetailEbooks.Show();
                pnlShowDetailsChapter.Hide();
                foreach (DataRow item in dataEbooks.Rows)
                {
                    if (trvEbooks.SelectedNode.Text.Equals(item[1].ToString()))
                    {
                        lblMaSoSach.Text = "Mã số sách: " + item[0];
                        lblTieuDeSach.Text = "Tiêu đề sách: " + item[1];
                        lblGioiThieu.Text = "Giới thiệu: " + item[2];
                        lblTacGia.Text = "Tác giả: " + item[3];
                        lblNhaXuatBan.Text = "Nhà xuất bản: " + item[4];
                        break;
                    }
                }
            }
            else
            {
                lvEbooks.Hide();
                pnlShowDetailEbooks.Hide();
                
                string bookID = "";
                foreach (DataRow item in dataEbooks.Rows)
                {
                    if (trvEbooks.SelectedNode.Parent.Text.Equals(item[1].ToString()))
                    {
                        bookID = item[0].ToString();
                        // MessageBox.Show(bookID);
                        break;
                    }
                }
                foreach (DataRow item2 in dataChapter.Rows)
                {
                    if (trvEbooks.SelectedNode.Text.Contains(item2[2].ToString()) && bookID.Equals(item2[1]))
                    {
                        // MessageBox.Show(item2[2].ToString());
                        lblChuong.Text = "Chương: " + item2[0] + " " + item2[2];
                        lblChuongObjective.Text = "Chương Objective";
                        lblMucTieu.Text = item2[3].ToString();
                        lblNoiDung.Text = item2[5].ToString();
                        break;
                    }
                }
                pnlShowDetailsChapter.Show();
            }
        }

        #region
        //
        private void themSachMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ebooks b = new Ebooks();
            Ebooks_Winform feb = new Ebooks_Winform(1, b);
            feb.ShowDialog();
            this.Close();
        }
        
        private void xoaTatCaSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bBook.xoaToanBoEbooks() > 0)
            {
                MessageBox.Show("Xoa toan bo Books thanh cong");
            } else
            {
                MessageBox.Show("Xoa toan bo Books khong thanh cong");
            }
            MainGUI_Load(sender, e);
        }

        // 
        private void sửaThôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ebooks b = new Ebooks();
            foreach (DataRow item in bBook.layToanBoEbooks().Rows)
            {
                if (item[1].ToString().Equals(trvEbooks.SelectedNode.Text))
                {
                    b = new Ebooks(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString());
                    break;
                }
            }
            
            Ebooks_Winform feb = new Ebooks_Winform(3, b);
            feb.ShowDialog();
            this.Close();
        }

        private void xóaSáchĐangChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ebooks b = new Ebooks();
            foreach (DataRow item in bBook.layToanBoEbooks().Rows)
            {
                if (item[1].ToString().Equals(trvEbooks.SelectedNode.Text))
                {
                    b = new Ebooks(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString());
                    break;
                }
            }
            if (bBook.xoaMotEbooks(b.BookID) > 0)
            {
                MessageBox.Show("Xoa sach thanh cong");
                MainGUI_Load(sender, e);
            } else
            {
                MessageBox.Show("Xoa sach khong thanh cong");
            }
        }
        
        private void thêmChươngMớiChoSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataTable dataEbooks = bBook.layToanBoEbooks();
            Chapter ch = new Chapter();
            string bookID = "";

            foreach (DataRow item in dataEbooks.Rows)
            {
                if (trvEbooks.SelectedNode.Text.Equals(item[1].ToString()))
                {
                    bookID = item[0].ToString();
                    ch.BookID = bookID;
                    //ch = new Chapter(0, bookID, item[2].ToString(), item[3].ToString(), int.Parse(item[4].ToString()), item[5].ToString());
                    Chapters_Winform f = new Chapters_Winform(1, ch);
                    f.ShowDialog();
                    break;
                }
            }

            this.Close();
        }
        
        // 
        private void sửaThôngTinChươngSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chapter ch = getAChapter();
            Chapters_Winform f = new Chapters_Winform(2, ch);
            f.ShowDialog();
            this.Close();
        }

        private void xóaChươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chapter ch = getAChapter();
            if (bChapter.xoaMotChapter(ch.ChapterNumber.ToString()) > 0)
            {
                MessageBox.Show("Xoa chapter thanh cong");
                MainGUI_Load(sender, e);
            } else
            {
                MessageBox.Show("Xoa chapter khong thanh cong");
            }
        }

        private Chapter getAChapter()
        {
            Chapter ch = new Chapter();
            DataTable dataEbooks = bBook.layToanBoEbooks();

            string bookID = "";

            // MessageBox.Show(trvEbooks.SelectedNode.Parent.Text);
            foreach (DataRow value in dataEbooks.Rows)
            {
                if (trvEbooks.SelectedNode.Parent.Text.Equals(value[1].ToString()))
                {
                    bookID = value[0].ToString();
                    DataTable data = bChapter.layToanBoChapterDuaTheoBookID(bookID);

                    foreach (DataRow item in data.Rows)
                    {
                        if (trvEbooks.SelectedNode.Text.Contains(item[2].ToString()))
                        {
                            // MessageBox.Show(trvEbooks.SelectedNode.Text);
                            ch = new Chapter(int.Parse(item[0].ToString()), item[1].ToString(), item[2].ToString(), item[3].ToString(), int.Parse(item[4].ToString()), item[5].ToString());
                            break;
                        }

                    }
                    break;
                }
            }
            return ch;
        }
        #endregion

    }
}
