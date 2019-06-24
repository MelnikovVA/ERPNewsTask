using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Net.Http;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using ERPNews.Models;

namespace ERPNews.ViewModels
{
    class AllNewsViewModel
    {
        public ObservableCollection<News> NewsList { get; set; }

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
