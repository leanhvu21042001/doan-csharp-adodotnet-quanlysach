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
    public partial class Ebooks_Winform : Form
    {
        BUS_Ebooks bEb = new BUS_Ebooks();
        Ebooks layBenKia = new Ebooks();
        int i = 0;
        public Ebooks_Winform(int ch, Ebooks eb)
        {
            this.layBenKia = eb;
            i = ch;
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // lay du lieu ra va gan vao doi tuong ...
            
            Ebooks eb = new Ebooks(txtMaSach.Text, txtTuaDe.Text, rtbGioiThieu.Text, txtTacGia.Text, txtNhaXuatBan.Text);
            if (i == 1)
            {
                // them
                if (bEb.themMotEbooks(eb) > 0)
                {
                    MessageBox.Show("Them thanh cong");
                } else
                {
                    MessageBox.Show("Them khong thanh cong");
                }
            }
            else if (i == 2)
            {
                // xoa
                DataTable data = bEb.layToanBoEbooks();
                foreach (DataRow item in data.Rows)
                {
                    bEb.xoaMotEbooks(item[0].ToString());
                }
            }
            else if (i == 3)
            {
                if (bEb.suaMotEbooks(eb) > 0)
                {
                    MessageBox.Show("Sua sach thanh cong");
                } else
                {
                    MessageBox.Show("Sua sach khong thanh cong");
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

        private void Ebooks_Winform_Load(object sender, EventArgs e)
        {
            txtMaSach.Text = layBenKia.BookID;
            txtTuaDe.Text = layBenKia.BookTitle;
            rtbGioiThieu.Text = layBenKia.Introduction;
            txtTacGia.Text = layBenKia.AuthorName;
            txtNhaXuatBan.Text = layBenKia.PublisherName;
        }
    }
}
