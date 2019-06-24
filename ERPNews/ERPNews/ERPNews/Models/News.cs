using System;
using System.Collections.Generic;
using System.Text;

namespace ERPNews.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public string PreviewPath { get; set; }
        public string MainImagePath { get; set; }
        public List<String> AdditionalImagesPaths { get; set; }
        public String Language { get; set; }
    }
}
