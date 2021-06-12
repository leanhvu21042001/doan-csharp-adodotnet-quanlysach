using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Ebooks
    {
        // fields
        private string bookID;
        private string bookTitle;
        private string introduction;
        private string authorName;
        private string publisherName;

        // properties
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

        public string BookTitle
        {
            get
            {
                return bookTitle;
            }

            set
            {
                bookTitle = value;
            }
        }

        public string Introduction
        {
            get
            {
                return introduction;
            }

            set
            {
                introduction = value;
            }
        }

        public string AuthorName
        {
            get
            {
                return authorName;
            }

            set
            {
                authorName = value;
            }
        }

        public string PublisherName
        {
            get
            {
                return publisherName;
            }

            set
            {
                publisherName = value;
            }
        }

        // constructor
        public Ebooks() { }
        public Ebooks(string bookID, string bookTitle, string introduction, string authorName, string publisherName)
        {
            this.bookID = bookID;
            this.bookTitle = bookTitle;
            this.introduction = introduction;
            this.authorName = authorName;
            this.publisherName = publisherName;
        }
    }
}
