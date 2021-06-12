using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Chapter
    {
        // fields
        private int chapterNumber;
        private string bookID;
        private string chapterTitle;
        private string objective;
        private int partNumber;
        private string content;

        // properties
        public int ChapterNumber
        {
            get
            {
                return chapterNumber;
            }

            set
            {
                chapterNumber = value;
            }
        }

        public string BookID
        {
            get
            {
                return bookID;
            }

            set
            {
                bookID = value;
            }
        }

        public string ChapterTitle
        {
            get
            {
                return chapterTitle;
            }

            set
            {
                chapterTitle = value;
            }
        }

        public string Objective
        {
            get
            {
                return objective;
            }

            set
            {
                objective = value;
            }
        }

        public int PartNumber
        {
            get
            {
                return partNumber;
            }

            set
            {
                partNumber = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        // contructor
        public Chapter() { }
        public Chapter(int chapterNumber, string bookID, string chapterTitle, string objective, int partNumber, string content)
        {
            this.chapterNumber = chapterNumber;
            this.bookID = bookID;
            this.chapterTitle = chapterTitle;
            this.objective = objective;
            this.partNumber = partNumber;
            this.content = content;
        }
    }
}
