using ERPNews.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ERPNews.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AllNewsPage : ContentPage
	{
        AllNewsViewModel viewModel;
		public AllNewsPage ()
		{
			InitializeComponent ();
            viewModel = new AllNewsViewModel();
            //BindingContext = new AllNewsViewModel();
            BindingContext = viewModel;
            AllNewsListView.ItemsSource = viewModel.NewsListUnformatted;
        }


        private void OnItemSelected(object sender, ItemTappedEventArgs e)
        {

        }
    }
}


