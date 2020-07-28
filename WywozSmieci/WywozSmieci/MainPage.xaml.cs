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
        
        private List<Rejon> _Rejon;
        ViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();
           // _viewModel = new ViewModel();
            
            add();
            //BindingContext = _viewModel;
        }
        public void add()
        {
            _Rejon = new List<Rejon>();
            _Rejon.Add(new Rejon() { miejsce = "Osowa" });
            _Rejon.Add(new Rejon() { miejsce = "Osowa" });
            listView.ItemsSource = _Rejon;
        }
    }
}
