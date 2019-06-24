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
		}
	}
}