using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeWinAppDotNetForm
{
    internal class Caffee
    {
        public Decimal price = Decimal.Zero;

        public Caffee()
        {
            price = 120;
        }

        public void ExtraSugar()
        {
            price += 20;
        }

        public void ExtraMilk()
        {
            price += 30;
        }

        public void ExtraCream()
        {
            price += 50;
        }
    }
}
