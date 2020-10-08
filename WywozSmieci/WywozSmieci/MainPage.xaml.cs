using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using WywozSmieci.Model;
using Xamarin.Forms;

namespace WywozSmieci
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private DataController dataController;

        public MainPage()
        {

            dataController = new DataController();
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            var list=dataController.GetData();
            listView.ItemsSource = dataController.GetData();
        }

        private  void miejsce_Clicked(object sender, EventArgs e)
        {
            //ITemplatedItemsView<Cell> templatedItemsView = listView as ITemplatedItemsView<Cell>;
            //ViewCell firstCell = templatedItemsView.TemplatedItems[0] as ViewCell;
            //StackLayout stackLayout = firstCell.View as StackLayout;
            //StackLayout stack = (StackLayout)stackLayout.Children[0];
            ImageButton miejsce = (ImageButton)sender;
            FlexLayout grid = (FlexLayout)miejsce.Parent;
            CollectionView data = (CollectionView)grid.Children[2];
            
            if (data.IsVisible==true)
            {

                grid.HeightRequest = 100;
                data.IsVisible = false;
                miejsce.HorizontalOptions = LayoutOptions.Center;
                miejsce.VerticalOptions = LayoutOptions.Center;

            }
            else
            {
                grid.HeightRequest = 200;
                data.IsVisible = true;
                miejsce.HorizontalOptions = LayoutOptions.Center;
                miejsce.VerticalOptions = LayoutOptions.Center;

            }
            
        }
    }
}
