using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_Ebooks : Connect2DB
    {
        public DataTable layToanBoEbooks()
        {
            DataTable result = new DataTable();
            string spName = "spLayToanBoEbooks";
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(result);

            return result;
        }

        public int themMotEbooks(Ebooks eb)
        {
            string spName = "spThemMotEbooks";
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bookID", eb.BookID);
            cmd.Parameters.AddWithValue("@bookTitle", eb.BookTitle);
            cmd.Parameters.AddWithValue("@introduction", eb.Introduction);
            cmd.Parameters.AddWithValue("@authorName", eb.AuthorName);
            cmd.Parameters.AddWithValue("@publisherName", eb.PublisherName);
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

        public int suaMotEbooks(Ebooks eb)
        {
            string spName = "spSuaMotEbooks";
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bookID", eb.BookID);
            cmd.Parameters.AddWithValue("@bookTitle", eb.BookTitle);
            cmd.Parameters.AddWithValue("@introduction", eb.Introduction);
            cmd.Parameters.AddWithValue("@authorName", eb.AuthorName);
            cmd.Parameters.AddWithValue("@publisherName", eb.PublisherName);
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

        public int xoaMotEbooks(string bookID)
        {
            string spName = "spXoaMotEbooks";
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bookID", bookID);
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


        public int xoaToanBoEbooks()
        {
            string spName = "spXoaToanBoEbooks";
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
