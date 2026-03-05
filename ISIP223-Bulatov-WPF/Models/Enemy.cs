using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP223_Bulatov_WPF.Factories
{
    internal class Enemy
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public string Type { get; set; }
    }
}