using ISIP223_Bulatov_WPF.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP223_Bulatov.Factories
{
    internal interface IEnemyFactory
    {
        Enemy CreateRandomEnemy();
    }
}