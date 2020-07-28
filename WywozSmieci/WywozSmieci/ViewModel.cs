using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using WywozSmieci.Model;
using Xamarin.Forms;

namespace WywozSmieci
{
    public class ViewModel
    {
        public ObservableCollection<Rejon> Rejons;
        public ViewModel()
        {
            Rejons = new ObservableCollection<Rejon>()
            {
                new Rejon
                {
                    miejsce="Osowa"
                }
            };
               
        }

        
    }
}
