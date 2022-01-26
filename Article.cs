using System;
using System.ComponentModel.DataAnnotations;

namespace guardi
{
    public class Article
    {

        [Key]
        public int ArticleNumber { get; set; }

        public string Date { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string MainBody { get; set; }

        public string Paragraph { get; set; }

        public string ArticleType { get; set; }

        public string Author { get; set; }

         public string Photo { get; set; }

        public string PhotoLicence { get; set; }

        

    }
}