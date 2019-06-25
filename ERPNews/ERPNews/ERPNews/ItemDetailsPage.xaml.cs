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
		public ItemDetailsPage (News news)
		{
			InitializeComponent ();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = news.FormattedText;

            var htmlTitle = "<b>" + news.Title + "</b><br />";
            //webView.Source = htmlSource;


        }
	}
}