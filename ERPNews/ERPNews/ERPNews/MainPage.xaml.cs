using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using HtmlAgilityPack;
using System.Web;
using ERPNews.Models;
using ERPNews.ViewModels;

namespace ERPNews
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //BindingContext = new MainPageViewModel();
            //GetNewsList();
        }

        //private async void GetNewsList()
        //{
        //    HttpClient client = new HttpClient();
        //    String url = "https://education-erp.com/api/ClientApplication/News?schoolType=Football&cityId=4&count=10";
        //    var response = await client.GetStringAsync(url);
        //    var newsList = JsonConvert.DeserializeObject<List<News>>(response);
        //    var unformattedList = GetUnformattedList(newsList);
            
        //    NewsListView.ItemsSource = unformattedList;
        //}

        //private List<News> GetUnformattedList(List<News> list)
        //{
        //    foreach (var item in list)
        //    {
        //        HtmlDocument htmlDoc = new HtmlDocument();
        //        item.Text = item.Text.Replace("<br />", "\n");
        //        item.Text = HttpUtility.HtmlDecode(item.Text);
        //        htmlDoc.LoadHtml(item.Text);
        //        item.Text = htmlDoc.DocumentNode.InnerText;
        //    }
        //    return list;
        //}

        //private void OnItemSelected(object sender, ItemTappedEventArgs e)
        //{

        //}
    }
}
