using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using WywozSmieci.Model;
using WywozSmieci.Services;
using Xamarin.Forms;

namespace WywozSmieci
{
    public class ViewModel: INotifyPropertyChanged
    {
        private IEnumerable<Wywoz> _wywozy;
        private IWywozService _wywozService;
        public ViewModel(IWywozService rejonService)
        {
            _wywozService = rejonService;
            GetWywozy();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        

        public IEnumerable<Wywoz> Wywozy
        {
            get
            {
                return _wywozy;
            }
            set
            {
                _wywozy = value;
                OnPropertyChanged();
            }
        }

        public async void GetWywozy()
        {
            Wywozy = await _wywozService.GetAsync();
        }
        public string RejonMiejsce { get; set; }
        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    Wywozy = await _wywozService.GetAsync();
                    
                });
            }
        }

    }
}
