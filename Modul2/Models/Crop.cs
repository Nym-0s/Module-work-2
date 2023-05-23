using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modul2.Models
{
    public class Crop
    {
        public string Name { get; set; } //название культуры
        public double Yield { get; set; } //урожайность
        public bool RequiresIrrigation { get; set; } //нужно ли орошение
        public string RequiredFertilizers { get; set; } //нужные удобрения
    }
}