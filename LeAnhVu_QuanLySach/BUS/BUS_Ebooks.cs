using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using DAL;
namespace BUS
{
    public class BUS_Ebooks
    {
        DAL_Ebooks dalEbook = new DAL_Ebooks();
        public  DataTable layToanBoEbooks()
        {
            return dalEbook.layToanBoEbooks();
        }

        public int themMotEbooks(Ebooks eb)
        {
            return dalEbook.themMotEbooks(eb);
        }

        public int suaMotEbooks(Ebooks eb)
        {
            return dalEbook.suaMotEbooks(eb);
        }

        public int xoaMotEbooks(string bookID)
        {
            return dalEbook.xoaMotEbooks(bookID);
        }
        public int xoaToanBoEbooks()
        {
            return dalEbook.xoaToanBoEbooks();
        }
    }
}
