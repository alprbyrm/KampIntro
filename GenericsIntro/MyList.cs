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

        //constructor -- KOLAY YAZILIM (ctor tab*2)
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items; //gecici olarak listeyi buraya tutturduk liste elemanları kaybolmaması icin
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            //listenin son elemanı uzunlugunun 1 eksıgıdır 
            items[items.Length - 1] = item;

        }
    }
}
