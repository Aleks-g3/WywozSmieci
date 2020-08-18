using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WywozSmieci.Model
{
    public class Wywoz
    {
        [Key]
        public int Id { get; set; }
        public Rejon rejon { get; set; }
        public string Typ { get; set; }
        public DateTime Data { get; set; }
    }
}
