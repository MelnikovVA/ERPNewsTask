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
using ERPNews.Views;
using HtmlAgilityPack;
using System.Web;
using System.Threading.Tasks;

namespace ERPNews.ViewModels
{
    class AllNewsViewModel
    {
        private ObservableCollection<News> _newsList { get; set; }
        private ObservableCollection<News> _newsListUnformatted { get; set; }
        public ObservableCollection<News> NewsList
        {
            get
            {
                return _newsList;
            }
        }
        public ObservableCollection<News> NewsListUnformatted
        {
            get
            {
                return _newsListUnformatted;
            }
        }

        public AllNewsViewModel()
        {
            //NewsList = GetNewsList();
            //NewsListUnformatted = new ObservableCollection<News>();
            //GetNewsList();
            _newsList = new ObservableCollection<News>();
            _newsListUnformatted = new ObservableCollection<News>();
            GetNewsList();
        }

        private void GetNewsList()
        {
            HttpClient client = new HttpClient();
            String url = "https://education-erp.com/api/ClientApplication/News?schoolType=Football&cityId=4&count=10";
            var response = client.GetStringAsync(url);
            _newsList = JsonConvert.DeserializeObject<ObservableCollection<News>>(response);
            _newsListUnformatted = GetUnformattedList(NewsList);
            //ERPNews.Views.AllNews.
            // .NewsListView.ItemsSource = unformattedList;
        }

        private ObservableCollection<News> GetUnformattedList(ObservableCollection<News> list)
        {
            foreach (var item in list)
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                item.Text = item.Text.Replace("<br />", "\n");
                item.Text = HttpUtility.HtmlDecode(item.Text);
                htmlDoc.LoadHtml(item.Text);
                item.Text = htmlDoc.DocumentNode.InnerText;
            }
            return list;
        }
    }
}
