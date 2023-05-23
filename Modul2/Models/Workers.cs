using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modul2.Models
{
    public class Workers
    {
        public int WorkersNumber { get; set; } //номер команды работников
        public string SupervisorName { get; set; } //ФИО бригадира
        public List<string> Cruws { get; set; } //ФИО работников
        public Dictionary<string, int> AgriculturalEquipment { get; set; } //техника
    }
}