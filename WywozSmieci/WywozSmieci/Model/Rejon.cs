

using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace WywozSmieci.Model
{

    
    public class Rejon
    {

        
        public string Miejsce { get; set; }
        public List<Wywoz> Wywozy { get; set; }

    }
}
