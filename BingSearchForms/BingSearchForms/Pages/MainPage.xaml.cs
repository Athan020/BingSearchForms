using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MvvmCross.Forms.Views;
using BingSearchForms.Core.ViewModels;

namespace BingSearchForms.UI.Pages
{
	public partial class MainPage : MvxContentPage<MainViewModel>
	{
		public MainPage()
		{
			InitializeComponent();
		}
	}
}
