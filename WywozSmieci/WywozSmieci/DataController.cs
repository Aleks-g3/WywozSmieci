using System;
using System.Collections.Generic;
using System.Text;
using WywozSmieci.Model;

namespace WywozSmieci
{
    public class DataController
    {
        private List<Rejon> data;

        public DataController()
        {
            data = new List<Rejon>();
            Rejon baninoI = new Rejon() { Miejsce = "Banino I" };
            baninoI.Wywozy = new List<Wywoz>();
            baninoI.Wywozy.Add(new Wywoz() { Data = "2020-04-01", RodzajSmieci = new RodzajSmieci() { Typ = "Sztuczne" } });
            baninoI.Wywozy.Add(new Model.Wywoz() { Data = "2020-04-08", RodzajSmieci = baninoI.Wywozy.Find(w => w.RodzajSmieci.Typ == "Sztuczne").RodzajSmieci });
            baninoI.Wywozy.Add(new Model.Wywoz() { Data = "2020-04-29", RodzajSmieci = baninoI.Wywozy.Find(w => w.RodzajSmieci.Typ == "Sztuczne").RodzajSmieci });
            baninoI.Wywozy.Add(new Model.Wywoz() { Data = "2020-04-08", RodzajSmieci = new Model.RodzajSmieci() { Typ = "Mieszane" } });
            baninoI.Wywozy.Add(new Model.Wywoz() { Data = "2020-04-22", RodzajSmieci = baninoI.Wywozy.Find(w => w.RodzajSmieci.Typ == "Mieszane").RodzajSmieci });
            data.Add(baninoI);
            Rejon baninoII = new Rejon() { Miejsce = "Banino II" };
            baninoII.Wywozy = new List<Wywoz>();
            baninoII.Wywozy.Add(new Wywoz() { Data = "2020-04-02", RodzajSmieci = baninoI.Wywozy.Find(w => w.RodzajSmieci.Typ == "Sztuczne").RodzajSmieci });
            baninoII.Wywozy.Add(new Wywoz() { Data = "2020-04-09", RodzajSmieci = baninoI.Wywozy.Find(w => w.RodzajSmieci.Typ == "Sztuczne").RodzajSmieci });
            baninoII.Wywozy.Add(new Wywoz() { Data = "2020-04-30", RodzajSmieci = baninoI.Wywozy.Find(w => w.RodzajSmieci.Typ == "Sztuczne").RodzajSmieci });
            baninoII.Wywozy.Add(new Wywoz() { Data = "2020-04-08", RodzajSmieci = baninoI.Wywozy.Find(w => w.RodzajSmieci.Typ == "Mieszane").RodzajSmieci });
            baninoII.Wywozy.Add(new Wywoz() { Data = "2020-04-22", RodzajSmieci = baninoI.Wywozy.Find(w => w.RodzajSmieci.Typ == "Mieszane").RodzajSmieci });
            data.Add(baninoII);
        }

        public List<Rejon> GetData()
        {
            return data;
        }
    }
}
