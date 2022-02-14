using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        public MyList()//MyList newlerden otomatık calısır..
        {
            items = new T[0];//bir class newlendıgınde calısan bloga contructor denır..
        }
        public void Add(T item)
        {
            items = new T[items.Length + 1];
        }
    }
}
