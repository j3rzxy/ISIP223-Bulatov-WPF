using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP223_Bulatov_WPF.Factories
{
    internal class Boss : Enemy
    {
        public int CritChanceBonus { get; set; }
        public int FreezeChanceBonus { get; set; }
    }
}