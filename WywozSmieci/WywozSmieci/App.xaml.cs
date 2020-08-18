using System;
using WywozSmieci.Model;
using WywozSmieci.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WywozSmieci
{
    public partial class App : Application
    {
        

        public App()
        {
            InitializeComponent();
        }

        public App(IWywozService rejonService)
        {
            InitializeComponent();


            MainPage = new MainPage()
            {
                BindingContext = new ViewModel(rejonService)
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
