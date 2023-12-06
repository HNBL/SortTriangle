using sorttriangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTriangle
{
    internal class Class1
    {
        List<Tryangle> Tryanglelist = new List<Tryangle>();
        public void AddTryangle( Tryangle T)
        {
            Tryanglelist.Add(T);

        }

        public void Sort()
        {
            Tryanglelist.Sort();
        }
        public void Show()
        {
            foreach (Tryangle Tryangle in Tryanglelist) 
            {
                Tryangle.ShowTryangle();
            }

        }


    }
}
