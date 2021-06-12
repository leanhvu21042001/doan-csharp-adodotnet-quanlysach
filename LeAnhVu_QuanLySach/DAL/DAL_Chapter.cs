using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_Chapter : Connect2DB
    {
        public DataTable layToanBoChapter()
        {
            DataTable result = new DataTable();
            string spName = "spLayToanBoChapter";
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(result);

            return result;
        }

        public DataTable layToanBoChapterDuaTheoBookID(string bookID)
        {
            DataTable result = new DataTable();
            string spName = "spLayToanBoChapterDuaTheoBookID";
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bookID", bookID);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(result);

            return result;
        }

        public int themMotChapter(Chapter ct)
        {
            string spName = "spThemMotChapter";
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chapterNumber", ct.ChapterNumber);
            cmd.Parameters.AddWithValue("@bookID", ct.BookID);
            cmd.Parameters.AddWithValue("@chapterTitle", ct.ChapterTitle);
            cmd.Parameters.AddWithValue("@objective", ct.Objective);
            cmd.Parameters.AddWithValue("@partNumber", ct.PartNumber);
            cmd.Parameters.AddWithValue("@content", ct.Content);
            int c = 0;
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    c = 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return c;
        }

        public int suaMotChapter(Chapter ct)
        {
            string spName = "spSuaMotChapter";
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chapterNumber", ct.ChapterNumber);
            cmd.Parameters.AddWithValue("@bookID", ct.BookID);
            cmd.Parameters.AddWithValue("@chapterTitle", ct.ChapterTitle);
            cmd.Parameters.AddWithValue("@objective", ct.Objective);
            cmd.Parameters.AddWithValue("@partNumber", ct.PartNumber);
            cmd.Parameters.AddWithValue("@content", ct.Content);
            int c = 0;
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    c = 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return c;
        }

        public int xoaMotChapter(string chapterNumber)
        {
            string spName = "spXoaMotChapter";
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chapterNumber", chapterNumber);
            int c = 0;
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    c = 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return c;
        }

        public int xoaToanBoChapter()
        {
            string spName = "spXoaToanBoChapter";
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            int c = 0;
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    c = 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return c;
        }
    }
}
