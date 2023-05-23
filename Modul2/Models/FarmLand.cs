using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modul2.Models
{
    public class FarmLand
    {
        public int PlotNumber { get; set; } //уникальный номер
        public double Area { get; set; } //участок
        public bool IsIrrigated { get; set; } //орошение
        public string Crop { get; set; } //урожай
        public string Fertilizer { get; set; } //удобрения
    }
}