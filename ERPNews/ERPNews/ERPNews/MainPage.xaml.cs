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
using System.Linq;
using ERPNews.Models;

namespace ERPNews
{
    public partial class MainPage : ContentPage
    {
        public List<News> newsList;
        public MainPage()
        {
            InitializeComponent();

            FormNewsLists();
        }

        private async void FormNewsLists()
        {
            HttpClient client = new HttpClient();
            String url = "https://education-erp.com/api/ClientApplication/News?schoolType=Football&cityId=4&count=10";
            var response = await client.GetStringAsync(url);
            newsList = JsonConvert.DeserializeObject<List<News>>(response);
            foreach (var item in newsList)
            {
                item.FormattedText = item.Text;
            }
            DropHtmlTags(newsList);

            NewsListView.ItemsSource = newsList;
        }

        private void DropHtmlTags(List<News> list)
        {
            var newList = list;
            foreach (var item in newList)
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                item.Text = item.Text.Replace("<br />", "\n");
                item.Text = HttpUtility.HtmlDecode(item.Text);
                htmlDoc.LoadHtml(item.Text);
                item.Text = htmlDoc.DocumentNode.InnerText;
            }
        }

        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as News;
            await Navigation.PushAsync(new ItemDetailsPage(item));
        }
    }
}
