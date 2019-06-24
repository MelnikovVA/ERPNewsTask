using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using ERPNews.Models;

namespace ERPNews
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            GetNews();
        }

        private async void GetNews()
        {
            HttpClient client = new HttpClient();
            String url = "https://education-erp.com/api/ClientApplication/News?schoolType=Football&cityId=4&count=10";
            var response = await client.GetStringAsync(url);

            var newsList = JsonConvert.DeserializeObject<List<News>>(response);
            NewsListView.ItemsSource = newsList;
        }

        private void OnItemSelected(object sender, ItemTappedEventArgs e)
        {

        }
    }
}
