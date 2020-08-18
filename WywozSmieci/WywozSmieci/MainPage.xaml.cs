using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WywozSmieci.Model;
using Xamarin.Forms;

namespace WywozSmieci
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        

        public MainPage()
        {
            
            InitializeComponent();
           
        }

        private async void miejsce_Clicked(object sender, EventArgs e)
        {
            Button miejsce = (Button)sender;

            await DisplayAlert("test", miejsce.Text, "ok");
        }
    }
}
