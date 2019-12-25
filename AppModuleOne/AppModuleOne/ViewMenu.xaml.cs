using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppModuleOne
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewMenu : ContentView
	{
		public ViewMenu ()
		{
			InitializeComponent ();
		}
	}
}