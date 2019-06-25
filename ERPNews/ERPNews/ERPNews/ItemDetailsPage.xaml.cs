using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ERPNews.Models;

namespace ERPNews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetailsPage : ContentPage
	{
        HtmlWebViewSource htmlSource = new HtmlWebViewSource();

        public ItemDetailsPage (News news)
		{
			InitializeComponent ();
            BindingContext = news;
            
            ConcatHtml(news);
            webView.Source = htmlSource;
        }

        private void ConcatHtml(News news)
        {

            htmlSource.Html = news.FormattedText;

            var htmlTitle = "<big><b>" + news.Title + "</big></b><br />";

            var htmlCreationDate = "<p><small>" + DateTime.Parse(news.DateTime.ToString()).ToString() + "</small></p><br />";

            string htmlMainImg;
            if (Device.RuntimePlatform == Device.UWP)
                htmlMainImg = "<img src=\"" + news.MainImagePath + "\" style = \"width:50%; height:auto; margin: 5 auto;\"><br/>";
            else
                htmlMainImg = "<img src=\"" + news.MainImagePath + "\" style = \"width:99%; height:auto; margin: 5 auto;\">";


            htmlSource.Html = htmlTitle + htmlMainImg + htmlSource.Html + htmlCreationDate;

            string htmlAdditionalImg;
            foreach (var additionalPath in news.AdditionalImagesPaths)
            {
                if (Device.RuntimePlatform == Device.UWP)
                    htmlAdditionalImg = "<img src=\"" + additionalPath + "\" style = \"width:50%; height:auto; margin: 10 auto;\"><br/>";
                else
                    htmlAdditionalImg = "<img src=\"" + additionalPath + "\" style = \"width:99%; height:auto; margin: 5 auto;\">";
                htmlSource.Html += htmlAdditionalImg;
            }
        }
	}
}