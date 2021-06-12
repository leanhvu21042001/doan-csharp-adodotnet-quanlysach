using DTO;
using System.Data;
using DAL;
namespace BUS
{
    public class BUS_Chapter
    {
        DAL_Chapter dalChapter = new DAL_Chapter();
        public DataTable layToanBoChapter()
        {
            return dalChapter.layToanBoChapter();
        }

        public DataTable layToanBoChapterDuaTheoBookID(string bookID)
        {
            return dalChapter.layToanBoChapterDuaTheoBookID(bookID);
        }

        public int themMotChapter(Chapter eb)
        {
            return dalChapter.themMotChapter(eb);
        }

        public int suaMotChapter(Chapter eb)
        {
            return dalChapter.suaMotChapter(eb);
        }

        public int xoaMotChapter(string chapterNumber)
        {
            return dalChapter.xoaMotChapter(chapterNumber);
        }
        public int xoaToanBoChapter()
        {
            return dalChapter.xoaToanBoChapter();
        }
    }
}
