using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace MainGUI
{
    public partial class Chapters_Winform : Form
    {
        int i = 0;
        BUS_Chapter bch = new BUS_Chapter();
        Chapter ct = new Chapter();
        public Chapters_Winform(int ch, Chapter ct)
        {
            i = ch;
            this.ct = ct;
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                // lay ra chapterNumber cuoi cung
                DataTable data = bch.layToanBoChapterDuaTheoBookID(this.ct.BookID);
                DataRow item = data.Rows[data.Rows.Count - 1];
                int chapterNumber = int.Parse(item[0].ToString());
                // them mot chuong moi
                Chapter newCt = new Chapter(chapterNumber + 1, ct.BookID, txtTenChuong.Text, rtbMucTieuChuong.Text, int.Parse(txtPhan.Text), rtbNoiDung.Text);

                // them chuong moi
                if (bch.themMotChapter(newCt) > 0)
                {
                    MessageBox.Show("Them chapter thanh cong");
                }
                else
                {
                    MessageBox.Show("Them chapter khong thanh cong");
                }
            }
            else if (i == 2)
            {
                // sua chuong moi
                if (bch.suaMotChapter(ct) > 0)
                {
                    MessageBox.Show("Sua chapter thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua chapter khong thanh cong");
                }
            }


        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGUI fMain = new MainGUI();
            fMain.ShowDialog();
            this.Close();
        }

        private void Chapters_Winform_Load(object sender, EventArgs e)
        {
            txtSoThuTuChuong.Text = ct.ChapterNumber.ToString();
            txtTenChuong.Text = ct.ChapterTitle;
            rtbMucTieuChuong.Text = ct.Objective;
            txtPhan.Text = ct.PartNumber.ToString();
            rtbNoiDung.Text = ct.Content;
        }
    }
}
