using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CodePlusXaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScaryColorListPage : ContentPage
    {
        public ScaryColorListPage()
        {
            //Padding = Device.RuntimePlatform == Device.iOS ? new Thickness(0, 20, 0, 0) : new Thickness(0);

            InitializeComponent();
        }
    }
}